// ++++++++++++++       Child Class WritingAssignment     ++++++++++++++
// ++++++++++++   Different Kinds of Homework Assignments   ++++++++++++
// Learning 04 by - John S.

public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor -  use : base()
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // method for Writing assignments
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}