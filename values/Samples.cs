
namespace CsharpExample.Values
{
    class ValueSamples
    {
        public void Exec()
        {
            // 文字のサンプル
            StringSample stringSample = new StringSample();
            stringSample.ExecCharSample();
            stringSample.ExecStringSample();

            // //整数型のサンプル動作
            // IntegerSample integerSample =  new IntegerSample();
            // integerSample.ExecIntSample();
            // integerSample.ExecLongSample();
            // integerSample.ExecCastSample();

            // // //浮動小数値型のサンプル動作
            // FloatSample floatSample = new FloatSample();
            // floatSample.ExecFloatSample();
            // floatSample.ExecDoubleSample();
            // floatSample.ExecDecimalSample();

            // //真偽値のサンプル動作
            // BoolSample boolSample = new BoolSample();
            // boolSample.ExecBoolSample();
            // boolSample.ExecComparisonOperatorSample();
            // boolSample.ExecIfSample();

            // // 定数宣言のサンプル
            // ConstSampleClass constSampleClass = new ConstSampleClass();
            // constSampleClass.Exec();

            // // 配列のサンプル動作
            // ArraySample arraySample = new ArraySample();
            // arraySample.ExecSingleDimensionalArraySample();
            // arraySample.ExecMultiDimensionalArraySample();

            // // 可変長配列のサンプル
            // ListTypeSample listTypeSample = new ListTypeSample();
            // listTypeSample.ExecListSample();
            // listTypeSample.ExecLinkedListSample();
            // listTypeSample.ExecHashSetSample();
            // // ArrayListの利用は非推奨
            // listTypeSample.ExecArrayListSample();

            // // タプル型
            // TupleSample tupleSample = new TupleSample();
            // tupleSample.ExecTupleSample();

            // // 辞書型
            // DictionarySample dictionarySample = new DictionarySample();
            // dictionarySample.ExecDictionarySample();
            // dictionarySample.ExecHashTableSample();
        }

    }
}
