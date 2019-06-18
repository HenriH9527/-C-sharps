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



------

### C# 数组

> 数组是一个存储相同类型元素的固定大小的顺序集合。数组是用来存储数据的集合，通常认为数组是一个同一类型变量的集合。
>
> 

##### 声明数组

```c#
double[] blance;
```

##### 初始化数组

```c#
double[] balance = new double[10];
```



声明一个数组不会在内存中初始化数组。当初始化数组变量时，您可以赋值给数组。

数组是一个引用类型，所以您需要使用 **new** 关键字来创建数组的实例。



##### 赋值给数组

###### 可以通过使用索引号赋值给一个单独的数组元素，比如：

```c#
double[] balance = new double[10];
balance[0] = 4500.0;
```

###### 可以在声明数组的同时给数组赋值，比如：

```c#
double[] balance = { 2300.0, 45487.3, 4547.6 };
```

###### 可以创建并初始化一个数组

```c#
int [] marks = new int[5] { 99, 98, 93, 55 };
```

###### 也可以赋值一个数组变量到另一个目标数组变量中。在这种情况下，目标和源会指向相同的内存位置：

```c#
int [] marks = new int[] { 8, 7, 6, 33, 4 };
int[] score = marks;
```

*当您创建一个数组时，C# 编译器会根据数组类型隐式初始化每个数组元素为一个默认值。例如，int 数组的所有元素都会被初始化为 0。*



#### 访问数组元素

> 元素是通过带索引的数组名称来访问的。这是通过把元素的索引放置在数组名称后的方括号中来实现的。例如：

```c#
double salary = balance[3]
```



```c#
using System;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
         	int [] n = new int[10];
            inti, j;
            
            /* 初始化数组 */
            for ( i =0; i < 10; i++ )
            {
                n [ i ] = i + 100;
            }
            
            //输出每个数组元素的值
            for ( j = 0; j < 10; j++ )
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            Console.ReadKey()
        }
    }
}
//Element[0] = 100
//Element[1] = 101
//Element[2] = 102
//Element[3] = 103
//Element[4] = 104
//Element[5] = 105
//Element[6] = 106
//Element[7] = 107
//Element[8] = 108
//Element[9] = 109
```



#### 使用 foreach 循环

```c#
using System;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int [] n = new int[10];
            
            //初始化数组
            for ( int i = 0; i < 10; i++ )
            {
                n[i] = 100 + i;
            }
            
            //输出每个数组元素
            foreach( int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i ,j);
            }
            Console.ReadKey();
        }
    }
}
//Element[0] = 100
//Element[1] = 101
//Element[2] = 102
//Element[3] = 103
//Element[4] = 104
//Element[5] = 105
//Element[6] = 106
//Element[7] = 107
//Element[8] = 108
//Element[9] = 109
```



#### C# 数组细节

| 概念           | 描述                                                         |
| :------------- | :----------------------------------------------------------- |
| 多维数组       | C# 支持多维数组。多维数组最简单的形式是二维数组。            |
| 交错数组       | C# 支持交错数组，即数组的数组。                              |
| 传递数组给函数 | 您可以通过指定不带索引的数组名称来给函数传递一个指向数组的指针。 |
| 参数数组       | 这通常用于传递未知数量的参数给函数。                         |
| Array 类       | 在 System 命名空间中定义，是所有数组的基类，并提供了各种用于数组的属性和方法。 |



------

#### C# 字符串

##### 创建 String 对象

- 通过给 String 变量指定一个字符串
- 通过使用 String 类构造函数
- 通过使用字符串串联运算符（ + ）
- 通过检索属性或调用一个返回字符串的方法
- 通过格式化方法来转换一个值或对象为它的字符串表示形式



```c#
using System;

namespace StringApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串，字符串连接
            string fname, lname;
            fname = "Benben";
            lname = "Daidai";
            
            string fullname = fname + lname;
            Console.WriteLine("Full Nme: {0}", fullname);
            
            //通过使用 string 构造函数
            char[] letters = { 'H', 'e', 'l',	 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);
            
            //方法返回字符串
            string[] sarray = { "Hello", "From", "Tutorials", "point" };
            string message = String.join("", sarray);
            Console.WriteLine("Message :{0}", message);
            
            //用于转化值得格式化方法
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
            Console.ReadKey();
        }
    }
}

//Full Name: RowanAtkinson
//Greetings: Hello
//Message: Hello From Tutorials Point
//Message: Message sent at 17:58 on Wednesday, 10 October 2012
```



#### String 类的属性

| 序号 | 属性名称 & 描述                                              |
| :--- | :----------------------------------------------------------- |
| 1    | **Chars** 在当前 *String* 对象中获取 *Char* 对象的指定位置。 |
| 2    | **Length** 在当前的 *String* 对象中获取字符数。              |



#### String 类的方法

| 序号 | 方法名称 & 描述                                              |
| :--- | :----------------------------------------------------------- |
| 1    | **public static int Compare( string strA, string strB )**  比较两个指定的 string 对象，并返回一个表示它们在排列顺序中相对位置的整数。该方法区分大小写。 |
| 2    | **public static int Compare( string strA, string strB, bool ignoreCase )**  比较两个指定的 string 对象，并返回一个表示它们在排列顺序中相对位置的整数。但是，如果布尔参数为真时，该方法不区分大小写。 |
| 3    | **public static string Concat( string str0, string str1 )**  连接两个 string 对象。 |
| 4    | **public static string Concat( string str0, string str1, string str2 )**  连接三个 string 对象。 |
| 5    | **public static string Concat( string str0, string str1, string str2, string str3 )**  连接四个 string 对象。 |
| 6    | **public bool Contains( string value )**  返回一个表示指定 string 对象是否出现在字符串中的值。 |
| 7    | **public static string Copy( string str )**  创建一个与指定字符串具有相同值的新的 String 对象。 |
| 8    | **public void CopyTo( int sourceIndex, char[] destination, int destinationIndex, int count )**  从 string 对象的指定位置开始复制指定数量的字符到 Unicode 字符数组中的指定位置。 |
| 9    | **public bool EndsWith( string value )**  判断 string 对象的结尾是否匹配指定的字符串。 |
| 10   | **public bool Equals( string value )**  判断当前的 string 对象是否与指定的 string 对象具有相同的值。 |
| 11   | **public static bool Equals( string a, string b )**  判断两个指定的 string 对象是否具有相同的值。 |
| 12   | **public static string Format( string format, Object arg0 )**  把指定字符串中一个或多个格式项替换为指定对象的字符串表示形式。 |
| 13   | **public int IndexOf( char value )**  返回指定 Unicode 字符在当前字符串中第一次出现的索引，索引从 0 开始。 |
| 14   | **public int IndexOf( string value )**  返回指定字符串在该实例中第一次出现的索引，索引从 0 开始。 |
| 15   | **public int IndexOf( char value, int startIndex )**  返回指定 Unicode 字符从该字符串中指定字符位置开始搜索第一次出现的索引，索引从 0 开始。 |
| 16   | **public int IndexOf( string value, int startIndex )**  返回指定字符串从该实例中指定字符位置开始搜索第一次出现的索引，索引从 0 开始。 |
| 17   | **public int IndexOfAny( char[] anyOf )**  返回某一个指定的 Unicode 字符数组中任意字符在该实例中第一次出现的索引，索引从 0 开始。 |
| 18   | **public int IndexOfAny( char[] anyOf, int startIndex )**  返回某一个指定的 Unicode 字符数组中任意字符从该实例中指定字符位置开始搜索第一次出现的索引，索引从 0 开始。 |
| 19   | **public string Insert( int startIndex, string value )**  返回一个新的字符串，其中，指定的字符串被插入在当前 string 对象的指定索引位置。 |
| 20   | **public static bool IsNullOrEmpty( string value )**  指示指定的字符串是否为 null 或者是否为一个空的字符串。 |
| 21   | **public static string Join( string separator, string[] value )**  连接一个字符串数组中的所有元素，使用指定的分隔符分隔每个元素。 |
| 22   | **public static string Join( string separator, string[] value, int startIndex, int count )**  连接接一个字符串数组中的指定位置开始的指定元素，使用指定的分隔符分隔每个元素。 |
| 23   | **public int LastIndexOf( char value )**  返回指定 Unicode 字符在当前 string 对象中最后一次出现的索引位置，索引从 0 开始。 |
| 24   | **public int LastIndexOf( string value )**  返回指定字符串在当前 string 对象中最后一次出现的索引位置，索引从 0 开始。 |
| 25   | **public string Remove( int startIndex )**  移除当前实例中的所有字符，从指定位置开始，一直到最后一个位置为止，并返回字符串。 |
| 26   | **public string Remove( int startIndex, int count )**  从当前字符串的指定位置开始移除指定数量的字符，并返回字符串。 |
| 27   | **public string Replace( char oldChar, char newChar )**  把当前 string 对象中，所有指定的 Unicode 字符替换为另一个指定的 Unicode 字符，并返回新的字符串。 |
| 28   | **public string Replace( string oldValue, string newValue )**  把当前 string 对象中，所有指定的字符串替换为另一个指定的字符串，并返回新的字符串。 |
| 29   | **public string[] Split( params char[] separator )**  返回一个字符串数组，包含当前的 string 对象中的子字符串，子字符串是使用指定的 Unicode 字符数组中的元素进行分隔的。 |
| 30   | **public string[] Split( char[] separator, int count )**  返回一个字符串数组，包含当前的 string 对象中的子字符串，子字符串是使用指定的 Unicode 字符数组中的元素进行分隔的。int 参数指定要返回的子字符串的最大数目。 |
| 31   | **public bool StartsWith( string value )**  判断字符串实例的开头是否匹配指定的字符串。 |
| 32   | **public char[] ToCharArray()** 返回一个带有当前 string 对象中所有字符的 Unicode 字符数组。 |
| 33   | **public char[] ToCharArray( int startIndex, int length )**  返回一个带有当前 string 对象中所有字符的 Unicode 字符数组，从指定的索引开始，直到指定的长度为止。 |
| 34   | **public string ToLower()** 把字符串转换为小写并返回。       |
| 35   | **public string ToUpper()** 把字符串转换为大写并返回。       |
| 36   | **public string Trim()** 移除当前 String 对象中的所有前导空白字符和后置空白字符。 |



```c#
using System;

name StringApplication
{
	class stringProg
	{
		static void Main(string[] args)
		{
			string str1 = "this is test";
			string str2 = "this is text";
			
			if (String.Compare(str1, str2) == 0)
			{
				Console.WriteLine(str1 + " and " + str2 + "are equal");
			}
			else
			{
				Console.WriteLine(str1 + " and " + str2 + "are not equal");
			}
			
			Console.ReadKey();
		}
	}
}

//this is test and This is text are not equal.
```



###### 获取字符串

```c#
using System;

namepace StringApplication
{
	class StringProg
	{
		static void Main(string[] args)
		{
			string str = "Last night i dream of San Pedro";
			Console.WriteLine(str);
			string substr = str.Substring(23);
			Console.WriteLine(substr);
			Console.ReadKey();
		}
	}
}

//Last night I dreamt of San Pedro
//San Pedro
```



###### 连接字符串

```c#
using System;

namespace StringApplication
{
    class StringProg
    {
        static void Main(string[] args)
        {
            string[] starry = new string[] {"Down the way nights are dark", "and the sun shines daily on the mountain top", "I took a trip on a sailing ship", "And when I reached Jamaica", "I made a shop"};
            string str = String.Join("\n", starry);
            
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}

//Down the way nights are dark
//And the sun shines daily on the mountain top
//I took a trip on a sailing ship
//And when I reached Jamaica
//I made a stop
```



------

#### C# 结构体

> 在 C# 中，结构体是值类型数据结构。它使得一个单一变量可以存储各种数据类型的相关数据。**struct** 关键字用于创建结构体。



结构体是用来代表一个记录。假设您想跟踪图书馆中书的动态。您可能想跟踪每本书的以下属性：

- Title
- Author
- Subject
- Book ID



#### 定义结构体

为了定义一个结构体，必须使用 struct 语句。struct 语句为程序定义了一个带有多个成员的新的数据类型。

```c#
struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;
}
```



下面的程序演示了结构的用法：

```c#
using System;
using System.Text;

struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;
}

public class testStructure
{
    public static void Main(string[] args)
    {
        // 声明 Book1 Book2  类型为Book
        Books Book1;
        Books Book2;
        
        //Book1 详述
        Book1.title = "C Programing";
        Book1.author = "Zara Ali";
        Book1.subject = "Telecom Billing Tutorial";
        Book1.book_id = 45724;
        
        //打印 Book1 信息
        Console.WriteLine("Book 1 title : {0}", Book1.title);
        Console.WriteLine("Book 1 author : {0}", Book1.author);
        Console.WriteLine("Book 1 subject : {0}", Book1.subject);
        Console.WriteLine("Book 1 book_id : {0}", Book1.book_id);
        
        Console.ReadKey();
    }
}

//Book 1 title : C Programming
//Book 1 author : Nuha Ali
//Book 1 subject : C Programming Tutorial
//Book 1 book_id : 45724
```



