﻿// ライブラリの利用時にパッケージ名を
using System;

using CsharpExample.Values;
using CsharpExample.NameSpace; // using ディレクティブを使用すると名前空間で定義された型を完全修飾名前空間を指定せずに使える
using CsharpExample.Type;
using CsharpExample.Function;
using CsharpExample.Control;

public class Program
{
    // C#5まではコードのエントリーポイントとして Main関数を明示的に作成する必要がある
    public static void Main(string[] args)
    {
        // ValueSamples valueSamples = new ValueSamples();
        // valueSamples.Exec();

        // NameSpaceSamples nameSpaceSamples = new NameSpaceSamples();
        // nameSpaceSamples.Exec();

        // TypeSamples typeSamples = new TypeSamples();
        // typeSamples.Exec();

        FunctionSamples functionSamples = new FunctionSamples();
        functionSamples.Exec();

        // ConstSampleClass constSampleClass = new ConstSampleClass();
        // constSampleClass.Exec();

        // ControlSamples controlSamples = new ControlSamples();
        // controlSamples.Exec();
    }
}