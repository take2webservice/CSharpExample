using System;

namespace CsharpExample.Function
{
    // デリゲートはメソッドをオブジェクトとして扱い、他のメソッドへの参照を保持するための機能
    // メソッドを引数として渡したり、コールバックやイベントハンドリングのために使用したりすることができる。
    delegate string GreetingDelegate(string name);

    class DelegateSampleClass
    {

        public void UseDelegateAsCallback()
        {
            Called(Hello);
        }

        // GreetingDelegate を Func<string, string> と書いても動く
        public void Called(GreetingDelegate callback)
        {
            callback("Callback");
        }

        public void CombineDelegate()
        {
            // デリゲートを使うことで関数を結合することができる。
            GreetingDelegate greetingDelegate = Hello;
            greetingDelegate += GoodBye;
            string result = greetingDelegate("C#");

            Console.WriteLine($"result: {result}");
        }

        public string Hello(string name)
        {
            string message = $"Hello! {name}!";
            Console.WriteLine(message);
            return $"Hello! {name}!";
        }

        public string GoodBye(string name)
        {
            string message = $"GoodBye! {name}!";
            Console.WriteLine(message);
            return $"GoodBye! {name}!";
        }
    }

}