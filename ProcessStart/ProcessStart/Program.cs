using System.Diagnostics;

namespace ProcessStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("http://www.almocando.com.br/");
            Process.Start("explorer.exe");
            Process.Start(@"C:\Windows\Web\Wallpaper\Theme1\img1.jpg");
        }
    }
}