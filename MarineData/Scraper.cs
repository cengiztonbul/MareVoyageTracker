using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Threading;

namespace MarineData
{
	public class Scraper
	{
		FirefoxDriver driver;
		FirefoxDriverService service;
		FirefoxOptions options;
		string shipDataUrl = "https://www.marinetraffic.com/en/ais/details/ships/imo:";

		int sleep_ms = 1200;
		int max_retry_count = 3;

		public Scraper()
		{
			options = new FirefoxOptions();
			options.AddArgument("-headless");

			service = FirefoxDriverService.CreateDefaultService();
			CreateNewDriver();
		}

		public Scraper(int retry_count, int sleep_ms)
		{
			options = new FirefoxOptions();
			options.AddArgument("-headless");

			service = FirefoxDriverService.CreateDefaultService();
			CreateNewDriver();
			this.max_retry_count = retry_count;
			this.sleep_ms = sleep_ms;
		}

		public ShipData GetShipData(string imo)
		{
			Console.WriteLine("Getting vessel data");
			ShipData shipData = null;
			int retries = 0;
			while (retries < max_retry_count)
			{
				retries++;
				try
				{
					driver.Navigate().GoToUrl(shipDataUrl + imo);
				}
				catch
				{
					if (retries == max_retry_count)
					{
						Console.WriteLine("Couldn't connect site");
						return shipData;
					}
					else
					{
						Console.WriteLine("RetryCount: " + retries);
					}
				}
			}
			retries = 0;
			while (retries < max_retry_count)
			{
				retries++;
				try
				{
					Thread.Sleep(sleep_ms);
					var t = driver.FindElementById("vesselDetails_voyageInfoSection");
					var detailItems = t.FindElements(By.ClassName("MuiGrid-item"));

					shipData = new ShipData();
					shipData.imo = imo;
					shipData.departurePort = detailItems[1].Text;
					shipData.destinationPort = detailItems[2].Text;
					shipData.departurePort.Replace('\n', ' ');
					shipData.destinationPort.Replace('\n', ' ');
					shipData.ATD = detailItems[8].Text;
					shipData.ETA = detailItems[9].Text;
					var shipNameElement = driver.FindElement(By.TagName("h1"));
					shipData.name = shipNameElement.Text;
				}
				catch
				{
					if (retries == max_retry_count)
					{
						Console.WriteLine("COULDN'T GET THE DATA");
					}
					else
					{
						Console.WriteLine("Retry Count: " + retries);
					}

				}
			}

			return shipData;
		}

		public void Quit()
		{
			driver.Quit();
		}

		public void CreateNewDriver()
		{
			service.FirefoxBinaryPath = Properties.Settings.Default.FirefoxLocation; // TODO: get the location from a file
			driver = new FirefoxDriver(service, options);
		}
	}
}
