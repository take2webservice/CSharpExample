using System;

namespace CsharpExample.Type.ClassSample
{
    // クラス宣言
    class ComparableClassSample{
        // インスタンス変数
        public string name;
        public int age;

        public ComparableClassSample(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override bool Equals(Object? other)
        {
            // 比較対象のobjがnullもしくは型が違う場合は違うものとして扱う
            if ((other == null) || ! this.GetType().Equals(other.GetType()))
            {
                return false;
            }
            else {
                ComparableClassSample otherCompareable = (ComparableClassSample) other;
                return (this.name == otherCompareable.name) && (this.age == otherCompareable.age);
            }
        }

        public override int GetHashCode()
        {
            return (this.name + this.age).GetHashCode();
        }
    }

    class NotComparableClassSample{
        // インスタンス変数
        public string name;
        public int age;

        public NotComparableClassSample(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
