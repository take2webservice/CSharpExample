using System;

namespace CsharpExample.Control{
    public class LoopSample
    {
        // 一般的なfor文の書き方
        public void ExecForLoop()
        {
            // 以下の3つの要素を;で区切る
            // 最初にfor文で使う変数宣言
            // 次にfor文内のブロックの実行条件
            // 1ループ終了後の処理
            for (int i=0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        // brakで停止する場合のfor文の書き方
        public void ExecForLoopWithBreak()
        {
            // 以下の3つの要素を;で区切る
            // 最初にfor文で使う変数宣言
            // 次にfor文内のブロックの実行条件
            // 1ループ終了後の処理
            for (int i=0; i < 5; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }

        // continueで処理をスキップする場合のfor文の書き方
        public void ExecForLoopWithContinue()
        {
            // 以下の3つの要素を;で区切る
            // 最初にfor文で使う変数宣言
            // 次にfor文内のブロックの実行条件
            // 1ループ終了後の処理
            for (int i=0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        // foreach文の書き方
        public void ExecForEachLoop()
        {
            int[] intArray = {1, 2, 3, 4, 5};
            // foreachは
            // in の左側に取り出した値を代入する変数の宣言
            // in の右側に値を取り出す元になる配列などの変数
            // を記述する。
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
            // foreachのinの右側に配置できる変数はIEnumerableインターフェースを実装した型のインスタンス
        }

        // while文の書き方
        public void ExecWhileLoop()
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        // do-while文の書き方
        public void ExecDoWhileLoop()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 3);
        }
    }
}