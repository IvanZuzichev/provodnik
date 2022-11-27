using System.Diagnostics;
namespace Provodnik
{
    internal class vibor
    {
        public static string[] vibr(string dirname)
        {
            Console.Clear();

            if (Directory.Exists(dirname))
            {
                int a = 0;
                int pos = 0;
                string[] Directories = Directory.GetDirectories(dirname);
                foreach (string dir in Directories)
                {
                    Console.SetCursorPosition(4, pos);
                    Console.WriteLine(dir);
                    Console.SetCursorPosition(75, pos);
                    Console.WriteLine(Directory.GetCreationTime(dir));
                    pos++;
                }
                string[] files = Directory.GetFiles(dirname);
                foreach (string file in files)
                {
                    Console.SetCursorPosition(4, pos);
                    Console.WriteLine(file);
                    Console.SetCursorPosition(75, pos);
                    Console.WriteLine(Directory.GetCreationTime(file));
                    pos++;
                }
                string[] list = new string[files.Length + Directories.Length];
                foreach (string file in Directories)
                {
                    list[a++] = file;
                }
                foreach (string file in files)
                {
                    list[a++] = file;
                }
                return list;
            }
            else 
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = dirname,
                    UseShellExecute = true
                });
                string[] vixod = new string[0];
                return vixod;
            }
        }
    }
}
