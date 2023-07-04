using System;

namespace CsharpExample.Values
{
    public class FloatSample
    {
        // https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
        // C# の浮動小数型にはfloat, double, decimalがある。
        // dobleはfloatの倍精度の値を扱うことができる。
        // decimalはより正確な数値計算のために使うことができる。
        // 例: double や float では 0.1 を正確に表せないが、decimal なら可能。
        // 
        // 整数型と float および double 型を 1 つの式の中で混在させることができる。
        // この場合、整数型は、浮動小数点型の 1 つに暗黙的に変換される。

        public void ExecFloatSample()
        {
            float f = 1.1F; // 1.1fも可
            int i = 1; 

            // 整数型と float および double 型を 1 つの式の中で混在させることができる。
            Console.WriteLine(f + i); // 2.1
            Console.WriteLine(f - i); // 0.100000024 floatやdoubleでは0.1を正確に表現できない
            Console.WriteLine(f * i); // 1.1
            Console.WriteLine(f / i); // 1.1
            Console.WriteLine(f % i); // 0.100000024
        }

        public void ExecDoubleSample()
        {
            double d1 = 1.1; // 少数のリテラルはdoubleとして扱われる
            double d2 = 1.1D; // 1.1dも可
            Console.WriteLine(d1);
            Console.WriteLine(d2);

            // float および double 型を 1 つの式の中で混在させることができる。
            float f = 1.1F;
            // float result = f + d1; // float と double を使って結果をfloatに入れることはできない。
            double result = f + d1;
            Console.WriteLine(result);
        }

        public void ExecDecimalSample()
        {
            decimal d = 1.2M; // 1.1mも可

            // float および double 型を 1 つの式の中で混在させることができる。
            float f = 1.1F;
            // double result = f + d; // decimal と float および double を 1 つの式の中で混在させることはできない
            Console.WriteLine(d - (decimal)f); // 0.1 明示的にdecimalにキャストする必要がある
        }
    }    
}
