namespace FruitNinjaWinFormsApp
{
    partial class StartForm
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
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.DodgerBlue;
            button1.Font = new System.Drawing.Font("Cambria", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.Location = new System.Drawing.Point(276, 162);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(296, 90);
            button1.TabIndex = 0;
            button1.Text = "Играть!!!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(266, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(316, 33);
            label1.TabIndex = 1;
            label1.Text = "Приготовьтесь к игре!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(229, 111);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(398, 33);
            label2.TabIndex = 2;
            label2.Text = "Для старта нажмите играть!";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.PaleTurquoise;
            ClientSize = new System.Drawing.Size(835, 310);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "StartForm";
            Text = "Фруктовый ниндзя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}