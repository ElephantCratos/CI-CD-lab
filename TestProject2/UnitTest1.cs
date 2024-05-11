using NUnit.Framework;

namespace TestProject2
{
    [TestFixture]
    public class ExperimentalRatTests
    {
        [TestCase("racecar", true)]
        [TestCase("hello", false)]
        [TestCase("madam", true)]
        [TestCase("level", true)]
        [TestCase("le", false)]
        public void IsPalindrome_ReturnsCorrectResult(string input, bool expectedResult)
        {
            bool result = ExperimentalRat.IsPalindrome(input);

            Assert.AreEqual(expectedResult, result);
        }


        [TestCase(5, 120)]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(10, 3628800)]
        public void GetFactorial_ReturnsCorrectResult(int position, int expectedResult)
        {
            int result = ExperimentalRat.GetFactorial(position);

            Assert.AreEqual(expectedResult, result);
        }


        [TestCase(10, 55)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(20, 6765)]
        public void GetFibonachi_ReturnsCorrectResult(int position, int expectedResult)
        {
            int result = ExperimentalRat.GetFibonachi(position);

            Assert.AreEqual(expectedResult, result);
        }


        [TestCase("I live in a house near the mountains", "live", true)]
        [TestCase("We do lots of things together", "lotts ", false)]
        [TestCase("Hello, world!", "world", true)]
        [TestCase("Hello, world!", "wod", false)]
        public void SubstringSearch_ReturnsCorrectResult(string str, string substr, bool expectedResult)
        {
            bool result = ExperimentalRat.SubstringSearch(str, substr);

            Assert.AreEqual(expectedResult, result);
        }


        [TestCase(17, true)]
        [TestCase(4, false)]
        [TestCase(23, true)]
        [TestCase(100, false)]
        public void IsPrime_ReturnsCorrectResult(long number, bool expectedResult)
        {
            bool result = ExperimentalRat.IsPrime(number);

            Assert.AreEqual(expectedResult, result);
        }


        [TestCase(12345, 54321)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(987654321, 123456789)]
        public void GetReversedNumber_ReturnsCorrectResult(int number, int expectedResult)
        {
            int result = ExperimentalRat.GetReversedNumber(number);

            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void GetReversedNumber_BeyondIntMaxValue_ReturnsZero()
        {
            long number = (long)Int32.MaxValue + 5;

            int result = ExperimentalRat.GetReversedNumber((int)number);

            Assert.AreEqual(0, result);
        }


        [Test]
        public void GetReversedNumber_BeyondIntMinValue_ReturnsZero()
        {
            long number = (long)Int32.MinValue - 5;

            int result = ExperimentalRat.GetReversedNumber((int)number);

            Assert.AreEqual(0, result);
        }


        [TestCase(1984, "MCMLXXXIV")]
        [TestCase(0, "Incorrect Data")]
        [TestCase(1, "I")]
        [TestCase(2022, "MMXXII")]
        public void ConvertToRoman_ReturnsCorrectResult(int number, string expectedResult)
        {
            string result = ExperimentalRat.ConvertToRoman(number);

            Assert.AreEqual(expectedResult, result);
        }



        [TestCase(new[] { 5, 2, 8, 3, 1 }, new[] { 1, 2, 3, 5, 8 })]
        [TestCase(new[] { 10, 5, 1, 8, 3 }, new[] { 1, 3, 5, 8, 10 })]
        [TestCase(new[] { 7, 4, 2, 9, 6 }, new[] { 2, 4, 6, 7, 9 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
        public void MergeSort_ReturnsSortedArray(int[] array, int[] expectedResult)
        {
            int[] result = ExperimentalRat.MergeSort(array);

            Assert.AreEqual(expectedResult, result);
        }



        [Test]
        public void Merge_ReturnsMergedArray()
        {
            int[] targetArray = new int[5];
            int[] array1 = new int[] { 1, 3 };
            int[] array2 = new int[] { 2, 4, 5 };

            int[] result = ExperimentalRat.Merge(targetArray, array1, array2);

            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, result);
        }

    }
}