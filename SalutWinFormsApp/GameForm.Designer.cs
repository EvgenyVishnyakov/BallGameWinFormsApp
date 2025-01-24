namespace SalutWinFormsApp
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
            components = new System.ComponentModel.Container();
            SaluteTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // SaluteTimer
            // 
            SaluteTimer.Enabled = true;
            SaluteTimer.Interval = 4500;
            SaluteTimer.Tag = "5";
            SaluteTimer.Tick += SaluteTimer_Tick;
            // 
            // GameForm
            // 
            BackColor = System.Drawing.Color.LightGray;
            ClientSize = new System.Drawing.Size(841, 641);
            Name = "GameForm";
            Text = "Салют!!!";            
            MouseDown += GameForm_MouseDown;
            
            ResumeLayout(false);
            
        }

        #endregion

        private System.Windows.Forms.Timer SaluteTimer;
    }
}
