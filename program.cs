using System;
namespace MediaTypes
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                MediaTypes[] items = new MediaTypes[]
                {
                     new book("Harry Potter", "Person"),
                new book("Harry Potter 2", "Person"),
                new book("Harry Potter 3", "Person")
            };


                DetectMediaType(items[0]);


                items[1].Loan("Taylor");

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
            else
            {
                throw new Exception("unexpected media type");
            }
        }
    }
}




