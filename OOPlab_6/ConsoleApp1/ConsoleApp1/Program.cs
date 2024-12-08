using System;
using System.Text;

class TeachersWorkload
{
    private string subjectName;
    private int semester;
    private int studentsCount;
    private SemesterControlInfo semesterControl;

    public TeachersWorkload(string subjectName, int semester, int studentsCount, SemesterControlInfo semesterControl)
    {
        this.subjectName = subjectName;
        this.semester = semester;
        this.studentsCount = studentsCount;
        this.semesterControl = semesterControl;
    }

    public string SubjectName
    {
        get { return subjectName; }
    }

    public int Semester
    {
        get { return semester; }
    }

    public int StudentsCount
    {
        get { return studentsCount; }
    }

    public SemesterControlInfo SemesterControl
    {
        get { return semesterControl; }
    }
}

class SemesterControlInfo
{
    private string controlForm;
    private string scale;
    private DateTime examinationDate;
    private DateTime resultsFillingDate;
    private double hours;

    public SemesterControlInfo(string controlForm, string scale, DateTime examinationDate, DateTime resultsFillingDate, double hours)
    {
        this.controlForm = controlForm;
        this.scale = scale;
        this.examinationDate = examinationDate;
        this.resultsFillingDate = resultsFillingDate;
        this.hours = hours;
    }

    public string ControlForm
    {
        get { return controlForm; }
    }

    public string Scale
    {
        get { return scale; }
    }

    public DateTime ExaminationDate
    {
        get { return examinationDate; }
    }

    public DateTime ResultsFillingDate
    {
        get { return resultsFillingDate; }
    }

    public double Hours
    {
        get { return hours; }
    }

    public double GetTotalTime(int studentsCount)
    {
        return hours * studentsCount;
    }

    public bool IsHappeningToday()
    {
        return examinationDate.Date == resultsFillingDate.Date;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;  

        SemesterControlInfo examInfo = new SemesterControlInfo("Екзамен", "5-бальна", new DateTime(2024, 12, 8), new DateTime(2024, 12, 8), 2.0);

        TeachersWorkload workload = new TeachersWorkload("Математика", 1, 25, examInfo);

        Console.WriteLine($"Сумарний час на екзамен: {examInfo.GetTotalTime(workload.StudentsCount)} годин");
        Console.WriteLine($"Відбувається сьогодні: {examInfo.IsHappeningToday()}");
    }
}
