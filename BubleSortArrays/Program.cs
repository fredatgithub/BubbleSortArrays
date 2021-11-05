using ClassLibraryBubbleSort;
using System;

namespace BubleSortArrays
{
  internal class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      var oneArray = HelperClass.OriginalMethod();
      var sortedArray = HelperClass.BubbleSortStringByLength(oneArray);
      Display($"The first element and thus the shortest one is: {sortedArray[0, 0]} and the priority is {sortedArray[0, 1]}");
      Display($"The last element and thus the longest one is: {sortedArray[49, 0]} and the priority is {sortedArray[49, 1]}");
      Display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
