// usingを使うことで名前空間配下の要素を利用可能にできる。
using CsharpExample.OtherNameSapce;

// usingと代入を組み合わせることで別名をつけることもできる。
using AnotherNameSapceSample =  CsharpExample.OtherNameSapce.OtherNameSapceSample;

// 名前空間は . で区切る。
namespace CsharpExample.NameSpace
{
    class NameSpaceSamples
    {
        public void Exec()
        {
            // 完全修飾指名`名前空間名+クラス名`で指定すれば usingを使わなくても良いが、記述が長い。
            CsharpExample.OtherNameSapce.OtherNameSapceSample otherNameSapceSample = 
                new CsharpExample.OtherNameSapce.OtherNameSapceSample();
            otherNameSapceSample.Exec();

            // using で名前空間をインポートすることで、名前空間内のメンバー名で指定できる。
            OtherNameSapceSample shortOtherSapceSample = new OtherNameSapceSample();
            shortOtherSapceSample.Exec();

            AnotherNameSapceSample anotherNameSapceSample = new AnotherNameSapceSample();
            anotherNameSapceSample.Exec();

            // 同一の名前空間にある場合はusingは不要(privateは除く)
            SameNameSapceSample sameNameSapceSample = new SameNameSapceSample();
            sameNameSapceSample.Exec();

            // 名前空間に属さないグローバルクラスは、usingを使わず別のファイルからそのクラスを参照できる。
            NoNameNameSapceSample noNameSpace = new NoNameNameSapceSample();
            noNameSpace.Exec();
        }

    }
}
