using System.Drawing;
using System.Windows.Forms;

namespace BillyardBallsWinFormsApp
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
            leftLabel = new Label();
            rightLabel = new Label();
            topLabel = new Label();
            downLabel = new Label();
            SuspendLayout();
            // 
            // leftLabel
            // 
            leftLabel.AutoSize = true;
            leftLabel.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leftLabel.Location = new Point(7, 192);
            leftLabel.Name = "leftLabel";
            leftLabel.Size = new Size(21, 21);
            leftLabel.TabIndex = 0;
            leftLabel.Text = "0";
            // 
            // rightLabel
            // 
            rightLabel.AutoSize = true;
            rightLabel.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rightLabel.Location = new Point(767, 192);
            rightLabel.Name = "rightLabel";
            rightLabel.Size = new Size(21, 21);
            rightLabel.TabIndex = 1;
            rightLabel.Text = "0";
            // 
            // topLabel
            // 
            topLabel.AutoSize = true;
            topLabel.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            topLabel.Location = new Point(400, 9);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(21, 21);
            topLabel.TabIndex = 2;
            topLabel.Text = "0";
            // 
            // downLabel
            // 
            downLabel.AutoSize = true;
            downLabel.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            downLabel.Location = new Point(400, 420);
            downLabel.Name = "downLabel";
            downLabel.Size = new Size(21, 21);
            downLabel.TabIndex = 3;
            downLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(downLabel);
            Controls.Add(topLabel);
            Controls.Add(rightLabel);
            Controls.Add(leftLabel);
            Name = "MainForm";
            Text = "BillyardGame";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftLabel;
        private Label rightLabel;
        private Label topLabel;
        private Label downLabel;
    }
}
