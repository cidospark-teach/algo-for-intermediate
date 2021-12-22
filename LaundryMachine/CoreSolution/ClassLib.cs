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

            return maxNoOfWash;
        }
    }
}
