using System;
using System.Collections.Generic;
using System.Text;

namespace CTDL_GT
{
    internal class Stack_Queue
    {
        static void Main(string[] args)
        {
            int[] m = new int[] { 45, 214, 6, 35, 67, 37, 355 };
            int n = 3;
            Stack<int> kq = new Stack<int>(m);
            List<Stack<int>> san = new List<Stack<int>>();
            for (int i = 0; i < 10; i++)
                san.Add (new Stack<int>());
            
            //THUAT TOAN
            for(int j = 0; j < n; j++)
            {
                int so;
                while (kq.Count > 0)
                {
                    so = kq.Pop();
                    int gtss = (so / (int)Math.Pow(10, j)) % 10;
                    san[gtss].Push(so);
                }
                for(int i = 0; i < san.Count; i++)
                {
                    while (san[i].Count > 0)
                    {
                        so = san[i].Pop();
                        kq.Push(so);
                    }
                }
            }
            while (kq.Count > 0)
                Console.Write(
        }
     }
}
