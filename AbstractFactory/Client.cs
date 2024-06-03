namespace AbstractFactory;

/// <summary>
/// Abstract Factory(抽象ファクトリー、抽象工場)は、 生成に関するデザインパターンの一つで、 
/// 関連したオブジェクトの集りを、 具象クラスを指定することなく生成することを可能とする。
/// </summary>
/// https://refactoring.guru/ja/design-patterns/abstract-factory
internal class Client
{
    public void Main()
    {
        ClientMethod(new ConcreteFactory1());
        Console.WriteLine();

        ClientMethod(new ConcreteFactory2());
    }

    public void ClientMethod(IAbstractFactory factory)
    {
        // ファクトリーのメソッドを用いることで、プロダクトのインスタンスを生成することが出来る
        // クライアント側でプロダクトに関する具象クラスに関心を持たなくていいのが良き
        var productA = factory.CreateProductA();
        var productB = factory.CreateProductB();

        Console.WriteLine(productB.UsefulFunctionB());
        Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
