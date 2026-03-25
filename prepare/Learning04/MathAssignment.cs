// ++++++++++++++       Child Class MathAssignment      ++++++++++++++
// ++++++++++++   Different Kinds of Homework Assignments   ++++++++++++
// Learning 04 by - John S.


public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    // constructor - use : base()
    public MathAssignment(string studentName, string topic, 
                          string textBookSection, string problems)
        : base(studentName, topic) 
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    // method for Math assignments
    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}