// See https://aka.ms/new-console-template for more information

                                                             //задание 1(2,2)
// using System;
// using rabota2._2;
//
// class Program
// {
//   static void Main(string[] args)
//   {
//     Student student = new Student();
//
//     student.ChangeName ("Вилан Арина");
//     student.ChangeDateOfBirth (new DateTime(2000, 1, 1));
//     student.ChangeGroupNumber(1);
//     student.Grades = new int[] { 5, 4, 4, 3, 5 };
//
//     Console.WriteLine("Информация о студенте:");
//     student.PrintInfo();
//
//     student.ChangeName("Акопян Милена");
//     student.ChangeDateOfBirth(new DateTime(2001, 2, 2));
//     student.ChangeGroupNumber(4);
//     student.Grades = new int[] { 3, 3, 4, 3, 5 };
//
//     Console.WriteLine("\nОбновленная информация о студенте:");
//     student.PrintInfo();
//
//     Console.Write("\nВведите ФИО студента : ");
//     string lastName = Console.ReadLine();
//
//     Console.Write("Введите дату рождения студента (yyyy/mm/dd): ");
//     DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
//
//     if (student.Name.EndsWith(lastName) && student.DateOfBirth == dateOfBirth)
//     {
//       Console.WriteLine("\nИнформация о студенте:");
//       student.PrintInfo();
//     }
//     else
//     {
//       Console.WriteLine("\nСтудент с указанной фамилией и датой рождения не найден");
//     }
//   }
// }
                                                                  //задание 2(2,2)
// using System;   
// using System.Collections.Generic;
// using System.Text;
// using rabota2._2;
//
// namespace Rabota
// {
//
//     namespace Rabota
//     {
//         class Program
//         {
//             static void Main()
//             {
//                 Train train1 = new Train();
//
//                 train1.points = "Томск";
//                 train1.number = 101;
//                 train1.time = "09:00";
//
//                 Train train2 = new Train();
//
//                 train2.points = "Санкт-Петербург";
//                 train2.number = 102;
//                 train2.time = "12:10";
//
//                 Train train3 = new Train();
//
//                 train3.points = "Екатеренбург";
//                 train3.number = 103;
//                 train3.time = "20:25";
//
//                 Train trains = new Train();
//
//                 Console.Write("Выберите номер поезда[101, 102, 103], чтобы узнать о нем информацию - ");
//                 trains.number = int.Parse(Console.ReadLine());
//
//                 switch (trains.number)
//                 {
//                     case 101:
//                         Console.Write(
//                             $"Поезд под номером {train1.number} отправляется в {train1.points} в {train1.time}");
//                         break;
//                     case 102:
//                         Console.Write(
//                             $"Поезд под номером {train2.number} отправляется в {train2.points} в {train2.time}");
//                         break;
//                     case 103:
//                         Console.Write(
//                             $"Поезд под номером {train3.number} отправляется в {train3.points} в {train3.time}");
//                         break;
//                 }
//             }
//         }
//     }
// }
                                                                //задание 3(2,2)
// using System.Collections.Generic;
// using System.Text;
// using System.Linq;
// using System;
// using rabota2._2;
//
// class Program
// {
//     static void Main()
//     {
//         Numbers number = new Numbers(0, 0);
//         while (true)
//         {
//             Console.WriteLine("Введите число 0 чтобы закончить программу.");
//             Console.WriteLine("Введите число 1 чтобы измеить числа");
//             Console.WriteLine("Введите число 2 чтобы вывести числа");
//             Console.WriteLine("Введите число 3 чтобы найти сумму чисел");
//             Console.WriteLine("Введите число 4 чтобы найти максимальное число");
//             int num = int.Parse(Console.ReadLine());
//             switch (num)
//             {
//                 case 0:
//                     Console.WriteLine("Программа завершена");
//                     break;
//                 case 1:
//                     Console.Write("Введите Перове число: ");
//                     int nums1 = int.Parse(Console.ReadLine());
//                     Console.Write("Введите Второе число: ");
//                     int nums2 = int.Parse(Console.ReadLine());
//                     number.changOfNumbers(nums1, nums2);
//                     break;
//                 case 2:
//                     number.conclusionOfNumbers();
//                     break;
//                 case 3:
//                     Console.WriteLine($"Сумма чисел: {number.sumOfNumbers()}");
//                     break;
//                 case 4:
//                     Console.WriteLine($"Наибольшее число: {number.maxOfNumbers()}");
//                     break;
//             }
//         }   
//     }
// }



// using System;                       //задание 4 (2,2)
// using System.Collections.Generic;
// using System.Text;
// using System.Linq;
// using rabota2._2;
//
// class Program
// {
//     static void Main()
//     {
//         counter count = new counter();
//         Random rand = new Random();
//         while (true)
//         {
//             Console.WriteLine("Введите число 0, чтобы завершить работу счетсчика.");
//             Console.WriteLine("Введите число 1, чтобы уменьшить значение счетчика.");
//             Console.WriteLine("Введите число 2, чтобы увеличить значение счетчика.");
//             Console.WriteLine("Введите число 3, чтобы вывести значение счетчика.");
//             Console.WriteLine("Введите число 4, чтобы счетчик произвольное значение.");
//             Console.WriteLine("Введите номер операции: ");
//             int num = int.Parse(Console.ReadLine());
//             int number = 0;
//             switch (num)
//             {
//                 case 0:
//                     Console.WriteLine("Вы завершили работу программу.");
//                     return;
//                 case 1:
//                     count.shetchickOfLow();
//                     break;
//                 case 2:
//                     count.shetchickOfSum();
//                     break;
//                 case 3:
//                     Console.WriteLine(count.Output);
//                     break;
//                 case 4:
//                     number = rand.Next();
//                     count = new counter(number);
//                     break;
//             }
//         }
//     }
// }
                                                               //задание 5 (2,2)
// using System;  
// using System.Collections.Generic;
// using System.Text;
// using System.Linq;
// using rabota2._2;
// class Program
// {
//     static void Main()
//     {
//         NamesSurname people = new NamesSurname();
//         while (true)
//         {
//             Console.WriteLine("Введите число 0, чтобы завершить работу программы.");
//             Console.WriteLine("Введите число 1, чтобы ввести имя и фамилию");
//             Console.WriteLine("Введите число 2, чтобы показать данные");
//             Console.Write("Введите номер операции: ");
//             int num = int.Parse(Console.ReadLine());
//             switch (num)
//             {
//                 case 0:
//                     Console.WriteLine("Вы завершили программу");
//                     return;
//                 case 1:
//                     Console.Write("Введите Имя: ");
//                     String name1 = Console.ReadLine();
//                     Console.Write("Введите Фамилию: ");
//                     String name2 = Console.ReadLine();
//                     people = new NamesSurname(name1, name2);
//                     break;
//                 case 2:
//                     Console.WriteLine(people.name);
//                     Console.WriteLine(people.surname);
//                     break;
//             }
//         }
//     }
// }





                             


  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  





