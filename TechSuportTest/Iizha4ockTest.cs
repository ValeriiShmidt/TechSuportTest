namespace TechSuportTest
{
    public static class Iizha4ockTest
    {
        public static int CalculateMinCountOfRendezvous(int selectedColor, int[] countsByColor)
        {
            int selectedColorCount;
            int firstNonSelectedColorCount;
            int secondNonSelectedColorCount;
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


            if ((firstNonSelectedColorCount - secondNonSelectedColorCount) % 3 != 0)
            {
                return -1;
            }

            if (selectedColorCount == 0 && (firstNonSelectedColorCount == 0 || secondNonSelectedColorCount == 0))
            {
                return -1;
            }

            int countOfRendezvous = 0;

            while (firstNonSelectedColorCount - secondNonSelectedColorCount != 0)
            {
                if (selectedColorCount == 0)
                {
                    firstNonSelectedColorCount -= 1;
                    secondNonSelectedColorCount -= 1;
                    selectedColorCount += 2;
                    
                    countOfRendezvous++;
                }

                firstNonSelectedColorCount -= 1;
                secondNonSelectedColorCount += 2;
                selectedColorCount -= 1;

                countOfRendezvous++;
            }

            countOfRendezvous += firstNonSelectedColorCount;

            return countOfRendezvous;
        }       
    }
}
