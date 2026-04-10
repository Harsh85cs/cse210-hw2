using System;

public class WritingAssigment : Assigments
{
    private string _title;

    public WritingAssigment (string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWrittingInformation()
    {
        return  _title;
    }
}