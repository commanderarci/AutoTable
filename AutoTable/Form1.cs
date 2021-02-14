using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutoTable
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;


        bool running = false;
        bool preview = false;
        int counter = 0;
        int clicks = 0;

        List<Color> BlackListerColors = new List<Color>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            running = !running;
            if (running)
            {
                Start_button.Text = "STOP";
                timer1.Enabled = true;
                PreviewButton.Enabled = false;
            }
            else
            {
                Start_button.Text = "START";
                timer1.Enabled = false;
                PreviewButton.Enabled = true;
            }
        }
        private void PreviewButton_Click(object sender, EventArgs e)
        {
            preview = !preview;
            if (preview)
            {
                PreviewButton.Text = "Preview ON";
                timer1.Enabled = true;
                Start_button.Enabled = false;
                timer1.Interval = 200;
            }
            else
            {
                PreviewButton.Text = "Preview OFF";
                timer1.Enabled = false;
                Start_button.Enabled = true;
                timer1.Interval = 1000;
            }
        }


        bool clickFlipFlop = true;
        public void MainEventChain()
        {
            Bitmap workbitmap = GetChestScreenshot();
            int gridLeft = (int)GridLeftNumeric.Value, gridTop = (int)GridTopNumeric.Value;
            int offsetLeft = workbitmap.Width/ gridLeft, offsetTop = workbitmap.Width / gridTop;
            Color bestcolor =  Color.FromArgb(0,0,0);
            int bestX = 0, bestY = 0;

            for (int x = 0; x < gridLeft; x++)
            {
                for (int y = 0; y < gridTop; y++)
                {
                    if (x * offsetLeft < workbitmap.Width && y * offsetTop < workbitmap.Height)
                    {
                        Color canditateColor = workbitmap.GetPixel(x * offsetLeft, y * offsetTop);
                        if (!BlackListerColors.Contains(canditateColor))
                        {
                            float greenValue = canditateColor.G - canditateColor.R - canditateColor.B;
                            if (greenValue > bestcolor.G)
                            {
                                bestcolor = canditateColor;
                                bestX = x * offsetLeft;
                                bestY = y * offsetTop;
                            }
                            //Color canditates
                            if (greenValue > 0)
                            {
                                Color tempcolor = Color.FromArgb(0, (int)greenValue, 0);
                                workbitmap = DrawCircle(x * offsetLeft, y * offsetTop, workbitmap, tempcolor,true);
                            }
                            else
                            {
                                workbitmap = DrawCircle(x * offsetLeft, y * offsetTop, workbitmap, Color.Gray);

                            }
                        }
                    }
                }
            }

            if (bestcolor.G > 100)
            {
                // Click on the best candidate
                if (clickFlipFlop)
                {
                    //Click on position
                    DoMouseClick(this.Left + 8 + 250 + bestX + 5, this.Top + 32 + 50 + bestY + 15);
                    CounterClicker();
                    clickFlipFlop = !clickFlipFlop;
                }
                else
                {
                    //Move to position
                    DoMouseMove(this.Left + 8 + 250 + bestX + 5, this.Top + 32 + 50 + bestY + 15);
                    clickFlipFlop = !clickFlipFlop;
                }
            }


            ClickPicturebox.Image = workbitmap;
        }
        public void Preview()
        {
            Bitmap workbitmap = GetChestScreenshot();
            int gridLeft = (int)GridLeftNumeric.Value, gridTop = (int)GridTopNumeric.Value;
            int offsetLeft = workbitmap.Width / gridLeft, offsetTop = workbitmap.Width / gridTop;
            for (int x = 0; x < gridLeft; x++)
            {
                for (int y = 0; y < gridTop; y++)
                {
                    if (x * offsetLeft < workbitmap.Width && y * offsetTop < workbitmap.Height)
                    {
                        workbitmap = DrawCircle(x * offsetLeft, y * offsetTop, workbitmap,Color.Black);
                    }
                }
            }

            ClickPicturebox.Image = workbitmap;
        }

        int oldX = 0, oldY=0;
        public Bitmap DrawCircle(int ix, int iy, Bitmap inbitmap, Color iC, bool trackline = false)
        {
            for (int x = -2; x < 2; x++)
            {
                for (int y = -2; y < 2; y++)
                {
                    if ((ix + x) < inbitmap.Width && (ix + x) > 0 && (iy + y) < inbitmap.Height && (iy + y) > 0)
                    {
                        inbitmap.SetPixel(ix + x, iy + y, iC);
                        if (trackline)
                        {
                            inbitmap = DrawLine(inbitmap,ix + x, iy + y,oldX,oldY);
                            oldX = 0;
                            oldY = 0;
                            oldX += ix + x;
                            oldY += iy + y;

                        }
                    }
                }
            }

            return inbitmap;
        }

        public Bitmap DrawLine(Bitmap inputMap,int FromX, int FromY, int ToX, int ToY)
        {
            for(int i = FromX; i < ToX; i++)
            {
                if (i > 0 && i < ToX)
                {
                    inputMap.SetPixel(i, FromY, Color.Black);
                }
            }
            for (int i = FromY; i < ToY; i++)
            {
                if (i > 0 && i < ToX)
                {
                    inputMap.SetPixel(FromX, i, Color.Black);
                }
            }


            return inputMap;
        }

        public Bitmap GetChestScreenshot()
        {
            int offsetLeft = 250, offsetTop = 50;
            Bitmap captureBitmap = new Bitmap(350, 270, PixelFormat.Format32bppArgb);
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);
            captureGraphics.CopyFromScreen(this.Left + McPictureBox.Left + 8 + offsetLeft,this.Top + McPictureBox.Top + 32 + offsetTop, 0, 0, captureRectangle.Size);

           
            
            return captureBitmap;
        }
        public void DoMouseMove(int iX, int iY)
        {
            uint X = Convert.ToUInt32(iX);
            uint Y = Convert.ToUInt32(iY);
            Cursor.Position = new Point(iX, iY);
            //ADD SMALL DELAY FOR MAGIC TO HAPPEN
        }
        public void DoMouseClick(int iX, int iY)
        {
            uint X = Convert.ToUInt32(iX);
            uint Y = Convert.ToUInt32(iY);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (running)
            {
                Random rnd = new Random();
                MainEventChain();
                timer1.Interval = 300 + rnd.Next(-200, 200);
                label1.Text = "TICKRATE" + timer1.Interval;

            }
            if (preview)
            {
                Preview();
            }
        }

        private void GreenTriggerNumeric_ValueChanged(object sender, EventArgs e)
        {
            Color bestcolor = Color.FromArgb(0,(int)GreenTriggerNumeric.Value, 0);
            GreenTriggerNumeric.BackColor = bestcolor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ADD BLACKLISTED COLROS
            BlackListerColors.Add(Color.FromArgb(131,212,28));
            BlackListerColors.Add(Color.FromArgb(118, 198, 16));
            BlackListerColors.Add(Color.FromArgb(101, 172, 9));
            BlackListerColors.Add(Color.FromArgb(90, 154, 8));
            BlackListerColors.Add(Color.FromArgb(75, 106, 34));
            BlackListerColors.Add(Color.FromArgb(85, 124, 32));
            BlackListerColors.Add(Color.FromArgb(79, 113, 33));
            BlackListerColors.Add(Color.FromArgb(96, 145, 30));
        }

        private void ResetClicksButton_Click(object sender, EventArgs e)
        {
            counter_label.Text = "Clicks: ";
        }
        public void CounterClicker()
        {
            //This will be called every click
            counter++;
            counter_label.Text = "Clicks: " + Convert.ToString(counter);
            if (counter != 79)
                {
                if (45 > counter && counter >= 12)
                {
                    clicks = 1;
                }
                else if (78 > counter && counter >= 45)
                {
                    clicks = 2;
                }
                else if (counter >= 78)
                {
                    clicks = 3;
                }
                else 
                {
                    clicks = 0;
                }
                ClickInformartionLabel.Text = "Amount of extra clicks earned: " + Convert.ToString(clicks);
                
            }
                
        }

    }
}
