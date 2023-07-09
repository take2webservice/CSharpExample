using System;

namespace CsharpExample.Values
{
    class ConstSampleClass{
        // 定数はconstをつけて宣言する。
        public const double PI = 3.14;
        
        public void Exec()
        {
            // 関数内でも定数はconstをつけると宣言できる。
            const string HOGE = "HOGE";
            Console.WriteLine(PI);
            Console.WriteLine(HOGE);
            // HOGE = "FUGA"; 定数なので代入はできず、「代入式の左辺には変数、プロパティ、またはインデクサーを指定してください」とエラーが出る。
        }
    }
}