#### C#结构的特点

- 结构可带有方法、字段、索引、属性、运算符方法和事件。
- 结构可定义构造函数，但不能定义析构函数。但是，您不能为结构定义默认的构造函数。默认的构造函数是自动定义的，且不能被改变。
- 与类不同，结构不能继承其他的结构或类。
- 结构不能作为其他结构或类的基础结构。
- 结构可实现一个或多个接口。
- 结构成员不能指定为 abstract、virtual 或 protected。
- 当您使用 **New** 操作符创建一个结构对象时，会调用适当的构造函数来创建结构。与类不同，结构可以不使用 New 操作符即可被实例化。
- 如果不使用 New 操作符，只有在所有的字段都被初始化之后，字段才被赋值，对象才被使用。



#### 类 VS 结构

类和结构有以下几个基本的不同点：

- 类是引用类型，结构是值类型。
- 结构不支持继承。
- 结构不能声明默认的构造函数。



```c#
using System;
using System.Text;

struct Books
{
    private string title;
    private string author;
    private string subject;
    private int bool_id;
    public void getValues(string t, string a, string s, int id)
    {
        title = t;
        author = a;
        subject = s;
        book_id = id;
    }
    
    public void display()
    {
        Console.WriteLine("Tilte: {0}", title);
        Console.WriteLine("Author: {0}", author);
        Console.WriteLine("Subject: {0}", subject);
        Console.WriteLine("Book_id: {0}", book_id);
    }
};

public class testStructure
{
    public static void Main(string[] args)
    {
        Books Book1 = new Books();
        Books Book2 = new Books();
        
        //Book1 详述
        Book1.getValues("C Programing", "Nuha Ali", "telecom billing", 454564);
        
        //打印 Book 的信息
        Book1.display();
    }
}
/*
Title : C Programming
Author : Nuha Ali
Subject : C Programming Tutorial
Book_id : 6495407
*/
```



------

#### C#  枚举

> 枚举是一组命名整型常量。枚举类型是使用 **enum** 关键字声明的。
>
> C# 枚举是值类型。换句话说，枚举包含自己的值，且不能继承或传递继承。



#### 声明 enum 变量

```c#
enum <enum_name>
{
	enumeration list
};
```



其中：

- *enum_name* 指定枚举的类型名称。
- *enumeration list* 是一个用逗号分隔的标识符列表。



枚举列表中的每个符号代表一个整数值，一个比它前面的符号大的整数值。默认情况下，第一个枚举符号的值是 0.例如：

```c#
enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
```



```c#
using System;

public class EnumTest
{
    enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
    
    static void Main()
    {
        int x = (int)Day.Sun;
        int y = (int)Day.Fri;
        Console.WriteLine("Sun = {0}", x);
        Console.WriteLine("Fri = {0}", y);
    }
}

//Sun = 0
//Fri = 5
```



------

#### c# 类（Class）

> 当你定义一个类时，你定义了一个数据类型的蓝图。这实际上并没有定义任何的数据，但它定义了类的名称意味着什么，也就是说，类的对象由什么组成及在这个对象上可执行什么操作。对象是类的实例。构成类的方法和变量成为类的成员。



#### 类的定义

> 类的定义是以关键字 **class** 开始，后跟类的名称。类的主体，包含在一对花括号内。下面是类定义的一般形式：

```c#
<access specifier> class class_name
{
    //member variables
    <access specifier> <data type> variable1;
    <access specifier> <data type> variable2;
    ...
        
    <access specifier> <data type> varialben;
    //member methods
    <access specifier> <return type> method1(paramter_list)
    {
        //method body
    }
}
```



注意：

- 访问标识符 <access specifier> 指定了对类及其成员的访问规则。如果没有指定，则使用默认的访问标识符。类的默认访问标识符是 **internal**，成员的默认访问标识符是 **private**。
- 数据类型 <data type> 指定了变量的类型，返回类型 <return type> 指定了返回的方法返回的数据类型。
- 如果要访问类的成员，你要使用点（.）运算符。
- 点运算符链接了对象的名称和成员的名称。



```c#
using System;

namespace BoxApplication
{
    class Box
    {
        public double Length;
        public double Breadth;
        public double Height;
    }
    
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            double volume = 0.0;   //体积
            
            //Box1 详述
            Box1.Height = 5.0;
            Box1.Length = 6.0;
            Box1.Breadth = 7.0;
            
            //Box1体积
            volume = Box1.Height * Box1.Length * Box1.Breadth;
            Console.WriteLine("Box1 的体积：{0}", volume);
            Console.ReadKey();
        }
    }
}

//Box1 的体积： 210
```



#### 成员函数和封装

> 类的成员函数是一个在类定义中有它的定义或原型的函数，就像其他变量一样。作为类的一个成员，它能在类的任何对象上操作，且能访问该对象的类的所有成员。
>
> 成员变量是对象的属性（从设计角度），且它们保持私有来实现封装。这些变量只能使用公共成员函数来访问。



```c#
using System;

namespace BoxApplication
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;
        public void setLength( double len )
        {
            length = len;
        }
        
        public void setBreadth( double bre )
        {
            breadth = bre;
        }
        
        public void setHeight( double hei )
        {
            height = hei;
        }
        
        public double getVolume()
        {
            return length * height * breadth;
        }
    }
    
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            double volume;
            
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(8.0);
            
            volume = Box1.getVolume();
            Console.WriteLine("Box1的体积：{0}", volume);
            Console.ReadKey();
        }
    }
}

//Box1 的体积： 210
```



#### C#中的构造函数

> 类的 **构造函数** 是类的一个特殊的成员函数，当创建类的新对象时执行。
>
> 构造函数的名称与类的名称完全相同，它没有任何返回类型。



```c#
using System;

namespace LineApplication
{
    class Line
    {
        private double length;
        public line()
        {
            Console.WriteLine("对象已创建");
        }
        
        public void setLength( double len )
        {
            length = len;
        }
        
        public double getLength()
        {
            return length;
        }
        
        static void Main(string[] args)
        {
            Line line = new Line();
            
            line.setLength(6.0);
            Console.WriteLine("线条的长度：{0}", line.getLength());
            Console.ReadKey();
        }
    }
}

//对象已创建
//线条的长度： 6
```



**默认的构造函数**没有任何参数。但是如果你需要一个带有参数的构造函数可以有参数，这种构造函数叫做**参数化构造函数**。这种技术可以帮助你在创建对象的同时给对象赋初始值，具体请看下面实例：

```c#
using System;

namespace LineApplication
{
    class Line
    {
        private double length;
        public Line( double len )  //参数化构造函数
        {
            Console.WriteLine("对象已创建，length = {0}", len);
            length = len;
        }
        
        public void setLength( double len )
        {
            length = len;
        }
        
        public double getLength()
        {
            return length;
        }
        
        static void Main(string[] args)
        {
            Line line = new Line(10.0);
            Console.WriteLine("线条的长度：{0}", line.getLength*());
            
            line.setLength(6.0);
            Console.WriteLine("线条的长度：{0}", line.getLength());
            Console.ReadKey();
        }
    }
}

//对象已创建，length = 10
//线条的长度： 10
//线条的长度： 6
```



#### 析构函数

> 类的 **析构函数** 是类的一个特殊的成员函数，当类的对象超出范围时执行。
>
> 析构函数的名称是在类的名称前加上一个波浪形（~）作为前缀，它不返回值，也不带任何参数。
>
> 析构函数用于在结束程序（比如关闭文件、释放内存等）之前释放资源。析构函数不能继承或重载。



```c#
using System;

namespace LineApplication
{
    class Line
    {
        private double length;
        public Line()
        {
            Console.WriteLine("我是构造函数，对象已创建");
        }
        
        ~Line()
        {
            Console.WriteLine("我是析构函数，对象已删除");
        }
        
        public void setLength( double len )
        {
            length = len;
        }
        
        public double getLength()
        {
            return length;
        }
        
        static void Main(string[] args)
        {
            Line line = new Line();
            
            line.setLength(6.0);
            Console.WriteLine("线条的长度：{0}", line.getLength());
        }
    }
}

//我是构造函数，对象已创建
//线条的长度： 6
//我是析构函数，对象已删除
```



#### C# 类的静态成员

> 我们可以使用 **static** 关键字把类成员定义为静态的。当我们声明一个类成员为静态时，意味着无论有多少个类的对象被创建，只会有一个该静态成员的副本。
>
> 关键字 **static** 意味着类中只有一个该成员的实例。静态变量用于定义常量，因为它们的值可以通过直接调用类而不需要创建类的实例来获取。静态变量可在成员函数或类的定义外部进行初始化。你也可以在类的定义内部初始化静态变量。
>
> 下面的实例演示了**静态变量**的用法：



```c#
using System;

namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num;
        public void count()
        {
            num++
        }
        public int getNum()
        {
            return num;
        }
    }
    
    class StaticTester
    {
        static void Main(string[] args)
        {
            StaticVar s1 = new StaticVar();
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("s1 的变量num: {0}", s1.getNum);
            Console.ReadKey();
        }
    }
}

//s1 的变量 num： 6
```



你也可以把一个**成员函数**声明为 **static**。这样的函数只能访问静态变量。静态函数在对象被创建之前就已经存在。

```c#
using System;

namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num;
        public void count()
        {
            num++;
        }
        public static int getNum()
        {
            return num;
        }
    }
    
    class StaticTester
    {
        static void Main(string[] args)
        {
            StataticVar s = new StaticVar();
            s.count();
            s.count();
            s.count();
            Console.WriteLine("变量 num: {0}", StaticVar.getNum());
            Console.ReadKey();
        }
    }
}

//变量 num ： 3
```



------

#### C# 继承

> 继承是面向对象程序设计中最重要的概念之一。继承允许我们根据一个类来定义另一个类，这使得创建和维护应用程序变得更容易。同时也有利于重用代码和节省开发时间。



> 当创建一个类时，程序员不需要完全重新编写新的数据成员和成员函数，只需要设计一个新的类，继承了已有的类的成员即可。这个已有的类被称为的**基类**，这个新的类被称为**派生类**。



> 继承的思想实现了 **属于（IS-A）** 关系。例如，哺乳动物 **属于（IS-A）** 动物，狗 **属于（IS-A）** 哺乳动物，因此狗 **属于（IS-A）** 动物。



#### 基类和派生类

一个类可以派生自多个类或接口，这意味着它可以从多个基类或接口继承数据和函数。

```c#
<访问修饰符> class <基类>
{
	....
}

class <派生类> ：<基类>
{
	...
}
```

假设，有一个基类 Shape，它的派生类是 Rectangle：

```c#
using System;

namespace InheritanceApplication
{
    class Shape
    {
        public void setWidth(int w)
        {
     		width = w;       
        }
        
        public void setHeight( int h )
        {
            height = h;
        }
        
        protected int width;
        protected int height;
    }
    
    //派生类
    class Rectangle: shape
    {
    	public int getArea()
    	{
    		return (width * height);
    	}
    }
    
    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            
            Rect.setWidth(5);
            Rect.setHeight(7);
            
            //打印对象面积
            Console.WriteLine("总面积：{0}", Rect.getArea());
            Console.ReadKey();
        }
    }
}

//总面积： 35
```



#### 基类的初始化

派生类继承了基类的成员变量和成员方法。因此父类对象应在子类对象创建之前被创建。您可以在成员初始化列表中进行父类的初始化。



```c#
using System;

namespace RectangleApplication
{
    class Rectangle
    {
        //成员变量
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        
        public double GetArea()
        {
            return length * width;
        }
        
        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
         	Console.WriteLine("宽度： {0}", width);
         	Console.WriteLine("面积： {0}", GetArea());
        }
    }
    
    class Tabletop: Rectangle
    {
    	private double cost;
    	public Tabletop( double l, double w ) : base( l, w )
    	{
    		
    	}
    	public double GetCost()
    	{
    		double cost;
    		cost = GetArea() * 70;
    		return cost;
    	}
    	
    	public void Display()
    	{
    		base.Display();
    		Console.WriteLine("成本： {0}", getCost());
    	}
    	
    	class ExcuteRectangle
    	{
    		static void Main(string[] args)
    		{
    			Tabletop t = new Tabletop(4.5, 7.5);
    			t.Display();
    			Console.ReadLine();
    		}
    	}
    }
}

//长度： 4.5
//宽度： 7.5
//面积： 33.75
//成本： 2362.5
```



#### C#多重继承

多重继承指的是一个类别可以同时从多于一个父类继承行为与特征的功能。与单一继承相对，单一继承指一个类别只可以继承自一个父类。

**C# 不支持多重继承**。但是，您可以使用接口来实现多重继承。下面的程序演示了这点：



