using System.Diagnostics;

while (true)
{
    try
    {
        // Debugger.Launch会尝试启动调试器，如果用户已经附加了调试器，它将不执行任何操作。
        Debugger.Launch();
        Console.WriteLine("No debugger attached.");
    }
    catch (System.ComponentModel.Win32Exception)
    {
        // 如果调试器已经附加，捕获Win32异常
        Console.WriteLine("Debugger is attached.");
    }
}