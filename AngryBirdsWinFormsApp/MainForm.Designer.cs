using System.Drawing;

namespace AngryBirdsWinFormsApp
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
            label1 = new System.Windows.Forms.Label();
            shotDownPigBallCountLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 0;
            label1.Text = "Сбитых свинушек:";
            // 
            // shotDownPigBallCountLabel
            // 
            shotDownPigBallCountLabel.AutoSize = true;
            shotDownPigBallCountLabel.BackColor = Color.RosyBrown;
            shotDownPigBallCountLabel.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shotDownPigBallCountLabel.Location = new Point(241, 9);
            shotDownPigBallCountLabel.Name = "shotDownPigBallCountLabel";
            shotDownPigBallCountLabel.Size = new Size(19, 20);
            shotDownPigBallCountLabel.TabIndex = 1;
            shotDownPigBallCountLabel.Text = "0";
            // 
            // MainForm
            // 
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(shotDownPigBallCountLabel);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "AngryBirds";
            //Load += MainForm_Load;
            Shown += MainForm_Shown;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label shotDownPigBallCountLabel;
    }
}
