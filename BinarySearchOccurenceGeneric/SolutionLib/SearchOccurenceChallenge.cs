using System;
using System.Collections.Generic;

namespace SolutionLib
{
    public class SearchOccurenceChallenge<T>
    {
        public static Dictionary<int, T> Search(T[] arr, T searchItem)
        {
            // return early if array is empty
            if (arr.Length <= 0)
                return null;

            // convert array to list and sort
            var list = new List<T>(arr);
            list.Sort();

            // get middle index and middleItem
            int middleIndex = list.Count / 2;
            var middleItem = list[middleIndex];

            // return result if middle Item match search item
            if (searchItem.Equals(middleIndex))
                return new Dictionary<int, T>() { { middleIndex, middleItem } };

            // return result if first Item match search item
            if (searchItem.Equals(list[0]))
                return new Dictionary<int, T>() { { 0, list[0] } };

            // return result if middleIndex match search item
            if (searchItem.Equals(list[list.Count - 1]))
                return new Dictionary<int, T>() { { list.Count - 1, list[list.Count - 1] } };

            


            return null;
        }

        private static bool CompareList(List<T> list, T searchTerm)
        {
            return false;
        }

        private int getNumberOfOccurrence(List<T> list)
        {
            return 0;
        }
    }
}
