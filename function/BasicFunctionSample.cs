using System;

namespace CsharpExample.Function{
    public class BasicFunctionSample
    {
        // C#では基本的に関数はクラス内のメソッドとして存在する。
        // C# 9.0からはトップレベル関数という仕組みがあるが、ここでは紹介しない。

        // 関数では通常戻り値の型を明示する必要がある。
        public string ReturnMessage()
        {
            return "Hello World";
        }

        // voidは引数を返さない関数の戻り値型
        public void ExecVoidFunction()
        {
            Console.WriteLine("BasicFunctionSample.Execが実行されました");
        }

        // 引数を受け取る場合は型の指定が必要になる
        public int ExecWithArgument(int left, int right)
        {
            return left + right;
        }

        // static関数はクラスに属し、インスタンス化せずに使える。
        // 代わりにインスタンス変数へのアクセスはできない。
        public static string ExecStaticFunction()
        {
            return "ExecStaticFunction was called";
        }
    }
}