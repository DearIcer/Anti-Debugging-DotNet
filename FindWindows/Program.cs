using System.Runtime.InteropServices;

[DllImport("user32.dll", CharSet = CharSet.Auto)]
static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
string windowName = "x64dbg";

while (true)
{
    if (FindWindow(null, windowName) != IntPtr.Zero)
    {
        Console.WriteLine("Debugger found.");
    }
    else
    {
        Console.WriteLine("No debugger found.");
    }
}