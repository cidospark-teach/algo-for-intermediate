using System;
using System.Collections.Generic;
using System.Linq;

namespace SolutionLib
{
    public class SearchOccurenceChallenge<T>
    {
        private static int occurence;
        static List<T> rightSubList = null;

        public static int Search(T[] arr, T searchItem)
        {
            // convert array to list and sort
            var list = new List<T>(arr);
            list.Sort();

            // to avoid the repeated process of sorting I had to extract the code into PerformSearch() method below
            SearchLeftSide(list, searchItem);

            if (rightSubList != null)
                SearchRightSide(rightSubList, searchItem);

            return occurence;
        }

        private static int SearchLeftSide(List<T> list, T searchItem)
        {
            // if array length is 0 or less Or the length is 1 and not equal to the search term the return early
            if (list.Count < 1 || list.Count == 1 && !list[0].Equals(searchItem))
                return 0;

            // get middle index and middleItem
            int middleIndex = list.Count / 2;
            var middleItem = list[middleIndex];

            // return result if middle Item, first item or last ittem match search item
            if (list.Count > 2 && searchItem.Equals(middleItem))
                occurence += 1;

            // return result if middle Item, first item or last ittem match search item
            if (searchItem.Equals(list[0]))
                occurence += 1;

            // return result if middle Item, first item or last ittem match search item
            if (searchItem.Equals(list[list.Count - 1]) && (list.Count - 1) != 0)
                occurence += 1;

            var newList = new List<T>() { searchItem, middleItem };
            var nextItem = list.Count > middleIndex + 1? list[middleIndex + 1] : default(T);
            List<T> sublist = null;

            var comparison = CompareList(newList, searchItem, nextItem);
            if(comparison == 0)
            {
                sublist = list.Skip(1).Take(middleIndex - 1).ToList();
                rightSubList = list.Skip(middleIndex + 1).Take((list.Count - (middleIndex + 1)) - 1).ToList();
            }
            else if (comparison == 1)
            {
                sublist = list.Skip(1).Take(middleIndex - 1).ToList();
            }
            else
            {
                sublist = list.Skip(middleIndex + 1).Take((list.Count - (middleIndex + 1)) - 1).ToList();
            }


            return SearchLeftSide(sublist, searchItem); // recursive action, method calling itself to evaluate the list

        }

        private static int CompareList(List<T> list, T searchTerm, T nextItem)
        {
            list.Sort();
            if (list[0].Equals(searchTerm) && searchTerm.Equals(nextItem))
                return 0;
            else if (list[0].Equals(searchTerm))
                return 1;
            else
                return 2;
        }

        private static int SearchRightSide(List<T> list, T searchItem)
        {
            return SearchLeftSide(list, searchItem);
        }
    }

}
