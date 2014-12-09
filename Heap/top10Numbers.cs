using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
   public class top10Numbers<T>  where T:IComparable
    {
          internal class node:IComparable<node>
         {
              public uint frequency;
             public T data;

              public int CompareTo(node other)
              {
                  return this.frequency.CompareTo(other.frequency);
              }

          }
          Dictionary<T,uint> _list;
          MinHeap<node> _minheap;

          public top10Numbers()
          {
              _list = new Dictionary<T, uint>();
              _minheap = new MinHeap<node>();
          }

          public void Add(T data)
          {    
              if(_list.Keys.Contains(data))
              {
                 _list[data]++;
                  if(_minheap.peek().frequency<_list[data])
                  {
                      _minheap.ExtractMin();
                      _minheap.Add(new node() { data = data, frequency = _list[data] });
                  }
                  else
                  {
                      //_minheap.
                  }

              }
              else
              {
                  _list.Add(data, 1);
                  if(_minheap.count()<10)
                  {
                      _minheap.Add(new node() { data = data, frequency = 1 });
                  } 
                 
               
              }
          }









    }
}
