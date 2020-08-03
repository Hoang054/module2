using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Threading
{
	public class Program
	{
		private static string ROOTFOLDER = @"C:\Users\Hoang\Documents\module2\Threading\Threading";
		private static string DESTINATIONFOLDER = @"C:\Users\Hoang\Documents\module2\Threading\Threading\NewFolder";

		static void Main(string[] args)
		{
			string[] folders = new string[]{
			"Store A",
			"Store B",
			"Store C",
			};
			Console.WriteLine("Start copy");
			List<Task> tasks = new List<Task>();
			foreach (var folder in folders)
			{
				tasks.Add(Task.Factory.StartNew(() =>
				{
					var files = System.IO.Directory.EnumerateFiles(Path.Combine(ROOTFOLDER, folder), "*");
					foreach (var file in files)
					{
						File.Copy(file, Path.Combine(DESTINATIONFOLDER, Path.GetFileName(file)));
						Console.WriteLine(file + " is copied successfully.");
					}
				}));
			}

			Task.WhenAll(tasks.ToArray());
			Console.ReadLine();
		}
	}
}