using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace BandNameGenerator
{
    [TestFixture]
    public class BandNameGeneratorUnitTest
    {
        [TestCase("The Knife", "knife")]
        [TestCase("Tartart", "tart")]
        [TestCase("Sandlesandles", "sandles")]
        [TestCase("The Bed", "bed")]
        public void BandNameGeneratorTest(string expected, string inputString)
        {
            var nameGenerator = new BandNameGenerator();
            var actual = nameGenerator.Generator(inputString);
            Assert.AreEqual(expected, actual);
        }
    }
}

