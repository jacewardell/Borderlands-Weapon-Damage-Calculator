using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public class Model
	{
		double WBD;
		double EDM;
		double WPM;
		double total;
		double hitChance;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new View());
		}

		public Model(double _WBD, double _EDM, double _WPM)
		{
			WBD = _WBD;
			EDM = _EDM;
			WPM = _WPM;
		}

		public double CalculateTotal()
		{
			total = WBD + (WBD * EDM * WPM);
			return total;
		}

		public double CalculateChance(string weapType, int elemMult, Dictionary<string, List<double>> chanceTable)
		{
			List<double> chance;

			if (elemMult < 0)
				elemMult = 0;
			else if (elemMult > 4)
				elemMult = 4;
			chanceTable.TryGetValue(weapType, out chance);
			hitChance = chance[elemMult];
			return hitChance;
		}

		public double CalculateAverage()
		{
			return ((total * hitChance) + WBD * (1 - hitChance));
		}
	}
}
