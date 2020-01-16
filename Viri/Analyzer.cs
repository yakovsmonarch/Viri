using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Viri
{
	public class Analyzer
	{
		public static int sumCount{get; private set;}
		public static double sumLength{get; private set;}
		public static double sumTotalLength{get; private set;}
		public static int sumDimple{get; private set;}
		public static int sumTotalDimple{get; private set;}
		
		public string filename;
		public int count{get; private set;}
		public double length{get; private set;}
		public double totalLength{get; private set;}
		public int dimple{get; private set;}
		public int totalDimple{get; private set;}
		
		public string[] lines;
		public string error{get; private set;}
		
		public Analyzer(string filename)
		{
			this.filename = filename;
			this.count = 0;
			this.length = 0;
			this.totalLength = 0;
			error = "";
		}
		
		public static void CalcTotals(List<Analyzer> list)
		{
			sumCount = 0;
			sumLength = 0;
			sumTotalLength = 0;
			sumDimple = 0;
			sumTotalDimple = 0;
			foreach(Analyzer a in list)
			{
				sumCount += a.count;
				sumLength += a.length;
				sumTotalLength += a.totalLength;
				sumDimple += a.dimple;
				sumTotalDimple += a.totalDimple;
			}
		}

		void SetCount(int i)
		{
			this.count = i;
			this.totalLength = this.length * this.count;
			this.totalDimple = this.dimple * this.count;
		}
		void ReadCount()
		{
			Match match = Regex.Match(filename, @"_(\d+)pcs", RegexOptions.IgnoreCase);
			if(match.Success)
			{
				SetCount(int.Parse(match.Groups[1].Value));
			}
			else
			{
				SetCount(1);
			}
		}

		void ReadContent()
		{
			if(lines.Length < 4)
			{
				error = "Файл слишком короткий";
				return;
			}
			double myLength = 0;
			int myDimple = 0;
			for(int j = 3; j < lines.Length; j++)
			{
				string[] tabs = lines[j].Split('\t');
				if(tabs.Length < 5)
					continue;
				if(tabs[0] != "COMPONENT")
					continue;
				myLength += double.Parse( tabs[4], CultureInfo.InvariantCulture);
				myDimple = calcItems(tabs, "DIMPLE");
			}
			length = myLength;
			totalLength = count * length;
			dimple = myDimple;
			totalDimple = count * dimple;
		}

		void ReadDimple()
		{
			
		}
		
		int calcItems(string[] tabs, string item)
		{
			int q = 0;
			foreach(string tab in tabs)
			{
				if(tab.Trim() == item)
				{
					q++;
				}
			}
			return q;
		}
		
		public void ReadFile()
		{
			try
			{
				ReadCount();
				lines = File.ReadAllLines(filename);
				ReadContent();
			}
			catch(Exception ex)
			{
				this.error = ex.Message;
			}
		}
	}
}
