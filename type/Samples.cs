using System;
using CsharpExample.Type.ClassSample;

namespace CsharpExample.Type
{
    class TypeSamples
    {
        public void Exec()
        {
            // クラスのインスタンス生成には new キーワードをつかい new クラス名()を実行
            UninitializedSampleClass uninitializedSampleClass = new UninitializedSampleClass();
            Console.WriteLine(uninitializedSampleClass.name); // 既定値が割り当てられていないので nullが返され空行が表示される
            Console.WriteLine(uninitializedSampleClass.age); // 既定値が割り当てられていないので 0が返される

            InitializedSampleClass initializedSampleClass = new InitializedSampleClass();
            Console.WriteLine(initializedSampleClass.name); // Sample Name
            Console.WriteLine(initializedSampleClass.age); // 20

            // クラスのインスタンス生成時にはコンストラクタで引数を受け取っている場合、引数を渡せる
            InitializedWithArgsSampleClass initializedWithArgsSampleClass = new InitializedWithArgsSampleClass("Arg Name", 100);
            Console.WriteLine(initializedWithArgsSampleClass.name); // Sample Name
            Console.WriteLine(initializedWithArgsSampleClass.age); // 20

            HoldingMethodSampleClass holdingMethodSampleClass = new HoldingMethodSampleClass("With Method Name", 50);
            Console.WriteLine(holdingMethodSampleClass.GetName()); // Sample Name
            Console.WriteLine(holdingMethodSampleClass.GetAge()); // Sample Name
            holdingMethodSampleClass.SetName("New name");
            holdingMethodSampleClass.SetAge(70);
            Console.WriteLine(holdingMethodSampleClass.GetName()); // Sample Name
            Console.WriteLine(holdingMethodSampleClass.GetAge()); // Sample Name

            HoldingPropertySampleClass holdingPropertySampleClass = new HoldingPropertySampleClass("Prop Name", 30);
            Console.WriteLine(holdingPropertySampleClass.Name); // Sample Name
            Console.WriteLine(holdingPropertySampleClass.Age); // Sample Name
            holdingPropertySampleClass.Name = "Property's New name";
            holdingPropertySampleClass.Age = 40;
            Console.WriteLine(holdingPropertySampleClass.Name); // Sample Name
            Console.WriteLine(holdingPropertySampleClass.Age); // Sample Name

            ClassValueSample classValueSample1 = new ClassValueSample();
            ClassValueSample classValueSample2 = new ClassValueSample();
            Console.WriteLine(ClassValueSample.classValue);
            // Console.WriteLine(classValueSample.classValue); // 外部からはクラス変数にはインスタンス経由でアクセスできない
            classValueSample1.PrintClassValue();
            ClassValueSample.classValue = "ClassValueはインスタンス間で共有される";
            classValueSample1.PrintClassValue();
            classValueSample2.PrintClassValue();


            // ReadOnlyClassValueSample.classValue = "update"; // 代入しようとすると「静的読み取り専用フィールドへの割り当てはできません」と怒られる。

            ClassMethodSample.PrintClassValue();

            PrintableClassSample printableClassSample = new PrintableClassSample("PrintableName", 20);
            Console.WriteLine(printableClassSample);

            ComparableClassSample comparableClassSample1 = new ComparableClassSample("name", 10);
            ComparableClassSample comparableClassSample2 = new ComparableClassSample("name", 10);
            Console.WriteLine(comparableClassSample1 == comparableClassSample2); // False
            Console.WriteLine(comparableClassSample1.Equals(comparableClassSample2)); // True

            NotComparableClassSample notComparableClassSample1 = new NotComparableClassSample("name", 10);
            NotComparableClassSample notComparableClassSample2 = new NotComparableClassSample("name", 10);
            Console.WriteLine(notComparableClassSample1 == notComparableClassSample2); // False
            Console.WriteLine(notComparableClassSample1.Equals(notComparableClassSample2)); // False

            // new StaticClassSample(); staticクラス 'StaticClassSample' のインスタンスを作成できない。
            StaticClassSample.PrintName();

            FiveNumbersSampleClass fiveNumbersSampleClass = new FiveNumbersSampleClass();
            // fiveNumbersSampleClass.CreateNumbers(); 派生クラス以外からは protected メソッドにはアクセスできない
            Console.WriteLine(String.Join(",", fiveNumbersSampleClass.numbers));
            TenNumbersSampleClass tenNumbersSampleClass = new TenNumbersSampleClass();
            Console.WriteLine(String.Join(",", tenNumbersSampleClass.numbers));

            InheritanceBaseSampleClass inheritanceBaseSampleClass = new InheritanceBaseSampleClass("基底クラス", 20);
            Console.WriteLine(inheritanceBaseSampleClass.CreateIntroduceMessage());
            DerivationSampleClass derivationSampleClass = new DerivationSampleClass("基底クラス", 20, "日本");
            Console.WriteLine(derivationSampleClass.CreateIntroduceMessage());
            Console.WriteLine(derivationSampleClass.CreateIntroduceMessageWithCountry());

            // インターフェースを実装したクラスの利用
            ImplementInterfaceSampleClass1 implementInterfaceSampleClass1 = new ImplementInterfaceSampleClass1("実装1", 20);
            ImplementInterfaceSampleClass2 implementInterfaceSampleClass2 = new ImplementInterfaceSampleClass2("実装2", 30, "アメリカ");

            UseInterfaceSampleClass useInterfaceSampleClassWithClass1 = new UseInterfaceSampleClass(implementInterfaceSampleClass1);
            UseInterfaceSampleClass useInterfaceSampleClassWithClass2 = new UseInterfaceSampleClass(implementInterfaceSampleClass2);
            useInterfaceSampleClassWithClass1.Greet();
            useInterfaceSampleClassWithClass2.Greet();

            // Structの利用
            StructSample structSample1 = new StructSample(1, 1);
            StructSample structSample2 = new StructSample(2, 2);
            Console.WriteLine(structSample1);
            structSample1.Move(-1, -1);
            Console.WriteLine(structSample1);
            Console.WriteLine(structSample1.CalculateDistance(structSample2));

            // Enumの利用
            Console.WriteLine(EnumSample.Value1);
            // Enumの値に設定した数値はキャストすることで取り出せる。
            Console.WriteLine((int)EnumSampleWithValue.Value1);
            // 数値からEnumの値に変換する
            EnumSampleWithValue enumValue = (EnumSampleWithValue)Enum.ToObject(typeof(EnumSampleWithValue), 200);
            Console.WriteLine(enumValue);
        }

    }
}
