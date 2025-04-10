using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core;
public class Backpack<T> : IEnumerable<T>
{
    T[] items;

    public int Count { get; private set; }

    public Backpack()
    {
        items = new T[2];
    }

    public void Add(T item)
    {
        if (Count == items.Length)
            Array.Resize(ref items, Count * 2);

        items[Count++] = item;
    }

    public void Clear()
    {
        items = new T[2];
        Count = 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
            yield return items[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
