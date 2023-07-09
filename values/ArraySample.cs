using System;

namespace CsharpExample.Values
{
    // C#のArrayは固定長の配列で、同じ型の複数の変数を格納できる
    public class ArraySample
    {
        // 一次元の配列のサンプル
        public void ExecSingleDimensionalArraySample()
        {
            // 長さ5のint型の値を持った配列を宣言している。
            int[] blankIntArray = new int[5];
            // 配列の値を初期化していないので、intの初期値の0が入っている。
            // 配列のn番目の要素にアクセスする際には`配列型の値[n]`でアクセスできる。
            Console.WriteLine(blankIntArray[0]);
            // 配列の長さはLengthプロパティに入っている。
            Console.WriteLine(blankIntArray.Length);

            // 長さ3のstring型の値を持った配列を宣言している。
            string[] blankStringArray = new string[3];
            // 配列の値を初期化していないので、stringの初期値のnullが入っている。
            Console.WriteLine(blankStringArray[0] == null);
            
            // 配列の初期化時に値を渡すには以下のように{}で値を渡す。
            int[] intArray = new int[] {1, 2, 3, 4, 5, 6};
            // int[] intArray = {1, 2, 3, 4, 5, 6}; のように右辺の型指定を省略できる

            Console.WriteLine(intArray[0]);
            intArray[0] = 100;
            // 配列型の値の中の要素を置き換えるには左辺に`intArray[0]`のように要素を指定する
            Console.WriteLine(intArray[0]);
        }

        public void ExecMultiDimensionalArraySample()
        {
            // 多次元の配列は以下のように宣言する
            int[, ] twoByThreeIntArray = new int[2, 3];
            // twoByThreeArray[0]のようにして一括で値を取得することはできない。
            // 要素には1つずつアクセスする必要がある。
            Console.WriteLine(twoByThreeIntArray[0, 0]); // 初期化されていないので0が出る
            
            char[, ] twoByThreeCharArray = new char[2, 3]{
                {'a', 'b', 'c'},
                {'d', 'e', 'f'}
            };
            Console.WriteLine(twoByThreeCharArray[0, 0]); // a
            Console.WriteLine(twoByThreeCharArray[0, 1]); // b
            Console.WriteLine(twoByThreeCharArray[1, 0]); // d

            // 2次元配列ではLengthは2次元配列の要素の総数(行数と列数の積)を返します。
            Console.WriteLine(twoByThreeCharArray.Length); //6
            // 2次元配列では次元数を返すRankは常に2を返します。
            Console.WriteLine(twoByThreeCharArray.Rank); //2

            // これらを利用してfor文で全要素を取得できる。
            for (int i=0; i < twoByThreeCharArray.Rank; i++)
            {
                for (int j=0; j < twoByThreeCharArray.Length/twoByThreeCharArray.Rank; j++)
                Console.WriteLine(twoByThreeCharArray[i, j]);
            }

            // GetLengthで行、列の要素数をそれぞれ取得することもできる。
            Console.WriteLine(twoByThreeCharArray.GetLength(0)); // 行数 2
            Console.WriteLine(twoByThreeCharArray.GetLength(1)); // 列数 3
        }        
    }    
}
