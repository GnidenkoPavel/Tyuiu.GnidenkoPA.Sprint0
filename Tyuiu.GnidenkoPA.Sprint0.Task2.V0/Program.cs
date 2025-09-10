using System;
using Tyuiu.GnidenkoPA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GnidenkoPA.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMassage("Паша"));
            Console.ReadKey();
        }
    }
}

