using System;
using System.Collections.Generic;

namespace CsharpExample.Type.ClassSample
{
    class VirtualInheritanceBaseSampleClass{
        
        public string? name;
        public int age;

        public VirtualInheritanceBaseSampleClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // 派生クラスで上書きされるメソッドやプロパティには`virtual`を指定しておく必要がある。
        public virtual string CreateIntroduceMessage()
        {
            return $"私の名前は{this.name}。{this.age}です。";
        }
    }

    class DerivationVirtualSampleClass: VirtualInheritanceBaseSampleClass
    {
        public string? country;

        // 派生クラスから基底クラスのコンストラクタを呼び出す場合は、ブロックの前に base() で呼び出す。
        public DerivationVirtualSampleClass(string name, int age, string country): base(name, age)
        {
            this.country = country;
            
        }

        // 派生クラスで基底クラスのメソッドやプロパティを再定義する際には`override`を指定しておく必要がある。
        public override string CreateIntroduceMessage()
        {
            return $"私の名前は{this.name}。{this.country}出身の {this.age}です。";
        }
    }
}