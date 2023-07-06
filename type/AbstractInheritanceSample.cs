using System;
using System.Collections.Generic;

namespace CsharpExample.Type.ClassSample
{
    // 抽象クラスの宣言
    // 抽象クラスでは派生クラスでも使う具体的な実装と派生クラスで実装が必要なabstractメソッドを定義できる
    // 派生クラスでabstractメソッドの実装が漏れていると警告が出る。
    abstract class AbstractInheritanceBaseSampleClass{
        // インスタンス変数
        public Queue<int> numbers = new Queue<int>();

        // protectedを指定することで、派生クラスからアクセス可能にできる。
        protected abstract Queue<int> CreateNumbers();

        public AbstractInheritanceBaseSampleClass()
        {
            this.numbers = CreateNumbers();
        }        

        public int PopNumber()
        {
            return this.numbers.Dequeue();
        }
    }

    class FiveNumbersSampleClass: AbstractInheritanceBaseSampleClass
    {
        protected override Queue<int> CreateNumbers()
        {
            Queue<int> numbers = new Queue<int>();
            for (int i = 0; i < 5; i++)
            {
                numbers.Enqueue(i);
            }
            return numbers;
        }
    }

    class TenNumbersSampleClass: AbstractInheritanceBaseSampleClass
    {
        protected override Queue<int> CreateNumbers()
        {
            Queue<int> numbers = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Enqueue(i);
            }
            return numbers;
        }
    }
}