using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common;
public class Ball
{
    public Timer timer = new Timer();

    public float CenterX { get; set; }
    public float CenterY { get; set; }
    public int Radius { get; set; }
    public Brush Brush { get; set; }

    protected Brush choiceColor;
    protected float vx { get; set; }
    protected float vy { get; set; }
    protected Rectangle rectangle = new Rectangle();
    protected Random random = new Random();
    protected Form game = new Form();


    public Ball(Form game)
    {
        choiceColor = random.Next(1, 10) == 1 ?
        Brush = Brushes.Black : random.Next(1, 10) == 1 ? Brush = Brushes.Yellow :
        Brush = new SolidBrush(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));

        this.game = game;
        timer = new Timer();
        timer.Interval = 80;
        timer.Tick += Timer_Tick;
        timer.Start();
    }
    public Ball(Form game, Brush brush)
    {
        this.Brush = brush;
        this.game = game;
    }

    protected virtual void Timer_Tick(object? sender, EventArgs e)
    {
        MoveBall();
    }

    public void Draw(Brush brush)
    {
        var graphiscs = game.CreateGraphics();
        var rectangle = new RectangleF(CenterX - Radius, CenterY - Radius, 2 * Radius, 2 * Radius);
        graphiscs.FillEllipse(brush, rectangle);
    }

    public void Show()
    {
        Draw(Brush);
    }

    public void Clear()
    {
        var brush = Brushes.LightGray;
        Draw(brush);
    }

    public void MoveBall()
    {
        Clear();
        Go();
        Show();
    }

    public bool IsMoveBallable()
    {
        return timer.Enabled;
    }

    public bool IsCrossingBall(Ball other)
    {
        var dx = CenterX - other.CenterX;
        var dy = CenterY - other.CenterY;
        return dx * dx + dy * dy <= (Radius + other.Radius) * (Radius + other.Radius);
    }

    public bool Contains(int x, int y)
    {
        var dx = x - CenterX;
        var dy = y - CenterY;
        return dx * dx + dy * dy <= Radius * Radius;
    }

    //public bool OnForm()
    //{
    //    return CenterX >= LeftSide() && CenterX < RightSide() && CenterY >= TopSide() && CenterY <= DownSide();
    //}

    protected virtual void Go()
    {
        CenterX += vx;
        CenterY += vy;
    }

    public void Start()
    {
        timer.Start();
    }

    public void Stop()
    {
        timer.Stop();
    }

    public int LeftSide()
    {
        return Radius;
    }

    public int RightSide()
    {
        return game.ClientSize.Width - Radius;
    }

    public int TopSide()
    {
        return Radius;
    }

    public int DownSide()
    {
        return game.ClientSize.Height - Radius;
    }

    public bool LeftOfCenter()
    {
        return CenterX + 2 * Radius < game.ClientSize.Width / 2;
    }

    public bool RightOfCenter()
    {
        return CenterX - 2 * Radius > game.ClientSize.Width / 2;
    }

    public Brush GetBrush()
    {
        return Brush;
    }
}
