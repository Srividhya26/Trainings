using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileSystemOperations
{
    class Files
    {
        //To traverse through all the files in a folder
        public IEnumerable<string> GetAllFiles(string path,string searchPattern,SearchOption value)
        {
            return Directory.EnumerateFiles(path).Union(
                Directory.EnumerateDirectories(path).SelectMany(d =>
                {
                    try
                    {
                        return GetAllFiles(d,searchPattern,value);
                    }
                    catch (Exception)
                    {
                        return Enumerable.Empty<string>();
                    }
                }));
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\srividhya\Desktop\Trainings\Javascript\FileSystems";
            Files val = new Files();
            var res = val.GetAllFiles(path,"*", SearchOption.AllDirectories);
            Console.WriteLine(res.Count()); // To find total number of files in a folder
            foreach(string file in res)  //To find the file with similar text
            {
                string text = File.ReadAllText(file);
                if(text == "Gislen Software")
                {
                    var result = System.IO.Path.GetFullPath(file);
                    Console.WriteLine(result);

                    //To move the files to the new location 

                    System.IO.File.Move(result, @"C:\Users\srividhya\Desktop\Trainings\MovedCopy");
                }
                
            }

            //To find the jpg file

            var images = val.GetAllFiles(path, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".jpg"));
            foreach(string image in images)
            {
                var fileName = System.IO.Path.GetFullPath(image);
                Console.WriteLine("The image files with JPG Format is " + fileName);

                //To cut and move into different directory

                System.IO.File.Move(fileName, @"C: \Users\srividhya\Desktop\Trainings\MovedCopy");
            }
        }
    }
}




