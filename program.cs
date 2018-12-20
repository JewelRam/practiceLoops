using System;
namespace MediaTypes
{
    class program
    {
static void Main(string[] args)
{
    var Album = new album();
    Album.Title = "Yellow Submarine";
    Album.Artist = "The Beatles";

    var Book = new book();
    Book.Title = "Harry Potter";
    Book.Author = "Person";

    var Movie = new movie();
    Movie.Title = "Alien";
    Movie.Genre = "SciFi";

    Console.WriteLine("Movie we added:"+ Movie.Title);
}
    }
    
}