namespace CatchTheGhost
{
    partial class MainForm
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
            btnStart = new Button();
            pbGhost = new PictureBox();
            lblGameScore = new Label();
            lblTimerCount = new Label();
            tGame = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbGhost).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.BurlyWood;
            btnStart.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.ForeColor = Color.Cornsilk;
            btnStart.Location = new Point(356, 333);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 50);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += button1_Click;
            // 
            // pbGhost
            // 
            pbGhost.Image = Properties.Resources.Ghost;
            pbGhost.Location = new Point(368, 138);
            pbGhost.Name = "pbGhost";
            pbGhost.Size = new Size(120, 120);
            pbGhost.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGhost.TabIndex = 1;
            pbGhost.TabStop = false;
            pbGhost.Visible = false;
            pbGhost.Click += pbGhost_Click;
            // 
            // lblGameScore
            // 
            lblGameScore.AutoSize = true;
            lblGameScore.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblGameScore.ForeColor = Color.Yellow;
            lblGameScore.Location = new Point(35, 20);
            lblGameScore.Name = "lblGameScore";
            lblGameScore.Size = new Size(71, 30);
            lblGameScore.TabIndex = 2;
            lblGameScore.Text = "label1";
            lblGameScore.Visible = false;
            // 
            // lblTimerCount
            // 
            lblTimerCount.AutoSize = true;
            lblTimerCount.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimerCount.ForeColor = Color.Yellow;
            lblTimerCount.Location = new Point(35, 64);
            lblTimerCount.Name = "lblTimerCount";
            lblTimerCount.Size = new Size(71, 30);
            lblTimerCount.TabIndex = 3;
            lblTimerCount.Text = "label1";
            lblTimerCount.Visible = false;
            // 
            // tGame
            // 
            tGame.Interval = 1000;
            tGame.Tick += tGame_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(784, 461);
            Controls.Add(lblTimerCount);
            Controls.Add(lblGameScore);
            Controls.Add(pbGhost);
            Controls.Add(btnStart);
            Name = "MainForm";
            Text = "תופסת רוח";
            ((System.ComponentModel.ISupportInitialize)pbGhost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private PictureBox pbGhost;
        private Label lblGameScore;
        private Label lblTimerCount;
        private System.Windows.Forms.Timer tGame;
    }
}
