using NUnit.Framework;

namespace GenericsTests
{
    public class Data
    {
        private int _value;

        public void SetValue(int value)
        {
            _value = value;
        }

        public int GetValue()
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
            test.SetValue(5);

            Assert.AreEqual(5, test.GetValue());
        }
    }
}
