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

