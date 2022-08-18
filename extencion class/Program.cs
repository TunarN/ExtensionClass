using extencion_class.models;
using System;

namespace extencion_class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Console.WriteLine(25.IsOdd());
            Console.WriteLine(25.IsEven());
            Console.WriteLine("Tunar".IsContainsDigit());
            Console.WriteLine("tUnar".ToCapitalize());
            int[] Arr = "Tunaara".GetValueIndexes('a');
            foreach (int item in Arr)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Task2
            string fullname, groupNo;
            int age;
            do
            {
                Console.Write("Fullname: ");
                fullname = Console.ReadLine();
            } while (!student.CheckFullname(fullname));

            do
            {
                Console.Write("Group No: ");
                groupNo = Console.ReadLine();
            } while (!student.CheckGroupNo(groupNo));


            do
            {
                Console.Write("age: ");
                age = Convert.ToInt32(Console.ReadLine());
            } while (age <= 0 || age > 170);

            student st = new student(fullname, groupNo, age);

            #endregion
        }
    } 
}
