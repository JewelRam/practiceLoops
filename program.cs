using System;
namespace MediaTypes
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                MediaTypes[] items =
                {
                     new book("Harry Potter", "Person"),
                new book("Harry Potter 2", "Person"),
                new book("Harry Potter 3", "Person"),
                                new album("Paint It Black", "Rolling Stones")

            };


                DetectMediaType(items[0]);
                DetectMediaType(items[1]);
                Display(items[1]);

                items[1].Loan("Taylor");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }


        }

        static void Display(MediaTypes item)
        {
            if (item is album)
            {

                Console.WriteLine(((album)item).GetDisplayText());
            }
            else if (item is book)
            {
                Console.WriteLine(((book)item).GetDisplayText());


            }
            else if (item is movie)
            {
                Console.WriteLine(((movie)item).GetDisplayText());

            }
            else
            {
                throw new Exception("unexpected media type");
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
            else
            {
                throw new Exception("unexpected media type");
            }
        }
    }
}




