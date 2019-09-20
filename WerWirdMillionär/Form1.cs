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
        private Image buttonRight = (Image)Resources.Button_PositivePress;
        private Image buttonFalse = (Image)Resources.Button_NegativePress;

        private Image jokerHover1 = (Image)Resources.Joker_1_hover;
        private Image jokerHover2 = (Image)Resources.Joker_2_hover;
        private Image jokerHover3 = (Image)Resources.Joker_3_hover;
        private Image joker1Idle = (Image)Resources.Joker_1;
        private Image joker2Idle = (Image)Resources.Joker_2;
        private Image joker3Idle = (Image)Resources.Joker_3;
        private Image joker1Used = (Image)Resources.Joker_1_used;
        private Image joker2Used = (Image)Resources.Joker_2_used;
        private Image joker3Used = (Image)Resources.Joker_3_used;

        private PictureBox[] answerButtons = new PictureBox[4];
        private Label[] answerLabels = new Label[4];

        private Boolean jokerStatus1 = true;
        private Boolean jokerStatus2 = true;
        private Boolean jokerStatus3 = true;
        OleDbConnection con = null;
        OleDbDataReader reader = null;
        private int schwierigkeit = 0;
        List<Frage> frageliste = new List<Frage>();
        private int preisStufe = -1;
        private String testDBString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\RitusChristus\Desktop\test1.accdb";
        private int r;

        private Label[] labelPreise;
        private Label[] labelZahlen;

        public Form1()
        {
            InitializeComponent();
            //ErstellePreisListe();
            ErstelleButtons();
            SetzeTransparenz();
            FillLabelAndButtons();
        }

        private void FillLabelAndButtons()
        {
            answerButtons[0] = button_answer_1;
            answerButtons[1] = button_answer_2;
            answerButtons[2] = button_answer_3;
            answerButtons[3] = button_answer_4;

            answerLabels[0] = label_answer_1;
            answerLabels[1] = label_answer_2;
            answerLabels[2] = label_answer_3;
            answerLabels[3] = label_answer_4;
        }

        private void verbindeDB()
        {
            con = new OleDbConnection();
            con.ConnectionString = Properties.Settings.Default.DBCon;
            //con.ConnectionString = testDBString;
            try
            {
                con.Open();
            }
            catch(OleDbException ex)
            {
                MessageBox.Show("Verbindung mit Datenbank nicht möglich");
            }
        }

        public void holeFrage()
        {
            schwierigkeit++;
            frageliste.Clear();
            Frage f = null;
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tFragen where Schwierigkeit = " + schwierigkeit;
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                f = MkFrageObject(reader);
                frageliste.Add(f);

            }
            //frageliste.Remove(f);
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
            r = new Random().Next(0, frageliste.Count());         
            label_question_1.Text = frageliste[r].Frage1;
            int s = new Random().Next(1, 4);
            if(s == 1)
            {
                label_answer_1.Text = frageliste[r].AntwortR;
                label_answer_2.Text = frageliste[r].AntwortF1;
                label_answer_3.Text = frageliste[r].AntwortF2;
                label_answer_4.Text = frageliste[r].AntwortF3;
            }
            else if(s == 2)
            {
                label_answer_2.Text = frageliste[r].AntwortR;
                label_answer_1.Text = frageliste[r].AntwortF1;
                label_answer_3.Text = frageliste[r].AntwortF2;
                label_answer_4.Text = frageliste[r].AntwortF3;
            }
            else if(s == 3)
            {
                label_answer_3.Text = frageliste[r].AntwortR;
                label_answer_1.Text = frageliste[r].AntwortF1;
                label_answer_2.Text = frageliste[r].AntwortF2;
                label_answer_4.Text = frageliste[r].AntwortF3;
            }
            else if(s == 4)
            {
                label_answer_4.Text = frageliste[r].AntwortR;
                label_answer_1.Text = frageliste[r].AntwortF1;
                label_answer_2.Text = frageliste[r].AntwortF2;
                label_answer_3.Text = frageliste[r].AntwortF3;
            }
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
            Label textBox = (Label)me;
            pos = this.PointToScreen(textBox.Location);
            pos = transparentParent.PointToClient(pos);
            textBox.Parent = transparentParent;
            textBox.Location = pos;
            
            textBox.BringToFront();

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

            // answerLabelNameA

            transparentParent = button_answer_1;
            me = label_answerLabelName_1;
            labelMe = (Label)me;
            pos = this.PointToScreen(labelMe.Location);
            pos = transparentParent.PointToClient(pos);
            labelMe.Parent = transparentParent;
            labelMe.Location = pos;
            labelMe.BackColor = Color.Transparent;
            labelMe.BringToFront();

            // answerLabelNameB

            transparentParent = button_answer_2;
            me = label_answerLabelName_2;
            labelMe = (Label)me;
            pos = this.PointToScreen(labelMe.Location);
            pos = transparentParent.PointToClient(pos);
            labelMe.Parent = transparentParent;
            labelMe.Location = pos;
            labelMe.BackColor = Color.Transparent;
            labelMe.BringToFront();

            // answerLabelNameC

            transparentParent = button_answer_3;
            me = label_answerLabelNameC_3;
            labelMe = (Label)me;
            pos = this.PointToScreen(labelMe.Location);
            pos = transparentParent.PointToClient(pos);
            labelMe.Parent = transparentParent;
            labelMe.Location = pos;
            labelMe.BackColor = Color.Transparent;
            labelMe.BringToFront();

            // answerLabelNameD

            transparentParent = button_answer_4;
            me = label_answerLabelName_4;
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
            groupBoxGeld.Controls.Clear();
            labelPreise = new Label[15];
            labelZahlen = new Label[15];
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
            labelPreise[preisStufe].ForeColor = Color.Green;
        }


        // Methode gilt für alle Buttons (MouseEnter) (CH)
        private void setAnswerButtonStateHover(object sender, EventArgs e)
        {
            if (button_weiter.Visible == false)
            {
                PictureBox me = (PictureBox)sender;
                me.Image = buttonHover;
            }
        }

        private void setJoker1ButtonStateHover(object sender, EventArgs e)
        {
            if (button_weiter.Visible == false && jokerStatus1 == true)
                button_joker_1.Image = jokerHover1;
        }

        private void setJoker2ButtonStateHover(object sender, EventArgs e)
        {
            if (button_weiter.Visible == false && jokerStatus2 ==true)
                button_joker_2.Image = jokerHover2;
        }

        private void setJoker3ButtonStateHover(object sender, EventArgs e)
        {
            if (button_weiter.Visible == false && jokerStatus3 == true)
                button_joker_3.Image = jokerHover3;
        }

        // Wird beim eintreten in den Ui_layer1 ausgeführt (MouserEnter) (CH)
        private void resetAnswerButtonState(object sender, EventArgs e)
        {
            if (button_weiter.Visible == false)
            {
                button_answer_1.Image = buttonIdle;
                button_answer_2.Image = buttonIdle;
                button_answer_3.Image = buttonIdle;
                button_answer_4.Image = buttonIdle;
                if(jokerStatus1 == true)
                    button_joker_1.Image = joker1Idle;
                if (jokerStatus2 == true)
                    button_joker_2.Image = joker2Idle;
                if (jokerStatus3 == true)
                    button_joker_3.Image = joker3Idle;
            }

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
                String myStingValue = answerLabels[index - 1].Text;
                if(myStingValue == "")
                {
                    return;
                }
                if (myStingValue == frageliste[r].AntwortR && button_weiter.Visible == false)
                {
                    answerButtons[index - 1].Image = buttonRight;
                    RufeWeiterButton("Weiter");


                }
                else if (button_weiter.Visible == false)
                {
                    answerButtons[index - 1].Image = buttonFalse;
                    preisStufe = -1;
                    schwierigkeit = 0;
                    RufeWeiterButton("Verloren");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }


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
            if(index == 1 && jokerStatus1 == true)
            {
                useJoker1();
            }
            if (index == 2 && jokerStatus2 == true)
            {
                useJoker2();
            }
            if (index == 3 && jokerStatus3 == true)
            {
                useJoker3();
            }
        }

        private void RufeWeiterButton(String text)
        {
            label_weiter.Text = text;
            button_weiter.Visible = true;
            label_weiter.Visible = true;
        }

        private void OnWeiterClick(object sender, MouseEventArgs e)
        {
            button_weiter.Visible = false;
            label_weiter.Visible = false;
            if (preisStufe == -1)
            {
                verbindeDB();
                jokerStatus1 = true;
                jokerStatus2 = true;
                jokerStatus3 = true;
            }
            holeFrage();
            resetAnswerButtonState(sender,e);
            preisStufe++;
            if(preisStufe == 15)
            {
                MessageBox.Show("Sie haben Gewonnen!");
                Application.Exit();
            }
            ErstellePreisListe();
        }

        private void useJoker2() // 50/50
        {
            int counter = 0;
            int alradyChosenIndex = -1;
            while (counter < 2)
            {
                int rnd = new Random().Next(0, 3);
                if(answerLabels[rnd].Text != frageliste[r].AntwortR && alradyChosenIndex != rnd)
                {
                    answerLabels[rnd].Text = "";
                    alradyChosenIndex = rnd;
                    counter++;
                }
            }
            jokerStatus2 = false;
            button_joker_2.Image = joker2Used;
        }
        private void useJoker1() // Publikums joker
        {
            MessageBox.Show("Frag jemanden aus dem Publikum der die Frage beantworten kann, gib ihm 500€!");
            jokerStatus1 = false;
            button_joker_1.Image = joker1Used;
        }

        private void useJoker3()
        {
            int index = 0;
            if(label_answer_1.Text == frageliste[r].AntwortR)
            {
                index = 1;
            }
            if (label_answer_2.Text == frageliste[r].AntwortR)
            {
                index = 2;
            }
            if (label_answer_3.Text == frageliste[r].AntwortR)
            {
                index = 3;
            }
            if (label_answer_4.Text == frageliste[r].AntwortR)
            {
                index = 4;
            }
            int all = 100;
            int[] prozente = new int[5];
            prozente[index] += new Random().Next(30, 55);
            all -= prozente[index];
            for(int i = 1; i < 5;i++)
            {
                int rnd = new Random().Next(0, all+1);
                prozente[i] += rnd;
                all -= rnd;
                if(i== 4 || all == 0)
                {
                    if(all != 0)
                    {
                        i = 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            MessageBox.Show("Antwort A: " + prozente[1] + "%\n" + "Antwort B: " + prozente[2] + "%\n" + "Antwort C: " + prozente[3] + "%\n" +"Antwort D: " + prozente[4] + "%\n");
            jokerStatus3 = false;
            button_joker_3.Image = joker3Used;
        }

    }
}