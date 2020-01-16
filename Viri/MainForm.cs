using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Viri
{
	public partial class FormViri : Form
	{
		List<Analyzer> list = new List<Analyzer>();
		
		public FormViri()
		{
			InitializeComponent();
		}
		void ButtonOpenClick(object sender, EventArgs e)
		{
			openFiles.InitialDirectory = Environment.CurrentDirectory;
			openFiles.Filter = "CSV files (*.csv)|*.csv| All files (*.*)|*.*";
			if(openFiles.ShowDialog() != DialogResult.OK)
				return;
			LoadFiles(openFiles.FileNames);
			
		}

		void AddFile(string file)
		{
			Analyzer a = new Analyzer(file);
			list.Add(a);
			a.ReadFile();
			FileInfo fi = new FileInfo(file);
			
			int nr = grid.Rows.Count;
			grid.Rows.Add();
			grid["coNr", nr].Value = (nr + 1).ToString();
			grid["coFilename", nr].Value = fi.Name;
			grid["coCount", nr].Value = a.count;
			grid["coLength", nr].Value = a.length.ToString("0.0");
			grid["coSumLength", nr].Value = a.totalLength.ToString("0.0");
			grid["coDimple", nr].Value = a.totalDimple;
			if(a.error != "")
			{
				labelError.Text += "#" + (nr+1).ToString() + " " + a.error + Environment.NewLine;
			}
		}
		
		void LoadFiles(string[] str)
		{
			Clear();
			foreach(string file in str)
			{
				AddFile(file);
			}
			Analyzer.CalcTotals(list);
			AddTotals();
		}
		
		void Clear()
		{
			grid.Rows.Clear();
			labelError.Text = "";
			list.Clear();
		}
		
		void AddTotals()
		{
			int n = grid.Rows.Count;
			grid.Rows.Add();
			grid["coNr", n].Value = "";
			grid["coFilename", n].Value = "TOTAL";
			grid["coCount", n].Value = Analyzer.sumCount;
			grid["coLength", n].Value = Analyzer.sumLength;
			grid["coSumLength", n].Value = Analyzer.sumTotalLength;
			grid["coDimple", n].Value = Analyzer.sumTotalDimple;
			grid.Rows[n].DefaultCellStyle.Font = new Font(
				grid.DefaultCellStyle.Font.FontFamily,
				grid.DefaultCellStyle.Font.Size * 1.1f,
				FontStyle.Bold);
			grid.Columns[4].DefaultCellStyle.BackColor = Color.Yellow;
			grid["coFilename", n].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
		}
	}
}
