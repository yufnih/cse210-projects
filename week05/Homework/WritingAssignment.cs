public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string title, string studentName, string topic) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic}\n{_title}";
    }
}