```c#
using System;

namespace InheritanceApplication
{
    class Shape
    {
     	public void setWidth( double w )
        {
            width = w;
        }
        
        public void setHeight( double h )
        {
            height = h;
        }
        
        protected int width;
        protected int height;
    }
    
    //基类 paintCost
    public interface PaintCost
    {
        int getCost(int area);
    }
    
    //派生类
    class Rectangle: Shape, PaintCost
    {
    	public int getArea()
    	{
    		return (width * height);
    	}
    	
    	public getCost( int area )
    	{
    		return area * 70;
    	}
    }
    
    class RectangleTester
    {
        static void Main(string[] args)
        {
            int area;
            Rect.setWidth(5);
            Rect.setHeight(7);
            area = Rect.getArea();
            
            //打印对象面积
            Console.WriteLine("总面积：　{0}", Rect.getArea());
            Console.WriteLine("油漆总成本: ${0}", Rect.getCost(area));
            Console.ReadKey();
        }
    }
    
    
}
```



------

#### C# 多态性

> 多态是同一个行为具有多个不同表现形式或形态的能力。
>
> **多态性**意味着有多重形式。在面向对象编程范式中，多态性往往表现为"一个接口，多个功能"。
>
> 多态性可以是静态的或动态的。在**静态多态性**中，函数的响应是在编译时发生的。在**动态多态性**中，函数的响应是在运行时发生的。
>
> 在 C# 中，每个类型都是多态的，因为包括用户定义类型在内的所有类型都继承自 Object。
>
> 多态就是同一个接口，使用不同的实例而执行不同操作，如图所示：

