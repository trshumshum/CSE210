// ++++++++++++++       Parent Class Assignment      ++++++++++++++
// ++++++++++++   Different Kinds of Homework Assignments   ++++++++++++
// Learning 04 by - John S.

public class Assignment
{
    protected string _studentName; //used protected instead of private so I can reference in child class
    protected string _topic; //used protected instead of private so I can reference in child class

    // Constructor requiring 2 strings
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method that will be used by either MathAssignments or WritingAssignments
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}