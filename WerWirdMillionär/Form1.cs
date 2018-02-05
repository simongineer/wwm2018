using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerWirdMillionär
{
    public partial class Form1 : Form
    {

        private Image buttonHover = (Image)Resources.Button_Hover;
        private Image buttonIdle = (Image)Resources.Button_Idle;

        private Image jokerHover1 = (Image)Resources.Joker_1_hover;
        private Image jokerHover2 = (Image)Resources.Joker_2_hover;
        private Image jokerHover3 = (Image)Resources.Joker_3_hover;
        private Image joker1Idle = (Image)Resources.Joker_1;
        private Image joker2Idle = (Image)Resources.Joker_2;
        private Image joker3Idle = (Image)Resources.Joker_3;

        OleDbConnection con = null;
        OleDbDataReader reader = null;
        private int schwierigkeit = 1;
        List<Frage> frageliste = new List<Frage>();
        public Form1()
        {
            InitializeComponent();
            ErstellePreisListe();
            ErstelleButtons();
            SetzeTransparenz();
        }

        private void verbindeDB()
        {
            con = new OleDbConnection();
            con.ConnectionString = Properties.Settings.Default.DBCon;
            try
            {
                con.Open();
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show("Verbindung mit Datenbank nicht möglich");
            }
            startenSpiel();
        }

        public void startenSpiel()
        {
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tFragen where Schwierigkeit = 1";
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Frage f = MkFrageObject(reader);
                frageliste.Add(f);

            }
            anzeigezufälligeFrage();

        }

        private Frage MkFrageObject(OleDbDataReader reader)
        {
            Frage f = new Frage();
            f.Id = reader.GetInt32(0);
            f.Schwierigkeit = reader.GetInt32(1);
            f.Frage1 = reader.GetString(2);
            f.AntwortR = reader.GetString(3);
            f.AntwortF1 = reader.GetString(4);
            f.AntwortF2 = reader.GetString(5);
            f.AntwortF3 = reader.GetString(6);
            return f;
        }

        private void anzeigezufälligeFrage()
        {
            int r = new Random().Next(0, frageliste.Count());         
            label_question_1.Text = frageliste[r].Frage1;
            label_answer_1.Text = frageliste[r].AntwortR;
            label_answer_2.Text = frageliste[r].AntwortF3;
            label_answer_3.Text = frageliste[r].AntwortF2;
            label_answer_4.Text = frageliste[r].AntwortF1;
        }

        // Made by Ch
        private void SetzeTransparenz()
        {

            Control transparentParent = null;
            Point pos = Point.Empty;
            Component me = null;
            PictureBox pictureBoxMe = null;
            Label labelMe = null;

            // Ui_layer1

            transparentParent = background;
            me = Ui_layer1;
            pictureBoxMe = (PictureBox)me;
            pos = this.PointToScreen(pictureBoxMe.Location);
            pos = transparentParent.PointToClient(pos);
            pictureBoxMe.Parent = transparentParent;
            pictureBoxMe.Location = pos;
            pictureBoxMe.BackColor = Color.Transparent;
            pictureBoxMe.BringToFront();

            // button_answer_1

            transparentParent = Ui_layer1;
            me = button_answer_1;
            pictureBoxMe = (PictureBox)me;
            pos = this.PointToScreen(pictureBoxMe.Location);
            pos = transparentParent.PointToClient(pos);
            pictureBoxMe.Parent = transparentParent;
            pictureBoxMe.Location = pos;
            pictureBoxMe.BackColor = Color.Transparent;
            pictureBoxMe.BringToFront();

            // label_answer_1

            transparentParent = button_answer_1;
            me = label_answer_1;
            labelMe = (Label)me;
            pos = this.PointToScreen(labelMe.Location);
            pos = transparentParent.PointToClient(pos);
            labelMe.Parent = transparentParent;
            labelMe.Location = pos;
            labelMe.BackColor = Color.Transparent;
            labelMe.BringToFront();

            // button_answer_2

            transparentParent = Ui_layer1;
            me = button_answer_2;
            pictureBoxMe = (PictureBox)me;
            pos = this.PointToScreen(pictureBoxMe.Location);
            pos = transparentParent.PointToClient(pos);
            pictureBoxMe.Parent = transparentParent;
            pictureBoxMe.Location = pos;
            pictureBoxMe.BackColor = Color.Transparent;
            pictureBoxMe.BringToFront();

            // label_answer_2

            transparentParent = button_answer_2;
            me = label_answer_2;
            labelMe = (Label)me;
            pos = this.PointToScreen(labelMe.Location);
            pos = transparentParent.PointToClient(pos);
            labelMe.Parent = transparentParent;
            labelMe.Location = pos;
            labelMe.BackColor = Color.Transparent;
            labelMe.BringToFront();

            // button_answer_3

            transparentParent = Ui_layer1;
            me = button_answer_3;
            pictureBoxMe = (PictureBox)me;
            pos = this.PointToScreen(pictureBoxMe.Location);
            pos = transparentParent.PointToClient(pos);
            pictureBoxMe.Parent = transparentParent;
            pictureBoxMe.Location = pos;
            pictureBoxMe.BackColor = Color.Transparent;
            pictureBoxMe.BringToFront();

            // label_answer_3

            transparentParent = button_answer_3;
            me = label_answer_3;
            labelMe = (Label)me;
            pos = this.PointToScreen(labelMe.Location);
            pos = transparentParent.PointToClient(pos);
            labelMe.Parent = transparentParent;
            labelMe.Location = pos;
            labelMe.BackColor = Color.Transparent;
            labelMe.BringToFront();

            // button_answer_4

            transparentParent = Ui_layer1;
            me = button_answer_4;
            pictureBoxMe = (PictureBox)me;
            pos = this.PointToScreen(pictureBoxMe.Location);
            pos = transparentParent.PointToClient(pos);
            pictureBoxMe.Parent = transparentParent;
            pictureBoxMe.Location = pos;
            pictureBoxMe.BackColor = Color.Transparent;
            pictureBoxMe.BringToFront();

            // label_answer_4

            transparentParent = button_answer_4;
            me = label_answer_4;
            labelMe = (Label)me;
            pos = this.PointToScreen(labelMe.Location);
            pos = transparentParent.PointToClient(pos);
            labelMe.Parent = transparentParent;
            labelMe.Location = pos;
            labelMe.BackColor = Color.Transparent;
            labelMe.BringToFront();

            // label_question_1

            transparentParent = Ui_layer1;
            me = label_question_1;
            labelMe = (Label)me;
            pos = this.PointToScreen(labelMe.Location);
            pos = transparentParent.PointToClient(pos);
            labelMe.Parent = transparentParent;
            labelMe.Location = pos;
            labelMe.BackColor = Color.Transparent;
            labelMe.BringToFront();

            // label_question_2

            transparentParent = Ui_layer1;
            me = label_question_2;
            labelMe = (Label)me;
            pos = this.PointToScreen(labelMe.Location);
            pos = transparentParent.PointToClient(pos);
            labelMe.Parent = transparentParent;
            labelMe.Location = pos;
            labelMe.BackColor = Color.Transparent;
            labelMe.BringToFront();

            // button_joker_1

            transparentParent = Ui_layer1;
            me = button_joker_1;
            pictureBoxMe = (PictureBox)me;
            pos = this.PointToScreen(pictureBoxMe.Location);
            pos = transparentParent.PointToClient(pos);
            pictureBoxMe.Parent = transparentParent;
            pictureBoxMe.Location = pos;
            pictureBoxMe.BackColor = Color.Transparent;
            pictureBoxMe.BringToFront();

            // button_joker_2

            transparentParent = Ui_layer1;
            me = button_joker_2;
            pictureBoxMe = (PictureBox)me;
            pos = this.PointToScreen(pictureBoxMe.Location);
            pos = transparentParent.PointToClient(pos);
            pictureBoxMe.Parent = transparentParent;
            pictureBoxMe.Location = pos;
            pictureBoxMe.BackColor = Color.Transparent;
            pictureBoxMe.BringToFront();

            // button_joker_3

            transparentParent = Ui_layer1;
            me = button_joker_3;
            pictureBoxMe = (PictureBox)me;
            pos = this.PointToScreen(pictureBoxMe.Location);
            pos = transparentParent.PointToClient(pos);
            pictureBoxMe.Parent = transparentParent;
            pictureBoxMe.Location = pos;
            pictureBoxMe.BackColor = Color.Transparent;
            pictureBoxMe.BringToFront();

            // button_weiter

            transparentParent = Ui_layer1;
            me = button_weiter;
            pictureBoxMe = (PictureBox)me;
            pos = this.PointToScreen(pictureBoxMe.Location);
            pos = transparentParent.PointToClient(pos);
            pictureBoxMe.Parent = transparentParent;
            pictureBoxMe.Location = pos;
            pictureBoxMe.BackColor = Color.Transparent;
            pictureBoxMe.BringToFront();

            // label_question_2

            transparentParent = button_weiter;
            me = label_weiter;
            labelMe = (Label)me;
            pos = this.PointToScreen(labelMe.Location);
            pos = transparentParent.PointToClient(pos);
            labelMe.Parent = transparentParent;
            labelMe.Location = pos;
            labelMe.BackColor = Color.Transparent;
            labelMe.BringToFront();


        }

        private void ErstelleButtons()
        {
            Label[] antwortButtons = new Label[4];
        }

        private void ErstellePreisListe()
        {
            Label[] labelPreise = new Label[15];
            Label[] labelZahlen = new Label[15];
            string[] preise = { "50", "100", "200", "300", "500", "1.000", "2.000", "4.000", "8.000", "16.000", "32.000", "64.000", "125.000", "500.000", "1 MILLION" };
            //preise
            for (int i = 0; i < 15; i++)
            {
                labelPreise[i] = new Label();
                labelPreise[i].Font = new Font("Arial", 12/*, FontStyle.Bold*/);
                labelPreise[i].ForeColor = Color.Orange;
                labelPreise[i].Location = new Point(40, 285 - i * 19);
                if ((i + 1) % 5 == 0 && i != 0)//jedes 5te ist weis
                    labelPreise[i].ForeColor = Color.White;

                labelPreise[i].Text = String.Format("€ {0}", preise[i]);
                groupBoxGeld.Controls.Add(labelPreise[i]);
            }

            //Nummern
            for (int i = 0; i < 15; i++)
            {
                labelZahlen[i] = new Label();
                labelZahlen[i].Font = new Font("Arial", 12/*, FontStyle.Bold*/);
                labelZahlen[i].ForeColor = Color.Orange;
                labelZahlen[i].Location = new Point(8, 285 - i * 19);
                if ((i + 1) % 5 == 0 && i != 0)//jedes 5te ist weis
                    labelZahlen[i].ForeColor = Color.White;
                if ((i + 1) < 10)
                    labelZahlen[i].Text = String.Format("  {0}", i + 1);
                else
                    labelZahlen[i].Text = String.Format("{0}", i + 1);
                groupBoxGeld.Controls.Add(labelZahlen[i]);
            }
        }


        // Methode gilt für alle Buttons (MouseEnter) (CH)
        private void setAnswerButtonStateHover(object sender, EventArgs e)
        {
            PictureBox me = (PictureBox)sender;
            me.Image = buttonHover;
        }

        private void setJoker1ButtonStateHover(object sender, EventArgs e)
        {
            button_joker_1.Image = jokerHover1;
        }

        private void setJoker2ButtonStateHover(object sender, EventArgs e)
        {
            button_joker_2.Image = jokerHover2;
        }

        private void setJoker3ButtonStateHover(object sender, EventArgs e)
        {
            button_joker_3.Image = jokerHover3;
        }

        // Wird beim eintreten in den Ui_layer1 ausgeführt (MouserEnter) (CH)
        private void resetAnswerButtonState(object sender, EventArgs e)
        {
            button_answer_1.Image = buttonIdle;
            button_answer_2.Image = buttonIdle;
            button_answer_3.Image = buttonIdle;
            button_answer_4.Image = buttonIdle;
            button_joker_1.Image = joker1Idle;
            button_joker_2.Image = joker2Idle;
            button_joker_3.Image = joker3Idle;

        }
        // Methode gilt für alle Buttons (MosueClick) (CH)
        private void getAnswerIndex(object sender, MouseEventArgs e)
        {
            Int32 index = 0;
            try
            {
                String indexSting = ((Control)sender).Name.Split('_')[2];
                bool result = Int32.TryParse(indexSting, out index);
                if (result == false)
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }


            MessageBox.Show("Es wurde " + index + " ausgewählt!");


        }

        private void getJokerIndex(object sender, MouseEventArgs e)
        {
            Int32 index = 0;
            try
            {
                String indexSting = ((Control)sender).Name.Split('_')[2];
                bool result = Int32.TryParse(indexSting, out index);
                if (result == false)
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

            MessageBox.Show("Es wurde Joker " + index + " ausgewählt!");
        }

        private void OnWeiterClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Es wurde auf weiter geklickt");
            button_weiter.Visible = false;
            label_weiter.Visible = false;
            verbindeDB();
        }

    }
}