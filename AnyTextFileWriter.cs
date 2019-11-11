using System;
using System.IO;

class AnyTextFileWriter
{
	public static void Main(string[] args)
	{
		const string FilePath = "DemoFile.txt";
		
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		
		string pathString = System.IO.Path.Combine(folderPath,FilePath);
		
		try 
		{
			Console.WriteLine($"File written to {pathString}");
			
			if(!File.Exists(pathString))
			{
				File.Create(FilePath).Dispose();
				
				using (TextWriter newtw = new StreamWriter(pathString))
				{
					newtw.WriteLine("First line!");
				}
				
			}
			else if(File.Exists(pathString))
			{
				using (TextWriter newtw = new StreamWriter(pathString))
				{
					newtw.WriteLine("Another line!");
				}

			}
		}
		catch(Exception writeEx)
		{
			throw new Exception($"There was an error writing to the log {writeEx}");
		}
		
		
	}
}