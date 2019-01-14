using System;
namespace MediaTypes
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                var mediaLibrary = new mediaLibrary(new MediaTypes[]{
               new book("Harry Potter", "Person"),
                new book("Harry Potter 2", "Person"),
                new book("Harry Potter 3", "Person"),
                new album("Paint It Black", "Rolling Stones"),
                                new album("something", "Rush")

});

mediaLibrary.DisplayItems();

                DetectMediaType(mediaLibrary.GetItemAt(1));
                DetectMediaType(mediaLibrary.GetItemAt(0));
                DetectMediaType(mediaLibrary.GetItemAt(2));



            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }


        }

        static void DetectMediaType(MediaTypes item)
        {
            if (item == null)
            {
                return;
            }

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




