﻿using System;
using System.Reflection;
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
        bool experimental = false;
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
                ExperimentalButton.Enabled = false;
                Start_button.BackColor = Color.Red;

                DancePictureBox.Image = minecraftDanceGif;
                DancePictureBox.Visible = true;
                DancePictureBox.Enabled = true;
                BackgroundPicturebox.Visible = true;
            }
            else
            {
                Start_button.Text = "START";
                timer1.Enabled = false;
                PreviewButton.Enabled = true;
                ExperimentalButton.Enabled = true;
                Start_button.BackColor = Color.Lime;

                DancePictureBox.Visible = false;
                DancePictureBox.Enabled = false;
                BackgroundPicturebox.Visible = false;
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
                ExperimentalButton.Enabled = false;
                timer1.Interval = 200;

                DancePictureBox.Image = aquaDanceGif;
                DancePictureBox.Visible = true;
                DancePictureBox.Enabled = true;
            }
            else
            {
                PreviewButton.Text = "Preview OFF";
                timer1.Enabled = false;
                Start_button.Enabled = true;
                ExperimentalButton.Enabled = true;
                timer1.Interval = 1000;

                DancePictureBox.Visible = false;
                DancePictureBox.Enabled = false;
            }
        }
        private void ExperimentalButton_Click(object sender, EventArgs e)
        {
            experimental = !experimental;
            if (experimental)
            {
                ExperimentalButton.Text = "STOP";
                timer1.Enabled = true;
                PreviewButton.Enabled = false;
                Start_button.Enabled = false;

            }
            else
            {
                ExperimentalButton.Text = "Experimental";
                timer1.Enabled = false;
                PreviewButton.Enabled = true;
                Start_button.Enabled = true;
            }
        }
        public class ClickCandidate
        {
            public Color _color;
            public int posX, posY;
            public ClickCandidate(int iX, int iY, Color icolor)
            {
                posX = iX;
                posY = iY;
                _color = icolor;
            }

        }
        bool clickToggle = false;
        ClickCandidate oldBestCanditate;
        ClickCandidate bestCandidate;
        public void MainEventChain()
        {

            if (clickToggle)
            {
                //Click
                //Click on position
                DoMouseClick(this.Left + 8 + 250 + bestCandidate.posX + 5, this.Top + 32 + 50 + bestCandidate.posY + 15);
                CounterClicker();
                clickToggle = !clickToggle;

                //Add to history

                bestCandidate = null;
            }
            else
            {
                //Find and move mouse to best click position

                //Get bitmapmap 
                Bitmap workbitmap = GetChestScreenshot();
                //Settings
                int gridLeft = (int)GridLeftNumeric.Value, gridTop = (int)GridTopNumeric.Value;
                int offsetLeft = workbitmap.Width / gridLeft, offsetTop = workbitmap.Width / gridTop;

                //Get all canditates
                List<ClickCandidate> candidateslist = new List<ClickCandidate>();
                for (int x = 0; x < gridLeft; x++)
                {
                    for (int y = 0; y < gridTop; y++)
                    {
                        if (x * offsetLeft > 0 && x * offsetLeft < workbitmap.Width && y * offsetTop > 0 && y * offsetTop < workbitmap.Height)
                        {
                            //For each position
                            ClickCandidate newCandidate = new ClickCandidate(x * offsetLeft, y * offsetTop, GetAverageColor(x * offsetLeft, y * offsetTop, workbitmap));
                            if (!BlackListerColors.Contains(newCandidate._color))
                            {
                                candidateslist.Add(newCandidate);
                            }
                        }
                    }
                }

                //Now compare all the canditates and take the best one
                bestCandidate = new ClickCandidate(0, 0, Color.FromArgb(0, 0, 0));
                foreach (ClickCandidate candidate in candidateslist)
                {
                    float greenValue = candidate._color.G - candidate._color.R - candidate._color.B;
                    if (greenValue > bestCandidate._color.G)
                    {
                        workbitmap = DrawCircle(candidate.posX, candidate.posY, workbitmap, Color.GreenYellow);
                        bestCandidate = candidate;
                    }
                }


                //If it passed the treshhold value its good
                if (bestCandidate._color.G > GreenTriggerNumeric.Value)
                {
                    //Move to position
                    DoMouseMove(this.Left + 8 + 250 + bestCandidate.posX + 5, this.Top + 32 + 50 + bestCandidate.posY + 15);
                    clickToggle = !clickToggle;
                }

                //Visual Stimuli
                CandidatesLabel.Text = "Candidates: " + candidateslist.Count();
                if (viewCandidates)
                {
                    Bitmap candidateViewBitMap = new Bitmap((int)GridLeftNumeric.Value, (int)GridTopNumeric.Value, PixelFormat.Format32bppArgb);

                    foreach (ClickCandidate candidate in candidateslist)
                    {
                        int Gcolor = candidate._color.G - candidate._color.R - candidate._color.B;
                        if (Gcolor < 0)
                            Gcolor = 0;
                        if (Gcolor > 255)
                            Gcolor = 255;

                        Color tempColor = Color.FromArgb(0, Gcolor, 0);
                        candidateViewBitMap.SetPixel(candidate.posX / offsetLeft, candidate.posY / offsetTop, tempColor);
                    }

                    ClickPicturebox.Image = candidateViewBitMap;

                }
                else
                {
                    //Color the best one
                    Color tempcolor = Color.FromArgb(0, 255, 0);
                    workbitmap = DrawCircle(bestCandidate.posX * offsetLeft, bestCandidate.posY * offsetTop, workbitmap, tempcolor);
                    //smol preview
                    ClickPicturebox.Image = workbitmap;
                }
            }






        }

