## C#修仙记录册

#### 简介：

C# 是一个现代的、通用的、面向对象的编程语言，它是由微软（Microsoft）开发的，由 Ecma 和 ISO 核准认可的。

#### 优势：

- 现代的、通用的编程语言。
- 面向对象
- 面向组件
- 容易学习
- 结构化语言
- 它产生高效率的程序
- 它可以在多种计算机平台上编译
- .NET框架的一部分

#### 一部分重要的功能：

- 布尔条件（Boolean Conditions）
- 自动垃圾回收（Automatic Garbage Collection）
- 标准库（Standard Library）
- 组件版本（Assembly  Versioning）
- 属性（Properties）和事件（Events）
- 委托（Delegates）和事件管理（Events Management）
- 易于使用的泛型（Generics）
- 索引器（indexers）
- 条件编译（Conditional Compilation）
- 简单的多线程（Multithreading）
- LINQ 和 Lambda 表达式
- 集成 Windows

------

#### C# 与 .NET 之间的关系：

> C# 是 .Net 框架的一部分，且用于编写 .Net 应用程序

#### .NET 框架（.Net Framework）

- windows 应用程序
- Web 应用程序
- Web 服务

> .Net 框架应用程序是多平台的应用程序。框架的设计方式使它适用于下列各种语言：C#、C++、Visual Basic、Javascript、COBOL 等等。所有这些语言可以访问框架，彼此之间也可以互相交互。

#### .Net 框架由一个巨大的代码库组成，用于 C# 等客户端语言，下面列出一些 .Net 框架的组件：

- 公共语言运行库（Common Language Runtime - CLR）
- .Net 框架类库（.Net Framework Class library）
- 公共语言规范（Common Language Specification）
- 通用类型系统（Common Type System）
- 元数据（Metadata）和组件（Assembiles）
- Windows窗体（Windows Forms）
- ASP.Net 和 ASP.Net AJAX
- ADO.Net
- Windows 工作流基础（Windows Workflow foundation - WF）
- Windows 显示基础（Windows presentation Foundation）
- Windows 通信基础（Windows Communication Foundataion - WCF）
- LINQ

#### C#的集成开发环境（Integrated Development Environment- IDE）

微软（Microsoft）提供了下列用于 C# 编程的开发工具:

- Visual Studio 2010 (VS)

- Visual C# 2010 Express (VCE)

- Visual Web Developer

## 在 Linux 或 Mac OS 上编写 C# 程序

> **Mono** 是 .NET 框架的一个开源版本，它包含了一个 C# 编译器，且可运行于多种操作系统上，比如各种版本的 Linux 和 Mac OS

------

#### C#程序包括以下几个部分：

- 命名空间声明（Namespace declaration）
- 一个 class
- Class 方法
- Class 属性
- 一个 Main 方法
- 语句（Statements） & 表达式（Expressions）
- 注释

例子：

```c#
using System;
namespace HelloWorldApplication
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            /* 我的第一个 c# 程序  */
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    }
}
```

上面程序的各个部分的功能：

- 程序的第一行  `using System` 中的  `using`关键字用于在程序中包含 `System`  命名空间。一个程序一般有多个 `using` 语句。
- 下一行是 `namespace` 声明。一个 `namespace` 里包含了一系列的类。`HelloWorldApplication`  命名空间包含了类 `HelloWorld`
- 下一行是 class 声明。类 `HelloWorld` 包含了程序使用的数据和方法声明。类一般包含多个方法。方法定义了类的行为 。在这里，`Hello World`类只有一个 `Main` 方法。
- 下一行定义了 `Main` 方法，是所有 C# 程序的主入口。`Main` 方法说明当执行时： 类将做什么动作
- 下一行 `/***/` 是注释
- `Main` 方法通过语句 `Console.WriteLine("Hello World")` ;指定了它的行为。`WriteLine` 是一个定义在 `System` 命名空间中的 `Console` 类。该语句会在屏幕上显示消息“Hello World”
- 最后一行 `Console.ReadKey()`; 是针对 VS.NET 用户的。这使得程序会等待一个按键的动作，防止程序从 Visual Studio .NET 启动时屏幕会快速运行并关闭。

##### 需要注意的：

- C# 是大小写敏感的。
- 所有的语句和表达式必须以分号（;）结尾。
- 程序的执行从 `Main` 方法开始
- 与 Java 不同的是，文件名可以不同于类的名称

------



#### C# 数据类型：

