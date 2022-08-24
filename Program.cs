using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonDesignPattern;

var instance1 = Counter.GetInstance();
var instance2 = Counter.GetInstance();
var instance3 = Counter.GetInstance();
var instance4 = Counter.GetInstance();

instance1.Increase();
Print();

instance3.Increase();
Print();


void Print()
{
    Console.WriteLine(instance1.GetValue());
    Console.WriteLine(instance2.GetValue());
    Console.WriteLine(instance3.GetValue());
    Console.WriteLine(instance4.GetValue());
    Console.WriteLine("==============");
}
