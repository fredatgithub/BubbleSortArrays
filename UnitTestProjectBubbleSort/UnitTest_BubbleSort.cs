using ClassLibraryBubbleSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectBubbleSort
{
  [TestClass]
  public class UnitTest_BubbleSort
  {
    [TestMethod]
    public void TestMethod_Already_sorted()
    {
      string[,] source = new string[4, 2];
      source[0, 0] = "test";
      source[0, 1] = "33";
      source[1, 0] = "qwerty";
      source[1, 1] = "12";
      source[2, 0] = "long test";
      source[2, 1] = "3";
      source[3, 0] = "A long long time ago in a galaxy far far away";
      source[3, 1] = "153";
      string[,] expected = new string[4, 2];
      expected[0, 0] = "test";
      expected[0, 1] = "33";
      expected[1, 0] = "qwerty";
      expected[1, 1] = "12";
      expected[2, 0] = "long test";
      expected[2, 1] = "3";
      expected[3, 0] = "A long long time ago in a galaxy far far away";
      expected[3, 1] = "153";
      string[,] result = HelperClass.BubbleSortStringByLength(source);
      CollectionAssert.AreEquivalent(result, expected);
    }

    [TestMethod]
    public void TestMethod_Not_sorted()
    {
      string[,] source = new string[4, 2];
      source[3, 0] = "test";
      source[3, 1] = "33";
      source[2, 0] = "qwerty";
      source[2, 1] = "12";
      source[1, 0] = "long test";
      source[1, 1] = "3";
      source[0, 0] = "A long long time ago in a galaxy far far away";
      source[0, 1] = "153";
      string[,] expected = new string[4, 2];
      expected[0, 0] = "test";
      expected[0, 1] = "33";
      expected[1, 0] = "qwerty";
      expected[1, 1] = "12";
      expected[2, 0] = "long test";
      expected[2, 1] = "3";
      expected[3, 0] = "A long long time ago in a galaxy far far away";
      expected[3, 1] = "153";
      string[,] result = HelperClass.BubbleSortStringByLength(source);
      CollectionAssert.AreEquivalent(result, expected);
    }
  }
}
