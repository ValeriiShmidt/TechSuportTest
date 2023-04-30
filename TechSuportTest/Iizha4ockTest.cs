/// <summary>
/// Provides a static method for calculating the minimum count
/// of rendezvous of hedgehogs
/// </summary>

namespace TechSuportTest
{
    public static class Iizha4ockTest
    {
        /// <summary>
        /// Calculates the minimum count of rendezvous of hedgehogs
        /// </summary>
        /// <param name="selectedColor">
        /// The index of the selected color (0 for Red, 1 for Green, 2 for Blue).
        /// </param>
        /// <param name="countsByColor">
        /// An array containing the count of each color (Red, Green, Blue) in a certain situation.
        /// </param>
        /// <returns>
        /// The minimum count of rendezvous required to change colors of hedgehogs to selected one.
        /// If there is no way to reach the target returns -1.
        /// </returns>
        public static int CalculateMinCountOfRendezvous(int selectedColor, int[] countsByColor)
        {
            // Declaration of variables

            int selectedColorCount;
            int firstNonSelectedColorCount;
            int secondNonSelectedColorCount;

            // Initialization of variables.
            // firstNonSelectedColorCount is not smaller than secondNonSelectedColorCount
            if (selectedColor == 0)
            {
                selectedColorCount  = countsByColor[0];
                firstNonSelectedColorCount = Math.Max(countsByColor[1], countsByColor[2]);
                secondNonSelectedColorCount  = Math.Min(countsByColor[1], countsByColor[2]);
            }

            else if (selectedColor == 1)
            {
                selectedColorCount  = countsByColor[1];
                firstNonSelectedColorCount = Math.Max(countsByColor[0], countsByColor[2]);
                secondNonSelectedColorCount = Math.Min(countsByColor[0], countsByColor[2]);
            }

            else
            {
                selectedColorCount  = countsByColor[2];
                firstNonSelectedColorCount = Math.Max(countsByColor[0], countsByColor[1]);
                secondNonSelectedColorCount = Math.Min(countsByColor[0], countsByColor[1]);
            }

            // Checking for possibility to reach the target
            if ((firstNonSelectedColorCount - secondNonSelectedColorCount) % 3 != 0)
            {
                return -1;
            }

            if (selectedColorCount == 0 && (firstNonSelectedColorCount == 0 || secondNonSelectedColorCount == 0))
            {
                return -1;
            }

            // Main loop of program. Continue executing the loop until
            // the counts of hedgehogs of two non-selected colors became equal.
            int countOfRendezvous = 0;
            while (firstNonSelectedColorCount - secondNonSelectedColorCount != 0)
            {
                // If there are no hedgehogs of the selected color left, increase their count
                if (selectedColorCount == 0)
                {
                    firstNonSelectedColorCount -= 1;
                    secondNonSelectedColorCount -= 1;
                    selectedColorCount += 2;

                    // Increment the count of rendezvous.
                    countOfRendezvous++;
                }

                // Increase the count of the second non-selected color (the smaller one)
                firstNonSelectedColorCount -= 1;
                secondNonSelectedColorCount += 2;
                selectedColorCount -= 1;

                // Increment the count of rendezvous.
                countOfRendezvous++;
            }

            // Increase the count rendezvous by count of hedgehogd of non-selected color left
            countOfRendezvous += firstNonSelectedColorCount;

            // Return the result
            return countOfRendezvous;
        }       
    }
}
