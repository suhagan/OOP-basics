using System;

namespace Lab_05_The_basics_OOP
{
    class circleClass
    {
        float PI = 3.141f;
        int _Radius;

        public circleClass(int radius)
        {
            this._Radius = radius;
        }

        public double getCircleArea()
        {
            return PI * _Radius * _Radius;
        }
    }
}
