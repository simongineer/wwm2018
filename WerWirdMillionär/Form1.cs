using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerWirdMillionär
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ErstellePreisListe();
        }

        private void ErstellePreisListe()
        {
            Label[] labelPreise = new Label[15];
            Label[] labelZahlen = new Label[15];
            string[] preise = {"50","100","200","300","500","1.000","2.000","4.000","8.000","16.000","32.000","64.000","125.000","500.000","1 MILLION"};
            //preise
            for (int i = 0; i < 15; i++)
            {
                labelPreise[i] = new Label();
                labelPreise[i].Font = new Font("Arial", 12/*, FontStyle.Bold*/);
                labelPreise[i].ForeColor = Color.Orange;
                labelPreise[i].Location = new Point(40, 285-i*19);
                if((i+1)%5==0 && i!=0)//jedes 5te ist weis
                    labelPreise[i].ForeColor = Color.White;

                labelPreise[i].Text = String.Format("€ {0}", preise[i]);
                groupBoxGeld.Controls.Add(labelPreise[i]);
            }
            
            //Nummern
            for(int i = 0; i<15; i++)
            {
                labelZahlen[i] = new Label();
                labelZahlen[i].Font = new Font("Arial", 12/*, FontStyle.Bold*/);
                labelZahlen[i].ForeColor = Color.Orange;
                labelZahlen[i].Location = new Point(8, 285 - i * 19);
                if ((i + 1) % 5 == 0 && i != 0)//jedes 5te ist weis
                    labelZahlen[i].ForeColor = Color.White;
                if((i+1)<10)
                    labelZahlen[i].Text = String.Format("  {0}", i + 1);
                else
                    labelZahlen[i].Text = String.Format("{0}", i + 1);
                groupBoxGeld.Controls.Add(labelZahlen[i]);
            }
        }
    }
}
