using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.Diagnostics;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace MarineData
{
	public partial class MainForm : Form
	{
		Scraper sc;
		private readonly SynchronizationContext synchronizationContext;
		public MainForm()
		{
			InitializeComponent();
			this.FormClosed += QuitDriver;
			synchronizationContext = SynchronizationContext.Current; //context from UI thread  
			MouseDown += new MouseEventHandler(AppFormBase_MouseDown);
			MouseMove += new MouseEventHandler(AppFormBase_MouseMove);
			MouseUp += new MouseEventHandler(AppFormBase_MouseUp);
			
		}


		private void imoNumberInput_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.V)
			{
				imoNumberInput.Text += (string)Clipboard.GetData("Text");
				e.Handled = true;
			}

		}

		private async void processButton_Click(object sender, EventArgs e)
		{
			processButton.Enabled = false;
			UpdatePercentage(0);
			Log("Arama Baþlatýlýyor.");
			Properties.Settings.Default.sleepTime = (int) sleepTimeInput.Value;
			Properties.Settings.Default.retryCount = (int) retryCountInput.Value;
			Properties.Settings.Default.Save();
			try
			{
				sc = new Scraper(Properties.Settings.Default.retryCount, Properties.Settings.Default.sleepTime);
				Log("Tarayýcý açýldý.");
			}
			catch(Exception exception)
			{
				logList.Items.Add(exception.Message);
				processButton.Enabled = true;
				return;
			}
			string[] lines = new string[imoNumberInput.Lines.Length];
			imoNumberInput.Lines.CopyTo(lines, 0);
			await Task.Run(() =>
			{
			Excel excel = new Excel("save_file");// @"C:\Users\Cengiz\Desktop\marine_test1.xlsx", 1);
			excel.Write(0, 0, "IMO");
			excel.Write(0, 1, "Name");
			excel.Write(0, 2, "Departure");
			excel.Write(0, 3, "Destination");

			excel.Write(0, 4, "ATD");
			excel.Write(0, 5, "ETA");
			
			for (int i = 0; i < lines.Length; i++)
			{
				if (lines[i] == string.Empty)
				{
						UpdatePercentage((float)(i + 1) / lines.Length * 100);
						continue;	
				}

				Log("IMO:" + lines[i] + " verisi alýnýyor");
				ShipData ship = sc.GetShipData(lines[i]);
				
				if (ship != null)
				{
					excel.Write(i + 1, ship);
					Log(lines[i] + " verisi alýndý.");
				}
				else
				{
					excel.Write(i + 1, 0, lines[i - 1]);
					excel.Write(i + 1, 1, "VERÝ ALINAMADI.");
					Log("IMO: " + lines[i] + " VERÝSÝ ALINAMADI.");
				}
				UpdatePercentage((float)(i + 1) / lines.Length * 100);

				excel.Save();
			}
				excel.Close();
				excel.Display();

			} );

			if (sc != null)
				sc.Quit();

			Log("Arama Bitti.");
			
			processButton.Enabled = true;
		}
		public void UpdatePercentage(float percentage)
		{
			synchronizationContext.Post(new SendOrPostCallback(o =>
			{
				processPercentageLabel.Text = (Math.Round((float)o, 2)).ToString() + "%"; //((float)(i + 1) / lines.Length * 100).ToString() + "%";
			}), percentage);

		}
		public void Log(string text)
		{
			synchronizationContext.Post(new SendOrPostCallback(o =>
			{
				logList.Items.Add("[" + DateTime.Now + "] " + o); //((float)(i + 1) / lines.Length * 100).ToString() + "%";
			}), text);
		}

		public void QuitDriver(object sender, FormClosedEventArgs e)
		{
			if (sc != null)
				sc.Quit();
			Console.WriteLine("Closing");
		}

		private void firefoxLocationButton_Click(object sender, EventArgs e)
		{
			Console.WriteLine(Properties.Settings.Default.FirefoxLocation);

			using (var fbd = new OpenFileDialog())
			{
				DialogResult result = fbd.ShowDialog();
				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.FileName))
				{
					Console.WriteLine(fbd.FileName);
					Properties.Settings.Default.FirefoxLocation = fbd.FileName;
					Properties.Settings.Default.Save();
				}
			}
		}

		private void saveLocationButton_Click(object sender, EventArgs e)
		{
			Console.WriteLine(Properties.Settings.Default.SaveLocation);
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();
				Console.WriteLine(fbd.SelectedPath);
				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					Properties.Settings.Default.SaveLocation = fbd.SelectedPath + @"\";
					Properties.Settings.Default.Save();
				}
			}

		}
		public Point downPoint = Point.Empty;
		private void AppFormBase_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				downPoint = new Point(e.X, e.Y);
		}
		private void AppFormBase_MouseMove(object sender, MouseEventArgs e)
		{
			if (downPoint != Point.Empty)
				Location = new Point(Left + e.X - downPoint.X, Top + e.Y -downPoint.Y);
		}
		private void AppFormBase_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				downPoint = Point.Empty;
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void clearLog_Click(object sender, EventArgs e)
		{
			logList.Items.Clear();
		}

		private void clearImo_Click(object sender, EventArgs e)
		{
			imoNumberInput.Clear();
		}

		private void openSaveLocation_Click(object sender, EventArgs e)
		{
			Process cmd = new Process();
			Console.WriteLine("test");
			cmd.StartInfo.FileName = "cmd.exe";
			cmd.StartInfo.RedirectStandardInput = true;
			cmd.StartInfo.RedirectStandardOutput = true;
			cmd.StartInfo.CreateNoWindow = true;
			cmd.StartInfo.UseShellExecute = false;
			cmd.Start();
			Console.WriteLine(Properties.Settings.Default.SaveLocation.ToString());
			cmd.StandardInput.WriteLine("start " + Properties.Settings.Default.SaveLocation);
			cmd.StandardInput.Flush();
			cmd.StandardInput.Close();
			cmd.WaitForExit();

		}
	}
}
