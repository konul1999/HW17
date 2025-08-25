using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17.Models
{
    internal class Pair<T, U>
    {
        public T Key { get; set; }
        public U Value { get; set; }


        public Pair<T, U>[] arr { get; set; } = new Pair<T, U>[0];

        public U this[T index]
        {
            get
            {
                foreach (var pair in arr)
                {
                    if (pair.Key.Equals(index))
                    {
                        return pair.Value;
                    }
                }
                return default;
            }

        }
        public void Add(T key, U value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Key.Equals(key))
                {
                    Console.WriteLine("Key is already in dictionary");
                    return;
                }
            }

            Pair<T, U>[] newArray = new Pair<T, U>[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = new Pair<T, U>
                {
                    Key = arr[i].Key,
                    Value = arr[i].Value
                };
            }
            newArray[arr.Length] = new Pair<T, U> { Key = key, Value = value };
            arr = newArray;
        }

    }
}
