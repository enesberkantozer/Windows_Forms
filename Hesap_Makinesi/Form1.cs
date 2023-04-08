using System.Data;
using System.Resources;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string hesaplanacak = "";
        string islemi_duzenle = "";

        private void button_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            hesaplanacak += (sender as Button).Text;
        }

        private void button_sonuc_Click(object sender, EventArgs e)
        {
            islemi_duzenle = hesaplanacak.Replace("X", "*").Replace("÷", "/");
            try
            {
                textBox1.Text = new DataTable().Compute(islemi_duzenle, null).ToString().Replace(",", ".").ToString();
                hesaplanacak = textBox1.Text;
            }
            catch (Exception ex)
            {
                textBox1.Text = "";
                hesaplanacak = "";
            }
        }

        private void button_hep_temizle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            hesaplanacak = "";
        }

        private void button_bir_temizle_Click(object sender, EventArgs e)
        {
            if (hesaplanacak.Length > 0)
            {
                hesaplanacak = hesaplanacak.Remove(hesaplanacak.Length - 1);
            }
            textBox1.Text = hesaplanacak.ToString();
        }

        private void modMenuItem_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Text == "Standart")
            {
                standart_getir();
                mod_menu_standart.Checked = true;
                mod_menu_bilimsel.Checked = false;
            }
            else if ((sender as ToolStripMenuItem).Text == "Bilimsel")
            {
                bilimsel_getir();
                mod_menu_standart.Checked = false;
                mod_menu_bilimsel.Checked = true;
            }
        }

        private void tema_menu_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Text == "Açık Tema")
            {
                acik_mod_getir();
                tema_menu_acik.Checked = true;
                tema_menu_koyu.Checked = false;
            }
            else if ((sender as ToolStripMenuItem).Text == "Koyu Tema")
            {
                koyu_mod_getir();
                tema_menu_acik.Checked = false;
                tema_menu_koyu.Checked = true;
            }
        }

        private void cikis_menu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?",
                "Uygulama sonlandırılacak...", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modMenuItem_Click(mod_menu_standart, null);
            tema_menu_Click(tema_menu_acik, null);
        }

        private void standart_getir()
        {
            //
            // Temizleme
            //
            panel1.Controls.Clear();
            //
            // Oluþturma
            //
            label1 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            button_hep_temizle = new Button();
            button_bir_temizle = new Button();
            button_parantez_bas = new Button();
            button_parantez_bitis = new Button();
            button_bol = new Button();
            button_carp = new Button();
            button_cikar = new Button();
            button_topla = new Button();
            button_sonuc = new Button();
            button_nokta = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(109, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 28);
            label1.TabIndex = 42;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(17, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 100);
            panel2.TabIndex = 41;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(3, 30);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(421, 40);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button_hep_temizle
            // 
            button_hep_temizle.BackColor = Color.Orange;
            button_hep_temizle.Location = new Point(17, 154);
            button_hep_temizle.Name = "button_hep_temizle";
            button_hep_temizle.Size = new Size(100, 100);
            button_hep_temizle.TabIndex = 40;
            button_hep_temizle.Text = "C";
            button_hep_temizle.UseVisualStyleBackColor = false;
            button_hep_temizle.Click += button_hep_temizle_Click;
            // 
            // button_bir_temizle
            // 
            button_bir_temizle.BackColor = Color.Orange;
            button_bir_temizle.Location = new Point(127, 154);
            button_bir_temizle.Name = "button_bir_temizle";
            button_bir_temizle.Size = new Size(100, 100);
            button_bir_temizle.TabIndex = 39;
            button_bir_temizle.Text = "CE";
            button_bir_temizle.UseVisualStyleBackColor = false;
            button_bir_temizle.Click += button_bir_temizle_Click;
            // 
            // button_parantez_bas
            // 
            button_parantez_bas.BackColor = Color.Silver;
            button_parantez_bas.Location = new Point(237, 154);
            button_parantez_bas.Name = "button_parantez_bas";
            button_parantez_bas.Size = new Size(100, 100);
            button_parantez_bas.TabIndex = 38;
            button_parantez_bas.Text = "(";
            button_parantez_bas.UseVisualStyleBackColor = false;
            button_parantez_bas.Click += button_Click;
            // 
            // button_parantez_bitis
            // 
            button_parantez_bitis.BackColor = Color.Silver;
            button_parantez_bitis.Location = new Point(347, 154);
            button_parantez_bitis.Name = "button_parantez_bitis";
            button_parantez_bitis.Size = new Size(100, 100);
            button_parantez_bitis.TabIndex = 37;
            button_parantez_bitis.Text = ")";
            button_parantez_bitis.UseVisualStyleBackColor = false;
            button_parantez_bitis.Click += button_Click;
            // 
            // button_bol
            // 
            button_bol.BackColor = Color.Silver;
            button_bol.Location = new Point(347, 264);
            button_bol.Name = "button_bol";
            button_bol.Size = new Size(100, 100);
            button_bol.TabIndex = 36;
            button_bol.Text = "÷";
            button_bol.UseVisualStyleBackColor = false;
            button_bol.Click += button_Click;
            // 
            // button_carp
            // 
            button_carp.BackColor = Color.Silver;
            button_carp.Location = new Point(347, 374);
            button_carp.Name = "button_carp";
            button_carp.Size = new Size(100, 100);
            button_carp.TabIndex = 35;
            button_carp.Text = "X";
            button_carp.UseVisualStyleBackColor = false;
            button_carp.Click += button_Click;
            // 
            // button_cikar
            // 
            button_cikar.BackColor = Color.Silver;
            button_cikar.Location = new Point(347, 484);
            button_cikar.Name = "button_cikar";
            button_cikar.Size = new Size(100, 100);
            button_cikar.TabIndex = 34;
            button_cikar.Text = "-";
            button_cikar.UseVisualStyleBackColor = false;
            button_cikar.Click += button_Click;
            // 
            // button_topla
            // 
            button_topla.BackColor = Color.Silver;
            button_topla.Location = new Point(347, 594);
            button_topla.Name = "button_topla";
            button_topla.Size = new Size(100, 100);
            button_topla.TabIndex = 33;
            button_topla.Text = "+";
            button_topla.UseVisualStyleBackColor = false;
            button_topla.Click += button_Click;
            // 
            // button_sonuc
            // 
            button_sonuc.Location = new Point(237, 594);
            button_sonuc.Name = "button_sonuc";
            button_sonuc.Size = new Size(100, 100);
            button_sonuc.TabIndex = 32;
            button_sonuc.Text = "=";
            button_sonuc.UseVisualStyleBackColor = true;
            button_sonuc.Click += button_sonuc_Click;
            // 
            // button_nokta
            // 
            button_nokta.Location = new Point(17, 594);
            button_nokta.Name = "button_nokta";
            button_nokta.Size = new Size(100, 100);
            button_nokta.TabIndex = 31;
            button_nokta.Text = ".";
            button_nokta.UseVisualStyleBackColor = true;
            button_nokta.Click += button_Click;
            // 
            // button10
            // 
            button10.Location = new Point(127, 594);
            button10.Name = "button10";
            button10.Size = new Size(100, 100);
            button10.TabIndex = 30;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(237, 264);
            button9.Name = "button9";
            button9.Size = new Size(100, 100);
            button9.TabIndex = 29;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(127, 264);
            button8.Name = "button8";
            button8.Size = new Size(100, 100);
            button8.TabIndex = 28;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(17, 264);
            button7.Name = "button7";
            button7.Size = new Size(100, 100);
            button7.TabIndex = 27;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(237, 374);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 26;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(127, 374);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 25;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(17, 374);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 24;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(237, 484);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 23;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(127, 484);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 22;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 484);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 21;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button_hep_temizle);
            panel1.Controls.Add(button_bir_temizle);
            panel1.Controls.Add(button_parantez_bas);
            panel1.Controls.Add(button_parantez_bitis);
            panel1.Controls.Add(button_bol);
            panel1.Controls.Add(button_carp);
            panel1.Controls.Add(button_cikar);
            panel1.Controls.Add(button_topla);
            panel1.Controls.Add(button_sonuc);
            panel1.Controls.Add(button_nokta);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            //
            // Form1
            //
            Text = "Standart Hesap Makinesi";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();

            label1.Text = Text.ToString();
            //
            // Tema
            //
            if (tema_menu_acik.Checked)
            {
                acik_mod_getir();
            }
            else if (tema_menu_koyu.Checked)
            {
                koyu_mod_getir();
            }
        }

        private void bilimsel_getir()
        {
            panel1.Controls.Clear();
            Text = "Bilimsel Hesap Makinesi";
            label1.Text = Text.ToString();
        }

        private void acik_mod_getir()
        {
            // Form
            BackColor = SystemColors.Control;
            ForeColor = SystemColors.ControlText;
            // ToolStrip
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.ForeColor = Color.Black;
            mod_menu.BackColor = SystemColors.Control;
            mod_menu.ForeColor = SystemColors.ControlText;
            tema_menu.BackColor = SystemColors.Control;
            tema_menu.ForeColor = SystemColors.ControlText;
            mod_menu_standart.BackColor = SystemColors.Control;
            mod_menu_bilimsel.BackColor = SystemColors.Control;
            tema_menu_acik.BackColor = SystemColors.Control;
            tema_menu_koyu.BackColor = SystemColors.Control;
            mod_menu_standart.ForeColor = SystemColors.ControlText;
            mod_menu_bilimsel.ForeColor = SystemColors.ControlText;
            tema_menu_acik.ForeColor = SystemColors.ControlText;
            tema_menu_koyu.ForeColor = SystemColors.ControlText;
            cikis_menu.BackColor = SystemColors.Control;
            cikis_menu.ForeColor = SystemColors.ControlText;
            // Label
            label1.BackColor = SystemColors.Control;
            label1.ForeColor = SystemColors.ControlText;
            // Panel
            panel2.BackColor = Color.White;
            panel2.ForeColor = SystemColors.ControlText;
            // TextBox
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = SystemColors.WindowText;
            // Butonlar
            List<Button> buttons = new List<Button>();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttons.Add(button10);
            buttons.Add(button_nokta);
            buttons.Add(button_sonuc);
            buttons.Add(button_topla);
            buttons.Add(button_cikar);
            buttons.Add(button_carp);
            buttons.Add(button_bol);
            buttons.Add(button_parantez_bas);
            buttons.Add(button_parantez_bitis);
            buttons.Add(button_bir_temizle);
            buttons.Add(button_hep_temizle);
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].ForeColor = SystemColors.ControlText;
                if (i < 12)
                {
                    buttons[i].BackColor = SystemColors.Control;
                }
            }

        }

        private void koyu_mod_getir()
        {
            // Form
            BackColor = Color.FromArgb(24, 24, 24);
            ForeColor = Color.White;
            // ToolStrip
            toolStrip1.BackColor = Color.FromArgb(48, 48, 48);
            //toolStrip1.ForeColor = Color.White;
            mod_menu.BackColor = Color.FromArgb(48, 48, 48);
            mod_menu.ForeColor = Color.White;
            tema_menu.BackColor = Color.FromArgb(48, 48, 48);
            tema_menu.ForeColor = Color.White;
            mod_menu_standart.BackColor = Color.FromArgb(48, 48, 48);
            mod_menu_bilimsel.BackColor = Color.FromArgb(48, 48, 48);
            tema_menu_acik.BackColor = Color.FromArgb(48, 48, 48);
            tema_menu_koyu.BackColor = Color.FromArgb(48, 48, 48);
            mod_menu_standart.ForeColor = Color.White;
            mod_menu_bilimsel.ForeColor = Color.White;
            tema_menu_acik.ForeColor = Color.White;
            tema_menu_koyu.ForeColor = Color.White;
            cikis_menu.BackColor = Color.FromArgb(48, 48, 48);
            cikis_menu.ForeColor = Color.White;
            // Label
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            // Panel
            panel2.BackColor = Color.FromArgb(48, 48, 48);
            panel2.ForeColor = Color.White;
            // TextBox
            textBox1.BackColor = Color.FromArgb(48, 48, 48);
            textBox1.ForeColor = Color.White;
            // Butonlar
            List<Button> buttons = new List<Button>();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttons.Add(button10);
            buttons.Add(button_nokta);
            buttons.Add(button_sonuc);
            buttons.Add(button_topla);
            buttons.Add(button_cikar);
            buttons.Add(button_carp);
            buttons.Add(button_bol);
            buttons.Add(button_parantez_bas);
            buttons.Add(button_parantez_bitis);
            buttons.Add(button_bir_temizle);
            buttons.Add(button_hep_temizle);
            for (int i = 0; i < buttons.Count; i++)
            {
                if (i < 12)
                {
                    buttons[i].ForeColor = Color.White;
                    buttons[i].BackColor = Color.FromArgb(48, 48, 48);
                }
                else
                {
                    buttons[i].ForeColor = Color.Black;
                }
            }
        }

    }
}
