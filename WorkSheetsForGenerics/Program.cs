using System;
using System.Collections.Generic;

namespace WorkSheetsForGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> plakalar1 = new List<string>();
            plakalar1.Add("01-Adana");

            MaList<string> plakalar2 = new MaList<string>();
            plakalar2.Add("02-Adıyaman");
            Console.WriteLine(plakalar2.Count);
            plakalar2.List();




        }

        class MaList<T> 
        {
            T[] _array;
            T[] _tempArray;
            public MaList()
            {
                _array=new T[0];
            }
            public void Add(T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];

                }
                _array[_array.Length - 1] = item;

                
            }
            

            public int Count
            {
                get { return _array.Length; }
                
            }
            public void List()
            {
                foreach (T item in _array)
                {
                    Console.WriteLine(item);
                }
                
            }

        }
    }
}
