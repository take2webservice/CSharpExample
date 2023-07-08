using System;

namespace CsharpExample.Function{
    public class LambdaSample
    {
        public void UseLambda()
        {
            // ラムダ式(匿名関数)の宣言
            // Func<引数1の型, ..., 引数nの型, 戻り値の型> で匿名関数の型を指定
            // (仮引数1, ..., 仮引数n)で引数名を指定
            // => の後に関数の中身を指定
            // 1行で処理をかける場合はreturnは不要
            Func<int, int, string> addAndToString = (x, y) => $"{x + y}";
            // 仮引数の型は以下のように指定することもできる。
            // Func<int, int, string> addAndToString = (int x, int y) => $"{x + y}";

            // 複数行のラムダ式も指定できる
            // その場合returnで明示的に戻り値を返す必要がある。
            Func<int, int, int> multiple = (x, y) =>
            {
                return x * y;
            };

            Console.WriteLine(addAndToString(100, 1));
            Console.WriteLine(multiple(200, 2));
        }

        public void UseLambdaWithArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // FindAllなど引数としてLambda式を渡す場合は型指定を省略できる。
            int[]  evenNumbers = Array.FindAll(numbers, x => x % 2 == 0);
            // 以下のように引数の型を明示することはできる。
            // int[]  evenNumbers = Array.FindAll(numbers, (int x) => x % 2 == 0);
            Console.WriteLine( string.Join(", ", evenNumbers));
        }
    }
}