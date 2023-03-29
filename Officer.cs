class Officer
{
    private string name;
    private string surname;
    private int officerID;
    private string workingDistrict;
    private int crimeSolved;

    public Officer()
    {

    }

    public Officer(string name, string surname, int officerID, string workingDistrict, int crimeSolved)
    {
        this.name = name;
        this.surname = surname;
        this.officerID = officerID;
        this.workingDistrict = workingDistrict;
        this.crimeSolved = crimeSolved;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Surname
    {
        get { return this.surname; }
        set { this.surname = value; }
    }

    public int OfficerID
    {
        get { return this.officerID; }
        set { this.officerID = value; }
    }

    public string  WorkingDistrict
    {
        get { return this.workingDistrict; }
        set { this.workingDistrict = value; }
    }

    public int CrimeSolved
    {
        get { return this.crimeSolved; }
        set { this.crimeSolved = value; }
    }

    public override string ToString()
    {
        return $"name: {this.name}, surname: {this.surname}, officerID: {this.officerID}, workingDistrict: {this.workingDistrict}, crimesSolved: {this.crimeSolved} ";
    }

    public int CalculateLevel(int crimeSolved)
    {
        if (crimeSolved < 20)
        {
            return 1;
        }
        else if (crimeSolved > 20 && crimeSolved < 40)
        {
            return 2;
        }
        else
        {
            return 3;
        }
    }
}