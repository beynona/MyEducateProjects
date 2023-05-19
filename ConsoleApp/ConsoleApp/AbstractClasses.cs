using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    //мы не можем использовать конструктор абстрактного класса для создания его объекта.
    class AbstractClasses
    {
        void Print()
        {
            Figura rectangle = new Rectangle(5, 4, 34);
            rectangle.Display();
        }
    } //Абстрактные классы                   
    abstract class Figure
    {
        // абстрактный метод для получения периметра
        public abstract float Perimeter();
        // абстрактный метод для получения площади
        public abstract float Area();
    } // абстрактный класс фигуры
    class Rectangle : Figure
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangle(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }
        // переопределение получения периметра
        public override float Perimeter()
        {
            return Width * 2 + Height * 2;
        }
        // переопрелеление получения площади
        public override float Area()
        {
            return Width * Height;
        }
    } // производный класс прямоугольника
 
}
