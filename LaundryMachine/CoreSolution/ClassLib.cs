using System;
using System.Collections.Generic;

namespace CoreSolution
{
    public class ClassLib
    {
        public int GetMaximumPairOfSocks(int noOfWashes, int[] cleanPile, int[] dirtyPile)
        {
            if (noOfWashes < 0 || noOfWashes > 50)
                return -1;

            if(cleanPile.Length < 1 || cleanPile.Length > 50)
                return -1;

            if (dirtyPile.Length < 1 || dirtyPile.Length > 50)
                return -1;

            var listOfCleanPile = new List<int>(cleanPile);
            var listOfDirtyPile = new List<int>(dirtyPile);
            listOfCleanPile.Sort();
            listOfDirtyPile.Sort();
            var maxNoOfWash = 0;

            int index = 0;
            while (index < listOfCleanPile.Count && (index + 1) < listOfCleanPile.Count)
            {
                if (listOfCleanPile[index] == listOfCleanPile[index + 1])
                {
                    maxNoOfWash += 1;
                    listOfCleanPile.Remove(listOfCleanPile[index]);
                    listOfCleanPile.Remove(listOfCleanPile[index]);
                }
                else
                {
                    index += 1;
                }
            }

            index = 0;
            var firstList = new List<int>();
            var secondList = new List<int>();
            while (index < listOfCleanPile.Count && index < listOfDirtyPile.Count && noOfWashes > 0)
            {
                if (listOfCleanPile.Count < listOfDirtyPile.Count)
                {
                    // when you assign referrence types, the assignee points to the assigner
                    firstList = listOfDirtyPile; // pointing effect
                    secondList = listOfCleanPile; // pointing effect
                }
                else
                {
                    firstList = listOfCleanPile;
                    secondList = listOfDirtyPile;
                }

                if (firstList.Contains(secondList[index]))
                {
                    firstList.Remove(secondList[index]);
                    secondList.Remove(secondList[index]);
                    maxNoOfWash += 1;
                    noOfWashes -= 1;
                }
                else
                {
                    index += 1;
                }
            }

            return maxNoOfWash;
        }
    }
}
