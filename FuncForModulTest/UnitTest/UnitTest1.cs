using FuncForModulTest;
namespace UnitTest
{
    public class SortingTests
    {
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 2, 2, 4, 1, 1 }, new int[] { 1, 1, 2, 2, 4 })]
        [TestCase(new int[] { 5, 15, 10, 20, 25 }, new int[] { 5, 10, 15, 20, 25 })]
        [TestCase(new int[] {}, new int[] {})]
        
        
        public void Test1(int[] arr, int[] answ)
        {
            Assert.AreEqual(answ, Program.BubbleSort(arr));
        }
    }
    public class PalindromTests
    {
        [TestCase("",false)]
        [TestCase(" ",true)]
        [TestCase("55255",true)]
        [TestCase("1234",false)]
        


        public void Test1(string str, bool answ)
        {
            Assert.AreEqual(answ, Program.Palindrom(str));
        }
    }
    public class FactorialTests
    {
        [TestCase(5, 120)]
        [TestCase(0, 1)]
        [TestCase(33, -1)]
        [TestCase(-3, -1)]
  

        public void Test1(int number, int answ)
        {
            Assert.AreEqual(answ, Program.Factorial(number));
        }
    }
    public class FibonachiTests
    {
        [TestCase(-1, -1)]
        [TestCase(48, -1)]
        [TestCase(8, 21)]
        [TestCase(12, 144)]




        public void Test1(int number, int answ)
        {
            Assert.AreEqual(answ, Program.Fibonachi(number));
        }
    }
    public class LineContaintsTests
    {
        [TestCase("wolf", "olf", true)]
        [TestCase("maxim", "maxiiii", false)]
        [TestCase("", "", true)]
        [TestCase("Vo","", false)]




        public void Test1(string str,string str1, bool answ)
        {
            Assert.AreEqual(answ, Program.lineContaints(str, str1));
        }
    }
    public class SimpleNumberTests
    {
        [TestCase(0,false)]
        [TestCase(-1,false)]
        [TestCase(1,false)]
        [TestCase(5,true)]
        [TestCase(5,true)]
        [TestCase(8,false)]


        public void Test1(int number, bool answ)
        {
            Assert.AreEqual(answ, Program.simpleNumber(number));
        }
    }
    public class ReverseNumTest
    {
        [TestCase(4321, 1234)]
        [TestCase(10, 1)]
        [TestCase(-012, -21)]
        [TestCase(1001, 1001)]
        [TestCase(0, 0)]


        public void Test1(int number, int answ)
        {
            Assert.AreEqual(answ, Program.ReverseNum(number));
        }
    }
    public class ToRomanTests
    {
        [TestCase(4000, "error")]
        [TestCase(-1, "error")]
        [TestCase(0, "N")]
        [TestCase(1001, "MI")]


        public void Test1(int number, string answ)
        {
            Assert.AreEqual(answ, Program.ToRoman(number));
        }
    }
}