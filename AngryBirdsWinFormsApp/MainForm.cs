using System;
using System.Windows.Forms;

namespace AngryBirdsWinFormsApp;

public partial class MainForm : Form
{
    private BirdBall _bird { get; set; }
    private PigBall _pig { get; set; }

    Timer timer = new Timer();

    private int _numberOfGames = 10;
    private int _numberOfPigs = 0;

    public MainForm() : base()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
        timer.Interval = 20;
        timer.Tick += Timer_Tick;
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {

        if (_bird.IsCrossingBall(_pig))
        {
            CreateNewBird();
            CreateNewPig();

            _numberOfPigs++;
            shotDownPigBallCountLabel.Text = _numberOfPigs.ToString();
            _numberOfGames--;
        }

        if (!_bird.IsMoveBallable() || _bird.OutSide())
        {
            CreateNewBird();
            _numberOfGames--;
        }

        if (_numberOfGames == 0)
        {
            MessageBox.Show($"Игра окончена! Вы сбили {_numberOfPigs} хрюшек.");
            Application.Exit();
        }
    }

    private void CreateNewPig()
    {
        timer.Stop();
        if (_pig != null)
        {
            _pig.Stop();
            _pig.Clear();
        }
        _pig = new PigBall(this);
        _pig.Show();
    }

    private void CreateNewBird()
    {
        timer.Stop();
        if (_bird != null)
        {
            _bird.Stop();
            _bird.Clear();
        }

        _bird = new BirdBall(this);
        _bird.Show();
    }

    public void MainForm_MouseDown(object sender, MouseEventArgs e)
    {
        _bird.SetVelocity(e.X, e.Y);
        timer.Start();
        _bird.Start();
    }

    private void MainForm_Shown(object sender, EventArgs e)
    {
        CreateNewBird();
        CreateNewPig();
    }
}



