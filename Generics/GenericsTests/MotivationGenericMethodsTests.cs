using NUnit.Framework;

namespace GenericsTests
{
    [TestFixture]
    public class MotivationGenericMethodsTests //TODO: do this first
    {
        private class ObjectStack
        {
            int position;
            object[] data = new object[10];
            public void Push(object obj) => data[position++] = obj;
            public object Pop() => data[--position];
        }

        [Test]
        public void InvalidCastExceptionTest()
        {
            // Now suppose we want a stack that stores just integers:
            ObjectStack stack = new ObjectStack();

            // It's easy to make mistakes:
            stack.Push("s");  // Wrong type, but no error!

            Assert.Throws<System.InvalidCastException>(() =>
            {
                int i = (int)stack.Pop();  // Downcast - runtime error!
            });
            
            
        }
    }
}