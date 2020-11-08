using System;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management");
            LinqToDataTable linqToDataTable = new LinqToDataTable();
            linqToDataTable.AddDataTable();
        }
    }
}
