namespace Provodnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Code();
        }
        static void Code()
        {
            int colvo = 0;
            int q = 0;
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("    " + "Название:" + drive.Name + " " + "Объем диска:" + drive.TotalSize / 1073741824 + " " + "Свободное пространство:" + drive.TotalFreeSpace / 1073741824);
                colvo++;
            }

            List<string> List2 = new List<string>();
            string[] list;
            Strelki maslist = new Strelki();

            int[] mesto = maslist.strelki(colvo);
            list = vibor.vibr(Convert.ToString(drives[mesto[0]]));
            List2.Add(Convert.ToString(drives[mesto[0]]));

            while (q == 0)
            {
                mesto = maslist.strelki(list.Length);
                List2.Add(Convert.ToString(list[mesto[0]]));
                list = vibor.vibr(Convert.ToString(list[mesto[0]]));
            }
        }
    }
}