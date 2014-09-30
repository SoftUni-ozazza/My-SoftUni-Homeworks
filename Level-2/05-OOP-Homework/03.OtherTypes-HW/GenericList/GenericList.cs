using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GenericList<T> where T : IComparable<T>
{
    const int DefaultCapacity = 16;

    private T[] elements;
    private int count = 0;

    public GenericList(int capacity = DefaultCapacity)
    {
        elements = new T[capacity];
    }

    public int Count
    {
        get
        {
            return this.count;
        }
    }
    public int Capacity
    {
        get
        {
            return this.elements.Length;
        }
    }

    public void Add(T element)
    {
        //if (this.Count >= this.Capacity)
        //{
        //    throw new IndexOutOfRangeException(String.Format("The capacity of {0} /was/ exceeded.", elements.Length));
        //}
        if (count >= this.Capacity)
        {
            Expand();
        }
        this.elements[this.Count] = element;
        count++;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException(String.Format("Invalid index. Index {0} out of range.", index));
            }
            T result = elements[index];
            return result;
        }
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(String.Format("Invalid index. Index {0} out of range.", index));
        }

        for (int i = index; i < this.Count - 1; i++)
        {
            elements[i] = elements[i + 1];
        }
        count--;
        elements[count] = default(T);
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(String.Format("Invalid index. Index {0} out of range.", index));
        }

        if (count >= this.Capacity)
        {
            Expand();
        }

        for (int i = this.Count; i > index; i--)
        {
            this.elements[i] = this.elements[i - 1];
        }
        count++;
        this.elements[index] = element;
    }

    public void Clear()
    {
        count = 0;
        this.elements = new T[this.Capacity];
    }

    public int FindIndexOf(T element)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (this.elements[i].Equals(element))
            {
                return i;
            }
        }
        return -1;
    }

    public bool Contains(T element)
    {
        for (int i = 0; i < this.count; i++)
        {
            if (this.elements[i].CompareTo(element) > 0)
            {
                return true;
            }
        }
        return false;
    }

    public T Min()
    {
        T resultMin = this.elements[0];
        for (int i = 1; i < this.Count; i++)
        {
            if (this.elements[i].CompareTo(resultMin) < 0)
            {
                resultMin = this.elements[i];
            }
        }
        return resultMin;
    }

    public T Max()
    {
        T resultMax = this.elements[0];
        for (int i = 1; i < this.Count; i++)
        {
            if (this.elements[i].CompareTo(resultMax) > 0)
            {
                resultMax = this.elements[i];
            }
        }
        return resultMax;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < this.Count; i++)
        {
            if (i == this.Count - 1)
            {
                result.Append(this.elements[i]);
            }
            else
            {
                result.Append(this.elements[i] + ", ");
            }
        }
        return result.ToString();
    }

    private void Expand()
    {
        T[] expandArray = new T[this.Capacity * 2];
        Array.Copy(elements, expandArray, this.Capacity);
        this.elements = expandArray;
    }

}