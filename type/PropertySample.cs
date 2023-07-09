using System;

namespace CsharpExample.Type.ClassSample
{
    // クラス宣言
    class PropertySampleClass{
        private string name;
        private int age;

        public PropertySampleClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // プロパティは以下のように宣言する。
        // ここではNameというプロパティを介して、this.nameにアクセスするようにしている。
        // プロパティ化することで、値の設定時のバリデーションを行うことができる。
        // setの定義内では代入された値は`value`として扱える。
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("名前の長さが0です。");
                }
                this.name = value;
            }
        }

        // setを宣言していない場合、代入ができない。
        public string IntroductionMessage
        {
            get { return $"I'm {this.name}. I'm {this.age} yo."; }
        }
    }
}
