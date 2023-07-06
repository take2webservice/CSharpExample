using System;
namespace CsharpExample.Type.ClassSample
{
    class ClassValueSample
    {
        public static string classValue = "test";

        public void PrintClassValue()
        {
            Console.WriteLine($"現在のclassValue は{classValue}");
        }
    }

    class ReadOnlyClassValueSample
    {
        // static を指定された変数はインスタンスを介しては呼び出せない
        // ReadOnlyClassValueSample.classValueのように呼び出す
        public readonly static  string classValue = "test";

        // インスタンスメソッドからはクラス変数を呼び出すことができる。
        public void PrintClassValue()
        {
            Console.WriteLine($"現在のclassValue は{classValue}");
        }
    }

    // インスタンスにではなく、クラスに備わるメソッドの説明
    class ClassMethodSample
    {

        public string name;
        ClassMethodSample()
        {
            this.name = "インスタンス変数 name";
        }

        public readonly static  string classValue = "test";

        // static を指定されたメソッドはインスタンスを介しては呼び出せない
        // ReadOnlyClassValueSample.PrintClassValue() のように呼び出す
        public static void PrintClassValue()
        {
            Console.WriteLine($"現在のclassValue は{classValue}");
        }

        public static void PrintInstanceValue()
        {
            Console.WriteLine($"現在のclassValue は{classValue}");
            // this.name;
            // 上記のコードを書くと警告が出る
            // 「キーワード 'this' は、静的プロパティ、静的メソッド、または静的フィールド初期化子では無効です」と怒られる。
        }
    }
}