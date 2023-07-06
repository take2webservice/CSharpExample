using System;
using System.Collections.Generic;

namespace CsharpExample.Type.ClassSample
{
    class InheritanceBaseSampleClass{
        
        public string? name;
        public int age;

        public InheritanceBaseSampleClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string CreateIntroduceMessage()
        {
            return $"私の名前は{this.name}。{this.age}です。";
        }
    }

    class DerivationSampleClass: InheritanceBaseSampleClass
    {
        public string? country;

        // 派生クラスから基底クラスのコンストラクタを呼び出す場合は、ブロックの前に base() で呼び出す。
        public DerivationSampleClass(string name, int age, string country): base(name, age)
        {
            this.country = country;
            
        }

        public string CreateIntroduceMessageWithCountry()
        {
            return $"私の名前は{this.name}。{this.country}出身の {this.age}です。";
            // return $"私の名前は{base.name}。{this.country}出身の {base.age}です。";
            // 基底クラスで宣言されたインスタンス変数には上記のように base.変数名 などでもアクセスできる。
        }
    }
}