using System;

namespace ClassLibraryBubbleSort
{
  public static class HelperClass
  {
    public static string[,] OriginalMethod()
    {
      string[,] array = new string[50, 2];
      Random r = new Random();
      int number = 0;
      int space = 0;
      double fontossag = 0;
      for (int i = 0; i < 50; i++)
      {
        string message = string.Empty;
        int hossz = r.Next(10, 51);
        for (int h = 0; h < hossz; h++)
        {
          number = r.Next(0, 101);
          space = r.Next(0, 101);
          if (number <= 50)
          {
            message += (char)r.Next(97, 122);
          }
          else if (number >= 50)
          {
            message += (char)r.Next(65, 90);
          }
          if (space <= 10)
          {
            message += " ";
          }
        }

        for (int f = 0; f < 50; f++)
        {
          fontossag = r.NextDouble() * (10.0);
        }

        array[i, 0] += message;
        array[i, 1] += fontossag;
      }

      return array;
    }

    public static string[,] BubbleSortStringByLength(string[,] array)
    {
      int num = array.GetLength(0);
      for (int i = 0; i < num - 1; i++)
      {
        for (int j = 0; j < num - i - 1; j++)
        {
          if (array[j, 0].Length > array[j + 1, 0].Length)
          {
            // swap first column
            string tmp = array[j, 0];
            array[j, 0] = array[j + 1, 0];
            array[j + 1, 0] = tmp;
            // swap second column
            tmp = array[j, 1];
            array[j, 1] = array[j + 1, 1];
            array[j + 1, 1] = tmp;
          }
        }
      }

      return array;
    }
  }
}
