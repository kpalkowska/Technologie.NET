using System;
using System.Collections.Generic;
using System.Text;


namespace KolejkaFIFO
{
    public class Queue
    {
        private string[] Kolejka;
        private int first;
        private int last;

        public void Create(int liczbaElementow)
        {
            first = last = -1;
            Kolejka = new string[liczbaElementow];
        }

        public bool IsFull()
        {
            return ((first == 0 && last == Kolejka.Length - 1) || first == last + 1);
        }

        public void Enqueue(string os)
        {
            if (IsFull())
                throw new InvalidOperationException("Kolejka jest pe³na");
            if (last == Kolejka.Length - 1 || last == -1)
            {
                Kolejka[0] = os;
                last = 0;
                if (first == -1)
                    first = 0;
            }
            else
                Kolejka[++last] = os;
        }

        public bool IsEmpty()
        {
            return first == -1;
        }

        public string Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Kolejka jest pusta");
            string tmp;
            tmp = Kolejka[first];
            if (first == last)
                last = first = -1;
            else
                if (first == Kolejka.Length - 1)
                    first = 0;
                else
                    first++;
            return tmp;
        }

        public void Clear()
        {
            Create(Kolejka.Length);
        }

        public string Peek(Queue q)
        {
            if (IsEmpty())
                throw new InvalidOperationException("Kolejka jest pusta");
            return q.Kolejka[first];
        }

        public int GetLength()
        {
            if (first == -1)
                return 0;
            if (first <= last)
                return last - first + 1;
            return Kolejka.Length - first + last + 1;
        }
    }
}
