namespace Proyecto_Final_Individual
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new ns1.BunifuImageButton();
            this.drgForm = new ns1.BunifuDragControl(this.components);
            this.rdForm = new ns1.BunifuElipse(this.components);
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.bunifuSeparator3 = new ns1.BunifuSeparator();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.bunifuSeparator4 = new ns1.BunifuSeparator();
            this.lblM = new System.Windows.Forms.Label();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.lblSignifi = new System.Windows.Forms.Label();
            this.tblNumeros = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drgTitulo = new ns1.BunifuDragControl(this.components);
            this.rdTabla = new ns1.BunifuElipse(this.components);
            this.rdBoton = new ns1.BunifuElipse(this.components);
            this.btnPruebas = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.rdContinuar = new ns1.BunifuElipse(this.components);
            this.rdPruebas = new ns1.BunifuElipse(this.components);
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.arrastraTop = new ns1.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Controls.Add(this.btnCerrar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(597, 51);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(64, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 21);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "GENERADOR DE NÚMEROS";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Proyecto_Final_Individual.Properties.Resources.cancelar__2_;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(539, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // drgForm
            // 
            this.drgForm.Fixed = true;
            this.drgForm.Horizontal = true;
            this.drgForm.TargetControl = this.pnlTop;
            this.drgForm.Vertical = true;
            // 
            // rdForm
            // 
            this.rdForm.ElipseRadius = 30;
            this.rdForm.TargetControl = this;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Black;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerar.Location = new System.Drawing.Point(145, 313);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemilla.ForeColor = System.Drawing.Color.White;
            this.lblSemilla.Location = new System.Drawing.Point(43, 103);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(64, 21);
            this.lblSemilla.TabIndex = 2;
            this.lblSemilla.Text = "Semilla:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.White;
            this.lblA.Location = new System.Drawing.Point(43, 167);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(21, 21);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "a:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.White;
            this.lblC.Location = new System.Drawing.Point(43, 228);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(20, 21);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "c:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(47, 148);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(111, 16);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(47, 209);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(111, 16);
            this.bunifuSeparator2.TabIndex = 6;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(47, 272);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(111, 16);
            this.bunifuSeparator3.TabIndex = 7;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // txtSemilla
            // 
            this.txtSemilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txtSemilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSemilla.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtSemilla.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSemilla.Location = new System.Drawing.Point(47, 133);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(111, 22);
            this.txtSemilla.TabIndex = 8;
            this.txtSemilla.Text = "38";
            this.txtSemilla.TextChanged += new System.EventHandler(this.txtSemilla_TextChanged);
            this.txtSemilla.Validating += new System.ComponentModel.CancelEventHandler(this.txtSemilla_Validating);
            this.txtSemilla.Validated += new System.EventHandler(this.txtSemilla_Validated);
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtA.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtA.Location = new System.Drawing.Point(47, 194);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(111, 22);
            this.txtA.TabIndex = 9;
            this.txtA.Text = "101";
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            this.txtA.Validating += new System.ComponentModel.CancelEventHandler(this.txtA_Validating);
            this.txtA.Validated += new System.EventHandler(this.txtA_Validated);
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txtC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtC.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtC.Location = new System.Drawing.Point(47, 257);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(111, 22);
            this.txtC.TabIndex = 10;
            this.txtC.Text = "221";
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            this.txtC.Validating += new System.ComponentModel.CancelEventHandler(this.txtC_Validating);
            this.txtC.Validated += new System.EventHandler(this.txtC_Validated);
            // 
            // txtM
            // 
            this.txtM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txtM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtM.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtM.Location = new System.Drawing.Point(197, 133);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(111, 22);
            this.txtM.TabIndex = 13;
            this.txtM.Text = "17001";
            this.txtM.TextChanged += new System.EventHandler(this.txtM_TextChanged);
            this.txtM.Validating += new System.ComponentModel.CancelEventHandler(this.txtM_Validating);
            this.txtM.Validated += new System.EventHandler(this.txtM_Validated);
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(197, 148);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(111, 16);
            this.bunifuSeparator4.TabIndex = 12;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.ForeColor = System.Drawing.Color.White;
            this.lblM.Location = new System.Drawing.Point(193, 103);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(27, 21);
            this.lblM.TabIndex = 11;
            this.lblM.Text = "m:";
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb10.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.rb10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb10.Location = new System.Drawing.Point(197, 230);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(59, 25);
            this.rb10.TabIndex = 14;
            this.rb10.TabStop = true;
            this.rb10.Text = "10%";
            this.rb10.UseVisualStyleBackColor = true;
            this.rb10.Click += new System.EventHandler(this.rb10_Click);
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb5.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.rb5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb5.Location = new System.Drawing.Point(197, 253);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(50, 25);
            this.rb5.TabIndex = 15;
            this.rb5.TabStop = true;
            this.rb5.Text = "5%";
            this.rb5.UseVisualStyleBackColor = true;
            this.rb5.CheckedChanged += new System.EventHandler(this.rb5_CheckedChanged);
            // 
            // lblSignifi
            // 
            this.lblSignifi.AutoSize = true;
            this.lblSignifi.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignifi.ForeColor = System.Drawing.Color.White;
            this.lblSignifi.Location = new System.Drawing.Point(193, 174);
            this.lblSignifi.Name = "lblSignifi";
            this.lblSignifi.Size = new System.Drawing.Size(98, 42);
            this.lblSignifi.TabIndex = 16;
            this.lblSignifi.Text = "Nivel de \r\nsignificancia:";
            // 
            // tblNumeros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.tblNumeros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblNumeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblNumeros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tblNumeros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblNumeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblNumeros.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblNumeros.EnableHeadersVisualStyles = false;
            this.tblNumeros.Location = new System.Drawing.Point(368, 57);
            this.tblNumeros.Name = "tblNumeros";
            this.tblNumeros.ReadOnly = true;
            this.tblNumeros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblNumeros.RowHeadersVisible = false;
            this.tblNumeros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblNumeros.Size = new System.Drawing.Size(201, 342);
            this.tblNumeros.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ri";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // drgTitulo
            // 
            this.drgTitulo.Fixed = true;
            this.drgTitulo.Horizontal = true;
            this.drgTitulo.TargetControl = this.lblTitulo;
            this.drgTitulo.Vertical = true;
            // 
            // rdTabla
            // 
            this.rdTabla.ElipseRadius = 20;
            this.rdTabla.TargetControl = this.tblNumeros;
            // 
            // rdBoton
            // 
            this.rdBoton.ElipseRadius = 10;
            this.rdBoton.TargetControl = this.btnGenerar;
            // 
            // btnPruebas
            // 
            this.btnPruebas.BackColor = System.Drawing.Color.Black;
            this.btnPruebas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPruebas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPruebas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPruebas.Location = new System.Drawing.Point(47, 386);
            this.btnPruebas.Name = "btnPruebas";
            this.btnPruebas.Size = new System.Drawing.Size(111, 23);
            this.btnPruebas.TabIndex = 18;
            this.btnPruebas.Text = "Ver Pruebas";
            this.btnPruebas.UseVisualStyleBackColor = false;
            this.btnPruebas.Visible = false;
            this.btnPruebas.Click += new System.EventHandler(this.btnPruebas_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Black;
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnContinuar.Location = new System.Drawing.Point(233, 386);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(84, 23);
            this.btnContinuar.TabIndex = 19;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Visible = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // rdContinuar
            // 
            this.rdContinuar.ElipseRadius = 10;
            this.rdContinuar.TargetControl = this.btnContinuar;
            // 
            // rdPruebas
            // 
            this.rdPruebas.ElipseRadius = 10;
            this.rdPruebas.TargetControl = this.btnPruebas;
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // arrastraTop
            // 
            this.arrastraTop.Fixed = true;
            this.arrastraTop.Horizontal = true;
            this.arrastraTop.TargetControl = this.pnlTop;
            this.arrastraTop.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Creador: Edwin Villada";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(597, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnPruebas);
            this.Controls.Add(this.tblNumeros);
            this.Controls.Add(this.lblSignifi);
            this.Controls.Add(this.rb5);
            this.Controls.Add(this.rb10);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtSemilla);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblSemilla);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private ns1.BunifuImageButton btnCerrar;
        private ns1.BunifuDragControl drgForm;
        private ns1.BunifuElipse rdForm;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblSemilla;
        private ns1.BunifuSeparator bunifuSeparator1;
        private ns1.BunifuSeparator bunifuSeparator3;
        private ns1.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Label lblSignifi;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.TextBox txtM;
        private ns1.BunifuSeparator bunifuSeparator4;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lblTitulo;
        private ns1.BunifuDragControl drgTitulo;
        private ns1.BunifuElipse rdTabla;
        public System.Windows.Forms.DataGridView tblNumeros;
        private ns1.BunifuElipse rdBoton;
        private System.Windows.Forms.Button btnPruebas;
        private System.Windows.Forms.Button btnContinuar;
        private ns1.BunifuElipse rdContinuar;
        private ns1.BunifuElipse rdPruebas;
        private System.Windows.Forms.ErrorProvider error1;
        private ns1.BunifuDragControl arrastraTop;
        private System.Windows.Forms.Label label1;
    }
}

