using System;

public class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    public string StudentName
    {
        get { return _studentName; }
        set { _studentName = value; }
    }
    public string Topic
    {
        get { return _topic; }
        set { _topic = value; }
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return($"{_studentName} - {_topic}");
    }
}