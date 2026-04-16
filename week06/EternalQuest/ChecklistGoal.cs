public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
            _amountCompleted++;
    }

    public int GetBonusPoints()
    {
        return (_amountCompleted == _target) ? _bonus : 0;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string box = IsComplete() ? "[X]" : "[ ]";
        return $"{box} {GetName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{base.GetStringRepresentation()},{_target},{_bonus},{_amountCompleted}";
    }
}
