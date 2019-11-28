using System;
using System.Collections.Generic;
using System.Text;


namespace HackerRank_HomeCode
{
    //https://www.testdome.com/questions/c-sharp/train-composition/24950?visibility=1&skillId=18

    public class TrainComposition
    {
        LinkedList<int> list = new LinkedList<int>();
        public void AttachWagonFromLeft(int wagonId)
        {
            list.AddLast(wagonId);
        }

        public void AttachWagonFromRight(int wagonId)
        {
            list.AddFirst(wagonId);
        }

        public int DetachWagonFromLeft()
        {
            int lastwagon = list.Last.Value;
            list.RemoveLast();
            return lastwagon;
        }

        public int DetachWagonFromRight()
        {
            int firstwagon = list.First.Value;
            list.RemoveFirst();
            return firstwagon;
        }

        //public static void Main(string[] args)
        //{
        //    TrainComposition tree = new TrainComposition();
        //    tree.AttachWagonFromLeft(7);
        //    tree.AttachWagonFromLeft(13);
        //    wagon atatched are 13 ==> 7
        //    Console.WriteLine(tree.DetachWagonFromRight()); // 7 
        //    Console.WriteLine(tree.DetachWagonFromLeft()); // 13
        //}
    }
}
