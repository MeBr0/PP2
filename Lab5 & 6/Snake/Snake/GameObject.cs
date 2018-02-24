using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public abstract class GameObject //абстрактный класс содержащий основные элементы объектов
    {                                //abstract - не может быть создано экземпляров этого класса
        public List<Point> body { get; set; }      //массив точек
        public char c { get; set; }                //знак 
        public ConsoleColor color { get; set; }    //цвет

        public GameObject(Point first, ConsoleColor color, char c) //базовый конструктор
        {
            this.body = new List<Point>();
            if (first != null) this.body.Add(first);
            this.c = c;
            this.color = color;
        }
        
        public GameObject() //пустой конструктор для сериализации
        {

        }

        public void Draw() //базовый метод для рисования
        {
            Console.ForegroundColor = color;
            for(int i = 0; i < body.Count; ++i)
            {
                Console.SetCursorPosition(body[i].X, body[i].Y);
                Console.Write(c);
            }
        }
    }
}
