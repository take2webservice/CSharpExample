using System;

namespace CsharpExample.Type.ClassSample
{
    // staticクラスの宣言
    // staticクラスはインスタンスを作れない
    
    static class StaticClassSample{
        // インスタンスのメンバーは宣言できない
        // 宣言しようとすると、「静的クラスでインスタンスのメンバーを宣言することはできません」と警告が出る
        // public string? name;

        // staticクラスではインスタンス変数やインスタンスメソッドは宣言できない。
        public static string name = "Static Value";

        // staticクラスはインスタンスを作ることができないので、コンストラクタの宣言もできない。
        // public StaticClassSample(string name, int age)
        // {
        //     this.name = name;
        // }

        public static void PrintName()
        {
            Console.WriteLine($"StaticClassSample.name: {name}");
        }
    }
}
