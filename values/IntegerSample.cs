using System;

namespace CsharpExample.Values
{
    public class IntegerSample
    {
        // https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
        // C# の整数型にはshort, int, longがあり、負数を扱わない符号付きのushort, uint, ulongが存在する。
        // 
        public void ExecIntSample()
        {
            // int は　-2,147,483,648 ～ 2,147,483,647まで表現可能
            // 範囲外に出るとオーバーフローする
            int i = 1;
            Console.WriteLine(i);

            int right = 20;
            int left = 10;
            Console.WriteLine(right + left); // 足し算 30
            Console.WriteLine(right - left); // 引き算 10
            Console.WriteLine(right * left); // かけ算 200
            Console.WriteLine(right / left); // 割り算(商) 2
            Console.WriteLine(right % left); // 割り算(余) 0

            Console.WriteLine(20 / 9); // 割り算(商) 2
            Console.WriteLine(20 % 9); // 割り算(余) 2

            Console.WriteLine(int.MaxValue); // intの最大値 2147483647
            Console.WriteLine(int.MinValue); // intの最小値 -2147483648

            right += 10;
            Console.WriteLine(right); // 30
            right -= 10;
            Console.WriteLine(right); // 20
        }

        public void ExecLongSample()
        {
            // long は　-9,223,372,036,854,775,808 〜 9,223,372,036,854,775,807まで表現可能
            // 範囲外に出るとオーバーフローする
            long l = 2147483648;
            Console.WriteLine(l); // 2147483648

            long right = 2147483648;
            long left = 2;
            Console.WriteLine(right + left); // 足し算 2147483650
            Console.WriteLine(right - left); // 引き算 2147483646
            Console.WriteLine(right * left); // かけ算 4294967296
            Console.WriteLine(right / left); // 割り算(商) 1073741824
            Console.WriteLine(right % left); // 割り算(余) 0

        }

        public void ExecCastSample()
        {
            int i = 100;
            Console.WriteLine($"value: {i}, Type: {i.GetType()}"); // value: 100, Type: System.Int32

            long l = (long)i; // (型)変数 の書き方で値のキャスト(型変換)ができる
            Console.WriteLine($"value: {l}, Type: {l.GetType()}"); // value: 100, Type: System.Int64

            long l2 = 2147483649;
            Console.WriteLine((int)l2); // -2147483647 longからintへのダウンキャストにより値がオーバーフローする
        }
        
    }    
}
