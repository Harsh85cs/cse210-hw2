public class Cycling : Activity
{
    private double _speed; // mph

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    // Distance = speed * (minutes / 60)
    public override double GetDistance() => _speed * (GetMinutes() / 60.0);

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}
