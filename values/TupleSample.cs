using System;

namespace CsharpExample.Values
{
    // C#でもTuple型は使える
    public class TupleSample
    {
        // Tuple型のサンプル
        public void ExecTupleSample()
        {
            (int, string, bool) tuple = (1, "hoge", true);
            // 以下のようにTupleであることを明示的に宣言することもできる。
            // ValueTuple<int, string, bool> tuple = (1, "hoge", true);

            // 値へのアクセスはItemNというプロパティを使う。
            Console.WriteLine($"int: {tuple.Item1}");
            Console.WriteLine($"string: {tuple.Item2}");
            Console.WriteLine($"bool: {tuple.Item3}");

            // 値への代入も可能
            tuple.Item1 = 2;
            Console.WriteLine($"new int: {tuple.Item1}");

            // 分解代入することもできる。
            (int intValue, string stringValue, bool boolValue) = tuple;
            Console.WriteLine($"int: {intValue}");
            Console.WriteLine($"string: {stringValue}");
            Console.WriteLine($"bool: {boolValue}");
        }
    }    
}
