using System.Drawing;
using System.Windows.Forms;

namespace DiffusionWinFormsApp
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
            redTopLabel = new Label();
            redRightLabel = new Label();
            redleftLabel = new Label();
            redDownLabel = new Label();
            StopButton = new Button();
            MoveBallButton = new Button();
            greenTopLabel = new Label();
            greenRightLabel = new Label();
            greenLeftLabel = new Label();
            greenBottomLabel = new Label();
            ContinueButton = new Button();
            SuspendLayout();
            // 
            // redTopLabel
            // 
            redTopLabel.AutoSize = true;
            redTopLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            redTopLabel.ForeColor = Color.Red;
            redTopLabel.Location = new Point(378, 12);
            redTopLabel.Name = "redTopLabel";
            redTopLabel.Size = new Size(22, 23);
            redTopLabel.TabIndex = 0;
            redTopLabel.Text = "0";
            // 
            // redRightLabel
            // 
            redRightLabel.AutoSize = true;
            redRightLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            redRightLabel.ForeColor = Color.Red;
            redRightLabel.Location = new Point(756, 178);
            redRightLabel.Name = "redRightLabel";
            redRightLabel.Size = new Size(22, 23);
            redRightLabel.TabIndex = 1;
            redRightLabel.Text = "0";
            // 
            // redleftLabel
            // 
            redleftLabel.AutoSize = true;
            redleftLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            redleftLabel.ForeColor = Color.Red;
            redleftLabel.Location = new Point(23, 178);
            redleftLabel.Name = "redleftLabel";
            redleftLabel.Size = new Size(22, 23);
            redleftLabel.TabIndex = 2;
            redleftLabel.Text = "0";
            // 
            // redDownLabel
            // 
            redDownLabel.AutoSize = true;
            redDownLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            redDownLabel.ForeColor = Color.Red;
            redDownLabel.Location = new Point(378, 415);
            redDownLabel.Name = "redDownLabel";
            redDownLabel.Size = new Size(22, 23);
            redDownLabel.TabIndex = 3;
            redDownLabel.Text = "0";
            // 
            // StopButton
            // 
            StopButton.BackColor = Color.FromArgb(192, 192, 0);
            StopButton.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StopButton.ForeColor = Color.Red;
            StopButton.Location = new Point(628, 391);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(160, 47);
            StopButton.TabIndex = 4;
            StopButton.Text = "Стоп!";
            StopButton.UseVisualStyleBackColor = false;
            StopButton.Click += StopButton_Click;
            // 
            // MoveBallButton
            // 
            MoveBallButton.BackColor = Color.FromArgb(192, 192, 0);
            MoveBallButton.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoveBallButton.Location = new Point(628, 12);
            MoveBallButton.Name = "MoveBallButton";
            MoveBallButton.Size = new Size(160, 39);
            MoveBallButton.TabIndex = 5;
            MoveBallButton.Text = "Запуск";
            MoveBallButton.UseVisualStyleBackColor = false;
            MoveBallButton.Click += MoveBallButton_Click;
            // 
            // greenTopLabel
            // 
            greenTopLabel.AutoSize = true;
            greenTopLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greenTopLabel.ForeColor = Color.ForestGreen;
            greenTopLabel.Location = new Point(422, 12);
            greenTopLabel.Name = "greenTopLabel";
            greenTopLabel.Size = new Size(22, 23);
            greenTopLabel.TabIndex = 6;
            greenTopLabel.Text = "0";
            // 
            // greenRightLabel
            // 
            greenRightLabel.AutoSize = true;
            greenRightLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greenRightLabel.ForeColor = Color.ForestGreen;
            greenRightLabel.Location = new Point(756, 239);
            greenRightLabel.Name = "greenRightLabel";
            greenRightLabel.Size = new Size(22, 23);
            greenRightLabel.TabIndex = 7;
            greenRightLabel.Text = "0";
            // 
            // greenLeftLabel
            // 
            greenLeftLabel.AutoSize = true;
            greenLeftLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greenLeftLabel.ForeColor = Color.ForestGreen;
            greenLeftLabel.Location = new Point(23, 239);
            greenLeftLabel.Name = "greenLeftLabel";
            greenLeftLabel.Size = new Size(22, 23);
            greenLeftLabel.TabIndex = 8;
            greenLeftLabel.Text = "0";
            // 
            // greenBottomLabel
            // 
            greenBottomLabel.AutoSize = true;
            greenBottomLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greenBottomLabel.ForeColor = Color.ForestGreen;
            greenBottomLabel.Location = new Point(422, 415);
            greenBottomLabel.Name = "greenBottomLabel";
            greenBottomLabel.Size = new Size(22, 23);
            greenBottomLabel.TabIndex = 9;
            greenBottomLabel.Text = "0";
            // 
            // ContinueButton
            // 
            ContinueButton.BackColor = Color.FromArgb(192, 192, 0);
            ContinueButton.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContinueButton.ForeColor = Color.Red;
            ContinueButton.Location = new Point(12, 391);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(160, 47);
            ContinueButton.TabIndex = 10;
            ContinueButton.Text = "Продолжить";
            ContinueButton.UseVisualStyleBackColor = false;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(ContinueButton);
            Controls.Add(greenBottomLabel);
            Controls.Add(greenLeftLabel);
            Controls.Add(greenRightLabel);
            Controls.Add(greenTopLabel);
            Controls.Add(MoveBallButton);
            Controls.Add(StopButton);
            Controls.Add(redDownLabel);
            Controls.Add(redleftLabel);
            Controls.Add(redRightLabel);
            Controls.Add(redTopLabel);
            Name = "MainForm";
            Text = "Диффузия";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label redTopLabel;
        private Label redRightLabel;
        private Label redleftLabel;
        private Label redDownLabel;
        private Button StopButton;
        private Button MoveBallButton;
        private Label greenTopLabel;
        private Label greenRightLabel;
        private Label greenLeftLabel;
        private Label greenBottomLabel;
        private Button ContinueButton;
    }
}
