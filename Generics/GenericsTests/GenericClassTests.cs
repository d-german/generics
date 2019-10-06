using NUnit.Framework;

namespace GenericsTests
{
    [TestFixture]
    public class GenericClassTests
    {
        [Test]
        public void GenericClassTest()
        {
            var genericClass = new GenericClass<SomeConcreteClass>
            {
                TypeT = new SomeConcreteClass("SomeConcreteClass")
            };
            Assert.AreEqual(13, genericClass.Add());
            Assert.AreEqual("SomeConcreteClass", genericClass.TypeT.ClassName);
        }

        [Test]
        public void GenericClassBuildTypeTTest()
        {
            var concreteClass = GenericClass<SomeConcreteClass>.BuildTypeT();
            Assert.NotNull(concreteClass);
            var res = concreteClass.SomeClassMethod() - concreteClass.SomeInterfaceMethod();
            Assert.AreEqual(-3, res);
        }

        private abstract class SomeAbstractClass
        {
            public abstract int SomeClassMethod();
        }

        private interface ISomeInterface
        {
            int SomeInterfaceMethod();
        }

        private class GenericClass<T> where T : SomeAbstractClass, ISomeInterface, new()
        {
            public T TypeT { get; set; }

            public int Add()
            {
                return TypeT.SomeClassMethod() + TypeT.SomeInterfaceMethod();
            }

            public static T BuildTypeT()
            {
                return new T();
            }
        }

        private class SomeConcreteClass : SomeAbstractClass, ISomeInterface
        {
            public override int SomeClassMethod()
            {
                return 5;
            }

            public int SomeInterfaceMethod()
            {
                return 8;
            }

            public SomeConcreteClass(string name)
            {
                ClassName = name;
            }

            public SomeConcreteClass()
            {
            }

            public string ClassName { get; set; }
        }
    }
}