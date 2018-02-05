namespace WerWirdMillionär
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxGeld = new System.Windows.Forms.GroupBox();
            this.Ui_layer1 = new System.Windows.Forms.PictureBox();
            this.button_answer_1 = new System.Windows.Forms.PictureBox();
            this.label_answer_1 = new System.Windows.Forms.Label();
            this.label_answer_2 = new System.Windows.Forms.Label();
            this.button_answer_2 = new System.Windows.Forms.PictureBox();
            this.label_answer_3 = new System.Windows.Forms.Label();
            this.button_answer_3 = new System.Windows.Forms.PictureBox();
            this.label_answer_4 = new System.Windows.Forms.Label();
            this.button_answer_4 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.button_joker_1 = new System.Windows.Forms.PictureBox();
            this.button_joker_2 = new System.Windows.Forms.PictureBox();
            this.button_joker_3 = new System.Windows.Forms.PictureBox();
            this.button_weiter = new System.Windows.Forms.PictureBox();
            this.label_weiter = new System.Windows.Forms.Label();
            this.label_question_1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ui_layer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_answer_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_answer_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_answer_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_answer_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_joker_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_joker_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_joker_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_weiter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxGeld
            // 
            this.groupBoxGeld.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGeld.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxGeld.BackgroundImage")));
            this.groupBoxGeld.ForeColor = System.Drawing.Color.White;
            this.groupBoxGeld.Location = new System.Drawing.Point(511, 34);
            this.groupBoxGeld.Name = "groupBoxGeld";
            this.groupBoxGeld.Size = new System.Drawing.Size(191, 338);
            this.groupBoxGeld.TabIndex = 1;
            this.groupBoxGeld.TabStop = false;
            // 
            // Ui_layer1
            // 
            this.Ui_layer1.Image = ((System.Drawing.Image)(resources.GetObject("Ui_layer1.Image")));
            this.Ui_layer1.Location = new System.Drawing.Point(0, -1);
            this.Ui_layer1.Name = "Ui_layer1";
            this.Ui_layer1.Size = new System.Drawing.Size(720, 600);
            this.Ui_layer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ui_layer1.TabIndex = 2;
            this.Ui_layer1.TabStop = false;
            this.Ui_layer1.MouseEnter += new System.EventHandler(this.resetAnswerButtonState);
            // 
            // button_answer_1
            // 
            this.button_answer_1.Image = ((System.Drawing.Image)(resources.GetObject("button_answer_1.Image")));
            this.button_answer_1.Location = new System.Drawing.Point(110, 468);
            this.button_answer_1.Name = "button_answer_1";
            this.button_answer_1.Size = new System.Drawing.Size(198, 45);
            this.button_answer_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.button_answer_1.TabIndex = 3;
            this.button_answer_1.TabStop = false;
            this.button_answer_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getAnswerIndex);
            this.button_answer_1.MouseEnter += new System.EventHandler(this.setAnswerButtonStateHover);
            // 
            // label_answer_1
            // 
            this.label_answer_1.AutoSize = true;
            this.label_answer_1.BackColor = System.Drawing.Color.Transparent;
            this.label_answer_1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_answer_1.Location = new System.Drawing.Point(142, 481);
            this.label_answer_1.Name = "label_answer_1";
            this.label_answer_1.Size = new System.Drawing.Size(129, 19);
            this.label_answer_1.TabIndex = 4;
            this.label_answer_1.Tag = "1";
            this.label_answer_1.Text = "Generic Answer";
            this.label_answer_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getAnswerIndex);
            // 
            // label_answer_2
            // 
            this.label_answer_2.AutoSize = true;
            this.label_answer_2.BackColor = System.Drawing.Color.Transparent;
            this.label_answer_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_answer_2.Location = new System.Drawing.Point(420, 481);
            this.label_answer_2.Name = "label_answer_2";
            this.label_answer_2.Size = new System.Drawing.Size(129, 19);
            this.label_answer_2.TabIndex = 6;
            this.label_answer_2.Tag = "2";
            this.label_answer_2.Text = "Generic Answer";
            this.label_answer_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getAnswerIndex);
            // 
            // button_answer_2
            // 
            this.button_answer_2.Image = ((System.Drawing.Image)(resources.GetObject("button_answer_2.Image")));
            this.button_answer_2.Location = new System.Drawing.Point(388, 468);
            this.button_answer_2.Name = "button_answer_2";
            this.button_answer_2.Size = new System.Drawing.Size(198, 45);
            this.button_answer_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.button_answer_2.TabIndex = 5;
            this.button_answer_2.TabStop = false;
            this.button_answer_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getAnswerIndex);
            this.button_answer_2.MouseEnter += new System.EventHandler(this.setAnswerButtonStateHover);
            // 
            // label_answer_3
            // 
            this.label_answer_3.AutoSize = true;
            this.label_answer_3.BackColor = System.Drawing.Color.Transparent;
            this.label_answer_3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_answer_3.Location = new System.Drawing.Point(142, 542);
            this.label_answer_3.Name = "label_answer_3";
            this.label_answer_3.Size = new System.Drawing.Size(129, 19);
            this.label_answer_3.TabIndex = 8;
            this.label_answer_3.Tag = "3";
            this.label_answer_3.Text = "Generic Answer";
            this.label_answer_3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getAnswerIndex);
            // 
            // button_answer_3
            // 
            this.button_answer_3.Image = ((System.Drawing.Image)(resources.GetObject("button_answer_3.Image")));
            this.button_answer_3.Location = new System.Drawing.Point(110, 529);
            this.button_answer_3.Name = "button_answer_3";
            this.button_answer_3.Size = new System.Drawing.Size(198, 45);
            this.button_answer_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.button_answer_3.TabIndex = 7;
            this.button_answer_3.TabStop = false;
            this.button_answer_3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getAnswerIndex);
            this.button_answer_3.MouseEnter += new System.EventHandler(this.setAnswerButtonStateHover);
            // 
            // label_answer_4
            // 
            this.label_answer_4.AutoSize = true;
            this.label_answer_4.BackColor = System.Drawing.Color.Transparent;
            this.label_answer_4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_answer_4.Location = new System.Drawing.Point(420, 542);
            this.label_answer_4.Name = "label_answer_4";
            this.label_answer_4.Size = new System.Drawing.Size(129, 19);
            this.label_answer_4.TabIndex = 10;
            this.label_answer_4.Tag = "4";
            this.label_answer_4.Text = "Generic Answer";
            this.label_answer_4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getAnswerIndex);
            // 
            // button_answer_4
            // 
            this.button_answer_4.Image = ((System.Drawing.Image)(resources.GetObject("button_answer_4.Image")));
            this.button_answer_4.Location = new System.Drawing.Point(388, 529);
            this.button_answer_4.Name = "button_answer_4";
            this.button_answer_4.Size = new System.Drawing.Size(198, 45);
            this.button_answer_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.button_answer_4.TabIndex = 9;
            this.button_answer_4.TabStop = false;
            this.button_answer_4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getAnswerIndex);
            this.button_answer_4.MouseEnter += new System.EventHandler(this.setAnswerButtonStateHover);
            // 
            // background
            // 
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, -1);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(720, 600);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.background.TabIndex = 11;
            this.background.TabStop = false;
            // 
            // button_joker_1
            // 
            this.button_joker_1.Image = ((System.Drawing.Image)(resources.GetObject("button_joker_1.Image")));
            this.button_joker_1.Location = new System.Drawing.Point(12, 12);
            this.button_joker_1.Name = "button_joker_1";
            this.button_joker_1.Size = new System.Drawing.Size(80, 39);
            this.button_joker_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_joker_1.TabIndex = 14;
            this.button_joker_1.TabStop = false;
            this.button_joker_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getJokerIndex);
            this.button_joker_1.MouseEnter += new System.EventHandler(this.setJoker1ButtonStateHover);
            // 
            // button_joker_2
            // 
            this.button_joker_2.Image = ((System.Drawing.Image)(resources.GetObject("button_joker_2.Image")));
            this.button_joker_2.Location = new System.Drawing.Point(105, 12);
            this.button_joker_2.Name = "button_joker_2";
            this.button_joker_2.Size = new System.Drawing.Size(80, 39);
            this.button_joker_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_joker_2.TabIndex = 15;
            this.button_joker_2.TabStop = false;
            this.button_joker_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getJokerIndex);
            this.button_joker_2.MouseEnter += new System.EventHandler(this.setJoker2ButtonStateHover);
            // 
            // button_joker_3
            // 
            this.button_joker_3.Image = ((System.Drawing.Image)(resources.GetObject("button_joker_3.Image")));
            this.button_joker_3.Location = new System.Drawing.Point(197, 12);
            this.button_joker_3.Name = "button_joker_3";
            this.button_joker_3.Size = new System.Drawing.Size(80, 39);
            this.button_joker_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_joker_3.TabIndex = 16;
            this.button_joker_3.TabStop = false;
            this.button_joker_3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getJokerIndex);
            this.button_joker_3.MouseEnter += new System.EventHandler(this.setJoker3ButtonStateHover);
            // 
            // button_weiter
            // 
            this.button_weiter.Image = ((System.Drawing.Image)(resources.GetObject("button_weiter.Image")));
            this.button_weiter.Location = new System.Drawing.Point(242, 399);
            this.button_weiter.Name = "button_weiter";
            this.button_weiter.Size = new System.Drawing.Size(210, 45);
            this.button_weiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.button_weiter.TabIndex = 17;
            this.button_weiter.TabStop = false;
            this.button_weiter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnWeiterClick);
            // 
            // label_weiter
            // 
            this.label_weiter.AutoSize = true;
            this.label_weiter.BackColor = System.Drawing.Color.Transparent;
            this.label_weiter.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label_weiter.Location = new System.Drawing.Point(305, 410);
            this.label_weiter.Name = "label_weiter";
            this.label_weiter.Size = new System.Drawing.Size(84, 22);
            this.label_weiter.TabIndex = 18;
            this.label_weiter.Text = "WEITER";
            this.label_weiter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnWeiterClick);
            // 
            // label_question_1
            // 
            this.label_question_1.AutoSize = true;
            this.label_question_1.BackColor = System.Drawing.Color.Transparent;
            this.label_question_1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_question_1.Location = new System.Drawing.Point(179, 403);
            this.label_question_1.Name = "label_question_1";
            this.label_question_1.Size = new System.Drawing.Size(301, 19);
            this.label_question_1.TabIndex = 12;
            this.label_question_1.Text = "Generic Question located in Line 1 of 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(714, 602);
            this.Controls.Add(this.label_weiter);
            this.Controls.Add(this.button_weiter);
            this.Controls.Add(this.button_joker_3);
            this.Controls.Add(this.button_joker_2);
            this.Controls.Add(this.button_joker_1);
            this.Controls.Add(this.label_question_1);
            this.Controls.Add(this.label_answer_4);
            this.Controls.Add(this.button_answer_4);
            this.Controls.Add(this.label_answer_3);
            this.Controls.Add(this.button_answer_3);
            this.Controls.Add(this.label_answer_2);
            this.Controls.Add(this.button_answer_2);
            this.Controls.Add(this.label_answer_1);
            this.Controls.Add(this.button_answer_1);
            this.Controls.Add(this.groupBoxGeld);
            this.Controls.Add(this.Ui_layer1);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Wer Wird Millionär - JZ, KT, SP, CS, SR";
            ((System.ComponentModel.ISupportInitialize)(this.Ui_layer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_answer_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_answer_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_answer_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_answer_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_joker_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_joker_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_joker_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_weiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxGeld;
        private System.Windows.Forms.PictureBox Ui_layer1;
        private System.Windows.Forms.PictureBox button_answer_1;
        private System.Windows.Forms.Label label_answer_1;
        private System.Windows.Forms.Label label_answer_2;
        private System.Windows.Forms.PictureBox button_answer_2;
        private System.Windows.Forms.Label label_answer_3;
        private System.Windows.Forms.PictureBox button_answer_3;
        private System.Windows.Forms.Label label_answer_4;
        private System.Windows.Forms.PictureBox button_answer_4;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox button_joker_1;
        private System.Windows.Forms.PictureBox button_joker_2;
        private System.Windows.Forms.PictureBox button_joker_3;
        private System.Windows.Forms.PictureBox button_weiter;
        private System.Windows.Forms.Label label_weiter;
        private System.Windows.Forms.Label label_question_1;
    }
}

