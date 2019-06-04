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
        public const int C1 = 5;
        public const int C2 = C1 + 5;

        public SampleClass(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    //输出数组
    public class ArrayApplication
    {
        public int[] N1 = new int[10];
        public int I, J;
        public void Output()
        {
            //初始化数组
            for (I = 0; I < 10; I++)
            {
                N1[I] = I + 100;
            }

            //for循环输出元素
            //for (J = 0; J < 10; J++)
            //{
            //    Console.WriteLine("Element[{0}] = {1}", J, N1[J]);
            //}
            
            //foreach循环输出元素
            foreach (var j in N1)
            {
                var i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
        }
    }

    public class StringApplication
    {
        public void StringType()
        {
            //字符串  字符串连接
            string fname,  lname;
            fname = "呆呆";
            lname = "笨笨";

            string fullname = fname + lname;
            Console.WriteLine("Full name: {0}", fullname);

            //通过使用 string 构造函数
            char[] letters = { 'H', 'E', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("Greeting: {0}", greetings);

            //方法返回字符串
            string[] sarray = {"Hello", "C", "sharp"};
            string message = String.Join("", sarray);
            Console.WriteLine("Message: {0}", message);

            //用于转化值的格式化方法
            DateTime waiting = new DateTime(2019, 10, 10, 19, 20, 15);
            string chat = String.Format("Message send at:  {0:t}, on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
            Console.ReadKey();
        }
    }

    //结构体
    struct Books
    {
        private string Title;
        private string Author;
        private string Subject;
        private int Book_id;

        public void GetValues(string t, string a, string s, int id)
        {
            Title = t;
            Author = a;
            Subject = s;
            Book_id = id;
        }

        public void Display()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Author: {0}", Author);
            Console.WriteLine("Subject: {0}", Subject);
            Console.WriteLine("Book_id: {0}", Book_id);
        }
    }

    //通过抽象类和虚方法实现动态多态性

    public class shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        //虚方法
        public virtual void Draw()
        {
            Console.WriteLine("执行基类的画图任务");
        }
    }

    class Circle : shape
    {
        public override void Draw()
        {
            Console.WriteLine("画一个圆形");
            base.Draw();
        }
    }

    class Rectangles : shape
    {
        public override void Draw()
        {
            Console.WriteLine("画一个长方形");
            base.Draw();
        }
    }

    class Triangle : shape
    {
        public override void Draw()
        {
            Console.WriteLine("画一个三角形");
            base.Draw();
        }
    }



    public class ExcuteRectangle
    {
        //程序主入口
        static void Main(string[] args)
        {
            //创建实例
            Rectangle r = new Rectangle();             //求矩形面积

            CalculateSize c = new CalculateSize();  //计算存储尺寸

            SampleClass mC = new SampleClass(11, 22);   //声明常量

            ArrayApplication newArray = new ArrayApplication();                     //输出数组

            StringApplication newString = new StringApplication();                  //输出字符串

            Books book1 = new Books();

            book1.GetValues("c#高级程序设计", "阿飞", "学无止境", 12345);

            // 创建一个 List<Shape> 对象，并向该对象添加 Circle、Triangle 和 Rectangle
            var shapes = new List<shape>
            {
                new Rectangles(),
                new Circle(),
                new Triangle()
            };

            // 使用 foreach 循环对该列表的派生类进行循环访问，并对其中的每个 Shape 对象调用 Draw 方法 
            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Console.WriteLine("按任意键退出");

            Console.ReadKey();

            book1.Display();

            newString.StringType();

            newArray.Output();

            Console.WriteLine("x = {0}, y = {1}", mC.x, mC.y);

            Console.WriteLine("c1 = {0}, c2 = {1}", SampleClass.C1, SampleClass.C2);

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
