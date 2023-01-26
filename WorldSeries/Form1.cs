using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSeries
{
    public partial class Form1 : Form
    {

        private string[] teamnames = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        private int[] teamwins = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outputLB.Text = "";
            using (StreamReader temptext = new StreamReader($"{Application.StartupPath}\\Teams.txt"))
            {
                string line;
                int i = 0;
                while ((line = temptext.ReadLine()) != null)
                {
                    string[] splitline = line.Split(',');
                    teamnames[i] = splitline[0];
                    teamwins[i] = int.Parse(splitline[1]);
                    i++;
                }
            }
            for (int i = 0; i < teamnames.Length; i++)
            {
                teamsLBOX.Items.Add(teamnames[i]);
            }
        }

        private void teamsLBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputLB.Text = $"The {teamnames[teamsLBOX.SelectedIndex]} have won {teamwins[teamsLBOX.SelectedIndex]} world series";
        }
    }
}
