using System;
namespace MediaTypes
{
    class mediaLibrary
    {

        private MediaTypes[] _items;

        public mediaLibrary(MediaTypes[] items)
        {
            _items = items;
        }

        public MediaTypes findItem(string criteria)
        {
            MediaTypes ItemToReturn = null;

            foreach (var item in _items)
            {
                if (item.Title.Contains(criteria))
                {
                    ItemToReturn = item;
                    break;
                }
            }

            return ItemToReturn;
        }
        public void DisplayItems()
        {
            for (int index = 0; index < _items.Length; index++)
            {
                DisplayItem(_items[index]);
            }
        }

        public static void DisplayItem(MediaTypes item)
        {
            if (item == null)
            {
                return;
            }

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
        public MediaTypes GetItemAt(int index)
        {
            if (index < _items.Length)
            {
                return _items[index];
            }
            else
            {
                Console.WriteLine("Doesn't look like " + index + "excists!!");
                return null;
            }

        }

    }
}