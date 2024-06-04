// using System;

// public class Person
// {
//     private string _title;
//     private string _firstName;
//     private string _lastName;

//     public Person()
//     {
//         _title = "";
//         _firstName = "Anonymous";
//         _lastName = "Unknown";
//     }

//     public Person(string first, string last)
//     {
//         _title = "";
//         _firstName = first;
//         _lastName = last;
//     }

//     public Person(string title, string first, string last)
//     {
//         _title = title;
//         _firstName = first;
//         _lastName = last;
//     }

//     public string Getfullname()
//     {
//         return $"{_title} {_firstName} {_lastName}";
//     }


//     public static void Main()
//     {
//         Person p1 = new Person(); // Don't pass any information to get the default values
//         Person p2 = new Person("Jane", "Doe"); // pass the first and last names
//         Person p3 = new Person("Mrs.", "Jane", "Doe"); // pass all three variables

//         Console.WriteLine($"{p1.Getfullname()}, {p2.Getfullname()}, {p3.Getfullname()}");

//     }
// }
