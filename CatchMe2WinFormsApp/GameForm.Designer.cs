using System.Drawing;
using System.Windows.Forms;

namespace CatchMe2WinFormsApp
{
    partial class GameForm
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
            StartButton = new Button();
            RestartButton = new Button();
            CountBallLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.DarkKhaki;
            StartButton.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartButton.Location = new Point(630, 12);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(148, 44);
            StartButton.TabIndex = 0;
            StartButton.Text = "Играть";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // RestartButton
            // 
            RestartButton.BackColor = Color.DarkKhaki;
            RestartButton.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RestartButton.Location = new Point(630, 394);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(148, 44);
            RestartButton.TabIndex = 4;
            RestartButton.Text = "Хочу еще!";
            RestartButton.UseVisualStyleBackColor = false;
            RestartButton.Click += RestartButton_Click;
            // 
            // CountBallLabel
            // 
            CountBallLabel.AutoSize = true;
            CountBallLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CountBallLabel.Location = new Point(400, 5);
            CountBallLabel.Name = "CountBallLabel";
            CountBallLabel.Size = new Size(22, 23);
            CountBallLabel.TabIndex = 5;
            CountBallLabel.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 5);
            label1.Name = "label1";
            label1.Size = new Size(216, 23);
            label1.TabIndex = 6;
            label1.Text = "Пойманных шариков";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(CountBallLabel);
            Controls.Add(RestartButton);
            Controls.Add(StartButton);
            Name = "GameForm";
            Text = "Поймай меня ;)";
            FormClosing += GameForm_FormClosing;
            MouseDown += GameForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button RestartButton;
        private Label CountBallLabel;
        private Label label1;
    }
}
