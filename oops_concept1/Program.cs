public class students
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
}
public class test
{
    public static void Main(String[] args)
    {
        students newstudents = new students();
        newstudents.StudentId = 1;
        newstudents.StudentName = "Sajal";
        Console.WriteLine("id " + newstudents.StudentId);
        Console.WriteLine("name " + newstudents.StudentName);

    }
}
