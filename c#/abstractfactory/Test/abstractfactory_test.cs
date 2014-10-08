using NUnit.Framework;

namespace abstracfactory
{
    [TestFixture]
    class abstractfactory_test
    {

        [Test]
        public void call_to_CreateProductX_method_should_return_productX()
        {
            IAbstractFactory factory = new ConcreteFactory();

            IAbstractProductX productX = factory.CreateProductX();

            Assert.AreEqual("Called: ConcreteProductX", productX.feature());
        }

        [Test]
        public void call_to_CreateProductY_method_should_return_productY()
        {
            IAbstractFactory factory = new ConcreteFactory();

            IAbstractProductY productX = factory.CreateProductY();

            Assert.AreEqual("Called: ConcreteProductY", productX.feature());
        }

        [Test]
        public void call_to_createProductX_overridden_method_should_return_new_productX()
        {
            IAbstractFactory myFactory = new MyConcreteFactory();

            IAbstractProductX myProduct = myFactory.CreateProductX();

            Assert.That(myProduct.feature(), Is.EqualTo("Called: MyProductX"));
        }
    }

    internal class MyConcreteFactory : IAbstractFactory
    {
        public IAbstractProductX CreateProductX()
        {
            return new MyProductX();
        }

        public IAbstractProductY CreateProductY()
        {
            return new MyProductY();
        }
    }

    internal class MyProductY : IAbstractProductY
    {
        public string feature()
        {
            return "Called: MyProductX";
        }
    }

    internal class MyProductX : IAbstractProductX
    {
        public string feature()
        {
            return "Called: MyProductX";
        }
    }
}
