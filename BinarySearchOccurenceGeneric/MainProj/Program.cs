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
            int searchTerm = 13;


            var res = SearchOccurenceChallenge<int>.Search(arr, searchTerm);

            Console.Write(res < 1 ? "Not found" : $"Found {res} occurence(s) for the search term ==> {searchTerm}");

        }
    }
}
