namespace abstracfactory
{
    internal class ConcreteFactory : IAbstractFactory
    {
        public IAbstractProductX CreateProductX()
        {
            return new ConcreteProductX();
        }

        public IAbstractProductY CreateProductY()
        {
            return new ConcreteProductY();
        }
    }
}