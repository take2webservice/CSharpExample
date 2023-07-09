
namespace CsharpExample.Values
{
    class ValueSamples
    {
        public void Exec()
        {
            // //整数型のサンプル動作
            IntegerSample integerSample =  new IntegerSample();
            integerSample.ExecIntSample();
            integerSample.ExecLongSample();
            integerSample.ExecCastSample();

            // //浮動小数値型のサンプル動作
            FloatSample floatSample = new FloatSample();
            floatSample.ExecFloatSample();
            floatSample.ExecDoubleSample();
            floatSample.ExecDecimalSample();

            //真偽値のサンプル動作
            BoolSample boolSample = new BoolSample();
            boolSample.ExecBoolSample();
            boolSample.ExecComparisonOperatorSample();
            boolSample.ExecIfSample();

            // 定数宣言のサンプル
            ConstSampleClass constSampleClass = new ConstSampleClass();
            constSampleClass.Exec();
        }

    }
}
