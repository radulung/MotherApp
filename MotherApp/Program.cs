using Submodule1;
using Submodule2;
using System;

namespace MotherApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AddOperation add = new AddOperation();
            var addResult = add.Execute(2, 5);

            SubstractOperation subsctract = new SubstractOperation();
            var substractResult = subsctract.Execute(5, 2);

            Console.WriteLine($"Add result: {addResult}");
            Console.WriteLine($"Substract result: {substractResult}");
            Console.ReadKey();
        }
    }
}
