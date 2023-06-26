namespace Presentacion
{
    partial class frm_cajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cajero));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Contacto = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Nombre1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_precio_und = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ingredientes = new System.Windows.Forms.TextBox();
            this.dtg_Datos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_Factura = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_Iva = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_facturar = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbx_mediospagos = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_facturar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "PEDIDOS ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 51);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(716, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Identificacion";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(139, 71);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(217, 29);
            this.txt_ID.TabIndex = 5;
            this.txt_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_ID_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(464, 71);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.ReadOnly = true;
            this.txt_Nombre.Size = new System.Drawing.Size(266, 29);
            this.txt_Nombre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contacto";
            // 
            // txt_Contacto
            // 
            this.txt_Contacto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contacto.Location = new System.Drawing.Point(139, 113);
            this.txt_Contacto.Name = "txt_Contacto";
            this.txt_Contacto.ReadOnly = true;
            this.txt_Contacto.Size = new System.Drawing.Size(217, 29);
            this.txt_Contacto.TabIndex = 10;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(464, 106);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.ReadOnly = true;
            this.txt_Direccion.Size = new System.Drawing.Size(266, 29);
            this.txt_Direccion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(369, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Codigo";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.Location = new System.Drawing.Point(139, 153);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(201, 29);
            this.txt_Codigo.TabIndex = 14;
            this.txt_Codigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Codigo_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "<ENTER>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "<ENTER>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nombre";
            // 
            // txt_Nombre1
            // 
            this.txt_Nombre1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre1.Location = new System.Drawing.Point(139, 194);
            this.txt_Nombre1.Name = "txt_Nombre1";
            this.txt_Nombre1.ReadOnly = true;
            this.txt_Nombre1.Size = new System.Drawing.Size(201, 29);
            this.txt_Nombre1.TabIndex = 17;
            this.txt_Nombre1.TextChanged += new System.EventHandler(this.txt_Nombre1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "Precio UND";
            // 
            // txt_precio_und
            // 
            this.txt_precio_und.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_und.Location = new System.Drawing.Point(139, 236);
            this.txt_precio_und.Name = "txt_precio_und";
            this.txt_precio_und.ReadOnly = true;
            this.txt_precio_und.Size = new System.Drawing.Size(201, 29);
            this.txt_precio_und.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Cantidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(139, 285);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(134, 29);
            this.txt_cantidad.TabIndex = 21;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.Location = new System.Drawing.Point(282, 276);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(58, 38);
            this.btn_agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_agregar.TabIndex = 22;
            this.btn_agregar.TabStop = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(347, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 22);
            this.label12.TabIndex = 23;
            this.label12.Text = "Ingredientes";
            // 
            // txt_ingredientes
            // 
            this.txt_ingredientes.Location = new System.Drawing.Point(385, 178);
            this.txt_ingredientes.Multiline = true;
            this.txt_ingredientes.Name = "txt_ingredientes";
            this.txt_ingredientes.ReadOnly = true;
            this.txt_ingredientes.Size = new System.Drawing.Size(345, 100);
            this.txt_ingredientes.TabIndex = 24;
            // 
            // dtg_Datos
            // 
            this.dtg_Datos.AllowUserToAddRows = false;
            this.dtg_Datos.AllowUserToDeleteRows = false;
            this.dtg_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2});
            this.dtg_Datos.Location = new System.Drawing.Point(23, 335);
            this.dtg_Datos.Name = "dtg_Datos";
            this.dtg_Datos.ReadOnly = true;
            this.dtg_Datos.Size = new System.Drawing.Size(716, 150);
            this.dtg_Datos.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio UND";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 521);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 37);
            this.label13.TabIndex = 18;
            this.label13.Text = "Factura No.";
            // 
            // lbl_Factura
            // 
            this.lbl_Factura.AutoSize = true;
            this.lbl_Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Factura.Location = new System.Drawing.Point(248, 521);
            this.lbl_Factura.Name = "lbl_Factura";
            this.lbl_Factura.Size = new System.Drawing.Size(36, 37);
            this.lbl_Factura.TabIndex = 26;
            this.lbl_Factura.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(614, 501);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Subtotal $";
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtotal.Location = new System.Drawing.Point(712, 501);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(18, 20);
            this.lbl_Subtotal.TabIndex = 28;
            this.lbl_Subtotal.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(653, 521);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Iva $";
            // 
            // lbl_Iva
            // 
            this.lbl_Iva.AutoSize = true;
            this.lbl_Iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Iva.Location = new System.Drawing.Point(712, 521);
            this.lbl_Iva.Name = "lbl_Iva";
            this.lbl_Iva.Size = new System.Drawing.Size(18, 20);
            this.lbl_Iva.TabIndex = 30;
            this.lbl_Iva.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(639, 541);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "Total $";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(712, 541);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(18, 20);
            this.lbl_Total.TabIndex = 32;
            this.lbl_Total.Text = "0";
            // 
            // btn_facturar
            // 
            this.btn_facturar.Image = ((System.Drawing.Image)(resources.GetObject("btn_facturar.Image")));
            this.btn_facturar.Location = new System.Drawing.Point(445, 511);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(59, 50);
            this.btn_facturar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_facturar.TabIndex = 33;
            this.btn_facturar.TabStop = false;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(335, 511);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(59, 47);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_cerrar.TabIndex = 34;
            this.btn_cerrar.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(410, 292);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 22);
            this.label16.TabIndex = 35;
            this.label16.Text = "Tipo De Pago";
            // 
            // cbx_mediospagos
            // 
            this.cbx_mediospagos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_mediospagos.FormattingEnabled = true;
            this.cbx_mediospagos.Location = new System.Drawing.Point(552, 289);
            this.cbx_mediospagos.Name = "cbx_mediospagos";
            this.cbx_mediospagos.Size = new System.Drawing.Size(178, 30);
            this.cbx_mediospagos.TabIndex = 36;
            // 
            // frm_cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 577);
            this.Controls.Add(this.cbx_mediospagos);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_facturar);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbl_Iva);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_Factura);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtg_Datos);
            this.Controls.Add(this.txt_ingredientes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_precio_und);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Nombre1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Contacto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cajero";
            this.Text = "frm_factura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_facturar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Contacto;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Nombre1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_precio_und;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.PictureBox btn_agregar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_ingredientes;
        private System.Windows.Forms.DataGridView dtg_Datos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_Factura;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_Iva;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.PictureBox btn_facturar;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbx_mediospagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}