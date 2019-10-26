using System;
using System.Collections;
using NUnit.Framework;

namespace Open_Lab_04._01
{
    [TestFixture]
    public class Tests
    {

        private Checker checker;

        private const int RandStrMinSize = 5;
        private const int RandStrMaxSize = 30;
        private const int RandSeed = 401401401;
        private const int RandTestCasesCount = 96;

        [OneTimeSetUp]
        public void Init() => checker = new Checker();

        [TestCase("loop", true)]
        [TestCase("yummy", true)]
        [TestCase("orange", false)]
        [TestCase("munchkin", false)]
        [TestCaseSource(nameof(GetRandom))]
        public void DoubleLettersTest(string str, bool expected) =>
            Assert.That(checker.DoubleLetters(str), Is.EqualTo(expected));

        private static IEnumerable GetRandom()
        {
            var rand = new Random(RandSeed);

            for (var i = 0; i < RandTestCasesCount; i++)
            {
                var arr = new char[rand.Next(RandStrMinSize, RandStrMaxSize + 1)];

                for (var j = 0; j < arr.Length; j++)
                    arr[j] = (char) rand.Next('a', 'z' + 1);

                var expected = false;
                for (var j = 0; j < arr.Length - 1; j++)
                    if (arr[j] == arr[j + 1])
                    {
                        expected = true;
                        break;
                    }

                yield return new TestCaseData(new string(arr), expected);
            }
        }

    }
}
