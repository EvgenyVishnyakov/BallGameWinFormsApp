namespace Ball.Common;

public class MoveBall : RandomBall
{
    public Timer timer;
    private GameForm gameForm= new GameForm();
    public MoveBall(GameForm gameForm) : base(gameForm)
    {
        vx = random.Next(-10, 15);
        vy = random.Next(-10, 16);
        size = random.Next(45, 60);
        timer = new Timer();
        timer.Interval = 80;
        timer.Tick += Timer_Tick;
        this.gameForm = gameForm;
    }
    public bool IsMoveBallable()
    {
        return timer.Enabled;
    }
    private void Timer_Tick(object? sender, EventArgs e)
    {

        MoveBall();
        if (positionX + size < 0 || positionY + size < 0 && positionX > gameForm.ClientSize.Width || positionY > gameForm.ClientSize.Height)
        {
            timer.Dispose();
        }
    }
    public void Start()
    {
        timer.Start();
    }
    public void Stop()
    {
        timer.Stop();
    }
}
