public class WrittingAssignments : Assignment
{
    private string _title;

    public WrittingAssignments(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWrittingInfo()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}