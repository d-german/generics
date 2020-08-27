using NUnit.Framework;

namespace GenericsTests
{
    [TestFixture]
    public class GenericMethodsTest
    {
        private static void Swap<T>(ref T a, ref T b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        private static void Swap(ref object a, ref object b)
        {
            object temp = a;
            //var i = (int)a;
            a = b;
            b = temp;
        }

        [Test]
        public void SwapGenericTest()
        {
            int a = 5;
            int b = 10;
            Swap<int>(ref a, ref b);

            Assert.AreEqual(10, a);
            Assert.AreEqual(5, b);
        }

        [Test]
        public void SwapObjectTest()
        {
            object a = "5";
            object b = 10;
            Swap(ref a, ref b);

            Assert.AreEqual(10, a);
            Assert.AreEqual("5", b);

        }


        
    }
}
