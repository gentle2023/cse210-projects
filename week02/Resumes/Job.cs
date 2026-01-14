public class Job
{

    public string _jobTitle = "Chemical Engineer";
    public string _company = "Tech Solutions Inc";
    public int _startYear = 2023;
    public int _endYear = 2024;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }


}