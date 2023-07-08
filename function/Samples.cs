using System;
using CsharpExample.Function;

// 名前空間は . で区切る。
namespace CsharpExample.Function
{
    class FunctionSamples
    {
        public void Exec()
        {
            BasicFunctionSample basicFunctionSample = new BasicFunctionSample();
            // 引数が存在しない関数の実行
            Console.WriteLine(basicFunctionSample.ReturnMessage());
            // 戻り値が存在しない関数の実行
            basicFunctionSample.ExecVoidFunction();
            // 引数と戻り値がある関数の実行
            Console.WriteLine(basicFunctionSample.ExecWithArgument(100, 1));
            // static関数の実行
            Console.WriteLine(BasicFunctionSample.ExecStaticFunction());

            // ラムダ式の利用(詳細は実行している関数の中を見てください。)
            LambdaSample lambdaSample = new LambdaSample();
            lambdaSample.UseLambda();
            lambdaSample.UseLambdaWithArray();

            // デリゲートの利用(詳細は実行している関数の中を見てください。)
            DelegateSampleClass delegateSampleClass = new DelegateSampleClass();
            delegateSampleClass.UseDelegateAsCallback();
            delegateSampleClass.CombineDelegate();
        }
    }
}
