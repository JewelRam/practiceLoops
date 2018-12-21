using System;
namespace MediaTypes
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                var Book1 = new book("Harry Potter", "Person");
                var Book2 = new book("Harry Potter 2", "Person");
                var Book3 = new book("Harry Potter 3", "Person");

                DetectMediaType(Book2);


                Console.WriteLine(Book1.GetDisplayText());

                Console.WriteLine(Book2.GetDisplayText());

                Book1.Loan("Taylor");
                Book2.Loan();
                Console.WriteLine(Book1.GetDisplayText());
                Console.WriteLine(Book2.GetDisplayText());

                Book1.Return();
                Console.WriteLine(Book1.GetDisplayText());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }


        }
        static void DetectMediaType(MediaTypes item)
        {
            if (item is album)
            {
                Console.WriteLine(item.Title + " is An Album");
            }
            else if (item is book)
            {
                Console.WriteLine(item.Title + " is a Book");
            }
            else if (item is movie)
            {
                Console.WriteLine(item.Title + " is a Movie");
            }
        }
    }
}




