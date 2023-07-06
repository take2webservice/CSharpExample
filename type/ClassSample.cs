namespace CsharpExample.Type.ClassSample
{
    // クラス宣言
    class UninitializedSampleClass{
        // インスタンス変数
        public string? name;
        public int age;
    }

    class InitializedSampleClass{
        // インスタンス変数
        public string? name;
        public int age;

        // コンストラクタは `クラス名()`で宣言し、ブロック(`{}`)の中でインスタンス初期化時の処理を書く
        public InitializedSampleClass()
        {
            name = "Sample Name";
            age = 20;
        }
    }


    class InitializedWithArgsSampleClass{
        // インスタンス変数
        public string name;
        public int age;

        // コンストラクタは特別なメソッド(関数)なので引数を受け取ることができる。
        public InitializedWithArgsSampleClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class HoldingMethodSampleClass{
        // privateなのでこのクラスの外からは参照できない
        private string name;
        private int age;

        public HoldingMethodSampleClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }

    class HoldingPropertySampleClass{
        // privateなのでこのクラスの外からは参照できない
        private string name;
        private int age;

        public HoldingPropertySampleClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int Age
        {
            get {return this.age;}
            set
            {
                this.age = value;
            }
        }

        public string Name
        {
            get {return this.name;}
            set
            {
                this.name = value;
            }
        }
    }
}
