namespace Clase_winforms
{
    // La clase parcial nos permite separar la logica del front.
    // Funciona junto con el archivo Persona.cs (Tienen que estar en el mismo proyecto)
    partial class FormView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormView));
            textBox1 = new TextBox();
            botonEnviar = new Button();
            domainUpDown1 = new DomainUpDown();
            PublicidadUno = new LinkLabel();
            primerBox = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            progressBar1 = new ProgressBar();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            splitContainer1 = new SplitContainer();
            richTextBox1 = new RichTextBox();
            propertyGrid1 = new PropertyGrid();
            toolStripContainer1 = new ToolStripContainer();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            trackBar1 = new TrackBar();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            checkedListBox1 = new CheckedListBox();
            dateTimePicker1 = new DateTimePicker();
            hScrollBar1 = new HScrollBar();
            pictureBox2 = new PictureBox();
            primerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(139, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 22);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // botonEnviar
            // 
            botonEnviar.BackColor = Color.FromArgb(128, 255, 128);
            botonEnviar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            botonEnviar.Location = new Point(227, 386);
            botonEnviar.Name = "botonEnviar";
            botonEnviar.Size = new Size(65, 22);
            botonEnviar.TabIndex = 1;
            botonEnviar.Text = "Enviar";
            botonEnviar.UseVisualStyleBackColor = false;
            botonEnviar.Click += button1_Click;
            // 
            // domainUpDown1
            // 
            domainUpDown1.BackColor = Color.FromArgb(255, 255, 192);
            domainUpDown1.Items.Add("Argentina");
            domainUpDown1.Items.Add("Uruguay");
            domainUpDown1.Items.Add("Peru");
            domainUpDown1.Items.Add("Paraguay");
            domainUpDown1.Items.Add("Otra");
            domainUpDown1.Location = new Point(139, 107);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.RightToLeft = RightToLeft.No;
            domainUpDown1.Size = new Size(225, 22);
            domainUpDown1.TabIndex = 4;
            domainUpDown1.Text = "Nacionalidad";
            domainUpDown1.TextAlign = HorizontalAlignment.Center;
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // PublicidadUno
            // 
            PublicidadUno.ActiveLinkColor = Color.Indigo;
            PublicidadUno.AutoSize = true;
            PublicidadUno.BackColor = Color.Gainsboro;
            PublicidadUno.BorderStyle = BorderStyle.Fixed3D;
            PublicidadUno.Location = new Point(31, 63);
            PublicidadUno.Margin = new Padding(3);
            PublicidadUno.Name = "PublicidadUno";
            PublicidadUno.RightToLeft = RightToLeft.No;
            PublicidadUno.Size = new Size(138, 22);
            PublicidadUno.TabIndex = 10;
            PublicidadUno.TabStop = true;
            PublicidadUno.Text = "Acceder Publicidad Uno ";
            PublicidadUno.TextAlign = ContentAlignment.MiddleCenter;
            PublicidadUno.UseCompatibleTextRendering = true;
            PublicidadUno.UseWaitCursor = true;
            // 
            // primerBox
            // 
            primerBox.BackColor = Color.LightGray;
            primerBox.Controls.Add(PublicidadUno);
            primerBox.Controls.Add(pictureBox1);
            primerBox.ForeColor = Color.FromArgb(0, 0, 64);
            primerBox.Location = new Point(576, 257);
            primerBox.Name = "primerBox";
            primerBox.RightToLeft = RightToLeft.No;
            primerBox.Size = new Size(200, 100);
            primerBox.TabIndex = 11;
            primerBox.TabStop = false;
            primerBox.Text = "Publicidad Uno";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(21, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 73);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 22);
            textBox2.TabIndex = 12;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(566, 374);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(222, 23);
            progressBar1.TabIndex = 13;
            progressBar1.Value = 60;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(139, 168);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 18);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Femenino";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(273, 168);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 18);
            radioButton2.TabIndex = 15;
            radioButton2.Text = "Masculino";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(505, 70);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(richTextBox1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            splitContainer1.Size = new Size(117, 53);
            splitContainer1.SplitterDistance = 39;
            splitContainer1.TabIndex = 16;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(192, 255, 192);
            richTextBox1.Location = new Point(-38, -13);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(112, 72);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = "1990\n1991\n1992\n1993\n1994\n1995\n1996\n1997\n1998\n1999\n2000";
            // 
            // propertyGrid1
            // 
            propertyGrid1.Location = new Point(576, 146);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(200, 105);
            propertyGrid1.TabIndex = 17;
            propertyGrid1.Click += propertyGrid1_Click;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(11, 0);
            toolStripContainer1.Location = new Point(304, 265);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(11, 8);
            toolStripContainer1.TabIndex = 20;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Click += toolStripContainer1_TopToolStripPanel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 18);
            label1.Name = "label1";
            label1.Size = new Size(114, 14);
            label1.TabIndex = 22;
            label1.Text = "Ingrese su nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 60);
            label2.Name = "label2";
            label2.Size = new Size(112, 14);
            label2.TabIndex = 23;
            label2.Text = "Ingrese su apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 146);
            label3.Name = "label3";
            label3.Size = new Size(128, 14);
            label3.TabIndex = 24;
            label3.Text = "Seleccione su genero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 200);
            label4.Name = "label4";
            label4.Size = new Size(114, 14);
            label4.TabIndex = 25;
            label4.Text = "Año de nacimiento:";
            label4.Click += label4_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(139, 212);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 26;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(435, 168);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 27;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(405, 35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(383, 105);
            tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 23);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(375, 78);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(375, 77);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(88, 63);
            dataGridView1.TabIndex = 29;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.InactiveCaption;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Tarea 1", "Tarea 2", "Tarea 3", "Tarea 4" });
            checkedListBox1.Location = new Point(447, 212);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(77, 72);
            checkedListBox1.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(558, 11);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 22);
            dateTimePicker1.TabIndex = 31;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(12, 77);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(104, 334);
            hScrollBar1.TabIndex = 32;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Location = new Point(435, 307);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // FormView
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 420);
            Controls.Add(pictureBox2);
            Controls.Add(hScrollBar1);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkedListBox1);
            Controls.Add(dataGridView1);
            Controls.Add(trackBar1);
            Controls.Add(tabControl1);
            Controls.Add(monthCalendar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStripContainer1);
            Controls.Add(propertyGrid1);
            Controls.Add(splitContainer1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(progressBar1);
            Controls.Add(textBox2);
            Controls.Add(primerBox);
            Controls.Add(domainUpDown1);
            Controls.Add(botonEnviar);
            Controls.Add(textBox1);
            Cursor = Cursors.Hand;
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormView";
            Text = "Primer Formulario";
            primerBox.ResumeLayout(false);
            primerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button botonEnviar;
        private DomainUpDown domainUpDown1;
        private LinkLabel PublicidadUno;
        public GroupBox primerBox;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private ProgressBar progressBar1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private SplitContainer splitContainer1;
        private PropertyGrid propertyGrid1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private ToolStripContainer toolStripContainer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private TrackBar trackBar1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private CheckedListBox checkedListBox1;
        private DateTimePicker dateTimePicker1;
        private HScrollBar hScrollBar1;
        private PictureBox pictureBox2;
    }
}