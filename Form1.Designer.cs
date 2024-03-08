namespace WindowsFormsApp1
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxIncidencias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chckBoxPrimeraVez = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoxTipoMaquina = new System.Windows.Forms.ComboBox();
            this.comBoxAlimentacion = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 316);
            this.listBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2024, 1, 16, 17, 18, 0, 0);
            // 
            // txtBoxIncidencias
            // 
            this.txtBoxIncidencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIncidencias.Location = new System.Drawing.Point(30, 173);
            this.txtBoxIncidencias.Multiline = true;
            this.txtBoxIncidencias.Name = "txtBoxIncidencias";
            this.txtBoxIncidencias.Size = new System.Drawing.Size(316, 28);
            this.txtBoxIncidencias.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.MinimumSize = new System.Drawing.Size(88, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Últimas órdenes";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(3, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 357);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(468, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 405);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(30, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 405);
            this.panel2.TabIndex = 38;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(344, 434);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(82, 26);
            this.btnCargarDatos.TabIndex = 39;
            this.btnCargarDatos.Text = "Cargar datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(134, 28);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(212, 20);
            this.txtBoxNombre.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Apellido y nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fecha de ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Incidencias";
            // 
            // chckBoxPrimeraVez
            // 
            this.chckBoxPrimeraVez.AutoSize = true;
            this.chckBoxPrimeraVez.Location = new System.Drawing.Point(30, 90);
            this.chckBoxPrimeraVez.Name = "chckBoxPrimeraVez";
            this.chckBoxPrimeraVez.Size = new System.Drawing.Size(88, 17);
            this.chckBoxPrimeraVez.TabIndex = 39;
            this.chckBoxPrimeraVez.Text = "Primera visita";
            this.chckBoxPrimeraVez.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Alimentación";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxTelefono);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtBoxDNI);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBoxNombre);
            this.groupBox3.Location = new System.Drawing.Point(20, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 111);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Nro de Documento";
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Location = new System.Drawing.Point(134, 55);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDNI.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Teléfono";
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Location = new System.Drawing.Point(134, 79);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTelefono.TabIndex = 39;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comBoxAlimentacion);
            this.groupBox4.Controls.Add(this.comBoxTipoMaquina);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtBoxIncidencias);
            this.groupBox4.Controls.Add(this.chckBoxPrimeraVez);
            this.groupBox4.Location = new System.Drawing.Point(20, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 232);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Máquina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tipo de máquina";
            // 
            // comBoxTipoMaquina
            // 
            this.comBoxTipoMaquina.FormattingEnabled = true;
            this.comBoxTipoMaquina.Location = new System.Drawing.Point(134, 27);
            this.comBoxTipoMaquina.Name = "comBoxTipoMaquina";
            this.comBoxTipoMaquina.Size = new System.Drawing.Size(121, 21);
            this.comBoxTipoMaquina.TabIndex = 40;
            // 
            // comBoxAlimentacion
            // 
            this.comBoxAlimentacion.FormattingEnabled = true;
            this.comBoxAlimentacion.Location = new System.Drawing.Point(134, 56);
            this.comBoxAlimentacion.Name = "comBoxAlimentacion";
            this.comBoxAlimentacion.Size = new System.Drawing.Size(121, 21);
            this.comBoxAlimentacion.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(674, 471);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(690, 510);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar ticket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBoxIncidencias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chckBoxPrimeraVez;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBoxTipoMaquina;
        private System.Windows.Forms.ComboBox comBoxAlimentacion;
    }
}

