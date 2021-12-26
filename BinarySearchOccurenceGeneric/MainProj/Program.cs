using System;
using System.Collections.Generic;
using SolutionLib;

namespace MainProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 4, 4, 13, 4, 4, 4 };
            var dict = new Dictionary<int, List<int>>();
            int searchTerm = 130;

            // I did something a little bit extra here ==>
            // this for loop is arranging the indexes of the arr items into value pairs of there frequency
            for (int i = 0; i < arr.Length; i++)
            {
                if(dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]].Add(i);
                }
                else
                {
                    dict.Add(arr[i], new List<int>(){ i });
                }
            }

            var res = SearchOccurenceChallenge<int>.Search(arr, searchTerm);


            //- - - - PRINTING THE OUTPUT - - - - //
            Console.Write(res < 1 ? "Not found" : $"Found {res} occurence(s) for the search term ==> {searchTerm}");

            if(res > 0)
            {
                Console.Write(" at the following index(es):  ");

                var indexes = dict[searchTerm];

                foreach(var item in indexes)
                {
                    Console.Write(item + ", ");
                }

                Console.WriteLine("\n");
            }
            //- - - - - - - - - - - -  - - - - - //
        }
    }
}
