using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.Diagnostics;

namespace MarineData
{

	public class Excel
	{
		string path;

		_Application excel = new _Excel.Application();
		Workbook wb;
		Worksheet ws;
		object misValue = System.Reflection.Missing.Value;
		bool savedAs;

		public Excel(string path, int sheet)
		{
			this.path = path;
			wb = excel.Workbooks.Open(path);
			ws = wb.Worksheets[sheet];
			savedAs = true;
		}
		public Excel(string saveName)
		{
			savedAs = false;
			saveName += "-" + DateTime.Now.Ticks + "-";
			path = Properties.Settings.Default.SaveLocation + saveName + ".xlsx";
			wb = excel.Workbooks.Add(misValue);
			ws = wb.Worksheets[1];
		}

		public string ReadValue(int x, int y)
		{
			x++;
			y++;

			if (ws.Cells[x, y] == null || ws.Cells[x, y].Value2 == null)
			{
				return "";
			}

			return ws.Cells[x, y].Value2;
		}

		public void Close()
		{
			wb.Save();
			wb.Close();
		}

		public void Write(int x, int y, string data)
		{
			x++;
			y++;
			ws.Cells[x, y].Value2 = data;
		}

		public void Write(int row, ShipData ship)
		{
			row++;
			if (ship == null)
				return;

			ws.Cells[row, 1].Value2 = ship.imo;
			ws.Cells[row, 2].Value2 = ship.name;
			ws.Cells[row, 3].Value2 = ship.departurePort;
			ws.Cells[row, 4].Value2 = ship.destinationPort;
			ws.Cells[row, 5].Value2 = ship.ATD;
			ws.Cells[row, 6].Value2 = ship.ETA;
			ws.Cells[row, 7].Formula = string.Format("=IFERROR(LEFT($C{0}, SEARCH(CHAR(10), $C{0})-1),$C{0})& \" \" &MID($E{0},6,10)", row);
			ws.Cells[row, 8].Formula = string.Format("=IFERROR(LEFT($D{0}, SEARCH(CHAR(10), $D{0})-1),$D{0})&\" \"&MID($F{0},6,10)", row);
			ws.Cells[row, 7].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
			ws.Cells[row, 8].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
		}

		public void Save()
		{
			if(!savedAs)
			{
				savedAs = true;
				wb.SaveAs(path, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, misValue,
				misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
			}
			else
			{
				wb.Save();
			}
		}

		public void Display()
		{
			Process cmd = new Process();
			cmd.StartInfo.FileName = "cmd.exe";
			cmd.StartInfo.RedirectStandardInput = true;
			cmd.StartInfo.RedirectStandardOutput = true;
			cmd.StartInfo.CreateNoWindow = true;
			cmd.StartInfo.UseShellExecute = false;
			cmd.Start();

			cmd.StandardInput.WriteLine(path);
			cmd.StandardInput.Flush();
			cmd.StandardInput.Close();
			cmd.WaitForExit();
		}
	}
}