- 值类型（Value types）
- 引用类型（Reference types）
- 指针类型（Pointer types）



#### 值类型：

![1559194529825](C:\Users\Administrator\AppData\Roaming\Typora\typora-user-images\1559194529825.png)

如需得到一个类型或一个变量在特定平台上的准确尺寸，可以使用 **sizeof** 方法。表达式 *sizeof(type)* 产生以字节为单位存储对象或类型的存储尺寸

> ```c#
> using System;
> 
> namespace DataTypeApplication
> {
>     class Program
>     {
>         static void Main(string[] args)
>         {
>             Console.WriteLine("Size of int: {0}", sizeof(int));
>         }
>     }
> }
> 
> //Size of int: 4
> ```



#### 引用类型（Reference types）：



> 引用类型不包含存储在变量中的实际数据，但它们包含对变量的引用。
>
> 换句话说，它们指的是一个内存位置。使用多个变量时，引用类型可以指向一个内存位置。如果内存位置的数据是由一个变量改变的，其他变量会自动反映这种值的变化。**内置的** 引用类型有：**object**、**dynamic** 和 **string**。



##### 对象（Object）类型

> **对象（Object）类型** 是 C# 通用类型系统（Common Type System - CTS）中所有数据类型的终极基类。Object 是 System.Object 类的别名。所以对象（Object）类型可以被分配任何其他类型（值类型、引用类型、预定义类型或用户自定义类型）的值。但是，在分配值之前，需要先进行类型转换。
>
> 当一个值类型转换为对象类型时，则被称为 **装箱**；另一方面，当一个对象类型转换为值类型时，则被称为 **拆箱**。



```c#
object obj;
obj = 100;  //这是装箱
```



##### 动态（Dynamic）类型

> 您可以存储任何类型的值在动态数据类型变量中。这些变量的类型检查是在运行时发生的。

```c#
//dynamic <variable_name> = value;

dynamic d = 20;
```

> 动态类型与对象类型相似，但是对象类型变量的类型检查是在编译时发生的，而动态类型变量的类型检查是在运行时发生的。



##### 字符串（String）类型

> **字符串（String）类型** 允许您给变量分配任何字符串值。字符串（String）类型是 System.String 类的别名。它是从对象（Object）类型派生的。字符串（String）类型的值可以通过两种形式进行分配：引号和 @引号。

```c#
String str = "c sharp is awsome";
//或
@"c sharp is awesome";
```

C# string 字符串的前面可以加 @（称作"逐字字符串"）将转义字符（\）当作普通字符对待，比如：

```c#
string str = @"C:\Windows";
```

等价于：

```c#
string str = "C:\\Windows";
```

@ 字符串中可以任意换行，换行符及缩进空格都计算在字符串长度之内。

```c#
string str = @"<script type=""text/javascript"">
    <!--
    -->
    </script>";
```

> 用户自定义引用类型有：class、interface 或 delegate。



##### 指针类型（Pointer types）

> 指针类型变量存储另一种类型的内存地址。C# 中的指针与 C 或 C++ 中的指针有相同的功能。

```c#
//type* identifier;

char* cptr;
int* iptr;
```



------



#### C# 类型转换

类型转换从根本上说是类型铸造，或者说是把数据从一种类型转换为另一种类型。在 C# 中，类型铸造有两种形式：

- **隐式类型转换** - 这些转换是 C# 默认的以安全方式进行的转换, 不会导致数据丢失。例如，从小的整数类型转换为大的整数类型，从派生类转换为基类。
- **显式类型转换** - 显式类型转换，即强制类型转换。显式转换需要强制转换运算符，而且强制转换会造成数据丢失。

```c#
namespace TypeConversionApplication
{
    class ExplicitConversion
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;

            // 强制转换 double 为 int
            i = (int)d;
            Console.WriteLine(i);
            Console.ReadKey();
            
        }
    }
}
```



#### C# 类型转换方法

###### C# 提供了下列内置的类型转换方法：

