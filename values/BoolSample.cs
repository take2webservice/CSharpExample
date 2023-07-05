using System;

namespace CsharpExample.Values
{
    public class BoolSample
    {
        // https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
        // C# の整数型にはshort, int, longがあり、負数を扱わない符号付きのushort, uint, ulongが存在する。
        // 
        public void ExecBoolSample()
        {
            // リテラル
            Console.WriteLine(true); // True
            Console.WriteLine(false); // False
            
            // 否定は!をつける
            Console.WriteLine(!false); // True
            Console.WriteLine(!true); // False

            // 論理演算子
            Console.WriteLine(true && true); // True
            Console.WriteLine(false || true); // True
        }

        public void ExecComparisonOperatorSample()
        {
            // 数値の比較1
            int i1 = 1;
            int i2 = 2;
            Console.WriteLine(i1 == i2); // False
            Console.WriteLine(i1 != i2); // False
            Console.WriteLine(7.1 < 7.1); // False
            Console.WriteLine(7.1 <= 7.1); // True
            Console.WriteLine(7.1 > 7.1); // False
            Console.WriteLine(7.1 >= 7.1); // True


            // 文字列の等価性の比較
            string s1 = "Sample";
            string s2 = "Sam";
            string s3 = "ple";
            Console.WriteLine(s1 == s2); // False
            Console.WriteLine(s1 == s2 + s3); // True

        }

        public void ExecIfSample()
        {
            // if文の書き方
            if (true)
            {
                Console.WriteLine("print by if");
            }

            // if_else文の書き方
            if (false)
            {
                // 到達不可
            } else {
                Console.WriteLine("print by else");
            }

            // if_else-if_else の書き方
            if (false)
            {
                // 到達不可
            } else if (false) {
                // 到達不可
            } else {
                Console.WriteLine("print by if_else-if_else");
            }
        }

        public void ExecConditionalOperatorSample()
        {
            // 三項演算子
            float temp = 31.0F;
            // condition ? consequent : alternative
            // condition が true なら consequent を返す。
            // condition が false なら alternative を返す。
            string howFeel = temp < 20.0 ? "Cold." : "Perfect!";


            // 文字列の等価性の比較
            string s1 = "Sample";
            string s2 = "Sam";
            string s3 = "ple";
            Console.WriteLine(s1 == s2); // False
            Console.WriteLine(s1 == s2 + s3); // True

        }

    }    
}
