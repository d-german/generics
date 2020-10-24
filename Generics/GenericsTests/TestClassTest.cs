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
        private static Test BuildTest()
        {
            return new Test();
        }

        [Test]
        public void Test()
        {
            var test = BuildTest();
            test.SetValue(5);

            Assert.AreEqual(5, test.GetValue());
        }
    }
}