| 序号 | 方法 & 描述                                                  |
| :--- | :----------------------------------------------------------- |
| 1    | **ToBoolean**<br/>如果可能的话，把类型转换为布尔型。         |
| 2    | **ToByte**<br/>把类型转换为字节类型。                        |
| 3    | **ToChar**<br/>如果可能的话，把类型转换为单个 Unicode 字符类型。 |
| 4    | **ToDateTime**<br/>把类型（整数或字符串类型）转换为 日期-时间 结构。 |
|      | **ToDecimal**<br/>把浮点型或整数类型转换为十进制类型。       |
|      | **ToDouble**<br/>把类型转换为双精度浮点型。                  |
|      | **ToInt16**<br/>把类型转换为 16 位整数类型。                 |
|      | **ToInt32**<br/>把类型转换为 32 位整数类型。                 |
|      | **ToInt64**<br/>把类型转换为 64 位整数类型。                 |
|      | **ToSbyte**<br/>把类型转换为有符号字节类型。                 |
|      | **ToSingle**<br/>把类型转换为小浮点数类型。                  |
|      | **ToString**<br/>把类型转换为字符串类型。                    |
|      | **ToType**<br/>把类型转换为指定类型。                        |
|      | **ToUInt16**<br/>把类型转换为 16 位无符号整数类型。          |
|      | **ToUInt32**<br/>把类型转换为 32 位无符号整数类型。          |
|      | **ToUInt64**<br/>把类型转换为 64 位无符号整数类型。          |



实例：

```c#
namespace TypeConversionApplication
{
    class StringConversion
    {
 		static void Main(string[] args)
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.4545;
            bool b = true;
            
            Console.WriteLine(i.toString());
            Console.WriteLine(f.toString());
            Console.WriteLine(d.toString());
            Console.WriteLine(b.toString());
            Console.ReadKey();
        }
    }
}

//75
//53.005
//234534545;
//True;
```



------

#### C# 变量

> 个变量只不过是一个供程序操作的存储区的名字。在 C# 中，每个变量都有一个特定的类型，类型决定了变量的内存大小和布局。范围内的值可以存储在内存中，可以对变量进行一系列操作。



| 类型       | 举例                                                       |
| :--------- | :--------------------------------------------------------- |
| 整数类型   | sbyte、byte、short、ushort、int、uint、long、ulong 和 char |
| 浮点型     | float 和 double                                            |
| 十进制类型 | decimal                                                    |
| 布尔类型   | true 或 false 值，指定的值                                 |
| 空类型     | 可为空值的数据类型                                         |

C# 允许定义其他值类型的变量，比如 **enum**，也允许定义引用类型变量，比如 **class**



#### C#中的变量定义与初始化

```c#
//  <data_type> <variable_list>
int i, j, k;
char c, ch;
float f, salary;
double d;

//初始化
int i = 100, j = 5;
byte z = 22;
double pi = 3.1415926;
char x = 'x';
```



#### 接受来自用户的值

**System** 命名空间中的 **Console** 类提供了一个函数 **ReadLine()**，用于接收来自用户的输入，并把它存储到一个变量中。



```c#
int num;
num = Convert.ToInt32(Console.ReadLine());

//函数 Convert.ToInt32() 把用户输入的数据转换为 int 数据类型，因为 Console.ReadLine() 只接受字符串格式的数据。
```



------

#### #一些转义序列码:

| 转义序列   | 含义                       |
| :--------- | :------------------------- |
| \\         | \ 字符                     |
| \'         | ' 字符                     |
| \"         | " 字符                     |
| \?         | ? 字符                     |
| \a         | Alert 或 bell              |
| \b         | 退格键（Backspace）        |
| \f         | 换页符（Form feed）        |
| \n         | 换行符（Newline）          |
| \r         | 回车                       |
| \t         | 水平制表符 tab             |
| \v         | 垂直制表符 tab             |
| \ooo       | 一到三位的八进制数         |
| \xhh . . . | 一个或多个数字的十六进制数 |



```c#
namespace EscapeChar
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\tWorld\n\n");
            Console.ReadLine();
        }
    }
}

//Hello  World
```



#### 定义常量

```c#
//const <data_type> <constant_name> = value;

using System;

public class ConstTest
{
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
    
    static void Main()
    {
        SampleClass mC = new SampleClass(11, 22);
        Console.WriteLine("x = {0}, y = {1}", mC.x, mC.y);
        Console.WriteLine("c1 = {0}, c2 = {1}", SampleClass.c1, SampleClass.c2);
    }
}

//x = 11, y = 22
//c1 = 5, c2 = 10

```



#### 算数运算符