/*        public void ExperimentalRoutine()
        {
            //Get bitmapmap 
            Bitmap workbitmap = GetChestScreenshot();
            //Settings
            int gridLeft = (int)GridLeftNumeric.Value * 5, gridTop = (int)GridTopNumeric.Value * 5;
            int offsetLeft = workbitmap.Width / gridLeft, offsetTop = workbitmap.Width / gridTop;

            //Get all canditates
            List<ClickCandidate> candidateslist = new List<ClickCandidate>();


            //WIP trying to make it keep searching untill its found
            while (candidateslist.Count == 0 && offsetLeft > 0 && offsetTop > 0)
            {
                for (int x = 0; x < gridLeft; x++)
                {
                    for (int y = 0; y < gridTop; y++)
                    {
                        if (x * offsetTop > 0 && x * offsetTop < workbitmap.Width && y * offsetLeft > 0 && y * offsetLeft < workbitmap.Height)
                        {
                            //For each position
                            ClickCandidate newCandidate = new ClickCandidate(x * offsetLeft, y * offsetTop, GetAverageColor(x * offsetLeft, y * offsetTop, workbitmap));
                            if (!BlackListerColors.Contains(newCandidate._color))
                            {
                                candidateslist.Add(newCandidate);
                            }


                            //Color that specific pixel :D for preview picture box
                            workbitmap = DrawCircle(x * offsetLeft, y * offsetTop, workbitmap, Color.Gray);
                        }
                    }
                }






                offsetTop -= 1;
                offsetLeft -= 1;
            }


            //Now compare all the canditates and take the best one
            ClickCandidate bestCandidate = new ClickCandidate(0, 0, Color.FromArgb(0, 0, 0));
            foreach (ClickCandidate candidate in candidateslist)
            {
                float greenValue = candidate._color.G - candidate._color.R - candidate._color.B;

                if (greenValue > bestCandidate._color.G)
                {
                    bestCandidate = candidate;
                }
            }


            //Color the best one
            Color tempcolor = Color.FromArgb(0, 255, 0);
            workbitmap = DrawCircle(bestCandidate.posX * offsetLeft, bestCandidate.posY * offsetTop, workbitmap, tempcolor);


            //Makes tracking lines
            foreach (ClickCandidate item in oldCanditatesList)
            {
                if (oldBestCanditate != null)
                {
                    workbitmap = DrawLine(workbitmap, oldBestCanditate.posX, oldBestCanditate.posY, item.posX, item.posY, Color.Green);
                }
                oldBestCanditate = item;
            }



            //If it passed the treshhold value its good
            if (bestCandidate._color.G > GreenTriggerNumeric.Value)
            {
                if (clickToggle)
                {
                    //Click on position
                    DoMouseClick(this.Left + 8 + 250 + bestCandidate.posX + 5, this.Top + 32 + 50 + bestCandidate.posY + 15);
                    CounterClicker();
                    clickToggle = !clickToggle;

                    //Add to history
                    oldCanditatesList.Add(bestCandidate);
                }
                else
                {
                    //Move to position
                    DoMouseMove(this.Left + 8 + 250 + bestCandidate.posX + 5, this.Top + 32 + 50 + bestCandidate.posY + 15);
                    clickToggle = !clickToggle;
                }
            }
            else
            {
                oldCanditatesList = new List<ClickCandidate>();
            }



        }*/


        public Bitmap DrawLine(Bitmap inputBMap, int X1, int Y1, int X2, int Y2, Color icolor, int Thickness = 3)
        {
            if (X1 != 0 && X2 != 0 && Y1 != 0 && Y2 != 0)
            {
                Pen blackPen = new Pen(icolor, Thickness);
                using (var graphics = Graphics.FromImage(inputBMap))
                {
                    graphics.DrawLine(blackPen, X1, Y1, X2, Y2);
                }

            }
            return inputBMap;
        }


        public Color GetAverageColor(int iX, int iY, Bitmap iMap)
        {
            int sizeAvg = (int)sizeAvgNumeric.Value;
            int gridLeft = (int)GridLeftNumeric.Value, gridTop = (int)GridTopNumeric.Value;
            int offsetLeft = iMap.Width / gridLeft, offsetTop = iMap.Width / gridTop;
            int R = 0, G = 0, B = 0;
            int counter = 1;


            for (int x = iX - sizeAvg; x < iX + sizeAvg; x++)
            {
                for (int y = iY - sizeAvg; y < iY + sizeAvg; y++)
                {
                    if (x > 0 && x < iMap.Width && y > 0 && y < iMap.Height)
                    {
                        R += iMap.GetPixel(x, y).R;
                        G += iMap.GetPixel(x, y).G;
                        B += iMap.GetPixel(x, y).B;
                        counter++;
                    }
                }
            }

            R = R / counter;
            G = G / counter;
            B = B / counter;


            Color avgColor = Color.FromArgb(R, G, B);

            return avgColor;
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
                        workbitmap = DrawCircle(x * offsetLeft, y * offsetTop, workbitmap, Color.Black);
                    }
                }
            }

            ClickPicturebox.Image = workbitmap;
        }

        public Bitmap DrawCircle(int ix, int iy, Bitmap inbitmap, Color iColor)
        {
            int size = (int)sizeAvgNumeric.Value;
            Pen drawingpen = new Pen(iColor, 1);
            using (var graphics = Graphics.FromImage(inbitmap))
            {
                graphics.DrawEllipse(drawingpen, ix - size/2, iy - size/2, size, size);
            }
            return inbitmap;
        }
        public Bitmap GetChestScreenshot()
        {
            int offsetLeft = 250, offsetTop = 50;
            Bitmap captureBitmap = new Bitmap(350, 270, PixelFormat.Format32bppArgb);
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);
            captureGraphics.CopyFromScreen(this.Left + McPictureBox.Left + 8 + offsetLeft, this.Top + McPictureBox.Top + 32 + offsetTop, 0, 0, captureRectangle.Size);
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
            if (experimental)
            {
/*                ExperimentalRoutine();*/
                timer1.Interval = 300 + GetIntRandomNumber(-200, 200);
                label1.Text = "TICKRATE" + timer1.Interval;
            }
            else if (running)
            {
                MainEventChain();
                timer1.Interval = 300 + GetIntRandomNumber(-200, 200);
                label1.Text = "TICKRATE" + timer1.Interval;

            }
            else if (preview)
            {
                Preview();
                label1.Text = "TICKRATE" + timer1.Interval;
            }

        }
        public int GetIntRandomNumber(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
        public Color GetRandomColor()
        {
            return Color.FromArgb(GetIntRandomNumber(50, 100), GetIntRandomNumber(50, 100), GetIntRandomNumber(50, 100));
        }
        private void GreenTriggerNumeric_ValueChanged(object sender, EventArgs e)
        {
            Color bestcolor = Color.FromArgb(0, (int)GreenTriggerNumeric.Value, 0);
            GreenTriggerNumeric.BackColor = bestcolor;
        }

        Image aquaDanceGif, fireBackgroundGif, minecraftDanceGif;
        private void Form1_Load(object sender, EventArgs e)
        {
            //ADD BLACKLISTED COLORS
            BlackListerColors.Add(Color.FromArgb(131, 212, 28));
            BlackListerColors.Add(Color.FromArgb(118, 198, 16));
            BlackListerColors.Add(Color.FromArgb(101, 172, 9));
            BlackListerColors.Add(Color.FromArgb(90, 154, 8));
            BlackListerColors.Add(Color.FromArgb(75, 106, 34));
            BlackListerColors.Add(Color.FromArgb(85, 124, 32));
            BlackListerColors.Add(Color.FromArgb(79, 113, 33));
            BlackListerColors.Add(Color.FromArgb(96, 145, 30));


            aquaDanceGif = Properties.Resources.AquaDanceGif;

            DancePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            fireBackgroundGif = Properties.Resources.BackgroundFire;
            BackgroundPicturebox.Image = fireBackgroundGif;
            BackgroundPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            BackgroundPicturebox.Visible = false;

            minecraftDanceGif = Properties.Resources.MinecraftDanceGif;

            Color bestcolor = Color.FromArgb(0, (int)GreenTriggerNumeric.Value, 0);
            GreenTriggerNumeric.BackColor = bestcolor;

        }


        private bool viewCandidates;
        private void CandidateViewToggle_Button_Click(object sender, EventArgs e)
        {
            viewCandidates = !viewCandidates;
            if (viewCandidates)
            {
                CandidateViewToggle_Button.BackColor = Color.DarkGreen;
            }
            else
            {
                CandidateViewToggle_Button.BackColor = Color.White;
            }


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
