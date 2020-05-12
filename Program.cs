using System;

namespace List6_16
{
    class Triangle : IZukei
    {
        public int CalcArea(int x, int y)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            int area = triangle.CalcArea(2, 3);
        }
    }
}
