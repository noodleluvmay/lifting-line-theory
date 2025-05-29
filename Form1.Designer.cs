
namespace lifting_line_NL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exit_bt = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.clear_bt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.calc_bt = new System.Windows.Forms.Button();
            this.panel_coef = new System.Windows.Forms.Panel();
            this.root_chord_tb = new System.Windows.Forms.TextBox();
            this.taper_tb = new System.Windows.Forms.TextBox();
            this.ae_tb = new System.Windows.Forms.TextBox();
            this.a0_tb = new System.Windows.Forms.TextBox();
            this.washout_tb = new System.Windows.Forms.TextBox();
            this.alpha_tb = new System.Windows.Forms.TextBox();
            this.span_tb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.A3_tb = new System.Windows.Forms.TextBox();
            this.A5_tb = new System.Windows.Forms.TextBox();
            this.A7_tb = new System.Windows.Forms.TextBox();
            this.cl_tb = new System.Windows.Forms.TextBox();
            this.cd_tb = new System.Windows.Forms.TextBox();
            this.A1_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.naca2412_bt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.naca4412_bt = new System.Windows.Forms.Button();
            this.naca0012_bt = new System.Windows.Forms.Button();
            this.naca65210_bt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.s5_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.s3_tb = new System.Windows.Forms.TextBox();
            this.s4_tb = new System.Windows.Forms.TextBox();
            this.s2_tb = new System.Windows.Forms.TextBox();
            this.s1_tb = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.sdeg1_tb = new System.Windows.Forms.TextBox();
            this.sdeg2_tb = new System.Windows.Forms.TextBox();
            this.sdeg3_tb = new System.Windows.Forms.TextBox();
            this.sdeg4_tb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel_left.SuspendLayout();
            this.panel_coef.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit_bt
            // 
            this.exit_bt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exit_bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exit_bt.FlatAppearance.BorderSize = 0;
            this.exit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bt.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_bt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit_bt.Location = new System.Drawing.Point(0, 463);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(147, 35);
            this.exit_bt.TabIndex = 60;
            this.exit_bt.Text = "Exit";
            this.exit_bt.UseVisualStyleBackColor = false;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel_left.Controls.Add(this.naca0012_bt);
            this.panel_left.Controls.Add(this.naca65210_bt);
            this.panel_left.Controls.Add(this.naca2412_bt);
            this.panel_left.Controls.Add(this.button3);
            this.panel_left.Controls.Add(this.naca4412_bt);
            this.panel_left.Controls.Add(this.clear_bt);
            this.panel_left.Controls.Add(this.button1);
            this.panel_left.Controls.Add(this.calc_bt);
            this.panel_left.Controls.Add(this.exit_bt);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(147, 498);
            this.panel_left.TabIndex = 70;
            // 
            // clear_bt
            // 
            this.clear_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_bt.FlatAppearance.BorderSize = 0;
            this.clear_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.clear_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(163)))));
            this.clear_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_bt.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_bt.ForeColor = System.Drawing.Color.White;
            this.clear_bt.Location = new System.Drawing.Point(0, 319);
            this.clear_bt.Name = "clear_bt";
            this.clear_bt.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.clear_bt.Size = new System.Drawing.Size(147, 36);
            this.clear_bt.TabIndex = 85;
            this.clear_bt.Text = "Clear";
            this.clear_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear_bt.UseVisualStyleBackColor = false;
            this.clear_bt.Click += new System.EventHandler(this.clear_bt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(163)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(163)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(163)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 36);
            this.button1.TabIndex = 84;
            this.button1.Text = "Information";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // calc_bt
            // 
            this.calc_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calc_bt.FlatAppearance.BorderSize = 0;
            this.calc_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.calc_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(163)))));
            this.calc_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calc_bt.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_bt.ForeColor = System.Drawing.Color.White;
            this.calc_bt.Location = new System.Drawing.Point(0, 277);
            this.calc_bt.Name = "calc_bt";
            this.calc_bt.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.calc_bt.Size = new System.Drawing.Size(147, 36);
            this.calc_bt.TabIndex = 71;
            this.calc_bt.Text = "Calculate";
            this.calc_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calc_bt.UseVisualStyleBackColor = false;
            this.calc_bt.Click += new System.EventHandler(this.calc_bt_Click);
            // 
            // panel_coef
            // 
            this.panel_coef.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_coef.Controls.Add(this.root_chord_tb);
            this.panel_coef.Controls.Add(this.taper_tb);
            this.panel_coef.Controls.Add(this.ae_tb);
            this.panel_coef.Controls.Add(this.a0_tb);
            this.panel_coef.Controls.Add(this.washout_tb);
            this.panel_coef.Controls.Add(this.alpha_tb);
            this.panel_coef.Controls.Add(this.span_tb);
            this.panel_coef.Controls.Add(this.label13);
            this.panel_coef.Controls.Add(this.label12);
            this.panel_coef.Controls.Add(this.label11);
            this.panel_coef.Controls.Add(this.label10);
            this.panel_coef.Controls.Add(this.label9);
            this.panel_coef.Controls.Add(this.label8);
            this.panel_coef.Controls.Add(this.label7);
            this.panel_coef.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_coef.Location = new System.Drawing.Point(147, 0);
            this.panel_coef.Name = "panel_coef";
            this.panel_coef.Size = new System.Drawing.Size(297, 498);
            this.panel_coef.TabIndex = 77;
            // 
            // root_chord_tb
            // 
            this.root_chord_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.root_chord_tb.BackColor = System.Drawing.Color.White;
            this.root_chord_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.root_chord_tb.Location = new System.Drawing.Point(184, 95);
            this.root_chord_tb.Name = "root_chord_tb";
            this.root_chord_tb.Size = new System.Drawing.Size(87, 29);
            this.root_chord_tb.TabIndex = 67;
            // 
            // taper_tb
            // 
            this.taper_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.taper_tb.BackColor = System.Drawing.Color.White;
            this.taper_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taper_tb.Location = new System.Drawing.Point(184, 163);
            this.taper_tb.Name = "taper_tb";
            this.taper_tb.Size = new System.Drawing.Size(87, 29);
            this.taper_tb.TabIndex = 66;
            // 
            // ae_tb
            // 
            this.ae_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ae_tb.BackColor = System.Drawing.Color.White;
            this.ae_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ae_tb.Location = new System.Drawing.Point(184, 231);
            this.ae_tb.Name = "ae_tb";
            this.ae_tb.Size = new System.Drawing.Size(87, 29);
            this.ae_tb.TabIndex = 65;
            // 
            // a0_tb
            // 
            this.a0_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.a0_tb.BackColor = System.Drawing.Color.White;
            this.a0_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a0_tb.Location = new System.Drawing.Point(184, 299);
            this.a0_tb.Name = "a0_tb";
            this.a0_tb.Size = new System.Drawing.Size(87, 29);
            this.a0_tb.TabIndex = 64;
            // 
            // washout_tb
            // 
            this.washout_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.washout_tb.BackColor = System.Drawing.Color.White;
            this.washout_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.washout_tb.Location = new System.Drawing.Point(184, 367);
            this.washout_tb.Name = "washout_tb";
            this.washout_tb.Size = new System.Drawing.Size(87, 29);
            this.washout_tb.TabIndex = 63;
            // 
            // alpha_tb
            // 
            this.alpha_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alpha_tb.BackColor = System.Drawing.Color.White;
            this.alpha_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alpha_tb.Location = new System.Drawing.Point(184, 435);
            this.alpha_tb.Name = "alpha_tb";
            this.alpha_tb.Size = new System.Drawing.Size(87, 29);
            this.alpha_tb.TabIndex = 62;
            // 
            // span_tb
            // 
            this.span_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.span_tb.BackColor = System.Drawing.Color.White;
            this.span_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.span_tb.Location = new System.Drawing.Point(184, 27);
            this.span_tb.Name = "span_tb";
            this.span_tb.Size = new System.Drawing.Size(87, 29);
            this.span_tb.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 44);
            this.label13.TabIndex = 60;
            this.label13.Text = "α zero lift\r\n(deg)";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 435);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 22);
            this.label12.TabIndex = 59;
            this.label12.Text = "α (deg)";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 44);
            this.label11.TabIndex = 58;
            this.label11.Text = "Washout\r\n(deg)";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 44);
            this.label10.TabIndex = 57;
            this.label10.Text = "Lift Curve Slope\r\n(per rad)";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 22);
            this.label9.TabIndex = 56;
            this.label9.Text = "Taper Ratio";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 22);
            this.label8.TabIndex = 55;
            this.label8.Text = "Root Chord (m)";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 54;
            this.label7.Text = "Span (m)";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.A3_tb);
            this.panel1.Controls.Add(this.A5_tb);
            this.panel1.Controls.Add(this.A7_tb);
            this.panel1.Controls.Add(this.cl_tb);
            this.panel1.Controls.Add(this.cd_tb);
            this.panel1.Controls.Add(this.A1_tb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(450, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 341);
            this.panel1.TabIndex = 78;
            // 
            // A3_tb
            // 
            this.A3_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.A3_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.A3_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3_tb.Location = new System.Drawing.Point(145, 79);
            this.A3_tb.Name = "A3_tb";
            this.A3_tb.ReadOnly = true;
            this.A3_tb.Size = new System.Drawing.Size(109, 29);
            this.A3_tb.TabIndex = 67;
            // 
            // A5_tb
            // 
            this.A5_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.A5_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.A5_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A5_tb.Location = new System.Drawing.Point(145, 130);
            this.A5_tb.Name = "A5_tb";
            this.A5_tb.ReadOnly = true;
            this.A5_tb.Size = new System.Drawing.Size(109, 29);
            this.A5_tb.TabIndex = 66;
            // 
            // A7_tb
            // 
            this.A7_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.A7_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.A7_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A7_tb.Location = new System.Drawing.Point(145, 181);
            this.A7_tb.Name = "A7_tb";
            this.A7_tb.ReadOnly = true;
            this.A7_tb.Size = new System.Drawing.Size(109, 29);
            this.A7_tb.TabIndex = 65;
            // 
            // cl_tb
            // 
            this.cl_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cl_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cl_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_tb.Location = new System.Drawing.Point(145, 232);
            this.cl_tb.Name = "cl_tb";
            this.cl_tb.ReadOnly = true;
            this.cl_tb.Size = new System.Drawing.Size(109, 29);
            this.cl_tb.TabIndex = 64;
            // 
            // cd_tb
            // 
            this.cd_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cd_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cd_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_tb.Location = new System.Drawing.Point(145, 283);
            this.cd_tb.Name = "cd_tb";
            this.cd_tb.ReadOnly = true;
            this.cd_tb.Size = new System.Drawing.Size(109, 29);
            this.cd_tb.TabIndex = 63;
            // 
            // A1_tb
            // 
            this.A1_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.A1_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.A1_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1_tb.Location = new System.Drawing.Point(145, 28);
            this.A1_tb.Name = "A1_tb";
            this.A1_tb.ReadOnly = true;
            this.A1_tb.Size = new System.Drawing.Size(109, 29);
            this.A1_tb.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = "Cd";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 22);
            this.label3.TabIndex = 58;
            this.label3.Text = "Cl";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 22);
            this.label4.TabIndex = 57;
            this.label4.Text = "A7";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 22);
            this.label5.TabIndex = 56;
            this.label5.Text = "A5";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 22);
            this.label6.TabIndex = 55;
            this.label6.Text = "A3";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(79, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 22);
            this.label14.TabIndex = 54;
            this.label14.Text = "A1";
            // 
            // naca2412_bt
            // 
            this.naca2412_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.naca2412_bt.FlatAppearance.BorderSize = 0;
            this.naca2412_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.naca2412_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(163)))));
            this.naca2412_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naca2412_bt.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naca2412_bt.ForeColor = System.Drawing.Color.White;
            this.naca2412_bt.Location = new System.Drawing.Point(0, 84);
            this.naca2412_bt.Name = "naca2412_bt";
            this.naca2412_bt.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.naca2412_bt.Size = new System.Drawing.Size(147, 36);
            this.naca2412_bt.TabIndex = 88;
            this.naca2412_bt.Text = "NACA 2412";
            this.naca2412_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.naca2412_bt.UseVisualStyleBackColor = false;
            this.naca2412_bt.Click += new System.EventHandler(this.naca2412_bt_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(163)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(163)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(163)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 36);
            this.button3.TabIndex = 87;
            this.button3.Text = "Aerofoil";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // naca4412_bt
            // 
            this.naca4412_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.naca4412_bt.FlatAppearance.BorderSize = 0;
            this.naca4412_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.naca4412_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(163)))));
            this.naca4412_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naca4412_bt.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naca4412_bt.ForeColor = System.Drawing.Color.White;
            this.naca4412_bt.Location = new System.Drawing.Point(0, 126);
            this.naca4412_bt.Name = "naca4412_bt";
            this.naca4412_bt.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.naca4412_bt.Size = new System.Drawing.Size(147, 36);
            this.naca4412_bt.TabIndex = 86;
            this.naca4412_bt.Text = "NACA 4412";
            this.naca4412_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.naca4412_bt.UseVisualStyleBackColor = false;
            this.naca4412_bt.Click += new System.EventHandler(this.naca4412_bt_Click);
            // 
            // naca0012_bt
            // 
            this.naca0012_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.naca0012_bt.FlatAppearance.BorderSize = 0;
            this.naca0012_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.naca0012_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(163)))));
            this.naca0012_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naca0012_bt.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naca0012_bt.ForeColor = System.Drawing.Color.White;
            this.naca0012_bt.Location = new System.Drawing.Point(0, 42);
            this.naca0012_bt.Name = "naca0012_bt";
            this.naca0012_bt.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.naca0012_bt.Size = new System.Drawing.Size(147, 36);
            this.naca0012_bt.TabIndex = 90;
            this.naca0012_bt.Text = "NACA 0012";
            this.naca0012_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.naca0012_bt.UseVisualStyleBackColor = false;
            this.naca0012_bt.Click += new System.EventHandler(this.naca0012_bt_Click);
            // 
            // naca65210_bt
            // 
            this.naca65210_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.naca65210_bt.FlatAppearance.BorderSize = 0;
            this.naca65210_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.naca65210_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(163)))));
            this.naca65210_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naca65210_bt.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naca65210_bt.ForeColor = System.Drawing.Color.White;
            this.naca65210_bt.Location = new System.Drawing.Point(0, 168);
            this.naca65210_bt.Name = "naca65210_bt";
            this.naca65210_bt.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.naca65210_bt.Size = new System.Drawing.Size(147, 36);
            this.naca65210_bt.TabIndex = 89;
            this.naca65210_bt.Text = "NACA 65210";
            this.naca65210_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.naca65210_bt.UseVisualStyleBackColor = false;
            this.naca65210_bt.Click += new System.EventHandler(this.naca65210_bt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.sdeg4_tb);
            this.panel2.Controls.Add(this.sdeg3_tb);
            this.panel2.Controls.Add(this.sdeg2_tb);
            this.panel2.Controls.Add(this.sdeg1_tb);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.s5_tb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.s3_tb);
            this.panel2.Controls.Add(this.s4_tb);
            this.panel2.Controls.Add(this.s2_tb);
            this.panel2.Controls.Add(this.s1_tb);
            this.panel2.Location = new System.Drawing.Point(450, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 151);
            this.panel2.TabIndex = 79;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(94, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 22);
            this.label15.TabIndex = 74;
            this.label15.Text = "Spanwise Location";
            // 
            // s5_tb
            // 
            this.s5_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.s5_tb.BackColor = System.Drawing.Color.White;
            this.s5_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s5_tb.Location = new System.Drawing.Point(242, 53);
            this.s5_tb.Name = "s5_tb";
            this.s5_tb.Size = new System.Drawing.Size(36, 29);
            this.s5_tb.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 22);
            this.label1.TabIndex = 79;
            this.label1.Text = "/";
            // 
            // s3_tb
            // 
            this.s3_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.s3_tb.BackColor = System.Drawing.Color.White;
            this.s3_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s3_tb.Location = new System.Drawing.Point(134, 53);
            this.s3_tb.Name = "s3_tb";
            this.s3_tb.Size = new System.Drawing.Size(36, 29);
            this.s3_tb.TabIndex = 78;
            // 
            // s4_tb
            // 
            this.s4_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.s4_tb.BackColor = System.Drawing.Color.White;
            this.s4_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s4_tb.Location = new System.Drawing.Point(176, 53);
            this.s4_tb.Name = "s4_tb";
            this.s4_tb.Size = new System.Drawing.Size(36, 29);
            this.s4_tb.TabIndex = 77;
            // 
            // s2_tb
            // 
            this.s2_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.s2_tb.BackColor = System.Drawing.Color.White;
            this.s2_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s2_tb.Location = new System.Drawing.Point(92, 53);
            this.s2_tb.Name = "s2_tb";
            this.s2_tb.Size = new System.Drawing.Size(36, 29);
            this.s2_tb.TabIndex = 76;
            // 
            // s1_tb
            // 
            this.s1_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.s1_tb.BackColor = System.Drawing.Color.White;
            this.s1_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s1_tb.Location = new System.Drawing.Point(50, 53);
            this.s1_tb.Name = "s1_tb";
            this.s1_tb.Size = new System.Drawing.Size(36, 29);
            this.s1_tb.TabIndex = 75;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 59);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 81;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 105);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 82;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // sdeg1_tb
            // 
            this.sdeg1_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sdeg1_tb.BackColor = System.Drawing.Color.White;
            this.sdeg1_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdeg1_tb.Location = new System.Drawing.Point(50, 98);
            this.sdeg1_tb.Name = "sdeg1_tb";
            this.sdeg1_tb.Size = new System.Drawing.Size(51, 29);
            this.sdeg1_tb.TabIndex = 83;
            // 
            // sdeg2_tb
            // 
            this.sdeg2_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sdeg2_tb.BackColor = System.Drawing.Color.White;
            this.sdeg2_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdeg2_tb.Location = new System.Drawing.Point(109, 98);
            this.sdeg2_tb.Name = "sdeg2_tb";
            this.sdeg2_tb.Size = new System.Drawing.Size(51, 29);
            this.sdeg2_tb.TabIndex = 84;
            // 
            // sdeg3_tb
            // 
            this.sdeg3_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sdeg3_tb.BackColor = System.Drawing.Color.White;
            this.sdeg3_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdeg3_tb.Location = new System.Drawing.Point(168, 98);
            this.sdeg3_tb.Name = "sdeg3_tb";
            this.sdeg3_tb.Size = new System.Drawing.Size(51, 29);
            this.sdeg3_tb.TabIndex = 85;
            // 
            // sdeg4_tb
            // 
            this.sdeg4_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sdeg4_tb.BackColor = System.Drawing.Color.White;
            this.sdeg4_tb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdeg4_tb.Location = new System.Drawing.Point(227, 98);
            this.sdeg4_tb.Name = "sdeg4_tb";
            this.sdeg4_tb.Size = new System.Drawing.Size(51, 29);
            this.sdeg4_tb.TabIndex = 86;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(284, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 22);
            this.label16.TabIndex = 87;
            this.label16.Text = "(-s)";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(284, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 22);
            this.label17.TabIndex = 88;
            this.label17.Text = "(deg)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_coef);
            this.Controls.Add(this.panel_left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(813, 545);
            this.MinimumSize = new System.Drawing.Size(813, 545);
            this.Name = "Form1";
            this.Text = "Lifting Line Wing Data - Nian Liu - 201616374";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_left.ResumeLayout(false);
            this.panel_coef.ResumeLayout(false);
            this.panel_coef.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_bt;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calc_bt;
        private System.Windows.Forms.Panel panel_coef;
        private System.Windows.Forms.TextBox root_chord_tb;
        private System.Windows.Forms.TextBox taper_tb;
        private System.Windows.Forms.TextBox ae_tb;
        private System.Windows.Forms.TextBox a0_tb;
        private System.Windows.Forms.TextBox washout_tb;
        private System.Windows.Forms.TextBox alpha_tb;
        private System.Windows.Forms.TextBox span_tb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox A3_tb;
        private System.Windows.Forms.TextBox A5_tb;
        private System.Windows.Forms.TextBox A7_tb;
        private System.Windows.Forms.TextBox cl_tb;
        private System.Windows.Forms.TextBox cd_tb;
        private System.Windows.Forms.TextBox A1_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button clear_bt;
        private System.Windows.Forms.Button naca0012_bt;
        private System.Windows.Forms.Button naca65210_bt;
        private System.Windows.Forms.Button naca2412_bt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button naca4412_bt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox s5_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox s3_tb;
        private System.Windows.Forms.TextBox s4_tb;
        private System.Windows.Forms.TextBox s2_tb;
        private System.Windows.Forms.TextBox s1_tb;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox sdeg4_tb;
        private System.Windows.Forms.TextBox sdeg3_tb;
        private System.Windows.Forms.TextBox sdeg2_tb;
        private System.Windows.Forms.TextBox sdeg1_tb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}

