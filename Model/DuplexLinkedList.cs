using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
   public class DuplexLinkedList<T> : IEnumerable<T>
   {
      public DuplexItem<T> Head { get; set; }
      public DuplexItem<T> Tail { get; set; }
      public int Count { get; set; }

      public DuplexLinkedList() { }

      public DuplexLinkedList(T data)
      {
         var item = new DuplexItem<T>(data);
         Head = item;
         Tail = item;
         Count = 1;
      }

      public void Add(T data)
      {
         var item = new DuplexItem<T>(data);

         if (Head == null)
         {
            Head = item;
         }
         else
         {
            Tail.Next = item;
            item.Previuos = Tail;
         }
         Tail = item;
         Count++;
      }

      public void Delete(T data)
      {
         var current = Head;

         while (current != null)
         {
            if (current.Data.Equals(data))
            {
               break;
            }
            current = current.Next;
         }

         if (current != null)
         {
            if (current.Next != null)
            {
               current.Next.Previuos = current.Previuos;
            }
            else
            {
               Tail = current.Previuos;
            }

            if (current.Previuos != null)
            {
               current.Previuos.Next = current.Next;
            }
            else
            {
               Head = current.Next;
            }
            Count--;
            return;
         }
         return;
      }

      public DuplexLinkedList<T> Reverse()
      {
         var result = new DuplexLinkedList<T>();

         var current = Tail;
         while(current != null)
         {
            result.Add(current.Data);
            current = current.Previuos;
         }
         return result;
      }

      public IEnumerator GetEnumerator()
      {
         var current = Head;
         while (current != null)
         {
            yield return current;
            current = current.Next;
         }
      }

      IEnumerator<T> IEnumerable<T>.GetEnumerator()
      {
         return (IEnumerator<T>)GetEnumerator();
      }
   }
}
