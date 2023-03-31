namespace rabota2._2;

public class Student
{
    public string Name;
    public DateTime DateOfBirth;
    public int GroupNumber;
    public int[] Grades;

  public void ChangeName(string newName)
  {
    Name = newName;
  }
  public void ChangeDateOfBirth(DateTime newDateOfBirth)
  {
    DateOfBirth = newDateOfBirth;
  }
  public void ChangeGroupNumber(int newGroupNumber)
  {
    GroupNumber = newGroupNumber;
  }

  public void PrintInfo()
  {
Console.WriteLine($"ФИО: {Name}");
    Console.WriteLine($"Дата рождения: {DateOfBirth:d}");
    Console.WriteLine($"Номер группы: {GroupNumber}");
    Console.WriteLine($"Успеваемость: {string.Join(", ", Grades)}");
  }
}