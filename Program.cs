using LinkedList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   class Program
   {
      static void Main(string[] args)
      {
         var list = new Model.LinkedList<int>();
         list.Add(1);
         list.Add(2);
         list.Add(3);
         list.Add(4);
         list.Add(5);

         foreach (var item in list)
         {
            Console.Write(item + " ");
         }
         Console.WriteLine();

         list.Delete(3);
         list.Delete(1);
         list.Delete(7);

         foreach (var item in list)
         {
            Console.Write(item + " ");
         }
         Console.WriteLine();

         list.AppendHead(90);
         list.AppendHead(91);
         list.AppendHead(92);

         foreach (var item in list)
         {
            Console.Write(item + " ");
         }
         Console.WriteLine();

         list.InsertAfter(92, 88);
         list.InsertAfter(5, 77);
         list.InsertAfter(666, 444);
         list.InsertAfter(77, 666);

         foreach (var item in list)
         {
            Console.Write(item + " ");
         }
         Console.WriteLine();


         var duplexList = new DuplexLinkedList<int>();

         duplexList.Add(55);
         duplexList.Add(56);
         duplexList.Add(57);
         duplexList.Add(58);
         duplexList.Add(59);

         foreach (var item in duplexList)
         {
            Console.WriteLine(item);
         }
         Console.WriteLine();

         duplexList.Delete(57);

         foreach (var item in duplexList)
         {
            Console.WriteLine(item);
         }
         Console.WriteLine();

         var reverse = duplexList.Reverse();

         foreach (var item in reverse)
         {
            Console.WriteLine(item);
         }

         Console.ReadLine();
      }
   }
}
