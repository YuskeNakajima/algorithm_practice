using System;
using System.Collections.Generic;
using System.Threading;
using Application.Utility;

namespace Application.Execute
{
    public class BubbleSort: IExecutable
    {
        public void Execute()
        {
            List<int> list = Functions.RandomList(10, 1, 999);
            int       number     = 1;

            for (int i = 0; i < list.Count; i++)
            {
                for (int f = 0; f < list.Count - 1; f++)
                {
                    Console.Clear();
                    Functions.ListWriteLine($"{number: 000}", list);

                    if (list[f] > list[f + 1])
                        (list[f + 1], list[f]) = (list[f], list[f + 1]);

                    number += 1;
                    Thread.Sleep(100);
                }
            }
        }
    }
}