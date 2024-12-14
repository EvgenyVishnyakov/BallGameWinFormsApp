namespace FruitNinjaWinFormsApp
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            FruitTimer = new System.Windows.Forms.Timer(components);
            label1 = new System.Windows.Forms.Label();
            CountBallLabel = new System.Windows.Forms.Label();
            countTimerLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // FruitTimer
            // 
            FruitTimer.Enabled = true;
            FruitTimer.Interval = 25;
            FruitTimer.Tick += FruitTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.GreenYellow;
            label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(74, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(199, 20);
            label1.TabIndex = 0;
            label1.Text = "Пойманных шариков : ";
            // 
            // CountBallLabel
            // 
            CountBallLabel.AutoSize = true;
            CountBallLabel.BackColor = System.Drawing.Color.GreenYellow;
            CountBallLabel.Location = new System.Drawing.Point(279, 7);
            CountBallLabel.Name = "CountBallLabel";
            CountBallLabel.Size = new System.Drawing.Size(19, 20);
            CountBallLabel.TabIndex = 1;           
            CountBallLabel.Text = "0";
            // 
            // countTimerLabel
            // 
            countTimerLabel.AutoSize = true;
            countTimerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            countTimerLabel.Location = new System.Drawing.Point(24, 458);
            countTimerLabel.Name = "countTimerLabel";
            countTimerLabel.Size = new System.Drawing.Size(57, 20);
            countTimerLabel.TabIndex = 2;
            countTimerLabel.Text = "label2";
            countTimerLabel.Visible = false;
            //countTimerLabel.Click += countTimerLabel_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.LightGray;
            ClientSize = new System.Drawing.Size(894, 510);
            Controls.Add(countTimerLabel);
            Controls.Add(CountBallLabel);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Name = "GameForm";
            Text = "Фруктовая битва";
            FormClosing += GameForm_FormClosing;
            Load += GameForm_Load;
            MouseMove += GameForm_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer FruitTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CountBallLabel;
        private System.Windows.Forms.Label countTimerLabel;
    }
}