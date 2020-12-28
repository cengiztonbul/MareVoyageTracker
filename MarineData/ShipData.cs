namespace MarineData
{
	public class ShipData
	{
		public string imo;
		public string name;

		public string ATD;
		public string ETA;
		public string departurePort;
		public string destinationPort;
		public override string ToString()
		{
			return  "departure: " + departurePort +
					"\ndestination: " + destinationPort +
					"\n" + ATD +
					"\n" + ETA;
		}
	}

}
