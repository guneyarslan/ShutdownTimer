using System.Windows.Forms;

namespace ShutdownTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timelabel = new Label();
            txtMinutes = new TextBox();
            shutdownbutton = new Button();
            stopbutton = new Button();
            lblCountdown = new Label();
            shutdownInfoLabel = new Label();
            title = new Label();
            desc = new Label();
            remainingtime = new Label();
            linkLabel1 = new LinkLabel();
            status = new Label();
            toolTip1 = new ToolTip(components);
            infobutton = new Button();
            SuspendLayout();
            // 
            // timelabel
            // 
            timelabel.AutoSize = true;
            timelabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timelabel.Location = new Point(13, 111);
            timelabel.Margin = new Padding(4, 0, 4, 0);
            timelabel.Name = "timelabel";
            timelabel.Size = new Size(159, 19);
            timelabel.TabIndex = 0;
            timelabel.Text = "Shutdown Time (minute):";
            // 
            // txtMinutes
            // 
            txtMinutes.Location = new Point(180, 108);
            txtMinutes.Margin = new Padding(4);
            txtMinutes.Name = "txtMinutes";
            txtMinutes.Size = new Size(141, 26);
            txtMinutes.TabIndex = 1;
            txtMinutes.Text = "120";
            // 
            // shutdownbutton
            // 
            shutdownbutton.Location = new Point(47, 154);
            shutdownbutton.Margin = new Padding(4);
            shutdownbutton.Name = "shutdownbutton";
            shutdownbutton.Size = new Size(237, 28);
            shutdownbutton.TabIndex = 2;
            shutdownbutton.Text = "Set timer and Shutdown";
            shutdownbutton.UseVisualStyleBackColor = true;
            shutdownbutton.Click += button1_Click;
            // 
            // stopbutton
            // 
            stopbutton.Cursor = Cursors.Hand;
            stopbutton.Location = new Point(118, 190);
            stopbutton.Margin = new Padding(4);
            stopbutton.Name = "stopbutton";
            stopbutton.Size = new Size(107, 28);
            stopbutton.TabIndex = 3;
            stopbutton.Text = "Stop Timer";
            stopbutton.UseVisualStyleBackColor = true;
            stopbutton.Click += button2_Click;
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountdown.Location = new Point(128, 241);
            lblCountdown.Margin = new Padding(4, 0, 4, 0);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(37, 17);
            lblCountdown.TabIndex = 4;
            lblCountdown.Text = "Time";
            // 
            // shutdownInfoLabel
            // 
            shutdownInfoLabel.AutoSize = true;
            shutdownInfoLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            shutdownInfoLabel.Location = new Point(62, 276);
            shutdownInfoLabel.Margin = new Padding(4, 0, 4, 0);
            shutdownInfoLabel.Name = "shutdownInfoLabel";
            shutdownInfoLabel.Size = new Size(30, 17);
            shutdownInfoLabel.TabIndex = 5;
            shutdownInfoLabel.Text = "Idle";
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(87, 9);
            title.Margin = new Padding(4, 0, 4, 0);
            title.Name = "title";
            title.Size = new Size(170, 27);
            title.TabIndex = 6;
            title.Text = "Shutdown Timer";
            // 
            // desc
            // 
            desc.Anchor = AnchorStyles.Top;
            desc.AutoSize = true;
            desc.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            desc.Location = new Point(47, 45);
            desc.Margin = new Padding(4, 0, 4, 0);
            desc.Name = "desc";
            desc.Size = new Size(263, 34);
            desc.TabIndex = 7;
            desc.Text = "Please enter the time in \"minutes\" you want\r\n the computer to shut down";
            // 
            // remainingtime
            // 
            remainingtime.AutoSize = true;
            remainingtime.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            remainingtime.Location = new Point(13, 239);
            remainingtime.Margin = new Padding(4, 0, 4, 0);
            remainingtime.Name = "remainingtime";
            remainingtime.Size = new Size(107, 19);
            remainingtime.TabIndex = 8;
            remainingtime.Text = "Remaining Time:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.Sienna;
            linkLabel1.Location = new Point(11, 367);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(77, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "MY GITHUB";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            status.Location = new Point(13, 274);
            status.Margin = new Padding(2, 0, 2, 0);
            status.Name = "status";
            status.Size = new Size(53, 19);
            status.TabIndex = 10;
            status.Text = "Status: ";
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 100;
            toolTip1.AutoPopDelay = 1500;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 20;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Information";
            // 
            // infobutton
            // 
            infobutton.BackColor = Color.PeachPuff;
            infobutton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            infobutton.Location = new Point(293, 7);
            infobutton.Name = "infobutton";
            infobutton.Size = new Size(37, 29);
            infobutton.TabIndex = 11;
            infobutton.Text = "?";
            infobutton.UseVisualStyleBackColor = false;
            infobutton.Click += infobutton_Click;
            infobutton.MouseLeave += infobutton_MouseLeave;
            infobutton.MouseHover += infobutton_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(342, 391);
            Controls.Add(infobutton);
            Controls.Add(status);
            Controls.Add(linkLabel1);
            Controls.Add(remainingtime);
            Controls.Add(desc);
            Controls.Add(title);
            Controls.Add(shutdownInfoLabel);
            Controls.Add(lblCountdown);
            Controls.Add(stopbutton);
            Controls.Add(shutdownbutton);
            Controls.Add(txtMinutes);
            Controls.Add(timelabel);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Opacity = 0.95D;
            Text = "Shutdown Timer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timelabel;
        private TextBox txtMinutes;
        private Button shutdownbutton;
        private Button stopbutton;
        private Label lblCountdown;
        private Label shutdownInfoLabel;
        private Label title;
        private Label desc;
        private Label remainingtime;
        private LinkLabel linkLabel1;
        private Label status;
        private ToolTip toolTip1;
        private Button infobutton;
    }
}