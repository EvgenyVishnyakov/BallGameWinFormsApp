using Balls.Common;
using System;
using System.Windows.Forms;

namespace BillyardBallsWinFormsApp;

public partial class MainForm : Form
{
    private int amountBall = 10;
    public MainForm()
    {
        InitializeComponent();
    }
    private void MainForm_Load(object sender, EventArgs e)
    {
        for (int i = 1; i < amountBall; i++)
        {
            var ball = new BillyardBall(this);
            ball.OnHited += Ball_OnHited;
            ball.Start();
        }
        
    }
    protected virtual void Ball_OnHited(object? sender, HitEventArgs e)
    {
        switch (e.Side)
        {
            case Side.Left: leftLabel.Text = (Convert.ToInt32(leftLabel.Text) + 1).ToString(); break;
            case Side.Right: rightLabel.Text = (Convert.ToInt32(rightLabel.Text) + 1).ToString(); break;
            case Side.Top: topLabel.Text = (Convert.ToInt32(topLabel.Text) + 1).ToString(); break;
            case Side.Bottom: downLabel.Text = (Convert.ToInt32(downLabel.Text) + 1).ToString(); break;
        }
    }
}
