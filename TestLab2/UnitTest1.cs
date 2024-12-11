namespace TestLab2
{
    

    public class Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual("0", Converter.DecimalToBinary(0));
            Assert.AreEqual("1", Converter.DecimalToBinary(1));
            Assert.AreEqual("10", Converter.DecimalToBinary(2));
            Assert.AreEqual("111", Converter.DecimalToBinary(7));
            Assert.AreEqual("1010", Converter.DecimalToBinary(10));
            Assert.AreEqual("1101", Converter.DecimalToBinary(13));
        }

        [Test]
        public void TestNegative()
        {
            Assert.Throws<ArgumentException>(() => Converter.DecimalToBinary(-1));
        }
    }
}