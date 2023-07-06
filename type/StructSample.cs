using System;

namespace CsharpExample.Type.ClassSample
{
    // strct(構造体)はclassと似た仕組み
    // structは値型で、classは参照型
    // 値型はスタックメモリに直接格納されるため、参照型と比較して高速に処理される
    // classと比べてメモリ効率が良いとされている
    // 継承ができない
    struct StructSample
    {
        public int xPoint;
        public int yPoint;

        public StructSample(int xPoint, int yPoint)
        {
            this.xPoint = xPoint;
            this.yPoint = yPoint;
        }

        public void Move(int xPoint, int yPoint)
        {
            this.xPoint += xPoint;
            this.yPoint += yPoint;
        }

        public double CalculateDistance(StructSample other)
        {
            Console.WriteLine((this.yPoint - other.yPoint));
            Console.WriteLine((this.yPoint - other.yPoint)^2);
            return Math.Sqrt(Math.Pow((this.xPoint - other.xPoint), 2) + Math.Pow((this.yPoint - other.yPoint), 2));
        }


        public override string ToString()
        {
            return $"(x: {this.xPoint}, y:{this.yPoint})";
        }
    }
}