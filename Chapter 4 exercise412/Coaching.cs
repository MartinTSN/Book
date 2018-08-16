class Coaching
{
    private string coachingType;
    private int players;
    private string classTimings;
    private decimal charges;

    public Coaching(string coachingType, int players, string classTimings, decimal charges)
    {
        CoachingType = coachingType;
        Players = players;
        ClassTimings = classTimings;
        Charges = charges;
    }

    public string CoachingType
    {
        get
        {
            return coachingType;
        }
        set
        {
            coachingType = value;
        }
    }

    public int Players
    {
        get
        {
            return players;
        }
        set
        {
            players = value;
        }
    }
    public string ClassTimings
    {
        get
        {
            return classTimings;
        }
        set
        {
            classTimings = value;
        }
    }
    public decimal Charges
    {
        get
        {
            return charges;
        }
        set
        {
            charges = value;
        }
    }

    public string DisplayDetails()
    {
        return $"CoachingType: \t Players: \t ClassTimings: \t Charges: " +
            $"\n{CoachingType} \t\t {Players} \t\t {ClassTimings} \t\t {Charges:C}";
    }
}