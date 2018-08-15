class Student
{
    string studentId;
    string studentName;
    decimal math;
    decimal english;
    decimal biology;

    public Student(string studentId, string studentName, decimal math, decimal english, decimal biology)
    {
        StudentId = studentId;
        StudentName = studentName;
        Math = math;
        English = english;
        Biology = biology;
    }

    public string StudentId
    {
        get
        {
            return studentId;
        }
        set
        {
            studentId = value;
        }
    }

    public string StudentName
    {
        get
        {
            return studentName;
        }
        set
        {
            studentName = value;
        }
    }

    public decimal Math
    {
        get
        {
            return math;
        }
        set
        {
            if (value > 0.0m)
            {
                if (value < 51m)
                {
                    math = value;
                }
            }
        }
    }

    public decimal English
    {
        get
        {
            return english;
        }
        set
        {
            if (value > 0.0m)
            {
                if (value < 51m)
                {
                    english = value;
                }
            }
        }
    }

    public decimal Biology
    {
        get
        {
            return biology;
        }
        set
        {
            if (value > 0.0m)
            {
                if (value < 51m)
                {
                    biology = value;
                }
            }
        }
    }

    public decimal GetAggregate(decimal math, decimal english, decimal biology)
    {
        decimal Aggregated = math + english + biology;
        return Aggregated;
    }

    public decimal GetPercentage(decimal math, decimal english, decimal biology)
    {
        decimal Percentage = (GetAggregate(math, english, biology) / 50) * 100;
        return Percentage;
    }
}
