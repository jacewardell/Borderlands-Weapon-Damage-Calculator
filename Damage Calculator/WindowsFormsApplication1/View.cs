/**
 * This is the controller.  It handles data going to the 'View' and to and from the 'Model'
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class View : Form
	{
		private Dictionary<string, List<double>> WPMTable;
		private Dictionary<string, List<double>> chanceTable;
		private double WBD;
		private double EDM;
		private double WPM;

		public View()
		{
			InitializeComponent();

			weapType1.SelectedIndex = 0;
			weapType2.SelectedIndex = 0;

			elemChoice1.SelectedIndex = 0;
			elemChoice2.SelectedIndex = 0;

			populateWPM();
		}

		private void populateWPM()
		{
			WPMTable = new Dictionary<string, List<double>>();
			chanceTable = new Dictionary<string, List<double>>();
			List<double> procMult = new List<double>();
			List<double> procChance = new List<double>();

			
			//For Assault Rifle
			procMult.Add(0);
			for (int i = 0; i < 3; i++)
				procMult.Add(1);
			procMult.Add(1.5);
			WPMTable.Add("Assault Rifle", procMult);
			procMult = new List<double>();

			procChance.Add(0);
			procChance.Add(.7);
			procChance.Add(.2);
			procChance.Add(.2);
			procChance.Add(.4);
			chanceTable.Add("Assault Rifle", procChance);
			procChance = new List<double>();

			//For Repeater
			procMult.Add(0);
			for (int i = 0; i < 4; i++)
				procMult.Add(1);
			WPMTable.Add("Repeater", procMult);
			procMult = new List<double>();

			procChance.Add(0);
			procChance.Add(.3);
			for (int i = 0; i < 2; i++)
				procChance.Add(.15);
			procChance.Add(.10);
			chanceTable.Add("Repeater", procChance);
			procChance = new List<double>();

			//For Revolver
			procMult.Add(0);
			for (int i = 0; i < 2; i++)
				procMult.Add(1);
			procMult.Add(1.5);
			procMult.Add(2);
			WPMTable.Add("Revolver", procMult);
			procMult = new List<double>();

			procChance.Add(0);
			procChance.Add(1);
			procChance.Add(.4);
			procChance.Add(.2);
			procChance.Add(.15);
			chanceTable.Add("Revolver", procChance);
			procChance = new List<double>();

			//For Rocket Launcher
			procMult.Add(0);
			procChance.Add(0);
			for (int i = 0; i < 4; i++)
			{
				procMult.Add(1);
				procChance.Add(1);
			}
			WPMTable.Add("Rocket Launcher", procMult);
			procMult = new List<double>();

			chanceTable.Add("Rocket Launcher", procChance);
			procChance = new List<double>();

			//For Shotgun
			procMult.Add(0);
			for (int i = 0; i < 4; i++)
				procMult.Add(1);
			WPMTable.Add("Shotgun", procMult);
			procMult = new List<double>();

			procChance.Add(0);
			procChance.Add(.25);
			for (int i = 0; i < 2; i++)
				procChance.Add(.10);
			procChance.Add(.15);
			chanceTable.Add("Shotgun", procChance);
			procChance = new List<double>();

			//For SMG
			procMult.Add(0);
			for (int i = 0; i < 4; i++)
				procMult.Add(1);
			WPMTable.Add("SMG", procMult);
			procMult = new List<double>();

			procChance.Add(0);
			procChance.Add(.25);
			for (int i = 0; i < 2; i++)
				procChance.Add(.10);
			procChance.Add(.20);
			chanceTable.Add("SMG", procChance);
			procChance = new List<double>();

			//For Sniper Rifle
			procMult.Add(0);
			for (int i = 0; i < 2; i++)
				procMult.Add(1);
			procMult.Add(1.5);
			procMult.Add(2);
			WPMTable.Add("Sniper Rifle", procMult);

			procChance.Add(0);
			for (int i = 0; i < 4; i++)
				procChance.Add(1);
			chanceTable.Add("Sniper Rifle", procChance);
		}

		private void View_Load(object sender, EventArgs e)
		{

		}

		private void calculate_Click(object sender, EventArgs e)
		{
			try
			{
				WBD = Convert.ToDouble(weapDam1.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please enter a number for 'Weapon Damage #1'");
			}

			EDM = CalculateEDM(elemChoice1.Text);

			try
			{
				WPM = CalculateWPM(weapType1.Text, Convert.ToDouble(elemMult1.Text));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please enter a number for 'Element Multiplier #1'");
				elemMult1.Text = "0";
			}

			Model mod = new Model(WBD, EDM, WPM);

			total1.Text = mod.CalculateTotal().ToString();
			procChanceBox1.Text = mod.CalculateChance(weapType1.Text, 
				Convert.ToInt32(elemMult1.Text), chanceTable).ToString();
			averageDam1.Text = mod.CalculateAverage().ToString();

			WBD = EDM = WPM = 0;

			try
			{
				WBD = Convert.ToDouble(weapDam2.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please enter a number for 'Weapon Damage #2'");
			}

			EDM = CalculateEDM(elemChoice2.Text);

			try
			{
				WPM = CalculateWPM(weapType1.Text, Convert.ToDouble(elemMult2.Text));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please enter a number for 'Element Multiplier #2'");
				elemMult2.Text = "0";
			}

			mod = new Model(WBD, EDM, WPM);

			total2.Text = mod.CalculateTotal().ToString();
			procChanceBox2.Text = mod.CalculateChance(weapType2.Text,
				Convert.ToInt32(elemMult2.Text), chanceTable).ToString();
			averageDam2.Text = mod.CalculateAverage().ToString();

			WBD = EDM = WPM = 0;
		}

		private double CalculateEDM(string elemChoice)
		{
			if (elemChoice.Equals("None"))
				return 0;
			else if (elemChoice.Equals("Incendiary"))
				return .60;
			else if (elemChoice.Equals("Shock"))
				return 1;
			else if (elemChoice.Equals("Explosive"))
				return 1.5;
			else
				return .40;
		}

		private double CalculateWPM(string weapType, double elemMult)
		{
			List<double> procMult;

			if (elemMult < 0)
				elemMult = 0;
			else if (elemMult > 4)
				elemMult = 4;

			WPMTable.TryGetValue(weapType, out procMult);

			return procMult[Convert.ToInt32(elemMult)];
		}

		private void elemChoice1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (elemChoice1.Text.Equals("None"))
			{
				elemMult1.Text = "0";
				elemMult1.Enabled = false;
			}
			else
			{
				elemMult1.Text = "1";
				elemMult1.Enabled = true;
			}
		}

		private void elemChoice2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (elemChoice2.Text.Equals("None"))
			{
				elemMult2.Text = "0";
				elemMult2.Enabled = false;
			}
			else
			{
				elemMult2.Text = "1";
				elemMult2.Enabled = true;
			}
		}

		private void elemMult1_Leave(object sender, EventArgs e)
		{
			try
			{
				if (Convert.ToInt32(elemMult1.Text) < 0)
					elemMult1.Text = "0";
				else if (Convert.ToInt32(elemMult1.Text) > 4)
					elemMult1.Text = "4";
			}
			catch (Exception ex)
			{
				elemMult1.Text = "0";
			}
		}

		private void elemMult2_Leave(object sender, EventArgs e)
		{
			try
			{
				if (Convert.ToInt32(elemMult2.Text) < 0)
					elemMult2.Text = "0";
				else if (Convert.ToInt32(elemMult2.Text) > 4)
					elemMult2.Text = "4";
			}
			catch (Exception ex)
			{
				elemMult2.Text = "0";
			}
		}
	}
}
