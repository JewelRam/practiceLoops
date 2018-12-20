using System;
namespace MediaTypes
{
    class program
    {
        static void Main(string[] args)
        {


            var Book1 = new book("Harry Potter", "Person");
            var Book2 = new book("Harry Potter 2", "Person");
            var Book3 = new book("Harry Potter 3", "Person");




            Console.WriteLine(Book1.GetDisplayText());

            Console.WriteLine(Book2.GetDisplayText());

            Book1.Loan("Taylor");
            Book2.Loan();
            Console.WriteLine(Book1.GetDisplayText());
                        Console.WriteLine(Book2.GetDisplayText());

            Book1.Return();
            Console.WriteLine(Book1.GetDisplayText());

        }
    }

}