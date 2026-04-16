using System;

public class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName() => _shortName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    public virtual void RecordEvent() { }
    public virtual bool IsComplete() => false;
    public virtual string GetDetailsString() => $"[ ] {_shortName} ({_description})";
    public virtual string GetStringRepresentation() => $"{_shortName},{_description},{_points}";
}