![img](https://www.runoob.com/wp-content/uploads/2013/12/dt-java.png)



#### 静态多态性

在编译时，函数和对象的连接机制被称为早期绑定，也被称为静态绑定。C# 提供了两种技术来实现静态多态性。分别为：

- 函数重载
- 运算符重载

#### 函数重载

可以在同一个范围内对相同的函数名有多个定义。函数的定义必须彼此不同，可以是参数列表中的参数类型不同，也可以是参数个数不同。不能重载只有返回类型不同的函数声明。

下面的实例演示了几个相同的函数 **Add()**，用于对不同个数参数进行相加处理：

```c#
using System;

namespace PolymorphismApplication
{
    public class TestData
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        
        public int Add(int a, int b)
        {
        	return a + b;    
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            TestData dataClass = new TestData();
            int add1 = dataClass.Add(1, 2);
            int add2 = dataClass.Add(1, 2, 3);
            
            Console.WriteLine("add1: " + add1);
            Console.WriteLine("add2: " ＋ add2);
        }
    }
}
```



下面的实例演示了几个相同的函数 **print()**，用于打印不同的数据类型：



```c#
using System;

namespace PolymorphismAppplication
{
    class Printdata
    {
        void print(int i)
        {
            Console.WriteLine("输出整型：{0}", i);
        }
        
        void print(double f)
        {
            Console.WriteLine("输出浮点型：{0}", f);
        }
        
        void print(string s)
        {
            Console.WriteLine("输出字符串：{0}", s);
        }
        
        static void Main(string[] args)
        {
            Printdata p = new Printdata();
            
            //调用print 打印整数
            p.print(1);
            //调用print 打印浮点数
			p.print(1.23);
            //调用print 打印字符串
            p.print("Hello World");
            Console.ReadKey();
        }
    }
    
}


//输出整型: 1
//输出浮点型: 1.23
//输出字符串: Hello Runoob
```



#### 动态多态性

C# 允许您使用关键字 **abstract** 创建抽象类，用于提供接口的部分类的实现。当一个派生类继承自该抽象类时，实现即完成。**抽象类**包含抽象方法，抽象方法可被派生类实现。派生类具有更专业的功能。



请注意，下面是有关抽象类的一些规则：

- 您不能创建一个抽象类的实例。
- 您不能在一个抽象类外部声明一个抽象方法。
- 通过在类定义前面放置关键字 **sealed**，可以将类声明为**密封类**。当一个类被声明为 **sealed** 时，它不能被继承。抽象类不能被声明为 sealed。

```c#
using System;

namespace PolymorphismApplication
{
    abstract class Shape
    {
        abstract public int area();
    }
    
    class Rectangle: Shape
    {
    	private int length;
    	private int width;
    	private int Reactangle( int a = 0, int b = 0 )
    	{
    		length = a;
    		width = b;
    	}
    	
    	public override int area()
    	{
    		Console.WriteLine("Rectangle 类的面积：");
    		return (width * length);
    	}
    }
    
    class ReactangleTester
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("面积：{0}", a);
            Console.ReadKey();
        }
    }
}

//Rectangle 类的面积：
//面积： 70
```



> 当有一个定义在类中的函数需要在继承类中实现时，可以使用**虚方法**。
>
> 虚方法是使用关键字 **virtual** 声明的。
>
> 虚方法可以在不同的继承类中有不同的实现。
>
> 对虚方法的调用是在运行时发生的。
>
> 动态多态性是通过 **抽象类** 和 **虚方法** 实现的。
>
> 以下实例创建了 Shape 基类，并创建派生类 Circle、 Rectangle、Triangle， Shape 类提供一个名为 Draw 的虚拟方法，在每个派生类中重写该方法以绘制该类的指定形状。



```c#
using System;
using System.Collections.Generic;

public class Shape
{
   public int X { get; private set; }
   public int Y { get; private set; }
   public int Height { get; set; }
   public int Width { get; set; }
    
   //虚方法
   public virtual void Draw()
   {
       Console.WriteLine("执基类的画图任务");
   }
}

class Circle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("画一个圆形");
		base.Draw();
	}
}

class Reactangle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("画一个长方形");
		base.Draw()
	}
}

class Triangle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("画一个三角形");
	}
}

class Program
{
    static void Main(string[] args)
    {
        //创建一个 List<Shape> 对象，并向该对象添加 Circle、 Triangle、和 Rectangle
        var shapes = new List<Shape>
        {
            new Reactangle(),
            new Triangle(),
            new Circle()
        };
        
        //使用 foreach 对该列表的派生类进行循环访问，并对其中的每个 Shape 对象调用 Draw 方法
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
        
        Console.WriteLine("按下任意键退出");
        Console.ReadKey();
    }
}
```

下面的程序演示通过虚方法 area() 来计算不同形状图像的面积：

```c#
using System;
namespace PolymorphismApplication
{
    class Shape
    {
        protected int width, height;
        public Shape( int a; int b )
        {
            width = a;
            height = b;
        }
        
        public virtual int area()
        {
            Console.WriteLine("父类的面积");
            return 0;
        }
    }
    
    class Rectangle: Shape
    {
    	public Rectangle( int a = 0, int b = 0 ):base(a, b)
    	{
    	
    	}
    	
    	public override int area()
    	{
    		Console.WriteLine("Rectangle 类的面积:");
    		return (width * height);
    	}
    }
    
    class Triangle: Shape
    {
    	public Triangle(int a = 0, int b = 0): base(a, b)
    	{
    	
    	}
    	
    	public override int area()
    	{
    		Console.WriteLine("Triangle类的面积:")；
    		return (width * height / 2);
    	}
    }
    
    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("面积：{0}", a);
        }
    }
    
    class Tester
    {
        static void Main(string[] args)
        {
            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);
            c.CallArea(r);
            c.CallArea(t);
            Console.ReadKey();
        }
    }
}

//Rectangle 类的面积：
//面积：70
//Triangle 类的面积：
//面积：25
```



------

#### C# 运算符重载

> 您可以重定义或重载 C# 中内置的运算符。因此，程序员也可以使用用户自定义类型的运算符。重载运算符是具有特殊名称的函数，是通过关键字 **operator** 后跟运算符的符号来定义的。与其他函数一样，重载运算符有返回类型和参数列表。

例如，请看下面的函数：

```c#
public static Box operator+ (Box b, Box c)
{
    Box box = new Box();
    box.length = b.length + c.length;
    box.breadth = b.breadth + c.breadth;
    box.height = b.height + c.height;
    return box;
}

/*
上面的函数为用户自定义的类 Box 实现了加法运算符（+）。它把两个 Box 对象的属性相加，并返回相加后的 Box 对象。
*/
```



####   运算符重载的实现

```c#
using System;

namespace OperatorApplication
{
    class Box
    {
        private double length;
        private double width;
        private double breadth;
        
        public double getVolume()
        {
            return length * breadth * height;
        }
        
        public void setLength(double len)
        {
            length = len;
        }
        
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        
        public boid setHeight(double hei)
        {
            height = hei;
        }
        
        //重载 + 运算符来把两个 BOx 对象相加
        public static Box operator+ (Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
             box.breadth = b.breadth + c.breadth;
             box.height = b.height + c.height;
             return box;
        }
    }
    
    class Tester
    {
       	static void Main(string[] args)
        {
           Box Box1 = new Box();         // 声明 Box1，类型为 Box
             Box Box2 = new Box();         // 声明 Box2，类型为 Box
             Box Box3 = new Box();         // 声明 Box3，类型为 Box
             double volume = 0.0;          // 体积

             // Box1 详述
             Box1.setLength(6.0);
             Box1.setBreadth(7.0);
             Box1.setHeight(5.0);

             // Box2 详述
             Box2.setLength(12.0);
             Box2.setBreadth(13.0);
             Box2.setHeight(10.0);

             // Box1 的体积
             volume = Box1.getVolume();
             Console.WriteLine("Box1 的体积： {0}", volume);

             // Box2 的体积
             volume = Box2.getVolume();
             Console.WriteLine("Box2 的体积： {0}", volume);

             // 把两个对象相加
             Box3 = Box1 + Box2;

             // Box3 的体积
             volume = Box3.getVolume();
             Console.WriteLine("Box3 的体积： {0}", volume);
             Console.ReadKey();
        }
    }
}

//Box1 的体积： 210
//Box2 的体积： 1560
//Box3 的体积： 5400
```



#### 可重载运算符

| 运算符                                | 描述                                         |
| :------------------------------------ | :------------------------------------------- |
| +, -, !, ~, ++, --                    | 这些一元运算符只有一个操作数，且可以被重载。 |
| +, -, *, /, %                         | 这些二元运算符带有两个操作数，且可以被重载。 |
| ==, !=, <, >, <=, >=                  | 这些比较运算符可以被重载。                   |
| &&, \|\|                              | 这些条件逻辑运算符不能被直接重载。           |
| +=, -=, *=, /=, %=                    | 这些赋值运算符不能被重载。                   |
| =, ., ?:, ->, new, is, sizeof, typeof | 这些运算符不能被重载。                       |



#### c#接口

> 接口定义了所有类继承接口时应遵循的语法合同。接口定义了语法合同 **"是什么"** 部分，派生类定义了语法合同 **"怎么做"**部分。
>
>  接口定义了属性、方法和事件，这些都是接口的成员。接口只包含了成员的声明。成员的定义是派生类的责任。接口提供了派生类应遵循的标准结构。
>
> 接口使得实现接口的类或结构在形式上保持一致。
>
> 抽象类在某种程度上与接口类似，但是，它们大多只是用在当只有少数方法由基类声明由派生类实现时。



#### 定义接口 ：MyInterface.cs

接口使用 **interface** 关键字声明，它与类的声明类似。接口声明默认是 public 的。下面是一个接口声明的实例：



```c#
interface IMyInterface
{
    void MethodToImplement();
}
```

以上代码定义了接口 IMyInterface。通常接口命令以 **I** 字母开头，这个接口只有一个方法MethodToImplement()，没有参数和返回值，当然我们可以按照需求设置参数和返回值。

值得注意的是，该方法并没有具体的实现。

#### 接下来我们来实现以上接口 ：InterfaceImplementer.cs

```c#
using System;

interface IMyInterface
{
    //接口成员
    void MethodToImplement();
}

class InterfaceImplementer : IMyInterface
{
	static void Main()
	{
		InterfaceImplementer iImp = new InterfaceImplementer();
		iImp.MethodToImplement();
	}
	
	public void MethodToImplement()
	{
		Console.WriteLine("MethodToImplement() called");
	}
}
```



InterfaceImplementer 类实现了 IMyInterface 接口，接口的实现与类的继承语法格式类似：

```c#
class InterfaceImplementer : IMyInterface
```

继承接口后，我们需要实现接口的方法 MethodToImplement() , 方法名必须与接口定义的方法名一致。



#### 接口继承：InterfaceInheritance.cs

以下实例定义了两个接口 IMyInterface 和 IParentInterface。

如果一个接口继承其他接口，那么实现类或结构就需要实现所有接口的成员。

以下实例 IMyInterface 继承了 IParentInterface 接口，因此接口实现类必须实现 MethodToImplement() 和 ParentInterfaceMethod() 方法：



```c#
using System;

interface IParentInterface
{
    void ParentInterfaceMethod();
}

interface IMyInterface : IParentInterface
{
	void MethodToImplement();
}

class InterfaceImplementer: IMyInterface
{
	static void Main()
	{
		InterfaceImplementer iImp = new InterfaceImplement();
		iImp.MethodToImplement();
		iImp.parentInterfaceMethod();
	}
	
	public void MethodToImplement()
	{
		Console.WriteLine("MethodToImplement() called");
	}
	
	public void ParentInterfaceMethod()
	{
		Console.WriteLine("ParentInterfaceMethod() called");
	}
}

//MethodToImplement() called.
//ParentInterfaceMethod() called.
```



接口注意的几点：

1. 接口方法不能用public abstract等修饰。接口内不能有字段变量，构造函数。
2. 接口内可以定义属性（有get和set的方法）。如string color { get ; set ; }这种。
3. 实现接口时，必须和接口的格式一致。
4. 必须实现接口的所有方法。



#### 接口的特点

接口的定义是指定一组函数成员而不实现成员的引用类型，其它类型和接口可以继承接口。定义还是很好理解的，但是没有反映特点，接口主要有以下特点：

-  通过接口可以实现多重继承，C# 接口的成员不能有 public、protected、internal、private 等修饰符。原因很简单，接口里面的方法都需要由外面接口实现去实现方法体，那么其修饰符必然是 public。C# 接口中的成员默认是 public 的，java 中是可以加 public 的。
-  接口成员不能有 new、static、abstract、override、virtual 修饰符。有一点要注意，当一个接口实现一个接口，这2个接口中有相同的方法时，可用 new 关键字隐藏父接口中的方法。
-  接口中只包含成员的签名，接口没有构造函数，所有不能直接使用 new 对接口进行实例化。接口中只能包含方法、属性、事件和索引的组合。接口一旦被实现，实现类必须实现接口中的所有成员，除非实现类本身是抽象类。
-  C# 是单继承，接口是解决 C# 里面类可以同时继承多个基类的问题。



------

#### c#命名空间

```c#
namespace namespace_name
{
    //代码声明
}
```



为了调用支持命名空间版本的函数或变量，会把命名空间的名称置于前面，如下所示：

```c#
namespace_name.item_name;
```



```c#
using System;
namespace first_space
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}

namespace second_sapce
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}

class TestClass
{
    static void Main(string[] args)
    {
        first_space.namespace_cl fc = new first_space.namespace_cl();
        second_space.namespace_cl sc = new second_space.namespace_cl();
        
        fc.func();
        sc.func();
        Console.ReadKey();
    }
}

//Inside first_space
//Inside second_space
```



#### using 关键字

**using** 关键字表明程序使用的是给定命名空间中的名称。例如，我们在程序中使用 **System** 命名空间，其中定义了类 Console。我们可以只写：

```c#
Console.WriteLine ("Hello there");
```

我们可以写完全限定名称，如下：

```c#
System.Console.WriteLine("Hello World");
```



您也可以使用 **using** 命名空间指令，这样在使用的时候就不用在前面加上命名空间名称。该指令告诉编译器随后的代码使用了指定命名空间中的名称。



```c#
using System;
using first_space;
using second_space;

namespace first_space
{
    class abc
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}

namespace second_space
{
    class efg
    {
        public void func()
        {
			Console.WriteLine("Inside second_space");
        }
    }
}

class TestClass()
{
    static void Main(string[] args)
    {
        abc fc = new abc();
        efg sc = mew efg();
        fc.func();
        sc.func();
        Console.ReadKey();
    }
}

//Inside first_space
//Inside second_space
```



#### 嵌套命名空间

```c#
namespace namespace_name1
{
    //代码声明
    namespace namespace_name2
    {
        //代码声明
    }
}
```



可以使用 . 运算符访问嵌套命名空间的成员

```c#
using System;
using SomeNameSpace;
using SomeNameSpace.Nested;

namespace SomeNameSpace
{
    public class MyClass
    {
        static void Main()
        {
       		Console.WriteLine("In SomeNameSpace");
            Nested.NestedNameSpaceClass.SayHello();
        }
    }
    //内嵌命名空间
    namespace Nested
    {
        public class NestedNameSpaceClass
        {
            public static void SayHello()
            {
                Console.WriteLine("In Nested");
            }
        }
    }
}

//In SomeNameSpace
//In Nested
```



## using的用法：

**1. using指令：引入命名空间**

这是最常见的用法，例如：

```
using System;
using Namespace1.SubNameSpace;
```

**2. using static 指令：指定无需指定类型名称即可访问其静态成员的类型**

```
using static System.Math;var = PI; // 直接使用System.Math.PI
```

**3. 起别名**

```
using Project = PC.MyCompany.Project;
```

**4. using语句：将实例与代码绑定**

```
using (Font font3 = new Font("Arial", 10.0f),
            font4 = new Font("Arial", 10.0f))
{
    // Use font3 and font4.
}
```



------

#### C#  预处理器指令

> 预处理器指令指导编译器在实际编译开始之前对信息进行预处理。
>
> 所有的预处理器指令都是以 # 开始。且在一行上，只有空白字符可以出现在预处理器指令之前。预处理器指令不是语句，所以它们不以分号（;）结束。
>
> C# 编译器没有一个单独的预处理器，但是，指令被处理时就像是有一个单独的预处理器一样。在 C# 中，预处理器指令用于在条件编译中起作用。与 C 和 C++ 不同的是，它们不是用来创建宏。一个预处理器指令必须是该行上的唯一指令。



| 预处理器指令 | 描述                                                         |
| :----------- | :----------------------------------------------------------- |
| #define      | 它用于定义一系列成为符号的字符。                             |
| #undef       | 它用于取消定义符号。                                         |
| #if          | 它用于测试符号是否为真。                                     |
| #else        | 它用于创建复合条件指令，与 #if 一起使用。                    |
| #elif        | 它用于创建复合条件指令。                                     |
| #endif       | 指定一个条件指令的结束。                                     |
| #line        | 它可以让您修改编译器的行数以及（可选地）输出错误和警告的文件名。 |
| #error       | 它允许从代码的指定位置生成一个错误。                         |
| #warning     | 它允许从代码的指定位置生成一级警告。                         |
| #region      | 它可以让您在使用 Visual Studio Code Editor 的大纲特性时，指定一个可展开或折叠的代码块。 |
| #endregion   | 它标识着 #region 块的结束。                                  |



**预处理器指令的用途理解：**

在程序调试和运行上有重要的作用。比如预处理器指令可以禁止编译器编译代码的某一部分，如果计划发布两个版本的代码，即基本版本和有更多功能的企业版本，就可以使用这些预处理器指令来控制。在编译软件的基本版本时，使用预处理器指令还可以禁止编译器编译于额外功能相关的代码。另外，在编写提供调试信息的代码时，也可以使用预处理器指令进行控制。总的来说和普通的控制语句（if等）功能类似，方便在于预处理器指令包含的未执行部分是不需要编译的。



```c#
#define PI
using System;

namespace PreprocessorDrAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            #if (PI)
                Console.WriteLine("PI is defined");
            #else
                Console.WriteLine("PI is not defined");
            #endif
                Console.ReadKey();
        }
    }
}
```



**#warning 和 #error：**

当编译器遇到它们时，会分别产生警告或错误。如果编译器遇到 #warning 指令，会给用户显示 #warning 指令后面的文本，之后编译继续进行。如果编译器遇到 #error 指令，就会给用户显示后面的文本，作为一条编译错误消息，然后会立即退出编译。使用这两条指令可以检查 #define 语句是不是做错了什么事，使用 #warning 语句可以提醒自己执行某个操作。



```c#
#if DEBUG && RELEASE
#error "You are defined DEBUG and RELEASE simultaneously"
#endif
#warning "Don't forget to remove this line before the boss tests the code!"
Console.WriteLine("i hate this job.");
```



**#region 和 #endregion**

#region 和 #endregion 指令用于把一段代码标记为有给定名称的一个块，如下所示:

```c#
#region Member Field Declarations

int x;
double d;
Currency balance;
#endregion
```

这看起来似乎没有什么用，它不影响编译过程。这些指令的优点是它们可以被某些编辑器识别，包括 Visual Studio .NET 编辑器。这些编辑器可以使用这些指令使代码在屏幕上更好地布局。



**#line**

#line 指令可以用于改变编译器在警告和错误信息中显示的文件名和行号信息，不常用。



**#pragma**

#pragma 指令可以抑制或还原指定的编译警告。与命令行选项不同，#pragma 指令可以在类或方法级别执行，对抑制警告的内容和抑制的时间进行更精细的控制

```c#
#pragma warnin disable 169     //取消编号  169 的警告（字段未使用的警告）
public class MyClass
{
    int neverUsedField;     //编译整个  MyClss 类时不会发出警告
}
#pragma warning restore 169   //恢复编号 169 的警告
```



#### C# 正则表达式

**正则表达式** 是一种匹配输入文本的模式。.Net 框架提供了允许这种匹配的正则表达式引擎。模式由一个或多个字符、运算符和结构组成。



#### 定义正则表达式

下面列出了用于定义正则表达式的各种类别的字符、运算符和结构。

- 字符转义
- 字符类
- 定位点
- 分组构造
- 限定符
- 反向引用构造
- 备用构造
- 替换
- 杂项构造



#### 字符转义

| 转义字符      | 描述                                                         | 模式                        | 匹配                                     |
| :------------ | :----------------------------------------------------------- | :-------------------------- | :--------------------------------------- |
| **\a**        | 与报警 (bell) 符 \u0007 匹配。                               | \a                          | "Warning!" + '\u0007' 中的 "\u0007"      |
| **\b**        | 在字符类中，与退格键 \u0008 匹配。                           | [\b]{3,}                    | "\b\b\b\b" 中的 "\b\b\b\b"               |
| **\t**        | 与制表符 \u0009 匹配。                                       | (\w+)\t                     | "Name\tAddr\t" 中的 "Name\t" 和 "Addr\t" |
| **\r**        | 与回车符 \u000D 匹配。（\r 与换行符 \n 不是等效的。）        | \r\n(\w+)                   | "\r\Hello\nWorld." 中的 "\r\nHello"      |
| **\v**        | 与垂直制表符 \u000B 匹配。                                   | [\v]{2,}                    | "\v\v\v" 中的 "\v\v\v"                   |
| **\f**        | 与换页符 \u000C 匹配。                                       | [\f]{2,}                    | "\f\f\f" 中的 "\f\f\f"                   |
| **\n**        | 与换行符 \u000A 匹配。                                       | \r\n(\w+)                   | "\r\Hello\nWorld." 中的 "\r\nHello"      |
| **\e**        | 与转义符 \u001B 匹配。                                       | \e                          | "\x001B" 中的 "\x001B"                   |
| **\ nnn**     | 使用八进制表示形式指定一个字符（nnn 由二到三位数字组成）。   | \w\040\w                    | "a bc d" 中的 "a b" 和 "c d"             |
| **\x nn**     | 使用十六进制表示形式指定字符（nn 恰好由两位数字组成）。      | \w\x20\w                    | "a bc d" 中的 "a b" 和 "c d"             |
| **\c X \c x** | 匹配 X 或 x 指定的 ASCII 控件字符，其中 X 或 x 是控件字符的字母。 | \cC                         | "\x0003" 中的 "\x0003" (Ctrl-C)          |
| **\u nnnn**   | 使用十六进制表示形式匹配一个 Unicode 字符（由 nnnn 表示的四位数）。 | \w\u0020\w                  | "a bc d" 中的 "a b" 和 "c d"             |
| **\**         | 在后面带有不识别的转义字符时，与该字符匹配。                 | \d+[\+-x\*]\d+\d+[\+-x\*\d+ | "(2+2) * 3*9" 中的 "2+2" 和              |



#### 字符类

字符类与一组字符中的任何一个字符匹配。

下表列出了字符类：

| 字符类                 | 描述                                                         | 模式   | 匹配                                       |
| :--------------------- | :----------------------------------------------------------- | :----- | :----------------------------------------- |
| **[character_group]**  | 匹配 character_group 中的任何单个字符。 默认情况下，匹配区分大小写。 | [mn]   | "mat" 中的 "m"，"moon" 中的 "m" 和 "n"     |
| **[^character_group]** | 非：与不在 character_group 中的任何单个字符匹配。 默认情况下，character_group 中的字符区分大小写。 | [^aei] | "avail" 中的 "v" 和 "l"                    |
| **[ first - last ]**   | 字符范围：与从 first 到 last 的范围中的任何单个字符匹配。    | [b-d]  | [b-d]irds 可以匹配 Birds、 Cirds、 Dirds   |
| **.**                  | 通配符：与除 \n 之外的任何单个字符匹配。  若要匹配原意句点字符（. 或 \u002E），您必须在该字符前面加上转义符 (\.)。 | a.e    | "have" 中的 "ave"， "mate" 中的 "ate"      |
| **\p{ name }**         | 与 *name* 指定的 Unicode 通用类别或命名块中的任何单个字符匹配。 | \p{Lu} | "City Lights" 中的 "C" 和 "L"              |
| **\P{ name }**         | 与不在 *name* 指定的 Unicode 通用类别或命名块中的任何单个字符匹配。 | \P{Lu} | "City" 中的 "i"、 "t" 和 "y"               |
| **\w**                 | 与任何单词字符匹配。                                         | \w     | "Room#1" 中的 "R"、 "o"、 "m" 和 "1"       |
| **\W**                 | 与任何非单词字符匹配。                                       | \W     | "Room#1" 中的 "#"                          |
| **\s**                 | 与任何空白字符匹配。                                         | \w\s   | "ID A1.3" 中的 "D "                        |
| **\S**                 | 与任何非空白字符匹配。                                       | \s\S   | "int __ctr" 中的 " _"                      |
| **\d**                 | 与任何十进制数字匹配。                                       | \d     | "4 = IV" 中的 "4"                          |
| **\D**                 | 匹配不是十进制数的任意字符。                                 | \D     | "4 = IV" 中的 " "、 "="、 " "、 "I" 和 "V" |



#### 定位点

定位点或原子零宽度断言会使匹配成功或失败，具体取决于字符串中的当前位置，但它们不会使引擎在字符串中前进或使用字符。

下表列出了定位点：

| 断言   | 描述                                                         | 模式     | 匹配                                            |
| :----- | :----------------------------------------------------------- | :------- | :---------------------------------------------- |
| **^**  | 匹配必须从字符串或一行的开头开始。                           | ^\d{3}   | "567-777-" 中的 "567"                           |
| **$**  | 匹配必须出现在字符串的末尾或出现在行或字符串末尾的 **\n** 之前。 | -\d{4}$  | "8-12-2012" 中的 "-2012"                        |
| **\A** | 匹配必须出现在字符串的开头。                                 | \A\w{4}  | "Code-007-" 中的 "Code"                         |
| **\Z** | 匹配必须出现在字符串的末尾或出现在字符串末尾的 **\n** 之前。 | -\d{3}\Z | "Bond-901-007" 中的 "-007"                      |
| **\z** | 匹配必须出现在字符串的末尾。                                 | -\d{3}\z | "-901-333" 中的 "-333"                          |
| **\G** | 匹配必须出现在上一个匹配结束的地方。                         | \G\(\d\) | "(1)(3)(5)[7](9)" 中的 "(1)"、 "(3)" 和 "(5)"   |
| **\b** | 匹配一个单词边界，也就是指单词和空格间的位置。               | er\b     | 匹配"never"中的"er"，但不能匹配"verb"中的"er"。 |
| **\B** | 匹配非单词边界。                                             | er\B     | 匹配"verb"中的"er"，但不能匹配"never"中的"er"。 |



### 分组构造

分组构造描述了正则表达式的子表达式，通常用于捕获输入字符串的子字符串。

下表列出了分组构造：

| 分组构造                             | 描述                                                 | 模式                                                         | 匹配                                                         |
| :----------------------------------- | :--------------------------------------------------- | :----------------------------------------------------------- | :----------------------------------------------------------- |
| **( subexpression )**                | 捕获匹配的子表达式并将其分配到一个从零开始的序号中。 | (\w)\1                                                       | "deep" 中的 "ee"                                             |
| **(?< name >subexpression)**         | 将匹配的子表达式捕获到一个命名组中。                 | (?< double>\w)\k< double>                                    | "deep" 中的 "ee"                                             |
| **(?< name1 -name2 >subexpression)** | 定义平衡组定义。                                     | (((?'Open'\()[^\(\)]*)+((?'Close-Open'\))[^\(\)]*)+)*(?(Open)(?!))$ | "3+2^((1-3)*(3-1))" 中的 "((1-3)*(3-1))"                     |
| **(?: subexpression)**               | 定义非捕获组。                                       | Write(?:Line)?                                               | "Console.WriteLine()" 中的 "WriteLine"                       |
| **(?imnsx-imnsx:subexpression)**     | 应用或禁用 *subexpression* 中指定的选项。            | A\d{2}(?i:\w+)\b                                             | "A12xl A12XL a12xl" 中的 "A12xl" 和 "A12XL"                  |
| **(?= subexpression)**               | 零宽度正预测先行断言。                               | \w+(?=\.)                                                    | "He is. The dog ran. The sun is out." 中的 "is"、 "ran" 和 "out" |
| **(?! subexpression)**               | 零宽度负预测先行断言。                               | \b(?!un)\w+\b                                                | "unsure sure unity used" 中的 "sure" 和 "used"               |
| **(?<=subexpression)**               | 零宽度正回顾后发断言。                               | (?<=19)\d{2}\b                                               | "1851 1999 1950 1905 2003" 中的 "99"、"50"和 "05"            |
| **(?<! subexpression)**              | 零宽度负回顾后发断言。                               | (?<!wo)man\b                                                 | "Hi woman Hi man" 中的 "man"                                 |
| **(?> subexpression)**               | 非回溯（也称为"贪婪"）子表达式。                     | [13579](?>A+B+)                                              | "1ABB 3ABBC 5AB 5AC" 中的 "1ABB"、 "3ABB" 和 "5AB"           |



```c#
using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string input = "1851 1999 1950 1905 2003";
        string pattern = @"(?<=19)\d{2}";
        
        foreach (Match match in Regex.Matches(input, pattern))
            Console.WriteLine(match.Value);
    }
}

// 90  50  05
```



#### 限定符

限定符指定在输入字符串中必须存在上一个元素（可以是字符、组或字符类）的多少个实例才能出现匹配项。 限定符包括下表中列出的语言元素。

下表列出了限定符：

| 限定符         | 描述                                                   | 模式       | 匹配                                                         |
| :------------- | :----------------------------------------------------- | :--------- | :----------------------------------------------------------- |
| *****          | 匹配上一个元素零次或多次。                             | \d*\.\d    | ".0"、 "19.9"、 "219.9"                                      |
| **+**          | 匹配上一个元素一次或多次。                             | "be+"      | "been" 中的 "bee"， "bent" 中的 "be"                         |
| **?**          | 匹配上一个元素零次或一次。                             | "rai?n"    | "ran"、 "rain"                                               |
| **{ n }**      | 匹配上一个元素恰好 n 次。                              | ",\d{3}"   | "1,043.6" 中的 ",043"， "9,876,543,210" 中的 ",876"、 ",543" 和 ",210" |
| **{ n ,}**     | 匹配上一个元素至少 n 次。                              | "\d{2,}"   | "166"、 "29"、 "1930"                                        |
| **{ n , m }**  | 匹配上一个元素至少 n 次，但不多于 m 次。               | "\d{3,5}"  | "166"， "17668"， "193024" 中的 "19302"                      |
| ***?**         | 匹配上一个元素零次或多次，但次数尽可能少。             | \d*?\.\d   | ".0"、 "19.9"、 "219.9"                                      |
| **+?**         | 匹配上一个元素一次或多次，但次数尽可能少。             | "be+?"     | "been" 中的 "be"， "bent" 中的 "be"                          |
| **??**         | 匹配上一个元素零次或一次，但次数尽可能少。             | "rai??n"   | "ran"、 "rain"                                               |
| **{ n }?**     | 匹配前导元素恰好 n 次。                                | ",\d{3}?"  | "1,043.6" 中的 ",043"， "9,876,543,210" 中的 ",876"、 ",543" 和 ",210" |
| **{ n ,}?**    | 匹配上一个元素至少 n 次，但次数尽可能少。              | "\d{2,}?"  | "166"、 "29" 和 "1930"                                       |
| **{ n , m }?** | 匹配上一个元素的次数介于 n 和 m 之间，但次数尽可能少。 | "\d{3,5}?" | "166"， "17668"， "193024" 中的 "193" 和 "024"               |



#### 反向引用构造

反向引用允许在同一正则表达式中随后标识以前匹配的子表达式。

下表列出了反向引用构造：

| 反向引用构造   | 描述                                | 模式                  | 匹配             |
| :------------- | :---------------------------------- | :-------------------- | :--------------- |
| **\ number**   | 反向引用。 匹配编号子表达式的值。   | (\w)\1                | "seek" 中的 "ee" |
| **\k< name >** | 命名反向引用。 匹配命名表达式的值。 | (?< char>\w)\k< char> | "seek" 中的 "ee" |



#### 备用构造

备用构造用于修改正则表达式以启用 either/or 匹配。

下表列出了备用构造：

| 备用构造                        | 描述                                                         | 模式                                 | 匹配                                                         |
| :------------------------------ | :----------------------------------------------------------- | :----------------------------------- | :----------------------------------------------------------- |
| **\|**                          | 匹配以竖线 (\|) 字符分隔的任何一个元素。                     | th(e\|is\|at)                        | "this is the day. " 中的 "the" 和 "this"                     |
| **(?( expression )yes \| no )** | 如果正则表达式模式由 expression 匹配指定，则匹配 *yes*；否则匹配可选的 *no* 部分。 expression 被解释为零宽度断言。 | (?(A)A\d{2}\b\|\b\d{3}\b)            | "A10 C103 910" 中的 "A10" 和 "910"                           |
| **(?( name )yes \| no )**       | 如果 name 或已命名或已编号的捕获组具有匹配，则匹配 *yes*；否则匹配可选的 *no*。 | (?< quoted>")?(?(quoted).+?"\|\S+\s) | "Dogs.jpg "Yiska playing.jpg"" 中的 Dogs.jpg 和 "Yiska playing.jpg" |



### 替换

替换是替换模式中使用的正则表达式。

下表列出了用于替换的字符：

| 字符            | 描述                                 | 模式                                 | 替换模式          | 输入字符串 | 结果字符串  |
| :-------------- | :----------------------------------- | :----------------------------------- | :---------------- | :--------- | :---------- |
| **$**number     | 替换按组 *number* 匹配的子字符串。   | \b(\w+)(\s)(\w+)\b                   | $3$2$1            | "one two"  | "two one"   |
| **${**name**}** | 替换按命名组 *name* 匹配的子字符串。 | \b(?< word1>\w+)(\s)(?< word2>\w+)\b | ${word2} ${word1} | "one two"  | "two one"   |
| **$$**          | 替换字符"$"。                        | \b(\d+)\s?USD                        | $$$1              | "103 USD"  | "$103"      |
| **$&**          | 替换整个匹配项的一个副本。           | (\$*(\d*(\.+\d+)?){1})               | **$&              | "$1.30"    | "**$1.30**" |
| **$`**          | 替换匹配前的输入字符串的所有文本。   | B+                                   | $`                | "AABBCC"   | "AAAACC"    |
| **$'**          | 替换匹配后的输入字符串的所有文本。   | B+                                   | $'                | "AABBCC"   | "AACCCC"    |
| **$+**          | 替换最后捕获的组。                   | B+(C+)                               | $+                | "AABBCCDD" | AACCDD      |
| **$_**          | 替换整个输入字符串。                 | B+                                   | $_                | "AABBCC"   | "AAAABBCCCC |



#### 杂项构造

下表列出了各种杂项构造：

| 构造               | 描述                                                   | 实例                                                   |
| :----------------- | :----------------------------------------------------- | :----------------------------------------------------- |
| **(?imnsx-imnsx)** | 在模式中间对诸如不区分大小写这样的选项进行设置或禁用。 | \bA(?i)b\w+\b 匹配 "ABA Able Act" 中的 "ABA" 和 "Able" |
| **(?#注释)**       | 内联注释。该注释在第一个右括号处终止。                 | \bA(?#匹配以A开头的单词)\w+\b                          |
| **#** [行尾]       | 该注释以非转义的 # 开头，并继续到行的结尾。            | (?x)\bA\w+\b#匹配以 A 开头的单词                       |



#### Regex 类

Regex 类用于表示一个正则表达式。

下表列出了 Regex 类中一些常用的方法：

| 序号 | 方法 & 描述                                                  |
| :--- | :----------------------------------------------------------- |
| 1    | **public bool IsMatch( string input )**  指示 Regex 构造函数中指定的正则表达式是否在指定的输入字符串中找到匹配项。 |
| 2    | **public bool IsMatch( string input, int startat )**  指示 Regex 构造函数中指定的正则表达式是否在指定的输入字符串中找到匹配项，从字符串中指定的开始位置开始。 |
| 3    | **public static bool IsMatch( string input, string pattern )**  指示指定的正则表达式是否在指定的输入字符串中找到匹配项。 |
| 4    | **public MatchCollection Matches( string input )**  在指定的输入字符串中搜索正则表达式的所有匹配项。 |
| 5    | **public string Replace( string input, string replacement )**  在指定的输入字符串中，把所有匹配正则表达式模式的所有匹配的字符串替换为指定的替换字符串。 |
| 6    | **public string[] Split( string input )**  把输入字符串分割为子字符串数组，根据在 Regex 构造函数中指定的正则表达式模式定义的位置进行分割。 |



下面的实例匹配了以 'S' 开头的单词：

```c#
using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
    class Program
    {
        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match in mc)
            {
                Console.WriteLine(m);
            }
        }
        
        static void Main(string[] args)
        {
            string str = "A Thousand Splendid Suns";
            
            Console.WriteLine("Matching words that start with 'S': ");
            showMatch(str, @"\bS\S*");
            Console.ReadKey();
        }
    }
}

//Matching words that start with 'S':
//The Expression: \bS\S*
//Splendid
//Suns
```



下面的实例匹配了以 'm' 开头以 'e' 结尾的单词：

```c#
using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
   class Program
   {
      private static void showMatch(string text, string expr)
      {
         Console.WriteLine("The Expression: " + expr);
         MatchCollection mc = Regex.Matches(text, expr);
         foreach (Match m in mc)
         {
            Console.WriteLine(m);
         }
      }
      static void Main(string[] args)
      {
         string str = "make maze and manage to measure it";

         Console.WriteLine("Matching words start with 'm' and ends with 'e':");
         showMatch(str, @"\bm\S*e\b");
         Console.ReadKey();
      }
   }
}

/*
Matching words start with 'm' and ends with 'e':
The Expression: \bm\S*e\b
make
maze
manage
measure
*/
```



下面的实例替换掉多余的空格：

```c#
using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
   class Program
   {
      static void Main(string[] args)
      {
         string input = "Hello   World   ";
         string pattern = "\\s+";
         string replacement = " ";
         Regex rgx = new Regex(pattern);
         string result = rgx.Replace(input, replacement);

         Console.WriteLine("Original String: {0}", input);
         Console.WriteLine("Replacement String: {0}", result);    
         Console.ReadKey();
      }
   }
}

//Original String: Hello   World   
//Replacement String: Hello World   
```



------

#### C#   异常处理

异常是在程序执行期间出现的问题。C# 中的异常是对程序运行时出现的特殊情况的一种响应，比如尝试除以零。

异常提供了一种把程序控制权从某个部分转移到另一个部分的方式。C# 异常处理时建立在四个关键词之上的：**try**、**catch**、**finally** 和 **throw**。

- **try**：一个 try 块标识了一个将被激活的特定的异常的代码块。后跟一个或多个 catch 块。
- **catch**：程序通过异常处理程序捕获异常。catch 关键字表示异常的捕获。
- **finally**：finally 块用于执行给定的语句，不管异常是否被抛出都会执行。例如，如果您打开一个文件，不管是否出现异常文件都要被关闭。
- **throw**：当问题出现时，程序抛出一个异常。使用 throw 关键字来完成。



#### 语法

假设一个块将出现异常，一个方法使用 try 和 catch 关键字捕获异常。try/catch 块内的代码为受保护的代码，使用 try/catch 语法如下所示：

```c#
try
{
    //引起异常语句
}
catch( ExceptionName e1 )
{
    //错误处理代码
}
catch( ExceptionName e2 )
{
    //错误处理代码
}
finally
{
    //要执行的语句
}
```



#### C#中的异常类

C# 异常是使用类来表示的。C# 中的异常类主要是直接或间接地派生于 **System.Exception** 类。**System.ApplicationException**和 **System.SystemException** 类是派生于 System.Exception 类的异常类。

**System.ApplicationException** 类支持由应用程序生成的异常。所以程序员定义的异常都应派生自该类。

**System.SystemException** 类是所有预定义的系统异常的基类。



| 异常类                            | 描述                                           |
| :-------------------------------- | :--------------------------------------------- |
| System.IO.IOException             | 处理 I/O 错误。                                |
| System.IndexOutOfRangeException   | 处理当方法指向超出范围的数组索引时生成的错误。 |
| System.ArrayTypeMismatchException | 处理当数组类型不匹配时生成的错误。             |
| System.NullReferenceException     | 处理当依从一个空对象时生成的错误。             |
| System.DivideByZeroException      | 处理当除以零时生成的错误。                     |
| System.InvalidCastException       | 处理在类型转换期间生成的错误。                 |
| System.OutOfMemoryException       | 处理空闲内存不足生成的错误。                   |
| System.StackOverflowException     | 处理栈溢出生成的错误。                         |



#### 异常处理

C# 以 try 和 catch 块的形式提供了一种结构化的异常处理方案。使用这些块，把核心程序语句与错误处理语句分离开。

这些错误处理块是使用 **try**、**catch** 和 **finally** 关键字实现的。下面是一个当除以零时抛出异常的实例：

```c#
using System;
namespace ErrorHandlingApplication
{
    class DivNumbers
    {
        int result;
        DivNumbers()
        {
            result = 0;
        }
        
        public void division( int num1, int num2 )
        {
            try
            {
                result = num1 / num2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        
        static void Main(string[] args)
        {
            DivNumber d = new DivNumbers();
            d.division(25, 0);
            Console.ReadKey();
        }
    }
}

//Exception caught: System.DivideByZeroException: Attempted to divide by zero. 
//at ...
//Result: 0
```

  



#### 创建用户自定义异常

您也可以定义自己的异常。用户自定义的异常类是派生自 **ApplicationException** 类。下面的实例演示了这点

```c#
using System;

namespace UserDefinedException
{
    class TestTemperature
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch(TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}

public class TempIsZeroException: ApplicationException
{
	public TempIsZeroException(string message): base(message)
	{
	
	}
}

public class Temperature
{
    int temperature = 0;
    public void showTemp()
    {
        if(temperature == 0)
        {
            throw (new TempIsZeroException("Zero Tempreature found"));
        }
        else
        {
            Console.WriteLine("Temperature: {0}", temperature);
        }
    }
}

//TempIsZeroException: Zero Temperature found
```



#### 抛出对象

如果异常是直接或间接派生自 **System.Exception** 类，您可以抛出一个对象。您可以在 catch 块中使用 throw 语句来抛出当前的对象，如下所示：

```c#
Catch(Exception e)
{
    ...
    Throw e
}
```



------

#### C# 文件的输入与输出

一个 **文件** 是一个存储在磁盘中带有指定名称和目录路径的数据集合。当打开文件进行读写时，它变成一个 **流**。

从根本上说，流是通过通信路径传递的字节序列。有两个主要的流：**输入流** 和 **输出流**。**输入流**用于从文件读取数据（读操作），**输出流**用于向文件写入数据（写操作）。



#### C# I/O 类

System.IO 命名空间有各种不同的类，用于执行各种文件操作，如创建和删除文件、读取或写入文件，关闭文件等。

| I/O 类         | 描述                               |
| :------------- | :--------------------------------- |
| BinaryReader   | 从二进制流读取原始数据。           |
| BinaryWriter   | 以二进制格式写入原始数据。         |
| BufferedStream | 字节流的临时存储。                 |
| Directory      | 有助于操作目录结构。               |
| DirectoryInfo  | 用于对目录执行操作。               |
| DriveInfo      | 提供驱动器的信息。                 |
| File           | 有助于处理文件。                   |
| FileInfo       | 用于对文件执行操作。               |
| FileStream     | 用于文件中任何位置的读写。         |
| MemoryStream   | 用于随机访问存储在内存中的数据流。 |
| Path           | 对路径信息执行操作。               |
| StreamReader   | 用于从字节流中读取字符。           |
| StreamWriter   | 用于向一个流中写入字符。           |
| StringReader   | 用于读取字符串缓冲区。             |
| StringWriter   | 用于写入字符串缓冲区。             |



FileStream 类

System.IO 命名空间中的 **FileStream** 类有助于文件的读写与关闭。该类派生自抽象类 Stream。

您需要创建一个 **FileStream** 对象来创建一个新的文件，或打开一个已有的文件。创建 **FileStream** 对象的语法如下：

```c#
FileStream <object_name> = new FileStream(<file_name>, <FileMode Enimerator>, <FileAccess Enumerator>, <FileShare Enumerator>);
```



例如，创建一个 FileStream 对象 **F** 来读取名为 **sample.txt** 的文件：

```c#
FileStream F = new FileStream("sample.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
```



| 参数       | 描述                                                         |
| :--------- | :----------------------------------------------------------- |
| FileMode   | **FileMode** 枚举定义了各种打开文件的方法。FileMode 枚举的成员有：**Append**：打开一个已有的文件，并将光标放置在文件的末尾。如果文件不存在，则创建文件。**Create**：创建一个新的文件。如果文件已存在，则删除旧文件，然后创建新文件。**CreateNew**：指定操作系统应创建一个新的文件。如果文件已存在，则抛出异常。**Open**：打开一个已有的文件。如果文件不存在，则抛出异常。**OpenOrCreate**：指定操作系统应打开一个已有的文件。如果文件不存在，则用指定的名称创建一个新的文件打开。**Truncate**：打开一个已有的文件，文件一旦打开，就将被截断为零字节大小。然后我们可以向文件写入全新的数据，但是保留文件的初始创建日期。如果文件不存在，则抛出异常。 |
| FileAccess | **FileAccess** 枚举的成员有：**Read**、**ReadWrite** 和 **Write**。 |
| FileShare  | **FileShare** 枚举的成员有：**Inheritable**：允许文件句柄可由子进程继承。Win32 不直接支持此功能。**None**：谢绝共享当前文件。文件关闭前，打开该文件的任何请求（由此进程或另一进程发出的请求）都将失败。**Read**：允许随后打开文件读取。如果未指定此标志，则文件关闭前，任何打开该文件以进行读取的请求（由此进程或另一进程发出的请求）都将失败。但是，即使指定了此标志，仍可能需要附加权限才能够访问该文件。**ReadWrite**：允许随后打开文件读取或写入。如果未指定此标志，则文件关闭前，任何打开该文件以进行读取或写入的请求（由此进程或另一进程发出）都将失败。但是，即使指定了此标志，仍可能需要附加权限才能够访问该文件。**Write**：允许随后打开文件写入。如果未指定此标志，则文件关闭前，任何打开该文件以进行写入的请求（由此进程或另一进过程发出的请求）都将失败。但是，即使指定了此标志，仍可能需要附加权限才能够访问该文件。**Delete**：允许随后删除文件。 |



##### 实例

```c#
using System;
using System.IO;

namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }
            
            F.Position = 0;
            
            for ( int i = 0; i <= 20; i++ )
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();
        }
    }
}

//1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 -1
```



#### C# 高级文件操作

上面的实例演示了 C# 中简单的文件操作。但是，要充分利用 C# System.IO 类的强大功能，您需要知道这些类常用的属性和方法。



| 主题                   | 描述                                                         |
| :--------------------- | :----------------------------------------------------------- |
| 文本文件的读写         | 它涉及到文本文件的读写。**StreamReader** 和 **StreamWriter** 类有助于完成文本文件的读写。 |
| 二进制文件的读写       | 它涉及到二进制文件的读写。**BinaryReader** 和 **BinaryWriter** 类有助于完成二进制文件的读写。 |
| Windows 文件系统的操作 | 它让 C# 程序员能够浏览并定位 Windows 文件和目录。            |



```c#
string dirPath = @"D:\TestDir";
string filePath = @"D:\TestDir\TestFile.txt";
Console.WriteLine("<<<<<<<<<<<{0}>>>>>>>>>>", "文件路径");
//获得当前路径
Console.WriteLine(Environment.CurrentDirectory);
//文件或文件夹所在目录
Console.WriteLine(Path.GetDirectoryName(filePath));     //D:\TestDir
Console.WriteLine(Path.GetDirectoryName(dirPath));      //D:\
//文件扩展名
Console.WriteLine(Path.GetExtension(filePath));         //.txt
//文件名
Console.WriteLine(Path.GetFileName(filePath));          //TestFile.txt
Console.WriteLine(Path.GetFileName(dirPath));           //TestDir
Console.WriteLine(Path.GetFileNameWithoutExtension(filePath)); //TestFile
//绝对路径
Console.WriteLine(Path.GetFullPath(filePath));          //D:\TestDir\TestFile.txt
Console.WriteLine(Path.GetFullPath(dirPath));           //D:\TestDir  
//更改扩展名
Console.WriteLine(Path.ChangeExtension(filePath, ".jpg"));//D:\TestDir\TestFile.jpg
//根目录
Console.WriteLine(Path.GetPathRoot(dirPath));           //D:\      
//生成路径
Console.WriteLine(Path.Combine(new string[] { @"D:\", "BaseDir", "SubDir", "TestFile.txt" })); //D:\BaseDir\SubDir\TestFile.txt
//生成随即文件夹名或文件名
Console.WriteLine(Path.GetRandomFileName());
//创建磁盘上唯一命名的零字节的临时文件并返回该文件的完整路径
Console.WriteLine(Path.GetTempFileName());
//返回当前系统的临时文件夹的路径
Console.WriteLine(Path.GetTempPath());
//文件名中无效字符
Console.WriteLine(Path.GetInvalidFileNameChars());
//路径中无效字符
Console.WriteLine(Path.GetInvalidPathChars()); 
```

------



### C# 高级

#### C# 特性（Attribute）



> **特性（Attribute）**是用于在运行时传递程序中各种元素（比如类、方法、结构、枚举、组件等）的行为信息的声明性标签。您可以通过使用特性向程序添加声明性信息。一个声明性标签是通过放置在它所应用的元素前面的方括号（[ ]）来描述的。
>
> 特性（Attribute）用于添加元数据，如编译器指令和注释、描述、方法、类等其他信息。.Net 框架提供了两种类型的特性：*预定义*特性和*自定义*特性。



#### 规定特性（Attribute）

语法:

```
[attribute(positional_parameters, name_parameter = value, ...)]
element
```

特性（Attribute）的名称和值是在方括号内规定的，放置在它所应用的元素之前。positional_parameters 规定必需的信息，name_parameter 规定可选的信息。



#### 预定义特性（Attribute）

.Net 框架提供了三种预定义特性：

- AttributeUsage
- Conditional
- Obsolete

#### AttributeUsage

预定义特性 **AttributeUsage** 描述了如何使用一个自定义特性类。它规定了特性可应用到的项目的类型。

规定该特性的语法如下：

```
[AttributeUsage(
   validon,
   AllowMultiple=allowmultiple,
   Inherited=inherited
)]
```

其中：

- 参数 validon 规定特性可被放置的语言元素。它是枚举器 *AttributeTargets* 的值的组合。默认值是 *AttributeTargets.All*。
- 参数 *allowmultiple*（可选的）为该特性的 *AllowMultiple* 属性（property）提供一个布尔值。如果为 true，则该特性是多用的。默认值是 false（单用的）。
- 参数 *inherited*（可选的）为该特性的 *Inherited* 属性（property）提供一个布尔值。如果为 true，则该特性可被派生类继承。默认值是 false（不被继承）。

```c#
[AttributeUsage(AttributeTargets.Class |
AttributeTargets.Constructor |
AttributeTargets.Field |
AttributeTargets.Method |
AttributeTargets.Property, 
AllowMultiple = true)]
```



#### Conditional

这个预定义特性标记了一个条件方法，其执行依赖于指定的预处理标识符。

它会引起方法调用的条件编译，取决于指定的值，比如 **Debug** 或 **Trace**。例如，当调试代码时显示变量的值。

规定该特性的语法如下：



```
[Conditional(
   conditionalSymbol
)]
```



```c#
[Conditional("DEBUG")]
```



实例：

```c#
#define DEBUG
using System;
using System.Diagnostics;
public class Myclass
{
    [Conditional("DEBUG")]
    public static void Message(string msg)
    {
        Console.WriteLine(msg);
    }
}

class Test
{
    static void function1()
    {
        MyClass.Message("In function1");
        function2();
    }
    static void function2()
    {
        Myclass.Message("In function2");
    }
    public static void Main()
    {
        Myclass.Message("In Main function");
        function1();
        Console.ReadKey();
    }
}

//In Main function
//In Function 1
//In Function 2
```



#### Obsolete

这个预定义特性标记了不应被使用的程序实体。它可以让您通知编译器丢弃某个特定的目标元素。例如，当一个新方法被用在一个类中，但是您仍然想要保持类中的旧方法，您可以通过显示一个应该使用新方法，而不是旧方法的消息，来把它标记为 obsolete（过时的）。

规定该特性的语法如下：

```
[Obsolete(
   message
)]
[Obsolete(
   message,
   iserror
)]
```



其中：

- 参数 *message*，是一个字符串，描述项目为什么过时的原因以及该替代使用什么。
- 参数 *iserror*，是一个布尔值。如果该值为 true，编译器应把该项目的使用当作一个错误。默认值是 false（编译器生成一个警告）。



```c#
using System;
public class MyClass
{
    [Obsolete("Don' use OldMethod, use NewMethod instead", true)]
    static void OldMethod()
    {
        Console.WriteLine("It is a old method");
    }
    static void NewMethod()
    {
        Console.WriteLine("It is the new Method");
    }
    public static void Main()
    {
        OldMethod();
    }
}

// Don't use OldMethod, use NewMethod instead
```



#### 创建自定义特性（Attribute）

.Net 框架允许创建自定义特性，用于存储声明性的信息，且可在运行时被检索。该信息根据设计标准和应用程序需要，可与任何目标元素相关。

创建并使用自定义特性包含四个步骤：

- 声明自定义特性
- 构建自定义特性
- 在目标程序元素上应用自定义特性
- 通过反射访问特性

最后一个步骤包含编写一个简单的程序来读取元数据以便查找各种符号。元数据是用于描述其他数据的数据和信息。该程序应使用反射来在运行时访问特性。我们将在下一章详细讨论这点。



#### 声明自定义特性

一个新的自定义特性应派生自 **System.Attribute** 类。例如：

```c#
// 一个自定义特性 BugFix 被赋给类及其成员
[AttributeUsage(AttributeTargets.Class |
AttributeTargets.Constructor |
AttributeTargets.Field |
AttributeTargets.Method |
AttributeTargets.Property,
AllowMultiple = true)]

public class DeBugInfo : System.Attribute
```

在上面的代码中，我们已经声明了一个名为 *DeBugInfo* 的自定义特性。



#### 构建自定义特性

让我们构建一个名为 *DeBugInfo* 的自定义特性，该特性将存储调试程序获得的信息。它存储下面的信息：

- bug 的代码编号
- 辨认该 bug 的开发人员名字
- 最后一次审查该代码的日期
- 一个存储了开发人员标记的字符串消息

我们的 *DeBugInfo* 类将带有三个用于存储前三个信息的私有属性（property）和一个用于存储消息的公有属性（property）。所以 bug 编号、开发人员名字和审查日期将是 DeBugInfo 类的必需的定位（ positional）参数，消息将是一个可选的命名（named）参数。

每个特性必须至少有一个构造函数。必需的定位（ positional）参数应通过构造函数传递。下面的代码演示了 *DeBugInfo* 类：



```c#
//一个自定义特性 BugFix 被赋给类及成员
[AttributeUsage(AttributeTargets.Class |
 AttributeTargets.Constructor |
 AttributeTargets.Field |
 AttributeTargets.Method |
 AttributeTargets.Property,
 AllowMultiple = true)]
 
public class DeBugInfo : System.Attribute
{
	private int bugNo;
	private string developer;
	private string lastReview;
	public string message;
	
	public DeBugInfo(int bg, string dev, string d)
	{
		this.bugNo = bg;
		this.developer = dev;
		this.lastReview = d;
	}
	
	public int BugNo
	{
		get
		{
			return bigNo;
		}
	}
	
	public string Developer
	{
		get
		{
			return developer
		}
	}
	
	public string LastReview
	{
		get
		{
			return lastReview;
		}
	}
	
	public string Message
	{
		get
		{
			return message;
		}
		set
		{
			message = value
		}
	}
}
```



### 应用自定义特性

通过把特性放置在紧接着它的目标之前，来应用该特性：

```c#
[DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
[DeBugInfo(49, "NuHa Ali", "10/10/2012", Message = "Unused variable")]

class Reactangle
{
    //成员变量
    protected double length;
    protected double width;
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }
    [DeBugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]
    public double GetArea()
    {
        return width * length;
    }
    [DeBugInfo(56, "Zara Ali", "19/10/2012")]
    public void Display()
    {
        Console.WriteLine("Length: {0}", length);
        Console.WriteLine("Width: {0}", width);
        Console.WriteLine("Area: {0}", GetArea());
    }
}
```

------

### C# 反射（Reflection）

反射指程序可以访问、检测和修改它本身状态或行为的一种能力。

程序集包含模块，而模块包含类型，类型又包含成员。反射则提供了封装程序集、模块和类型的对象。

您可以使用反射动态地创建类型的实例，将类型绑定到现有对象，或从现有对象中获取类型。然后，可以调用类型的方法或访问其字段和属性。

#### 优缺点

优点：

- 1、反射提高了程序的灵活性和扩展性。
- 2、降低耦合性，提高自适应能力。
- 3、它允许程序创建和控制任何类的对象，无需提前硬编码目标类。

缺点：

- 1、性能问题：使用反射基本上是一种解释操作，用于字段和方法接入时要远慢于直接代码。因此反射机制主要应用在对灵活性和拓展性要求很高的系统框架上，普通程序不建议使用。
- 2、使用反射会模糊程序内部逻辑；程序员希望在源代码中看到程序的逻辑，反射却绕过了源代码的技术，因而会带来维护的问题，反射代码比相应的直接代码更复杂。

#### 反射（Reflection）的用途

反射（Reflection）有下列用途：

- 它允许在运行时查看特性（attribute）信息。
- 它允许审查集合中的各种类型，以及实例化这些类型。
- 它允许延迟绑定的方法和属性（property）。
- 它允许在运行时创建新类型，然后使用这些类型执行一些任务。



#### 查看元数据

我们已经在上面的章节中提到过，使用反射（Reflection）可以查看特性（attribute）信息。

**System.Reflection** 类的 **MemberInfo** 对象需要被初始化，用于发现与类相关的特性（attribute）。为了做到这点，您可以定义目标类的一个对象，如下：

```
System.Reflection.MemberInfo info = typeof(MyClass);
```

下面的程序演示了这点：

```c#
using System;

[AttributeUsage(AttributeTargets.All)]
public class HelpAttribute: System.Attribute
{
	public readonly string Url;
	
	public string Topic //Topic 是一个命名(named)参数
	{
		get
		{
			return topic;
		}
		set
		{
			topic = value;
		}
	}
	
	public HelpAttribute(string url) //url 是一个定位（positional）参数
	{
		this.Url = url;
	}
	
	private string topic;
}

[HelpAttribute("information on the class MyClass")]
class MyClass
{
    
}

namespace AttributeAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo info = typeof(MyClass);
            Object[] attributes = info.GetCustomAttributes(true);
            for(int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }
            Console.ReadKey();
        }
    }
}

//HelpAttribute
```



在本实例中，我们将使用在上一章中创建的 *DeBugInfo* 特性，并使用反射（Reflection）来读取 *Rectangle* 类中的元数据。

```c#
using System;
using System.Reflection;
namespace BugFixApplication
{
   // 一个自定义特性 BugFix 被赋给类及其成员
   [AttributeUsage(AttributeTargets.Class |
   AttributeTargets.Constructor |
   AttributeTargets.Field |
   AttributeTargets.Method |
   AttributeTargets.Property,
   AllowMultiple = true)]

   public class DeBugInfo : System.Attribute
   {
      private int bugNo;
      private string developer;
      private string lastReview;
      public string message;

      public DeBugInfo(int bg, string dev, string d)
      {
         this.bugNo = bg;
         this.developer = dev;
         this.lastReview = d;
      }

      public int BugNo
      {
         get
         {
            return bugNo;
         }
      }
      public string Developer
      {
         get
         {
            return developer;
         }
      }
      public string LastReview
      {
         get
         {
            return lastReview;
         }
      }
      public string Message
      {
         get
         {
            return message;
         }
         set
         {
            message = value;
         }
      }
   }
   [DeBugInfo(45, "Zara Ali", "12/8/2012",
        Message = "Return type mismatch")]
   [DeBugInfo(49, "Nuha Ali", "10/10/2012",
        Message = "Unused variable")]
   class Rectangle
   {
      // 成员变量
      protected double length;
      protected double width;
      public Rectangle(double l, double w)
      {
         length = l;
         width = w;
      }
      [DeBugInfo(55, "Zara Ali", "19/10/2012",
           Message = "Return type mismatch")]
      public double GetArea()
      {
         return length * width;
      }
      [DeBugInfo(56, "Zara Ali", "19/10/2012")]
      public void Display()
      {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle  
   
   class ExecuteRectangle
   {
      static void Main(string[] args)
      {
         Rectangle r = new Rectangle(4.5, 7.5);
         r.Display();
         Type type = typeof(Rectangle);
         // 遍历 Rectangle 类的特性
         foreach (Object attributes in type.GetCustomAttributes(false))
         {
            DeBugInfo dbi = (DeBugInfo)attributes;
            if (null != dbi)
            {
               Console.WriteLine("Bug no: {0}", dbi.BugNo);
               Console.WriteLine("Developer: {0}", dbi.Developer);
               Console.WriteLine("Last Reviewed: {0}",
                                        dbi.LastReview);
               Console.WriteLine("Remarks: {0}", dbi.Message);
            }
         }
         
         // 遍历方法特性
         foreach (MethodInfo m in type.GetMethods())
         {
            foreach (Attribute a in m.GetCustomAttributes(true))
            {
               DeBugInfo dbi = (DeBugInfo)a;
               if (null != dbi)
               {
                  Console.WriteLine("Bug no: {0}, for Method: {1}",
                                                dbi.BugNo, m.Name);
                  Console.WriteLine("Developer: {0}", dbi.Developer);
                  Console.WriteLine("Last Reviewed: {0}",
                                                dbi.LastReview);
                  Console.WriteLine("Remarks: {0}", dbi.Message);
               }
            }
         }
         Console.ReadLine();
      }
   }
}

/*
Length: 4.5
Width: 7.5
Area: 33.75
Bug No: 49
Developer: Nuha Ali
Last Reviewed: 10/10/2012
Remarks: Unused variable
Bug No: 45
Developer: Zara Ali
Last Reviewed: 12/8/2012
Remarks: Return type mismatch
Bug No: 55, for Method: GetArea
Developer: Zara Ali
Last Reviewed: 19/10/2012
Remarks: Return type mismatch
Bug No: 56, for Method: Display
Developer: Zara Ali
Last Reviewed: 19/10/2012
Remarks: 
*/
```

------

### C# 属性（Property）

> **属性（Property）** 是类（class）、结构（structure）和接口（interface）的命名（named）成员。类或结构中的成员变量或方法称为 **域（Field）**。属性（Property）是域（Field）的扩展，且可使用相同的语法来访问。它们使用 **访问器（accessors）** 让私有域的值可被读写或操作。
>
> 属性（Property）不会确定存储位置。相反，它们具有可读写或计算它们值的 **访问器（accessors）**。

例如，有一个名为 Student 的类，带有 age、name 和 code 的私有域。我们不能在类的范围以外直接访问这些域，但是我们可以拥有访问这些私有域的属性。

## 访问器（Accessors）

属性（Property）的**访问器（accessor）**包含有助于获取（读取或计算）或设置（写入）属性的可执行语句。访问器（accessor）声明可包含一个 get 访问器、一个 set 访问器，或者同时包含二者。例如：

```c#
//声明类型为 string 的 code 属性

public string Code
{
	get
	{
		return code;
	}
	set
	{
		code = value;
	}
}

//声明类型为 string 的 name 属性
public string Name
{
	get
	{
		return name;
	}
	set
	{
		name = value;
	}
}

//声明类型为 int 的 Age属性
public int Age
{
	get
	{
		return age;
	}
	set
	{
		age = value;
	}
}
```

#### 实例

下面的实例演示了属性（Property）的用法：

```c#
using System;
namespace tutorialspoint
{
   class Student
   {

      private string code = "N.A";
      private string name = "not known";
      private int age = 0;

      // 声明类型为 string 的 Code 属性
      public string Code
      {
         get
         {
            return code;
         }
         set
         {
            code = value;
         }
      }
   
      // 声明类型为 string 的 Name 属性
      public string Name
      {
         get
         {
            return name;
         }
         set
         {
            name = value;
         }
      }

      // 声明类型为 int 的 Age 属性
      public int Age
      {
         get
         {
            return age;
         }
         set
         {
            age = value;
         }
      }
      public override string ToString()
      {
         return "Code = " + Code +", Name = " + Name + ", Age = " + Age;
      }
    }
    class ExampleDemo
    {
      public static void Main()
      {
         // 创建一个新的 Student 对象
         Student s = new Student();
            
         // 设置 student 的 code、name 和 age
         s.Code = "001";
         s.Name = "Zara";
         s.Age = 9;
         Console.WriteLine("Student Info: {0}", s);
         // 增加年龄
         s.Age += 1;
         Console.WriteLine("Student Info: {0}", s);
         Console.ReadKey();
       }
   }
}

//Student Info: Code = 001, Name = Zara, Age = 9
//Student Info: Code = 001, Name = Zara, Age = 10
```



#### 抽象属性（Abstract Properties）

抽象类可拥有抽象属性，这些属性应在派生类中被实现。下面的程序说明了这点：

```c#
using System;
namespace tutorialspoint
{
   public abstract class Person
   {
      public abstract string Name
      {
         get;
         set;
      }
      public abstract int Age
      {
         get;
         set;
      }
   }
   class Student : Person
   {

      private string code = "N.A";
      private string name = "N.A";
      private int age = 0;

      // 声明类型为 string 的 Code 属性
      public string Code
      {
         get
         {
            return code;
         }
         set
         {
            code = value;
         }
      }
   
      // 声明类型为 string 的 Name 属性
      public override string Name
      {
         get
         {
            return name;
         }
         set
         {
            name = value;
         }
      }

      // 声明类型为 int 的 Age 属性
      public override int Age
      {
         get
         {
            return age;
         }
         set
         {
            age = value;
         }
      }
      public override string ToString()
      {
         return "Code = " + Code +", Name = " + Name + ", Age = " + Age;
      }
   }
   class ExampleDemo
   {
      public static void Main()
      {
         // 创建一个新的 Student 对象
         Student s = new Student();
            
         // 设置 student 的 code、name 和 age
         s.Code = "001";
         s.Name = "Zara";
         s.Age = 9;
         Console.WriteLine("Student Info:- {0}", s);
         // 增加年龄
         s.Age += 1;
         Console.WriteLine("Student Info:- {0}", s);
         Console.ReadKey();
       }
   }
}

//Student Info: Code = 001, Name = Zara, Age = 9
//Student Info: Code = 001, Name = Zara, Age = 10
```



------

### C# 索引器（Indexer）

**索引器（Indexer）** 允许一个对象可以像数组一样被索引。当您为类定义一个索引器时，该类的行为就会像一个 **虚拟数组（virtual array）** 一样。您可以使用数组访问运算符（[ ]）来访问该类的实例。



#### 索引器（Indexer）的用途

索引器的行为的声明在某种程度上类似于属性（property）。就像属性（property），您可使用 **get** 和 **set** 访问器来定义索引器。但是，属性返回或设置一个特定的数据成员，而索引器返回或设置对象实例的一个特定值。换句话说，它把实例数据分为更小的部分，并索引每个部分，获取或设置每个部分。

定义一个属性（property）包括提供属性名称。索引器定义的时候不带有名称，但带有 **this** 关键字，它指向对象实例。下面的实例演示了这个概念：

```c#
using System;
namespace IndexerApplication
{
   class IndexedNames
   {
      private string[] namelist = new string[size];
      static public int size = 10;
      public IndexedNames()
      {
         for (int i = 0; i < size; i++)
         namelist[i] = "N. A.";
      }
      public string this[int index]
      {
         get
         {
            string tmp;

            if( index >= 0 && index <= size-1 )
            {
               tmp = namelist[index];
            }
            else
            {
               tmp = "";
            }

            return ( tmp );
         }
         set
         {
            if( index >= 0 && index <= size-1 )
            {
               namelist[index] = value;
            }
         }
      }

      static void Main(string[] args)
      {
         IndexedNames names = new IndexedNames();
         names[0] = "Zara";
         names[1] = "Riz";
         names[2] = "Nuha";
         names[3] = "Asif";
         names[4] = "Davinder";
         names[5] = "Sunil";
         names[6] = "Rubic";
         for ( int i = 0; i < IndexedNames.size; i++ )
         {
            Console.WriteLine(names[i]);
         }
         Console.ReadKey();
      }
   }
}

/*
Zara
Riz
Nuha
Asif
Davinder
Sunil
Rubic
N. A.
N. A.
N. A.
*/
```



#### 重载索引器（Indexer）

索引器（Indexer）可被重载。索引器声明的时候也可带有多个参数，且每个参数可以是不同的类型。没有必要让索引器必须是整型的。C# 允许索引器可以是其他类型，例如，字符串类型。

下面的实例演示了重载索引器：



```c#
using System;
namespace IndexerApplication
{
   class IndexedNames
   {
      private string[] namelist = new string[size];
      static public int size = 10;
      public IndexedNames()
      {
         for (int i = 0; i < size; i++)
         {
          namelist[i] = "N. A.";
         }
      }
      public string this[int index]
      {
         get
         {
            string tmp;

            if( index >= 0 && index <= size-1 )
            {
               tmp = namelist[index];
            }
            else
            {
               tmp = "";
            }

            return ( tmp );
         }
         set
         {
            if( index >= 0 && index <= size-1 )
            {
               namelist[index] = value;
            }
         }
      }
      public int this[string name]
      {
         get
         {
            int index = 0;
            while(index < size)
            {
               if (namelist[index] == name)
               {
                return index;
               }
               index++;
            }
            return index;
         }

      }

      static void Main(string[] args)
      {
         IndexedNames names = new IndexedNames();
         names[0] = "Zara";
         names[1] = "Riz";
         names[2] = "Nuha";
         names[3] = "Asif";
         names[4] = "Davinder";
         names[5] = "Sunil";
         names[6] = "Rubic";
         // 使用带有 int 参数的第一个索引器
         for (int i = 0; i < IndexedNames.size; i++)
         {
            Console.WriteLine(names[i]);
         }
         // 使用带有 string 参数的第二个索引器
         Console.WriteLine(names["Nuha"]);
         Console.ReadKey();
      }
   }
}

/*
Zara
Riz
Nuha
Asif
Davinder
Sunil
Rubic
N. A.
N. A.
N. A.
2
*/
```



------

#### C# 委托（Delegate）

C# 中的委托（Delegate）类似于 C 或 C++ 中函数的指针。**委托（Delegate）** 是存有对某个方法的引用的一种引用类型变量。引用可在运行时被改变。

委托（Delegate）特别用于实现事件和回调方法。所有的委托（Delegate）都派生自 **System.Delegate** 类。



#### 声明委托（Delegate）

委托声明决定了可由该委托引用的方法。委托可指向一个与其具有相同标签的方法。

例如，假设有一个委托：

```
delegate <return type> <delegate-name> <parameter list>
```

#### 实例化委托（Delegate）

一旦声明了委托类型，委托对象必须使用 **new** 关键字来创建，且与一个特定的方法有关。当创建委托时，传递到 **new** 语句的参数就像方法调用一样书写，但是不带有参数。例如：

```c#
public delegate void printString(string s);
...
printString ps1 = new printString(WriteToScreen);
printString ps2 = new printString(WriteToFile);
```



下面的实例演示了委托的声明、实例化和使用，该委托可用于引用带有一个整型参数的方法，并返回一个整型值。

```c#
using System;

delegate int NumberChanger(int n);
namespace DelegateAppl
{
   class TestDelegate
   {
      static int num = 10;
      public static int AddNum(int p)
      {
         num += p;
         return num;
      }

      public static int MultNum(int q)
      {
         num *= q;
         return num;
      }
      public static int getNum()
      {
         return num;
      }

      static void Main(string[] args)
      {
         // 创建委托实例
         NumberChanger nc1 = new NumberChanger(AddNum);
         NumberChanger nc2 = new NumberChanger(MultNum);
         // 使用委托对象调用方法
         nc1(25);
         Console.WriteLine("Value of Num: {0}", getNum());
         nc2(5);
         Console.WriteLine("Value of Num: {0}", getNum());
         Console.ReadKey();
      }
   }
}

//Value of Num: 35
//Value of Num: 175
```



#### 委托的多播（Multicasting of a Delegate）

委托对象可使用 "+" 运算符进行合并。一个合并委托调用它所合并的两个委托。只有相同类型的委托可被合并。"-" 运算符可用于从合并的委托中移除组件委托。

使用委托的这个有用的特点，您可以创建一个委托被调用时要调用的方法的调用列表。这被称为委托的 **多播（multicasting）**，也叫组播。下面的程序演示了委托的多播：



```c#
using System;

delegate int NumberChanger(int n);
namespace DelegateAppl
{
   class TestDelegate
   {
      static int num = 10;
      public static int AddNum(int p)
      {
         num += p;
         return num;
      }

      public static int MultNum(int q)
      {
         num *= q;
         return num;
      }
      public static int getNum()
      {
         return num;
      }

      static void Main(string[] args)
      {
         // 创建委托实例
         NumberChanger nc;
         NumberChanger nc1 = new NumberChanger(AddNum);
         NumberChanger nc2 = new NumberChanger(MultNum);
         nc = nc1;
         nc += nc2;
         // 调用多播
         nc(5);
         Console.WriteLine("Value of Num: {0}", getNum());
         Console.ReadKey();
      }
   }
}

//Value of Num: 75
```



#### 委托（Delegate）的用途

下面的实例演示了委托的用法。委托 *printString* 可用于引用带有一个字符串作为输入的方法，并不返回任何东西。

我们使用这个委托来调用两个方法，第一个把字符串打印到控制台，第二个把字符串打印到文件：

```c#
using System;
using System.IO;

namespace DelegateAppl
{
   class PrintString
   {
      static FileStream fs;
      static StreamWriter sw;
      // 委托声明
      public delegate void printString(string s);

      // 该方法打印到控制台
      public static void WriteToScreen(string str)
      {
         Console.WriteLine("The String is: {0}", str);
      }
      // 该方法打印到文件
      public static void WriteToFile(string s)
      {
         fs = new FileStream("c:\\message.txt",
         FileMode.Append, FileAccess.Write);
         sw = new StreamWriter(fs);
         sw.WriteLine(s);
         sw.Flush();
         sw.Close();
         fs.Close();
      }
      // 该方法把委托作为参数，并使用它调用方法
      public static void sendString(printString ps)
      {
         ps("Hello World");
      }
      static void Main(string[] args)
      {
         printString ps1 = new printString(WriteToScreen);
         printString ps2 = new printString(WriteToFile);
         sendString(ps1);
         sendString(ps2);
         Console.ReadKey();
      }
   }
}

//The String is: Hello World
```

------

### C# 事件（Event）

> **事件（Event）** 基本上说是一个用户操作，如按键、点击、鼠标移动等等，或者是一些出现，如系统生成的通知。应用程序需要在事件发生时响应事件。例如，中断。事件是用于进程间通信。

