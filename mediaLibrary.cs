using System;
namespace MediaTypes
{
    class mediaLibrary    {

private MediaTypes[] _items;

public mediaLibrary(MediaTypes[] items)
{
    _items = items;
}
public MediaTypes GetItemAt(int index)
{
return _items[index];
}

    }
}