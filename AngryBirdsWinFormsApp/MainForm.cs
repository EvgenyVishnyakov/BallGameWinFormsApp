using System;
using System.Windows.Forms;

namespace AngryBirdsWinFormsApp;

public partial class MainForm : Form
{
    BirdBall bird;
    PigBall pig;
    Timer timer = new Timer();

    private int numberOfGames = 10;
    private int numberOfPigs = 0;
    public MainForm()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
        timer.Interval = 20;
        timer.Tick += Timer_Tick;        
    }
    private void MainForm_Load(object sender, EventArgs e)
    {        
    }
    private void Timer_Tick(object? sender, EventArgs e)
    { 
        
        if (bird.IsCrossingBall(pig))
        {
            CreateNewBird();
            CreateNewPig();
            numberOfPigs++;
            shotDownPigBallCountLabel.Text = numberOfPigs.ToString();
            MouseDown += MainForm_MouseDown;
            numberOfGames--;
        }
        if (!bird.IsMoveBallable() || bird.OutSide())
        {
           CreateNewBird();
           MouseDown += MainForm_MouseDown;
           numberOfGames--;
        }
        if (numberOfGames == 0)
        {
            MessageBox.Show($"Игра окончена! Вы сбили {numberOfPigs} хрюшек."); 
            Application.Exit();
        }
    }
    private void CreateNewPig()
    {
        timer.Stop();
        if (pig != null)
        {
           pig.Stop();
           pig.Clear();
        }
        pig = new PigBall(this);
        pig.Show();
    }
    private void CreateNewBird()
    {
        timer.Stop();
        if (bird != null)
        {
            bird.Stop();
            bird.Clear();
        }
        bird = new BirdBall(this);
        bird.Show();
    }
    public void MainForm_MouseDown(object sender, MouseEventArgs e)
    {        
        bird.SetVelocity(e.X, e.Y);
        timer.Start();
        bird.Start();
        MouseDown -= MainForm_MouseDown;
    }   
    private void MainForm_Shown(object sender, EventArgs e)
    {
        CreateNewBird();
        CreateNewPig();
    }
}

    