| 运算符 | 描述                             | 实例             |
| :----- | :------------------------------- | :--------------- |
| +      | 把两个操作数相加                 | A + B 将得到 30  |
| -      | 从第一个操作数中减去第二个操作数 | A - B 将得到 -10 |
| *      | 把两个操作数相乘                 | A * B 将得到 200 |
| /      | 分子除以分母                     | B / A 将得到 2   |
| %      | 取模运算符，整除后的余数         | B % A 将得到 0   |
| ++     | 自增运算符，整数值增加 1         | A++ 将得到 11    |
| --     | 自减运算符，整数值减少 1         | A-- 将得到 9     |

#### 关系运算符

| 运算符 | 描述                                                         | 实例              |
| :----- | :----------------------------------------------------------- | :---------------- |
| ==     | 检查两个操作数的值是否相等，如果相等则条件为真。             | (A == B) 不为真。 |
| !=     | 检查两个操作数的值是否相等，如果不相等则条件为真。           | (A != B) 为真。   |
| >      | 检查左操作数的值是否大于右操作数的值，如果是则条件为真。     | (A > B) 不为真。  |
| <      | 检查左操作数的值是否小于右操作数的值，如果是则条件为真。     | (A < B) 为真。    |
| >=     | 检查左操作数的值是否大于或等于右操作数的值，如果是则条件为真。 | (A >= B) 不为真。 |
| <=     | 检查左操作数的值是否小于或等于右操作数的值，如果是则条件为真。 | (A <= B) 为真。   |

#### 逻辑运算符

| 运算符 | 描述                                                         | 实例              |
| :----- | :----------------------------------------------------------- | :---------------- |
| &&     | 称为逻辑与运算符。如果两个操作数都非零，则条件为真。         | (A && B) 为假。   |
| \|\|   | 称为逻辑或运算符。如果两个操作数中有任意一个非零，则条件为真。 | (A \|\| B) 为真。 |
| !      | 称为逻辑非运算符。用来逆转操作数的逻辑状态。如果条件为真则逻辑非运算符将使其为假。 | !(A && B) 为真。  |

#### 位运算符

| p    | q    | p & q | p \| q | p ^ q |
| :--- | :--- | :---- | :----- | :---- |
| 0    | 0    | 0     | 0      | 0     |
| 0    | 1    | 0     | 1      | 1     |
| 1    | 1    | 1     | 1      | 0     |
| 1    | 0    | 0     | 1      | 1     |

下表列出了 C# 支持的位运算符。假设变量 **A** 的值为 60，变量 **B** 的值为 13，则：

| 运算符 | 描述                                                         | 实例                                                         |
| :----- | :----------------------------------------------------------- | :----------------------------------------------------------- |
| &      | 如果同时存在于两个操作数中，二进制 AND 运算符复制一位到结果中。 | (A & B) 将得到 12，即为 0000 1100                            |
| \|     | 如果存在于任一操作数中，二进制 OR 运算符复制一位到结果中。   | (A \| B) 将得到 61，即为 0011 1101                           |
| ^      | 如果存在于其中一个操作数中但不同时存在于两个操作数中，二进制异或运算符复制一位到结果中。 | (A ^ B) 将得到 49，即为 0011 0001                            |
| ~      | 按位取反运算符是一元运算符，具有"翻转"位效果，即0变成1，1变成0，包括符号位。 | (~A ) 将得到 -61，即为 1100 0011，一个有符号二进制数的补码形式。 |
| <<     | 二进制左移运算符。左操作数的值向左移动右操作数指定的位数。   | A << 2 将得到 240，即为 1111 0000                            |
| >>     | 二进制右移运算符。左操作数的值向右移动右操作数指定的位数。   | A >> 2 将得到 15，即为 0000 1111                             |





```c#
using System;
namespace OperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 60;            /* 60 = 0011 1100 */  
            int b = 13;            /* 13 = 0000 1101 */
            int c = 0;           

             c = a & b;           /* 12 = 0000 1100 */ 
             Console.WriteLine("Line 1 - c 的值是 {0}", c );

             c = a | b;           /* 61 = 0011 1101 */
             Console.WriteLine("Line 2 - c 的值是 {0}", c);

             c = a ^ b;           /* 49 = 0011 0001 */
             Console.WriteLine("Line 3 - c 的值是 {0}", c);

             c = ~a;               /*-61 = 1100 0011 */
             Console.WriteLine("Line 4 - c 的值是 {0}", c);

             c = a << 2;     /* 240 = 1111 0000 */
             Console.WriteLine("Line 5 - c 的值是 {0}", c);

             c = a >> 2;     /* 15 = 0000 1111 */
             Console.WriteLine("Line 6 - c 的值是 {0}", c);
            Console.ReadLine();
        }
    }
}


//Line 1 - c 的值是 12
//Line 2 - c 的值是 61
//Line 3 - c 的值是 49
//Line 4 - c 的值是 -61
//Line 5 - c 的值是 240
//Line 6 - c 的值是 15
```



