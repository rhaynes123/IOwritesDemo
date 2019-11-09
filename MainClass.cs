using System;
using System.IO;

class AnyTextFileWriter
{
	public static void Main(string[] args)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		
		string FilePath = "DemoFile.txt";
		
		string pathString = System.IO.Path.Combine(folderPath,FilePath);
		
		Console.WriteLine("File written" + folderPath + pathString);
		
		if(!File.Exists(pathString))
		{
			File.Create(FilePath).Dispose();
			
			using (TextWriter newtw = new StreamWriter(pathString))
			{
				newtw.WriteLine("The very 1st line!");
			}
		}
		else if(File.Exists(pathString))
		{
			using (TextWriter newtw = new StreamWriter(pathString))
			{
				newtw.WriteLine("The next line!");
			}

		}
	}
}