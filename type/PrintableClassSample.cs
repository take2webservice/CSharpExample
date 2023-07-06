namespace CsharpExample.Type.ClassSample
{
    // クラス宣言
    class PrintableClassSample{
        // インスタンス変数
        public string? name;
        public int age;

        public PrintableClassSample(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // ToStringという特別なメソッドを`override`(上書き)してやることで、暗黙的に文字列化できる。
        public override string ToString()
        {
            return $"PrintableClassSample(name:{this.name}, age:{this.age})";
        }
    }
}
