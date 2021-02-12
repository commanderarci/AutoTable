
namespace AutoTable
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.McPictureBox = new System.Windows.Forms.PictureBox();
            this.Start_button = new System.Windows.Forms.Button();
            this.counter_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ClickPicturebox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GridLeftNumeric = new System.Windows.Forms.NumericUpDown();
            this.GridLeftLabel = new System.Windows.Forms.Label();
            this.GridTopLabel = new System.Windows.Forms.Label();
            this.GridTopNumeric = new System.Windows.Forms.NumericUpDown();
            this.PreviewButton = new System.Windows.Forms.Button();
            this.GreenTriggerNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.McPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClickPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLeftNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTopNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTriggerNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // McPictureBox
            // 
            this.McPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.McPictureBox.Location = new System.Drawing.Point(12, 12);
            this.McPictureBox.Name = "McPictureBox";
            this.McPictureBox.Size = new System.Drawing.Size(856, 521);
            this.McPictureBox.TabIndex = 0;
            this.McPictureBox.TabStop = false;
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(888, 12);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(129, 58);
            this.Start_button.TabIndex = 2;
            this.Start_button.Text = "START";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // counter_label
            // 
            this.counter_label.AutoSize = true;
            this.counter_label.Location = new System.Drawing.Point(1104, 12);
            this.counter_label.Name = "counter_label";
            this.counter_label.Size = new System.Drawing.Size(60, 13);
            this.counter_label.TabIndex = 3;
            this.counter_label.Text = "COUNTER";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1116, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // ClickPicturebox
            // 
            this.ClickPicturebox.Location = new System.Drawing.Point(880, 263);
            this.ClickPicturebox.Name = "ClickPicturebox";
            this.ClickPicturebox.Size = new System.Drawing.Size(350, 270);
            this.ClickPicturebox.TabIndex = 5;
            this.ClickPicturebox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1148, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // GridLeftNumeric
            // 
            this.GridLeftNumeric.Location = new System.Drawing.Point(941, 144);
            this.GridLeftNumeric.Name = "GridLeftNumeric";
            this.GridLeftNumeric.Size = new System.Drawing.Size(120, 20);
            this.GridLeftNumeric.TabIndex = 7;
            this.GridLeftNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // GridLeftLabel
            // 
            this.GridLeftLabel.AutoSize = true;
            this.GridLeftLabel.Location = new System.Drawing.Point(885, 146);
            this.GridLeftLabel.Name = "GridLeftLabel";
            this.GridLeftLabel.Size = new System.Drawing.Size(50, 13);
            this.GridLeftLabel.TabIndex = 8;
            this.GridLeftLabel.Text = "Grid Left:";
            // 
            // GridTopLabel
            // 
            this.GridTopLabel.AutoSize = true;
            this.GridTopLabel.Location = new System.Drawing.Point(885, 172);
            this.GridTopLabel.Name = "GridTopLabel";
            this.GridTopLabel.Size = new System.Drawing.Size(51, 13);
            this.GridTopLabel.TabIndex = 10;
            this.GridTopLabel.Text = "Grid Top:";
            // 
            // GridTopNumeric
            // 
            this.GridTopNumeric.Location = new System.Drawing.Point(941, 170);
            this.GridTopNumeric.Name = "GridTopNumeric";
            this.GridTopNumeric.Size = new System.Drawing.Size(120, 20);
            this.GridTopNumeric.TabIndex = 9;
            this.GridTopNumeric.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(888, 76);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(129, 23);
            this.PreviewButton.TabIndex = 11;
            this.PreviewButton.Text = "Preview OFF";
            this.PreviewButton.UseVisualStyleBackColor = true;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // GreenTriggerNumeric
            // 
            this.GreenTriggerNumeric.Location = new System.Drawing.Point(1107, 146);
            this.GreenTriggerNumeric.Name = "GreenTriggerNumeric";
            this.GreenTriggerNumeric.Size = new System.Drawing.Size(44, 20);
            this.GreenTriggerNumeric.TabIndex = 12;
            this.GreenTriggerNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.GreenTriggerNumeric.ValueChanged += new System.EventHandler(this.GreenTriggerNumeric_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 545);
            this.Controls.Add(this.GreenTriggerNumeric);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.GridTopLabel);
            this.Controls.Add(this.GridTopNumeric);
            this.Controls.Add(this.GridLeftLabel);
            this.Controls.Add(this.GridLeftNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClickPicturebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.counter_label);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.McPictureBox);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.McPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClickPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLeftNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTopNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTriggerNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox McPictureBox;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Label counter_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ClickPicturebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown GridLeftNumeric;
        private System.Windows.Forms.Label GridLeftLabel;
        private System.Windows.Forms.Label GridTopLabel;
        private System.Windows.Forms.NumericUpDown GridTopNumeric;
        private System.Windows.Forms.Button PreviewButton;
        private System.Windows.Forms.NumericUpDown GreenTriggerNumeric;
    }
}

