using System;
using System.Collections.Generic;

namespace Algorithms.Heap
{
    public class MinHeap
    {
        private List<int> _list;

        public int Count
        {
            get
            {
                return _list.Count;
            }
        }
        public MinHeap()
        {
            _list = new List<int>();
        }
        public MinHeap(int capacity)
        {
            _list = new List<int>(capacity);
        }

        public int Left(int i)
        {
            return (2 * i) + 1;
        }

        public int Right(int i)
        {
            return (2 * i) + 2;
        }

        public int Parent(int i)
        {
            return Convert.ToInt32(Math.Floor((i - 1) / 2.0));
        }

        public void Insert(int num)
        {
            _list.Add(num);
            int curInd = _list.Count - 1;
            int parInd = Parent(curInd);
            while (curInd != 0 && _list[curInd] < _list[parInd])
            {
                Swap(curInd, parInd);
                curInd = parInd;
                parInd = Parent(curInd);
            }
        }

        public int ExtractMin()
        {
            if (_list.Count == 0)
                return int.MaxValue;
            int min = _list[0];
            if (_list.Count == 1)
                return min;
            Swap(0, _list.Count - 1);
            _list.RemoveAt(_list.Count - 1);
            MinHeapify(0);
            return min;
        }
        public void MinHeapify(int ind)
        {
            int lInd = Left(ind);
            int rInd = Right(ind);
            int sInd = FindSmallestIndex(ind, lInd, rInd);
            if (sInd == ind)
                return;
            Swap(ind, sInd);
            MinHeapify(sInd);
        }

        private void Swap(int ind, int sInd)
        {
            int temp = _list[ind];
            _list[ind] = _list[sInd];
            _list[sInd] = temp;
        }

        private int FindSmallestIndex(int ind, int lInd, int rInd)
        {
            int minInd = ind;
            int min = _list[ind];
            if (lInd < _list.Count && _list[lInd] < min)
            {
                min = _list[lInd];
                minInd = lInd;
            }
            if (rInd < _list.Count && _list[rInd] < min)
            {
                min = _list[rInd];
                minInd = rInd;
            }
            return minInd;
        }
    }
}
