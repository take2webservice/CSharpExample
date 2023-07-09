using System;

namespace CsharpExample.Values
{
    // C#での文字と文字列のサンプル
    public class StringSample
    {
        // 文字(Char)のサンプル
        // Unicodeの範囲内の1つの文字を表現するためのデータ型
        // 一般的な文字やUnicodeの範囲の文字を表現できる。
        public void ExecCharSample()
        {
            // C#ではcharを宣言する際にはシングルクォートを使う
            char c = 'あ';
            Console.WriteLine(c);
        }

        // 文字列(String)のサンプル
        public void ExecStringSample()
        {
            // C#ではstringを宣言する際にはダブルクォートを使う
            string str = "あいうえお";
            Console.WriteLine(str);

            // 文字列の長さはLengthで取得できる
            Console.WriteLine($"{str}は{str.Length}文字です");
            // 文字列が含まれるかはContainsで確認できる
            Console.WriteLine($"{str}には「いう」は含まれる? {str.Contains("いう")}");
            // 指定の文字で分割するにはSplitを使う
            string[] splited = str.Split("う");
            Console.WriteLine(string.Join(", ", splited));
        }
    }    
}
