namespace abstracfactory
{
    internal interface IAbstractFactory
    {
        IAbstractProductX CreateProductX();
        IAbstractProductY CreateProductY();
    }
}