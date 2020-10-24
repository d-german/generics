using NUnit.Framework;

namespace GenericsTests
{
    public class Test
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

    [TestFixture]
    public class TestClassTest
    {
        [Test]
        public void Test()
        {
            var test = new Test();
            test.SetValue(5);

            Assert.AreEqual(5, test.GetValue());
        }
    }
}
