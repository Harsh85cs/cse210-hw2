using System;

public class MathAssigments: Assigments
{
    private string _textbookSection;
    private string _problems;

    public MathAssigments (string studentName, string topic, string textbookSection, string problems) : base( studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection} - {_problems}";
    }
}