#### 赋值运算符

| 简单的赋值运算符，把右边操作数的值赋给左边操作数 | C = A + B 将把 A + B 的值赋给 C                              |                           |
| ------------------------------------------------ | ------------------------------------------------------------ | ------------------------- |
| +=                                               | 加且赋值运算符，把右边操作数加上左边操作数的结果赋值给左边操作数 | C += A 相当于 C = C + A   |
| -=                                               | 减且赋值运算符，把左边操作数减去右边操作数的结果赋值给左边操作数 | C -= A 相当于 C = C - A   |
| *=                                               | 乘且赋值运算符，把右边操作数乘以左边操作数的结果赋值给左边操作数 | C *= A 相当于 C = C * A   |
| /=                                               | 除且赋值运算符，把左边操作数除以右边操作数的结果赋值给左边操作数 | C /= A 相当于 C = C / A   |
| %=                                               | 求模且赋值运算符，求两个操作数的模赋值给左边操作数           | C %= A 相当于 C = C % A   |
| <<=                                              | 左移且赋值运算符                                             | C <<= 2 等同于 C = C << 2 |
| >>=                                              | 右移且赋值运算符                                             | C >>= 2 等同于 C = C >> 2 |
| &=                                               | 按位与且赋值运算符                                           | C &= 2 等同于 C = C & 2   |
| ^=                                               | 按位异或且赋值运算符                                         | C ^= 2 等同于 C = C ^ 2   |
| \|=                                              | 按位或且赋值运算符                                           | C \|= 2 等同于 C = C \| 2 |



#### 其他运算符

| 运算符   | 描述                                   | 实例                                                         |
| :------- | :------------------------------------- | :----------------------------------------------------------- |
| sizeof() | 返回数据类型的大小。                   | sizeof(int)，将返回 4.                                       |
| typeof() | 返回 class 的类型。                    | typeof(StreamReader);                                        |
| &        | 返回变量的地址。                       | &a; 将得到变量的实际地址。                                   |
| *        | 变量的指针。                           | *a; 将指向一个变量。                                         |
| ? :      | 条件表达式                             | 如果条件为真 ? 则为 X : 否则为 Y                             |
| is       | 判断对象是否为某一类型。               | If( Ford is Car) // 检查 Ford 是否是 Car 类的一个对象。      |
| as       | 强制转换，即使转换失败也不会抛出异常。 | Object obj = new StringReader("Hello"); StringReader r = obj as StringReader; |

------

#### C#判断语句

