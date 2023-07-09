using System;

namespace CsharpExample.Control{
    public class TryCatchSample
    {
        // 一般的なtry-catch文の書き方
        // 全ての例外
        public void ExecTryCatch()
        {
            try // 例外が発生しうる処理を書く
            {
                int[] intArray = {1, 2, 3};
                int i = intArray[4]; // ここで　IndexOutOfRangeExceptionが発生する。
                Console.WriteLine(i);
            }
            catch (IndexOutOfRangeException e) // IndexOutOfRangeExceptionが発生した場合の処理を書く
            {
                Console.WriteLine("無効な範囲へのアクセスです");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)  // ここまでに補足できなかった例外が発生した場合の処理を書く
            {
                Console.WriteLine("想定外の例外が発生しました。");
                Console.WriteLine(e.Message);
            }
            finally // 例外が発生しても、しなくても実行する処理を書く
            {
                Console.WriteLine("例外が発生してもしなくても実行される。");
            }
        }
    }
}