
namespace Segundo_Parcial
{
    partial class MySql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySql));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bguardar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.bentrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bbuscar = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bnuevo = new System.Windows.Forms.Button();
            this.bactualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.lstsexo = new System.Windows.Forms.ComboBox();
            this.lstnivel = new System.Windows.Forms.ComboBox();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.txtpuesto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtisss = new System.Windows.Forms.TextBox();
            this.txtafp = new System.Windows.Forms.TextBox();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdui = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Location = new System.Drawing.Point(11, 226);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(80, 35);
            this.bguardar.TabIndex = 1;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // beliminar
            // 
            this.beliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar.Location = new System.Drawing.Point(97, 226);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(80, 35);
            this.beliminar.TabIndex = 2;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bmodificar
            // 
            this.bmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodificar.Location = new System.Drawing.Point(184, 226);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(80, 35);
            this.bmodificar.TabIndex = 3;
            this.bmodificar.Text = "Modificar";
            this.bmodificar.UseVisualStyleBackColor = true;
            this.bmodificar.Click += new System.EventHandler(this.bmodificar_Click);
            // 
            // bentrar
            // 
            this.bentrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bentrar.Location = new System.Drawing.Point(269, 226);
            this.bentrar.Name = "bentrar";
            this.bentrar.Size = new System.Drawing.Size(80, 35);
            this.bentrar.TabIndex = 4;
            this.bentrar.Text = "Entrar";
            this.bentrar.UseVisualStyleBackColor = true;
            this.bentrar.Click += new System.EventHandler(this.bentrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 228);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bbuscar
            // 
            this.bbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbuscar.Location = new System.Drawing.Point(441, 226);
            this.bbuscar.Name = "bbuscar";
            this.bbuscar.Size = new System.Drawing.Size(80, 35);
            this.bbuscar.TabIndex = 6;
            this.bbuscar.Text = "Buscar";
            this.bbuscar.UseVisualStyleBackColor = true;
            this.bbuscar.Click += new System.EventHandler(this.bbuscar_Click);
            // 
            // bsalir
            // 
            this.bsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsalir.Location = new System.Drawing.Point(355, 226);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(80, 35);
            this.bsalir.TabIndex = 7;
            this.bsalir.Text = "Salir";
            this.bsalir.UseVisualStyleBackColor = true;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Clave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nivel:";
            // 
            // bnuevo
            // 
            this.bnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevo.Location = new System.Drawing.Point(11, 226);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(80, 35);
            this.bnuevo.TabIndex = 15;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = true;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // bactualizar
            // 
            this.bactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bactualizar.Location = new System.Drawing.Point(183, 226);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(80, 35);
            this.bactualizar.TabIndex = 17;
            this.bactualizar.Text = "Actualizar";
            this.bactualizar.UseVisualStyleBackColor = true;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(226, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Sexo:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(527, 235);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 8;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(288, 13);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 29;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged_1);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(288, 39);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(100, 20);
            this.txtclave.TabIndex = 30;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(288, 92);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 31;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(288, 118);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(100, 20);
            this.txtcorreo.TabIndex = 32;
            // 
            // lstsexo
            // 
            this.lstsexo.FormattingEnabled = true;
            this.lstsexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.lstsexo.Location = new System.Drawing.Point(288, 144);
            this.lstsexo.Name = "lstsexo";
            this.lstsexo.Size = new System.Drawing.Size(100, 21);
            this.lstsexo.TabIndex = 33;
            this.lstsexo.SelectedIndexChanged += new System.EventHandler(this.lstedad_SelectedIndexChanged_1);
            // 
            // lstnivel
            // 
            this.lstnivel.FormattingEnabled = true;
            this.lstnivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lstnivel.Location = new System.Drawing.Point(288, 65);
            this.lstnivel.Name = "lstnivel";
            this.lstnivel.Size = new System.Drawing.Size(100, 21);
            this.lstnivel.TabIndex = 34;
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(474, 143);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(100, 20);
            this.txtsueldo.TabIndex = 136;
            // 
            // txtpuesto
            // 
            this.txtpuesto.Location = new System.Drawing.Point(474, 117);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(100, 20);
            this.txtpuesto.TabIndex = 135;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(411, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 15);
            this.label14.TabIndex = 134;
            this.label14.Text = "Sueldo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(412, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 133;
            this.label13.Text = "Puesto:";
            // 
            // dtfecha
            // 
            this.dtfecha.Location = new System.Drawing.Point(474, 91);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(100, 20);
            this.dtfecha.TabIndex = 132;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(412, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 131;
            this.label12.Text = "Fecha:";
            // 
            // txtisss
            // 
            this.txtisss.Location = new System.Drawing.Point(474, 64);
            this.txtisss.Name = "txtisss";
            this.txtisss.Size = new System.Drawing.Size(100, 20);
            this.txtisss.TabIndex = 130;
            // 
            // txtafp
            // 
            this.txtafp.Location = new System.Drawing.Point(474, 38);
            this.txtafp.Name = "txtafp";
            this.txtafp.Size = new System.Drawing.Size(100, 20);
            this.txtafp.TabIndex = 129;
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(474, 12);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(100, 20);
            this.txtnit.TabIndex = 128;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(430, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 127;
            this.label11.Text = "AFP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(425, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 126;
            this.label10.Text = "ISSS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(430, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 125;
            this.label9.Text = "NIT:";
            // 
            // txtdui
            // 
            this.txtdui.Location = new System.Drawing.Point(288, 171);
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(100, 20);
            this.txtdui.TabIndex = 138;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 137;
            this.label8.Text = "DUI:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(547, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 139;
            this.button1.Text = "Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MySql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(639, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdui);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.txtpuesto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtisss);
            this.Controls.Add(this.txtafp);
            this.Controls.Add(this.txtnit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstnivel);
            this.Controls.Add(this.lstsexo);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bactualizar);
            this.Controls.Add(this.bnuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.bbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bentrar);
            this.Controls.Add(this.bmodificar);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MySql";
            this.Text = "MySql";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button bentrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bbuscar;
        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.ComboBox lstsexo;
        private System.Windows.Forms.ComboBox lstnivel;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.TextBox txtpuesto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtisss;
        private System.Windows.Forms.TextBox txtafp;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdui;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

