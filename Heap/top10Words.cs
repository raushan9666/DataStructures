using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    #region tries

    public class trienode
    {
        public char Nodekey;
        public int prefixcount;
        public bool IsWord;
        public uint frequency;
        public int indexminheap;
        public Dictionary<int, trienode> children;
    }



    public class tries
    {

        public trienode root;

        public tries()
        {
            root = new trienode() { Nodekey = ' ',indexminheap=-1 };
        }

         public void Add(ref trieMinHeap _min, string s)
        {
            trienode curr = root;
            trienode tmp = null;
            foreach (char c in s)
            {
                if (curr.children == null)
                {
                    curr.children = new Dictionary<int, trienode>();
                }
                if (!curr.children.ContainsKey(c))
                {
                    tmp = new trienode() { Nodekey = c, indexminheap = -1 };
                    curr.children.Add(c, tmp);
                }
                curr = curr.children[c];
                curr.prefixcount++;
               

            }
            curr.IsWord = true;
            curr.frequency++;
            _min.InsertInMinHeap(ref curr, s);

        }
        public uint GetFrequecyCount(string s )
         {
             trienode curr = root;
             foreach (char c in s)
             {
                 if (curr.children == null)
                     return 0;
                 if(curr.children.ContainsKey(c))
                 {
                     curr = curr.children[c];
                 }
                 else
                 {
                     return 0;
                 }
             }
             return curr.frequency;
         }
    }

    #endregion

    #region TriesMinHeap
    public class trieMinHeap
    {
        internal class node:IComparable<node>
        {
            public uint frequecy;
            public trienode root;
            public string word;


            public int CompareTo(node other)
            {
                return this.frequecy.CompareTo(other.frequecy);
            }
        }

         List<node> _list;

        public trieMinHeap()
        {
            _list = new List<node>();
        }

        public void InsertInMinHeap(ref trienode root,string word)
        {     //word is already present
             if(root.indexminheap!=-1)
             {
                 this._list[root.indexminheap].frequecy++;
                 Heapify(root.indexminheap);

             }
            //word is not present and heap is not full
            else if(_list.Count<10)
             {
                 int count = _list.Count;
                 _list.Add(new node() { word = word, frequecy = root.frequency, root = root });
                 root.indexminheap = _list.Count - 1;
                 BuildHeap();
             }
            //word is not present and heap is full
             else if(root.frequency>_list[0].frequecy)
             {
                 _list.Add(new node() { word = word, root = root, frequecy = root.frequency });
                 _list[0] = _list[_list.Count - 1];
                 _list.RemoveAt(_list.Count - 1);
                 _list[0].root.indexminheap = 0;
                 Heapify(0);
             }

        }

        public void Heapify(int index)
        {
            int l, r, min;
            l = 2 * index + 1;
            r = 2 * index + 2;
            min = index;
            if(l<_list.Count&&_list[l].CompareTo(_list[min])<0)
            {
                min = l;
            }
            if(r<_list.Count&&_list[r].CompareTo(_list[min])<0)
            {
                min = r;
            }
            if(index!=min)
            {
                _list[min].root.indexminheap = index;
                _list[index].root.indexminheap = min;
                node tmp = _list[index];
                _list[index] = _list[min];
                _list[min] = tmp;

                Heapify(min);

            }
        }


        public void BuildHeap()
        {
            int n = _list.Count - 1;
            for(int i=(n-1)/2;i>=0;i--)
            {
                Heapify(i);
            }
        }

    public void display()
        {
            foreach (var item in _list)
            {
                Console.WriteLine(item.word+";"+item.frequecy);
            }
        }
    }

      #endregion
          
    public class top10Words
    {
           string[] paths = { "dict/acc.txt" };
           tries _dict = new tries();
           trieMinHeap _minheaptries = new trieMinHeap();
          
            string tmp = String.Empty;

            public void run()
            {

                foreach (string path in paths)
                {
                    using (StreamReader sr = new StreamReader(path, Encoding.ASCII))
                    {
                        while ((tmp = sr.ReadLine()) != null)
                        {
                            _dict.Add(ref _minheaptries, tmp.Split(' ')[0]);
                        }
                    }
                }
                //Random r = new Random();
                //for (int i = 0; i < 10000000; i++)
                //{
                //    _dict.Add(ref _minheaptries, (r.Next(1000).ToString()));
                //}
                string str = string.Empty;
                List<string> result = new List<string>();

                //uint c = _dict.GetFrequecyCount("raushan");
                _minheaptries.display();
                //while(true)
                //{
                //    Console.WriteLine("enter a to insert ; d to display;r");
                //    string s = Console.ReadLine();
                //    if (s == "a")
                //    {
                //        Console.WriteLine("enter the value");
                //        string s1 = Console.ReadLine();
                //        _dict.Add(ref _minheaptries, s1);
                //    }
                //    else if (s == "d")
                //    {
                //        _minheaptries.display();
                //    }
                //    else if (s == "r")
                //    {
                //        int d = r.Next(10);
                //        Console.WriteLine(d);
                //        for (int i = 0; i < 100000; i++)
                //        {   
                //            _dict.Add(ref _minheaptries, (d.ToString()));
                //        }
                //    }
                //    else
                //        break;
                //}
            }
    }
}
