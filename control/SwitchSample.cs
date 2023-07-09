using System;

namespace CsharpExample.Control{
    public class SwitchSample
    {
        public void ExecSwitch()
        {
            // ランダムな値を生成する。
            Random random = new Random();
            int i = random.Next(0, 10); // 0から9のいずれかが返る
            switch (i)
            {
                case 1:
                    Console.WriteLine("1でした");
                    break;
                case 2:
                    Console.WriteLine("2でした");
                    break;
                default:
                    Console.WriteLine("1, 2以外でした");
                    break;
            } 
        }

        // C# 8.0からはswitch式が使える
        // 式なので値を返すことができる。
        public string ExecSwitchExpression(int i)
        {
            // iの値に応じた処理を => を挟む形で書きます。
            string message = i switch
            {
                1 => "1でした",
                2 => "2でした",
                _ => "1, 2以外でした", // _ はいずれにも一致しなかった場合の処理
            };
            return message;
        }

        // C# 8.0からはswitch式が使える
        // 式なので値を返すことができる。
        public string ExecSwitchExpressionWithCompare(int i)
        {
            // iの値に応じた処理を => を挟む形で書きます。
            string message = i switch
            {
                > 5 => "5より大きい値でした",
                5 => "5でした",
                > 2 => "5より小さく、2より大きい値でした",
                _ => "2以下でした"
            };
            return message;
        }

        public string ExecPatternMatchingWithType(object obj)
        {
            // パータンマッチングとsitch式を組み合わせた例
            return obj switch
            {
                // データ型に応じて
                int i => $"integer: {i}",
                string str => $"string: {str}",
                bool b => $"boolean: {b}",
                _ => "It's an unknown value"
            };
        }

        public string ExecPatternMatchingWithTypeAndComare(object obj)
        {
            // パータンマッチングとsitch式を組み合わせた例
            return obj switch
            {
                // データ型と値の比較に応じて分岐させるには when を使う。
                int i when i > 0 => $"integer: {i}: 0より大きい",
                int i  => $"integer: {i}: 0より以下",
                string str when str.Length == 0 => $"string: {str}: 空文字",
                string str  => $"string: {str}: {str.Length}文字",
                bool b when b => $"boolean: {b}: true",
                bool b => $"boolean: {b}: false",
                _ => "It's an unknown value"
            };
        }
    }
}