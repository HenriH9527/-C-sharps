using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    打印 Hello World 
*/

//namespace HelloWorldApplication
//{
//    class HelloWorld
//    {
//        static void Main(string[] args)
//        {
//            //my first paragram
//            Console.WriteLine("Hello World");
//            Console.ReadKey();
//        }
//    }
//}

//处理矩形的面积

namespace RectTangleApplication
{
    class Rectangle
    {
        //成员变量
        double length;
        double width;
        //声明变量
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        //计算矩形面积
        public double GetArea()
        {
            return length * width;
        }
        //输出数据
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }

    }
    /*  一些操作方法  */
    public class CalculateSize
    {
        //计算数据存储尺寸
        public void ShowSize()
        {
            Console.WriteLine("Size of int: {0}", sizeof(char));
            Console.ReadLine();
        }

        //类型转换
        public void TypeConversion()
        {
            double d = 5764.46;
            int i;

            //强制转换 double 为 int
            i = (int)d;
            Console.WriteLine(i);
            Console.ReadKey();
        }

        //接受用户输入的值
        //public void AcceptUser()
        //{
        //    int num;
        //    num = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("用户输入的值为：{0}", num);
        //}

        //转义字符
        public void EscapeChar()
        {
            Console.WriteLine("Hello\tWorld\n\n");
            Console.ReadKey();
        }
    }

    //定义常量

    class SampleClass
    {
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public SampleClass(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    class ExcuteRectangle
    {
        //程序主入口
        static void Main(string[] args)
        {
            //创建实例
            Rectangle r = new Rectangle();             //求矩形面积

            CalculateSize c = new CalculateSize();  //计算存储尺寸

            SampleClass mC = new SampleClass(11, 22);   //声明常量

            Console.WriteLine("x = {0}, y = {1}", mC.x, mC.y);

            Console.WriteLine("c1 = {0}, c2 = {1}", SampleClass.c1, SampleClass.c2);

            r.Acceptdetails();                                   //声明变量

            r.Display();                                             //计算数据并展示

            c.ShowSize();                                         //展示存储尺寸

            c.TypeConversion();                              //强制数据转换

            // c.AcceptUser();                                      //接受用户输入的值

            c.EscapeChar();                                    //转义字符

            Console.ReadLine();
        }
    }
}
