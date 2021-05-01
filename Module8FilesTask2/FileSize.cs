using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8Files
{
    public class FileSize
    {
        public long FileSizeCount(string folder)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folder);
            DirectoryInfo[] directories = dirInfo.GetDirectories();
            FileInfo[] FI = dirInfo.GetFiles();
            long allFileSize = 0;
            
            if (dirInfo.Exists)
            {
                try
                {
                    foreach (FileInfo file in FI)
                    {
                        allFileSize += file.Length;
                    }
                    foreach (DirectoryInfo DI in directories)
                    {
                        allFileSize += FileSizeCount(DI.FullName);
                    }
                }

                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
             return allFileSize;
        }
    }
}
