public static class Utilities
{
    public static int GetIndexLoopedFromOtherSideWhenOutOfBounds(int index, int lowestValue, int highestValue)
    {
        if (index < lowestValue)
        {
            int howManyLoopsNeeded = (lowestValue - index - 1) / (highestValue - lowestValue + 1) + 1;
            //at first i wanted to do recursive function but with loops count calculated there is no need for that
            return index + (highestValue - lowestValue + 1) * howManyLoopsNeeded;
            // if bounds are 0---5 and index is -1 --> after teleport it will       return 5 as it should 
            // if bounds are 1---5 and index is  0 --> after teleport it will still return 5 as it should 
            
        }
        if (index > highestValue)
        {
            int howManyLoopsNeeded = ( index - highestValue - 1) / (highestValue - lowestValue + 1) + 1;
            return index - (highestValue - lowestValue + 1) * howManyLoopsNeeded;
        }
        return index;
    }
}