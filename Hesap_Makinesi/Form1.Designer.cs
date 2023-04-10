namespace Hesap_Makinesi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            mod_menu = new ToolStripDropDownButton();
            mod_menu_standart = new ToolStripMenuItem();
            mod_menu_bilimsel = new ToolStripMenuItem();
            tema_menu = new ToolStripDropDownButton();
            tema_menu_acik = new ToolStripMenuItem();
            tema_menu_koyu = new ToolStripMenuItem();
            cikis_menu = new ToolStripButton();
            panel1 = new Panel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { mod_menu, tema_menu, cikis_menu });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(464, 27);
            toolStrip1.TabIndex = 19;
            toolStrip1.Text = "toolStrip1";
            // 
            // mod_menu
            // 
            mod_menu.BackColor = SystemColors.Control;
            mod_menu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            mod_menu.DropDownItems.AddRange(new ToolStripItem[] { mod_menu_standart, mod_menu_bilimsel });
            mod_menu.ForeColor = SystemColors.ControlText;
            mod_menu.Image = (Image)resources.GetObject("mod_menu.Image");
            mod_menu.ImageTransparentColor = Color.Magenta;
            mod_menu.Name = "mod_menu";
            mod_menu.Size = new Size(71, 24);
            mod_menu.Text = "Modlar";
            mod_menu.ToolTipText = "Modunuzu buradan seçebilirsiniz";
            // 
            // mod_menu_standart
            // 
            mod_menu_standart.DisplayStyle = ToolStripItemDisplayStyle.Text;
            mod_menu_standart.Name = "mod_menu_standart";
            mod_menu_standart.Size = new Size(148, 26);
            mod_menu_standart.Text = "Standart";
            mod_menu_standart.ToolTipText = "Standart hesap makinesi moduna geçiş yapar";
            mod_menu_standart.Click += modMenuItem_Click;
            // 
            // mod_menu_bilimsel
            // 
            mod_menu_bilimsel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            mod_menu_bilimsel.Name = "mod_menu_bilimsel";
            mod_menu_bilimsel.Size = new Size(148, 26);
            mod_menu_bilimsel.Text = "Bilimsel";
            mod_menu_bilimsel.ToolTipText = "Bilimsel hesap makinesi moduna geçiş yapar";
            mod_menu_bilimsel.Click += modMenuItem_Click;
            // 
            // tema_menu
            // 
            tema_menu.BackColor = SystemColors.Control;
            tema_menu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tema_menu.DropDownItems.AddRange(new ToolStripItem[] { tema_menu_acik, tema_menu_koyu });
            tema_menu.ForeColor = SystemColors.ControlText;
            tema_menu.Image = (Image)resources.GetObject("tema_menu.Image");
            tema_menu.ImageTransparentColor = Color.Magenta;
            tema_menu.Name = "tema_menu";
            tema_menu.Size = new Size(76, 24);
            tema_menu.Text = "Temalar";
            tema_menu.ToolTipText = "Tema seçiminizi buradan yapabilirsiniz";
            // 
            // tema_menu_acik
            // 
            tema_menu_acik.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tema_menu_acik.Name = "tema_menu_acik";
            tema_menu_acik.Size = new Size(165, 26);
            tema_menu_acik.Text = "Açık Tema";
            tema_menu_acik.ToolTipText = "Açık tema uygula";
            tema_menu_acik.Click += tema_menu_Click;
            // 
            // tema_menu_koyu
            // 
            tema_menu_koyu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tema_menu_koyu.Name = "tema_menu_koyu";
            tema_menu_koyu.Size = new Size(165, 26);
            tema_menu_koyu.Text = "Koyu Tema";
            tema_menu_koyu.ToolTipText = "Koyu tema uygula";
            tema_menu_koyu.Click += tema_menu_Click;
            // 
            // cikis_menu
            // 
            cikis_menu.Alignment = ToolStripItemAlignment.Right;
            cikis_menu.BackColor = SystemColors.Control;
            cikis_menu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            cikis_menu.ForeColor = SystemColors.ControlText;
            cikis_menu.Image = (Image)resources.GetObject("cikis_menu.Image");
            cikis_menu.ImageTransparentColor = Color.Magenta;
            cikis_menu.Name = "cikis_menu";
            cikis_menu.Size = new Size(43, 24);
            cikis_menu.Text = "Çıkış";
            cikis_menu.ToolTipText = "Uygulamayı sonlandır";
            cikis_menu.Click += cikis_menu_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 711);
            panel1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 743);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            KeyPreview = true;
            Name = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton mod_menu;
        private ToolStripMenuItem mod_menu_standart;
        private ToolStripMenuItem mod_menu_bilimsel;
        private ToolStripDropDownButton tema_menu;
        private ToolStripMenuItem tema_menu_acik;
        private ToolStripMenuItem tema_menu_koyu;
        private ToolStripButton cikis_menu;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox textBox1;
        private Button button_hep_temizle;
        private Button button_bir_temizle;
        private Button button_parantez_bas;
        private Button button_parantez_bitis;
        private Button button_bol;
        private Button button_carp;
        private Button button_cikar;
        private Button button_topla;
        private Button button_sonuc;
        private Button button_virgul;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}