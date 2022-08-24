using SingletonDesignPattern;

var instance1 = Counter.GetInstance();
var instance2 = Counter.GetInstance();
var instance3 = Counter.GetInstance();
var instance4 = Counter.GetInstance();

Print();
instance1.Increase();
Print();
instance3.Increase();
Print();

if(instance1 == instance4)
{
    Console.WriteLine("hmm");
}

void Print()
{
    Console.WriteLine(instance1.GetValue());
    Console.WriteLine(instance2.GetValue());
    Console.WriteLine(instance3.GetValue());
    Console.WriteLine(instance4.GetValue());
    Console.WriteLine("==============");
}
