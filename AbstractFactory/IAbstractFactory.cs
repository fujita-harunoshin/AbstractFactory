namespace AbstractFactory;

internal interface IAbstractFactory
{
    IAbstractProductA CreateProductA();

    IAbstractProductB CreateProductB();
}
