// make this using  to use enum WeekDays that is in another folder 
using Session_6_Assignment.Enums.Q1;
// make this using to use enum Season that is in another folder 
using Session_6_Assignment.Enums.Q3;
// make this using to use enum Permission that is in another folder 
using Session_6_Assignment.Enums.Q4_PermissionEnum;
// make this using to use enum Color that is in another folder 
using Session_6_Assignment.Enums.Q5;
// make this using to use struct Person that is in another folder 
using Session_6_Assignment.Struct.Q2;
// make this using to use struct Point that is in another folder
using Session_6_Assignment.Struct.Q6;
using System.ComponentModel;

namespace Session_6_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (WeekDays weekdays in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(weekdays);
            //}
            //or
            //WeekDays[] weekdays = [WeekDays.Sunday, WeekDays.Monday, WeekDays.Tuesday, 
            //                       WeekDays.Wednesday, WeekDays.Thursday, WeekDays.Friday, 
            //                       WeekDays.Saturday];
            //for(int i = 0; i < weekdays.Length; i++)
            //{
            //    Console.WriteLine(weekdays[i]);
            //}
            #endregion

            #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] people = new Person[3];
            //bool IsParsed;
            //for (int i = 0; i < people.Length; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter name of Person {i + 1} : ");
            //        people[i].Name = Console.ReadLine();
            //    }
            //    while (people[i].Name == "");

            //    Console.WriteLine();

            //    do
            //    {
            //        Console.WriteLine($"Enter age of {people[i].Name} : ");
            //        IsParsed = int.TryParse(Console.ReadLine(), out people[i].Age);
            //    }
            //    while (!IsParsed);
            //}
            //Console.Clear();
            //Console.WriteLine("Person's Detalis : \n");
            //for(int i = 0;i < people.Length;i++)
            //{
            //    Console.WriteLine($"Name is : {people[i].Name} , Age is : {people[i].Age}");
            //}
            #endregion

            #region 3.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Season season;
            //bool IsParsed;
            //do
            //{
            //    Console.WriteLine("Enter Season Name [Spring, Summer, Autumn, Winter]");
            //    IsParsed = Enum.TryParse<Season>(Console.ReadLine(), true ,out season);

            //}
            //while (!IsParsed);
            //if (season == Season.Spring)
            //{
            //    System.Console.WriteLine("March to May");
            //}
            //else if (season == Season.Summer)
            //{
            //    System.Console.WriteLine("June to August");
            //}
            //else if (season == Season.Autumn)
            //{
            //    System.Console.WriteLine("September to November");
            //}
            //else if (season == Season.Winter)
            //{
            //    System.Console.WriteLine("December to February");
            //}
            #endregion

            #region 4.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. --> ⮚	Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            //Permission MyPermission = Permission.Write | Permission.Read;
            //// Add Delete
            //MyPermission |= Permission.Delete;
            //// Remove Write
            //MyPermission &= ~Permission.Write; // --> like --> ^ Xor

            //if((MyPermission & Permission.Execute) == Permission.Execute)
            //{
            //    Console.WriteLine("Permission Execute is Exist");
            //}
            //else
            //{
            //    Console.WriteLine("Permission Execute added");
            //    MyPermission |= Permission.Execute;
            //}
            //Console.WriteLine(MyPermission);

            #endregion

            #region 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Color colors;
            //bool IsParsed;


            //    Console.WriteLine("Enter a Color  [Red, Green , Blue]");
            //    IsParsed = Enum.TryParse<Color>(Console.ReadLine(), true, out colors);




            //    if (colors == Color.Red || colors == Color.Green || colors == Color.Blue)
            //    {
            //        Console.WriteLine($"{colors} is a Primary Color");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{colors} is not a Primary Color");
            //    }



            #endregion

            #region 6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Point P1, P2;
            //bool IsParsed;
            //do
            //{
            //    Console.WriteLine("Enter Point 1 in direction X : \n");
            //    IsParsed = int.TryParse(Console.ReadLine(), out P1.X);
            //}
            //while (!IsParsed);
            //Console.WriteLine();
            //do
            //{
            //    Console.WriteLine("Enter Point 1 in direction Y : \n");
            //    IsParsed = int.TryParse(Console.ReadLine(), out P1.Y);
            //}
            //while (!IsParsed);
            //Console.WriteLine();
            //do
            //{
            //    Console.WriteLine("Enter Point 2 in direction X : \n");
            //    IsParsed = int.TryParse(Console.ReadLine(), out P2.X);
            //}
            //while (!IsParsed);
            //Console.WriteLine();
            //do
            //{
            //    Console.WriteLine("Enter Point 2 in direction Y : \n");
            //    IsParsed = int.TryParse(Console.ReadLine(), out P2.Y);
            //}
            //while (!IsParsed);
            //Console.WriteLine();

            //int dx = P2.X - P1.X;
            //int dy = P2.Y - P1.Y;

            //int SumSq = dx * dx + dy * dy;
            //double Guess = SumSq / 2.0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Guess = (Guess + (SumSq / Guess)) / 2.0;
            //}
            //Console.WriteLine($"Distance : {Guess}");
            #endregion

            #region 7.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] people = new Person[3];
            //bool IsParsed;
            //for (int i = 0; i < people.Length; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter name of Person {i + 1} : ");
            //        people[i].Name = Console.ReadLine();
            //    }
            //    while (people[i].Name == "");

            //    Console.WriteLine();

            //    do
            //    {
            //        Console.WriteLine($"Enter age of {people[i].Name} : ");
            //        IsParsed = int.TryParse(Console.ReadLine(), out people[i].Age);
            //    }
            //    while (!IsParsed);
            //}
            //Console.Clear();
            //Console.WriteLine("Person's Detalis : \n");
            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"Name is : {people[i].Name} , Age is : {people[i].Age}");
            //}
            //Console.WriteLine();
            //int MaxAge = people[0].Age;
            //int index = 0;

            //for (int i = 0;i < people.Length;i++)
            //{
            //    if (people[i].Age > MaxAge)
            //    {
            //        MaxAge = people[i].Age;
            //        index = i;
            //    }
            //}
            //Console.WriteLine($"Oldest Person is : {people[index].Name} , His Age is : {people[index].Age}");
            #endregion

        }
    }
}
