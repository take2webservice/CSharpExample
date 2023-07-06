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
        public readonly static  string classValue = "test";

        public void PrintClassValue()
        {
            Console.WriteLine($"現在のclassValue は{classValue}");
        }
    }

    class ClassMethodSample
    {

        public string name;
        ClassMethodSample()
        {
            this.name = "インスタンス変数 name";
        }

        public readonly static  string classValue = "test";

        public static void PrintClassValue()
        {
            Console.WriteLine($"現在のclassValue は{classValue}");
        }

        public static void PrintInstanceValue()
        {
            Console.WriteLine($"現在のclassValue は{classValue}");
            // this.name; 「キーワード 'this' は、静的プロパティ、静的メソッド、または静的フィールド初期化子では無効です」と怒られる。
        }
    }
}