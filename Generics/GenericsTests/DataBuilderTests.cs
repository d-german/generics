using NUnit.Framework;

namespace GenericsTests
{
    public class Data
    {
        private int _value;

        public void SetData(int value)
        {
            _value = value;
        }

        public int GetData()
        {
            int ret = _value;
            return ret;
        }
    }

    public static class DataBuilder
    {
        public static Data BuildData()
        {
            return new Data();
        }
    }

    [TestFixture]
    public class TestClassTest
    {
        [Test]
        public void Test()
        {
            var test = DataBuilder.BuildData();
            test.SetData(5);

            Assert.AreEqual(5, test.GetData());
        }
    }
}
