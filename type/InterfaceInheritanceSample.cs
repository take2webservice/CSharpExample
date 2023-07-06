using System;

namespace CsharpExample.Type.ClassSample
{
    // インターフェースはそれを継承するクラスの振る舞い(メソッド)を定義する
    interface IBaseInterface{
        public string CreateIntroduceMessage();
    }

    class ImplementInterfaceSampleClass1: IBaseInterface
    {
        public string? name;
        public int age;
        public string? country;


        // インターフェースを継承するとインターフェースで定義されたメソッドを持つ必要がある。
        public ImplementInterfaceSampleClass1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string CreateIntroduceMessage()
        {
            return $"私の名前は{this.name}。{this.age}です。";
        }
    }

    class ImplementInterfaceSampleClass2: IBaseInterface
    {
        public string? name;
        public int age;
        public string? country;


        // インターフェースを継承するとインターフェースで定義されたメソッドを持つ必要がある。
        public ImplementInterfaceSampleClass2(string name, int age, string country)
        {
            this.name = name;
            this.age = age;
            this.country = country;
        }

        public string CreateIntroduceMessage()
        {
            return $"私の名前は{this.name}。{this.country}出身の {this.age}です。";
        }
    }

    class UseInterfaceSampleClass{
        IBaseInterface baseInterfaceImlemented;
        public UseInterfaceSampleClass(IBaseInterface baseInterfaceImlemented){
            this.baseInterfaceImlemented = baseInterfaceImlemented;
        }

        public void Greet()
        {
            Console.WriteLine(baseInterfaceImlemented.CreateIntroduceMessage());
        }
    }
}