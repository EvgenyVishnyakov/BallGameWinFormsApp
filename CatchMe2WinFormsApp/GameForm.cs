using Balls.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CatchMe2WinFormsApp;

public partial class GameForm : Form
{
    List<Ball> moveBalls = new List<Ball>();   
    private int amountBall = 5;
    private int totalBall = 0;

    public GameForm()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;       
    }
    private void StartButton_Click(object sender, EventArgs e)
    {
        StartButton.Enabled = false;
        moveBalls = new List<Ball>();
        for (int i = 1; i <= amountBall; i++)
        {
            var moveBall = new MoveBall(this);
            moveBalls.Add(moveBall);
            moveBall.Start();
        }
    }
    private void RestartButton_Click(object sender, EventArgs e)
    {
        GameForm gameForm = new GameForm();
        gameForm.Show();
        StartButton.Enabled = true;
        Hide();
    }
    private void GameForm_MouseDown(object sender, MouseEventArgs e)
    {
        for (int i = 0; i < moveBalls.Count; i++)
        {
            if (moveBalls[i].IsMoveBallable() && moveBalls[i].Contains(e.X, e.Y))
            {
                moveBalls[i].Stop();
                totalBall++;
            }
        }
        CountBallLabel.Text = totalBall.ToString();
    }    
    private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
}
