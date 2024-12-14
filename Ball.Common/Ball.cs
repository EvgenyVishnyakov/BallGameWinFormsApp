using System;
using System.Drawing;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace Balls.Common;
public class Ball
{
    public Timer timer = new Timer();
    protected Rectangle rectangle = new Rectangle();
    protected Random random = new Random();
    protected Form game = new Form();
    public Brush brush;

    protected Brush choiceColor;
    protected float vx;
    protected float vy;

    public float centerX;
    public float centerY;
    public int radius;
    
    public Ball(Form game)
    {
        choiceColor = random.Next(1, 10) == 1 ? 
        brush = Brushes.Black : random.Next(1, 10) == 1 ? brush = Brushes.Yellow :
        brush = new SolidBrush(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));        
        this.game = game;
        timer = new Timer();
        timer.Interval = 80;
        timer.Tick += Timer_Tick;
        timer.Start();       
    }
    public Ball(Form game,Brush brush)
    {
        this.brush = brush;
        this.game = game;             
    }
      
    protected virtual void Timer_Tick(object? sender, EventArgs e)
    {
        MoveBall();
    }
    public void Draw(Brush brush)
    {
        var graphiscs = game.CreateGraphics();
        var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
        graphiscs.FillEllipse(brush, rectangle);
    }
    public void Show()
    {
        Draw(brush);
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
        var dx = centerX - other.centerX;
        var dy = centerY - other.centerY;
        return dx * dx + dy * dy  <= (radius + other.radius) * (radius + other.radius);
    }
    public bool Contains(int x, int y)
    {
        var dx = x - centerX;
        var dy = y - centerY;
        return dx * dx + dy * dy <= radius * radius;
    }
    public bool OnForm()
    {
        return centerX >= LeftSide() && centerX < RightSide() && centerY >= TopSide() && centerY <= DownSide();
    }
    protected virtual void Go()
    {
        centerX += vx;
        centerY += vy;
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
        return radius;
    }
    public int RightSide()
    {
        return game.ClientSize.Width - radius;
    }
    public int TopSide()
    {
        return radius;
    }
    public int DownSide()
    {
        return game.ClientSize.Height - radius;
    }
    public bool LeftOfCenter()
    {
        return centerX + 2 * radius < game.ClientSize.Width / 2;
    }
    public bool RightOfCenter()
    {
        return centerX - 2 * radius > game.ClientSize.Width / 2;
    }
    public Brush GetBrush()
    {
        return brush;
    }      
}
