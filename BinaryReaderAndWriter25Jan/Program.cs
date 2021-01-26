using System;
using System.IO;

namespace BinaryReaderAndWriter25Jan
{
	class Program
	{
		static void WriteBinaryFile() //stores information in E:\\BinaryWriterFile.bin file
		{
			using (BinaryWriter bw = new BinaryWriter(File.Open("E:\\BinaryWriterFile.bin", FileMode.Create)))
			{
				try
				{
					Console.WriteLine("Writing to the file using BinaryWriter");

					bw.Write(10);//writing an int 
					bw.Write('S');//writing a char
					bw.Write(89.9f);//writing a float 
					bw.Write(875.99);//writing a double
					bw.Write("Binary Writer and Reader");//writing a String 
					bw.Write(true);//writing boolean value
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
		}
		static void ReadBinaryFile() //read data from bin file and displays on console screen.
		{
			using (BinaryReader br = new BinaryReader(File.Open("E:\\BinaryWriterFile.bin", FileMode.Open)))
			{
				try
				{
					Console.WriteLine("Reading values from a file using BinaryReader");

					Console.WriteLine("Int Value : " + br.ReadInt32());//reading an int 
					Console.WriteLine("Char Value : " + br.ReadChar());//reading a char 
					Console.WriteLine("Float Value : " + br.ReadSingle());//reading a float 
					Console.WriteLine("Double Value : " + br.ReadDouble());//reading a double
					Console.WriteLine("String entered : " + br.ReadString());//reading a string 
					Console.WriteLine("Boolean Value : " + br.ReadBoolean());//reading boolean value
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
		}
		static void Main(string[] args)
		{
			WriteBinaryFile();
			ReadBinaryFile();
			Console.ReadLine();
		}
	}
}