| 语句                                                         | 描述                                                         |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [if 语句](https://www.runoob.com/csharp/csharp-if.html)      | 一个 **if 语句** 由一个布尔表达式后跟一个或多个语句组成。    |
| [if...else 语句](https://www.runoob.com/csharp/csharp-if-else.html) | 一个 **if 语句** 后可跟一个可选的 **else 语句**，else 语句在布尔表达式为假时执行。 |
| [嵌套 if 语句](https://www.runoob.com/csharp/csharp-nested-if.html) | 您可以在一个 **if** 或 **else if** 语句内使用另一个 **if** 或 **else if** 语句。 |
| [switch 语句](https://www.runoob.com/csharp/csharp-switch.html) | 一个 **switch** 语句允许测试一个变量等于多个值时的情况。     |
| [嵌套 switch 语句](https://www.runoob.com/csharp/csharp-nested-switch.html) | 您可以在一个 **switch** 语句内使用另一个 **switch** 语句。   |

#### ? : 运算符

```c#
Exp1 ? Exp2 : Exp3;
```

------

#### C#循环

| 循环类型                                                     | 描述                                                         |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [while 循环](https://www.runoob.com/csharp/csharp-while-loop.html) | 当给定条件为真时，重复语句或语句组。它会在执行循环主体之前测试条件。 |
| [for/foreach 循环](https://www.runoob.com/csharp/csharp-for-loop.html) | 多次执行一个语句序列，简化管理循环变量的代码。               |
| [do...while 循环](https://www.runoob.com/csharp/csharp-do-while-loop.html) | 除了它是在循环主体结尾测试条件外，其他与 while 语句类似。    |
| [嵌套循环](https://www.runoob.com/csharp/csharp-nested-loops.html) | 您可以在 while、for 或 do..while 循环内使用一个或多个循环。  |



#### 循环控制语句

| [break 语句](https://www.runoob.com/csharp/csharp-break-statement.html) | 终止 **loop** 或 **switch** 语句，程序流将继续执行紧接着 loop 或 switch 的下一条语句。 |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| [continue 语句](https://www.runoob.com/csharp/csharp-continue-statement.html) | 引起循环跳过主体的剩余部分，立即重新开始测试条件。           |



------

#### C#  封装

> **封装** 被定义为"把一个或多个项目封闭在一个物理的或者逻辑的包中"。在面向对象程序设计方法论中，封装是为了防止对实现细节的访问。

一个 **访问修饰符** 定义了一个类成员的范围和可见性。C# 支持的访问修饰符如下所示：

- public: 　所有对象都可以访问
- private:　对象本身在对象内部可以访问
- protected:  只有该类对象及其子类对象可以访问
- internal:   同一个程序集的对象可以访问
- protected internal:  访问限于当前程序集或派生自包含类的类型



#### Public 访问修饰符

> Public 访问修饰符允许一个类将其成员变量和成员函数暴露给其他的函数和对象。任何公有成员可以被外部的类访问。



```c#
using System;

namespace RectangleApplication
{
    class Rectangle
    {
		//成员数量
        public double length;
        public double width;
        
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度：{0}", length);
        }
    }
    
    class ExcuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.Display();
            Console.ReadLine();
        }
    }
}
```



在上面的实例中，成员变量 `length`  `width`  被声明为 `public` ，所以它们可以被函数 `Main()`  使用 `Rectangle` 类的实例 `r`  访问。

成员函数 `Display()`  和 `GetArea()`  可以直接访问这些变量。

成员函数 `Display()`  也被声明为 `public` ，所以它也能被 `Main()` 使用 `Rectangle` 类的实例 `r`  访问



#### Private 访问修饰符

> Private 访问修饰符允许一个类将其成员变量和成员函数对其他的函数和对象进行隐藏。只有同一个类中的函数可以访问它的私有成员。即使是类的实例也不能访问它的私有成员。



```c#
using System;

namespace ReactangleApplication
{
    class Rectangle
    {
            //成员变量
        pricate double width;

        public void Acceptdetails()
        {
            Console.WriteLine("请输入长度：")
            length = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
        }
    }
    
    class ExcuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.Readline();
        }
    }
   
}
```



在上面的实例中，成员变量 length 和 width 被声明为 **private**，所以它们不能被函数 Main() 访问。

成员函数 *AcceptDetails()* 和 *Display()* 可以访问这些变量。

由于成员函数 *AcceptDetails()* 和 *Display()* 被声明为 **public**，所以它们可以被 *Main()* 使用 Rectangle 类的实例 **r** 访问



#### Protected 访问修饰符

> Protected 访问修饰符允许子类访问它的基类的成员变量和成员函数。这样有助于实现继承。



#### Internal 访问修饰符

> Internal 访问说明符允许一个类将其成员变量和成员函数暴露给当前程序中的其他函数和对象。换句话说，带有 internal 访问修饰符的任何成员可以被定义在该成员所定义的应用程序内的任何类或方法访问。



```c#
using System;

namespace ReactangleApplication
{
    class Rectangle
    {
            //成员变量
        internal double length;

        double GetArea()
        {
            return length * 2;
        }

        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
        }
    }
    
    class ExcuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.Display();
            Console.ReadLine();
        }
    }
}
```



在上面的实例中，请注意成员函数 *GetArea()* 声明的时候不带有任何访问修饰符。如果没有指定访问修饰符，则使用类成员的默认访问修饰符，即为 **private**。



## Protected Internal 访问修饰符

Protected Internal 访问修饰符允许在本类,派生类或者包含该类的程序集中访问。这也被用于实现继承。

------



#### C# 方法

一个方法是把一些相关的语句组织在一起，用来执行一个任务的语句块。<u>每一个 C# 程序至少有一个带有 Main 方法的类。</u>

要使用一个方法，您需要：

- 定义方法
- 调用方法

#### C# 中定义方法

```c#
<Access specifier> <Return Type> <Method Name>(Parameter List)
{
    Method Body
}
```



下面是方法的各个元素：

- Access Specifier: 访问修饰符，这个决定了变量或方法对于另一个类的可见性
- Return type: 返回类型，一个方法可以返回一个值。返回类型是方法返回的值得数据类型。如果方法不返回任何值，则返回类型为 void
- Method name: 方法名称，是一个唯一的标识符，且是大小写敏感的，他不能与类中声明的其他标识符相同
- Parameter list:  参数列表，使用圆括号括起来，该参数是用来传递和接受方法的数据。参数列表是指方法的参数类型、顺序和数量。参数是可选的，也就是说，一个方法可能不包含参数。
- Method body:  方法主体，包含了完成任务所需的指令集



定义方法：

```c#
class NumberManipulator
{
    public int FindMax(int num1, int num2)
    {
        //局部变量声明
        int result;
        
        if (num1 > num2)
            result = num1;
        else
            result = num2;
        return result;
    }
}
```



调用方法：

```c#
using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int FindMax(int num1, int num2)
        {
            //局部变量
            int result;
            
            if(num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }
        
        static void Main(string[] args)
        {
            //局部变量
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator();
            
            //调用 FindMax  方法
            ret = n.FindMax(a, b);
            Console.WriteLine("最大值是： {0}", ret);
            Console.ReadLine();
        }
    }
}
```



#### 递归方法调用

```c#
using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int factorial(int num)
        {
            //局部变量定义
            int result;
            
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }
        
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            
            //调用 factorial 方法
            Console.WriteLine("6 的阶乘是： {0}"， n.factorial(6));
            Console.WriteLine("6 的阶乘是： {0}"， n.factorial(7));
            Console.ReadLine();
        }
    }
}
```



#### 参数传递

三种传递方式

| 方式     | 描述                                                         |
| :------- | :----------------------------------------------------------- |
| 值参数   | 这种方式复制参数的实际值给函数的形式参数，实参和形参使用的是两个不同内存中的值。在这种情况下，当形参的值发生改变时，不会影响实参的值，从而保证了实参数据的安全。 |
| 引用参数 | 这种方式复制参数的内存位置的引用给形式参数。这意味着，当形参的值发生改变时，同时也改变实参的值。 |
| 输出参数 | 这种方式可以返回多个值。                                     |



## 按值传递参数

这是参数传递的默认方式。在这种方式下，当调用一个方法时，会为每个值参数创建一个新的存储位置。

实际参数的值会复制给形参，实参和形参使用的是两个不同内存中的值。所以，当形参的值发生改变时，不会影响实参的值，从而保证了实参数据的安全



```c#
using System;

namespace CalculatorApplication
{
    public void swap(int x, int y)
    {
        int temp;
        
        temp = x;
        x = y;
        y = temp;
    }
    
    static void Main(string[] args)
    {
        NumberManipulator n = new NumberManipulator();
        //局部变量
        int a = 100;
        int b = 200;
        
        Console.WriteLine("在交换之前， a 的值： {0}"，a);
        Console.WriteLine("在交换之前， b 的值： {0}", b);
        
        //调用函数来交换值
        n.swap(a, b);
        
        Console.WriteLine("在交换之后， a 的值： {0}"，a);
        Console.WriteLine("在交换之后， b 的值： {0}", b);
        
        Console.ReadLine();
        
        /*
        在交换之前，a 的值：100
        在交换之前，b 的值：200
        在交换之后，a 的值：100
        在交换之后，b 的值：200
        */
        
    }
}
```

结果表明，即使在函数内改变了值，值也没有发生任何的变化



#### 按引用传递参数

引用参数是一个对变量的**内存位置的引用**。当按引用传递参数时，与值参数不同的是，它不会为这些参数创建一个新的存储位置。引用参数表示与提供给方法的实际参数具有相同的内存位置。



**在 C# 中，使用 ref 关键字声明引用参数。**



```c#
using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            
            temp = x;
            x = y;
            y = temp;
        }
    }
    
    static void Main(string[] args)
    {
        NumberManipulator n = new NumberManipulator();
        
        int a = 100;
        int b = 200;
        Console.WriteLine("在交换之前，a 的值： {0}", a);
        Console.WriteLine("在交换之前，b 的值： {0}", b);
        
        //调用函数来交换值
        n.swap(ref a, ref b);
        
        Console.WriteLine("在交换之后，a 的值： {0}", a);
        Console.WriteLine("在交换之后，b 的值： {0}", b);
        
        Console.ReadLine();
    }
}

/*

交换之前，a 的值：100
在交换之前，b 的值：200
在交换之后，a 的值：200
在交换之后，b 的值：100

*/


```

结果表明，*swap* 函数内的值改变了，且这个改变可以在 *Main* 函数中反映出来。



#### 按输出传递参数

return 语句可用于只从函数中返回一个值。但是，可以使用 **输出参数** 来从函数中返回两个值。输出参数会把方法输出的数据赋给自己，其他方面与引用参数相似。



```c#
using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
        
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            
            //局部变量
            int a = 100;
            
            Console.WriteLine("在方法调用之前， a的值为： {0}", a);
            
            //调用函数来获取值
            n.getValue(out a);
            
            Console.WriteLine("在方法调用之后， a 的值为 {0}", a);
            Console.ReadLine();
        }
    }
}

//在方法调用之前，a 的值： 100
//在方法调用之后，a 的值： 5
```



提供给输出参数的变量不需要赋值。当需要从一个参数没有指定初始值的方法中返回值时，输出参数特别有用。

```c#
using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
    	public void getValues(out int x, out int y)
        {
            Console.WriteLine("请输入第一个值是：");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个值是：");
            y = Convert.ToInt32(Console.ReadLine());
        }
        
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a, b;
            
            //调用函数来获取值
            n.getValues(out a, out b);
            
            Console.WriteLine("在方法调用之后，a 的值： {0}", a);
            Console.WriteLine("在方法调用之后，b 的值： {0}", b);
            Console.ReadLine();
        }
    }
}
/*
    请输入第一个值：
    7
    请输入第二个值：
    8
    在方法调用之后，a 的值： 7
    在方法调用之后，b 的值： 8
*/
```



------

#### C# 可空类型（Nullable）

##### C#单问号 `?`  与 双问号 `??`

`?`  :  单问号用于对 int,double,bool 等无法直接赋值为 null 的数据类型进行 null 的赋值，意思是这个数据类型是 NullAble 类型的。

```c#
int? i = 3;
//等同于
Nullable<int> i = new Nullable<int>(3);

int i;  //默认值为0
int? ii; // 默认值为 null
```



`??` : 双问号 可用于判断一个变量在为 null 时返回一个指定的值。



#### C# 可空类型（Nullable）

C# 提供了一个特殊的数据类型，**nullable** 类型（可空类型），可空类型可以表示其基础值类型正常范围内的值，再加上一个 null 值。

例如，Nullable< Int32 >，读作"可空的 Int32"，可以被赋值为 -2,147,483,648 到 2,147,483,647 之间的任意值，也可以被赋值为 null 值。类似的，Nullable< bool > 变量可以被赋值为 true 或 false 或 null。

在处理数据库和其他包含可能未赋值的元素的数据类型时，将 null 赋值给数值类型或布尔型的功能特别有用。例如，数据库中的布尔型字段可以存储值 true 或 false，或者，该字段也可以未定义。

声明一个 **nullable** 类型（可空类型）的语法如下：

```c#
<data_type>?<variable_name> = null;
```

```c#
using System;

namespace CalculatorApplication
{
    class NullableAtShow
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
            
            bool? boolval = new bool?();
            
            //显示值
            
            Console.WriteLine("显示可空类型的值： {0}，{1}，{2}， {3}", num1, num2, num3, num4);
            Console.WriteLine("一个可空的布尔值： {0}", boolval);
            Console.ReadLine();
        }
    }
}

//显示可空类型的值： , 45,  , 3.14157
//一个可空的布尔值：
```



#### Null 合并运算符（ ?? ）

Null 合并运算符用于定义可空类型和引用类型的默认值。Null 合并运算符为类型转换定义了一个预设值，以防可空类型的值为 Null。Null 合并运算符把操作数类型隐式转换为另一个可空（或不可空）的值类型的操作数的类型。



如果第一个操作数的值为 null，则运算符返回第二个操作0数的值，否则返回第一个操作数的值。下面的实例演示了这点：

```c#
using System;
namespace CalculatorApplication
{
   class NullablesAtShow
   {
         
      static void Main(string[] args)
      {
         
         double? num1 = null;
         double? num2 = 3.14157;
         double num3;
         num3 = num1 ?? 5.34;      // num1 如果为空值则返回 5.34
         Console.WriteLine("num3 的值： {0}", num3);
         num3 = num2 ?? 5.34;
         Console.WriteLine("num3 的值： {0}", num3);
         Console.ReadLine();

      }
   }
}

//m3 的值： 5.34
//m3 的值： 3.14157
```

