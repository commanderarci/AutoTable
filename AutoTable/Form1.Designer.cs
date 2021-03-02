
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
            this.GridLeftNumeric = new System.Windows.Forms.NumericUpDown();
            this.GridLeftLabel = new System.Windows.Forms.Label();
            this.GridTopLabel = new System.Windows.Forms.Label();
            this.GridTopNumeric = new System.Windows.Forms.NumericUpDown();
            this.PreviewButton = new System.Windows.Forms.Button();
            this.GreenTriggerNumeric = new System.Windows.Forms.NumericUpDown();
            this.ResetClicksButton = new System.Windows.Forms.Button();
            this.ClickInformartionLabel = new System.Windows.Forms.Label();
            this.TriggerColorLabel = new System.Windows.Forms.Label();
            this.DancePictureBox = new System.Windows.Forms.PictureBox();
            this.BackgroundPicturebox = new System.Windows.Forms.PictureBox();
            this.ExperimentalButton = new System.Windows.Forms.Button();
            this.CandidateViewToggle_Button = new System.Windows.Forms.Button();
            this.CandidatesLabel = new System.Windows.Forms.Label();
            this.sizeAvgNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.McPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClickPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLeftNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTopNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTriggerNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DancePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeAvgNumeric)).BeginInit();
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
            this.Start_button.BackColor = System.Drawing.Color.Lime;
            this.Start_button.Location = new System.Drawing.Point(888, 12);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(129, 58);
            this.Start_button.TabIndex = 2;
            this.Start_button.Text = "START";
            this.Start_button.UseVisualStyleBackColor = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // counter_label
            // 
            this.counter_label.AutoSize = true;
            this.counter_label.Location = new System.Drawing.Point(1134, 12);
            this.counter_label.Name = "counter_label";
            this.counter_label.Size = new System.Drawing.Size(38, 13);
            this.counter_label.TabIndex = 3;
            this.counter_label.Text = "Clicks:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1064, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // ClickPicturebox
            // 
            this.ClickPicturebox.Location = new System.Drawing.Point(880, 263);
            this.ClickPicturebox.Name = "ClickPicturebox";
            this.ClickPicturebox.Size = new System.Drawing.Size(350, 270);
            this.ClickPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClickPicturebox.TabIndex = 5;
            this.ClickPicturebox.TabStop = false;
            // 
            // GridLeftNumeric
            // 
            this.GridLeftNumeric.Location = new System.Drawing.Point(941, 144);
            this.GridLeftNumeric.Name = "GridLeftNumeric";
            this.GridLeftNumeric.Size = new System.Drawing.Size(76, 20);
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
            this.GridTopNumeric.Size = new System.Drawing.Size(76, 20);
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
            this.GreenTriggerNumeric.Location = new System.Drawing.Point(1074, 172);
            this.GreenTriggerNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenTriggerNumeric.Name = "GreenTriggerNumeric";
            this.GreenTriggerNumeric.Size = new System.Drawing.Size(42, 20);
            this.GreenTriggerNumeric.TabIndex = 12;
            this.GreenTriggerNumeric.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenTriggerNumeric.ValueChanged += new System.EventHandler(this.GreenTriggerNumeric_ValueChanged);
            // 
            // ResetClicksButton
            // 
            this.ResetClicksButton.Location = new System.Drawing.Point(1137, 28);
            this.ResetClicksButton.Name = "ResetClicksButton";
            this.ResetClicksButton.Size = new System.Drawing.Size(75, 23);
            this.ResetClicksButton.TabIndex = 13;
            this.ResetClicksButton.Text = "Reset";
            this.ResetClicksButton.UseVisualStyleBackColor = true;
            this.ResetClicksButton.Click += new System.EventHandler(this.ResetClicksButton_Click);
            // 
            // ClickInformartionLabel
            // 
            this.ClickInformartionLabel.AutoSize = true;
            this.ClickInformartionLabel.Location = new System.Drawing.Point(1020, 114);
            this.ClickInformartionLabel.Name = "ClickInformartionLabel";
            this.ClickInformartionLabel.Size = new System.Drawing.Size(64, 13);
            this.ClickInformartionLabel.TabIndex = 14;
            this.ClickInformartionLabel.Text = "Extra clicks:";
            // 
            // TriggerColorLabel
            // 
            this.TriggerColorLabel.AutoSize = true;
            this.TriggerColorLabel.Location = new System.Drawing.Point(1071, 146);
            this.TriggerColorLabel.Name = "TriggerColorLabel";
            this.TriggerColorLabel.Size = new System.Drawing.Size(101, 13);
            this.TriggerColorLabel.TabIndex = 15;
            this.TriggerColorLabel.Text = "Green Trigger Level";
            // 
            // DancePictureBox
            // 
            this.DancePictureBox.Location = new System.Drawing.Point(1023, 4);
            this.DancePictureBox.Name = "DancePictureBox";
            this.DancePictureBox.Size = new System.Drawing.Size(100, 107);
            this.DancePictureBox.TabIndex = 16;
            this.DancePictureBox.TabStop = false;
            this.DancePictureBox.Visible = false;
            // 
            // BackgroundPicturebox
            // 
            this.BackgroundPicturebox.Location = new System.Drawing.Point(0, -5);
            this.BackgroundPicturebox.Name = "BackgroundPicturebox";
            this.BackgroundPicturebox.Size = new System.Drawing.Size(1248, 559);
            this.BackgroundPicturebox.TabIndex = 17;
            this.BackgroundPicturebox.TabStop = false;
            // 
            // ExperimentalButton
            // 
            this.ExperimentalButton.Location = new System.Drawing.Point(888, 104);
            this.ExperimentalButton.Name = "ExperimentalButton";
            this.ExperimentalButton.Size = new System.Drawing.Size(129, 23);
            this.ExperimentalButton.TabIndex = 18;
            this.ExperimentalButton.Text = "Experimental";
            this.ExperimentalButton.UseVisualStyleBackColor = true;
            this.ExperimentalButton.Click += new System.EventHandler(this.ExperimentalButton_Click);
            // 
            // CandidateViewToggle_Button
            // 
            this.CandidateViewToggle_Button.Location = new System.Drawing.Point(880, 227);
            this.CandidateViewToggle_Button.Name = "CandidateViewToggle_Button";
            this.CandidateViewToggle_Button.Size = new System.Drawing.Size(350, 30);
            this.CandidateViewToggle_Button.TabIndex = 19;
            this.CandidateViewToggle_Button.Text = "Canditate View Mode";
            this.CandidateViewToggle_Button.UseVisualStyleBackColor = true;
            this.CandidateViewToggle_Button.Click += new System.EventHandler(this.CandidateViewToggle_Button_Click);
            // 
            // CandidatesLabel
            // 
            this.CandidatesLabel.AutoSize = true;
            this.CandidatesLabel.Location = new System.Drawing.Point(938, 130);
            this.CandidatesLabel.Name = "CandidatesLabel";
            this.CandidatesLabel.Size = new System.Drawing.Size(66, 13);
            this.CandidatesLabel.TabIndex = 20;
            this.CandidatesLabel.Text = "Candidates: ";
            // 
            // sizeAvgNumeric
            // 
            this.sizeAvgNumeric.Location = new System.Drawing.Point(941, 196);
            this.sizeAvgNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.sizeAvgNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeAvgNumeric.Name = "sizeAvgNumeric";
            this.sizeAvgNumeric.Size = new System.Drawing.Size(76, 20);
            this.sizeAvgNumeric.TabIndex = 21;
            this.sizeAvgNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(885, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Size avg:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeAvgNumeric);
            this.Controls.Add(this.CandidatesLabel);
            this.Controls.Add(this.CandidateViewToggle_Button);
            this.Controls.Add(this.ExperimentalButton);
            this.Controls.Add(this.DancePictureBox);
            this.Controls.Add(this.TriggerColorLabel);
            this.Controls.Add(this.ClickInformartionLabel);
            this.Controls.Add(this.ResetClicksButton);
            this.Controls.Add(this.GreenTriggerNumeric);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.GridTopLabel);
            this.Controls.Add(this.GridTopNumeric);
            this.Controls.Add(this.GridLeftLabel);
            this.Controls.Add(this.GridLeftNumeric);
            this.Controls.Add(this.ClickPicturebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.counter_label);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.McPictureBox);
            this.Controls.Add(this.BackgroundPicturebox);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.McPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClickPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLeftNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTopNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTriggerNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DancePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeAvgNumeric)).EndInit();
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
        private System.Windows.Forms.NumericUpDown GridLeftNumeric;
        private System.Windows.Forms.Label GridLeftLabel;
        private System.Windows.Forms.Label GridTopLabel;
        private System.Windows.Forms.NumericUpDown GridTopNumeric;
        private System.Windows.Forms.Button PreviewButton;
        private System.Windows.Forms.NumericUpDown GreenTriggerNumeric;
        private System.Windows.Forms.Button ResetClicksButton;
        private System.Windows.Forms.Label ClickInformartionLabel;
        private System.Windows.Forms.Label TriggerColorLabel;
        private System.Windows.Forms.PictureBox DancePictureBox;
        private System.Windows.Forms.PictureBox BackgroundPicturebox;
        private System.Windows.Forms.Button ExperimentalButton;
        private System.Windows.Forms.Button CandidateViewToggle_Button;
        private System.Windows.Forms.Label CandidatesLabel;
        private System.Windows.Forms.NumericUpDown sizeAvgNumeric;
        private System.Windows.Forms.Label label2;
    }
}

