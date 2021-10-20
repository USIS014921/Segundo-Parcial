
namespace Segundo_Parcial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.bprimero = new System.Windows.Forms.Button();
            this.banterior = new System.Windows.Forms.Button();
            this.bsiguiente = new System.Windows.Forms.Button();
            this.bultimo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.lstsexo = new System.Windows.Forms.ComboBox();
            this.lstnivel = new System.Windows.Forms.ComboBox();
            this.lstedad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Location = new System.Drawing.Point(61, 226);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(80, 30);
            this.bguardar.TabIndex = 1;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // beliminar
            // 
            this.beliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar.Location = new System.Drawing.Point(147, 226);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(80, 30);
            this.beliminar.TabIndex = 2;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bmodificar
            // 
            this.bmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodificar.Location = new System.Drawing.Point(234, 226);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(80, 30);
            this.bmodificar.TabIndex = 3;
            this.bmodificar.Text = "Modificar";
            this.bmodificar.UseVisualStyleBackColor = true;
            this.bmodificar.Click += new System.EventHandler(this.bmodificar_Click);
            // 
            // bentrar
            // 
            this.bentrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bentrar.Location = new System.Drawing.Point(319, 226);
            this.bentrar.Name = "bentrar";
            this.bentrar.Size = new System.Drawing.Size(80, 30);
            this.bentrar.TabIndex = 4;
            this.bentrar.Text = "Entrar";
            this.bentrar.UseVisualStyleBackColor = true;
            this.bentrar.Click += new System.EventHandler(this.bentrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(821, 228);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bbuscar
            // 
            this.bbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbuscar.Location = new System.Drawing.Point(405, 190);
            this.bbuscar.Name = "bbuscar";
            this.bbuscar.Size = new System.Drawing.Size(80, 30);
            this.bbuscar.TabIndex = 6;
            this.bbuscar.Text = "Buscar";
            this.bbuscar.UseVisualStyleBackColor = true;
            this.bbuscar.Click += new System.EventHandler(this.bbuscar_Click);
            // 
            // bsalir
            // 
            this.bsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsalir.Location = new System.Drawing.Point(405, 226);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(80, 30);
            this.bsalir.TabIndex = 7;
            this.bsalir.Text = "Salir";
            this.bsalir.UseVisualStyleBackColor = true;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Clave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nivel:";
            // 
            // bnuevo
            // 
            this.bnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevo.Location = new System.Drawing.Point(61, 226);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(80, 30);
            this.bnuevo.TabIndex = 15;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = true;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // bactualizar
            // 
            this.bactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bactualizar.Location = new System.Drawing.Point(234, 226);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(80, 30);
            this.bactualizar.TabIndex = 17;
            this.bactualizar.Text = "Actualizar";
            this.bactualizar.UseVisualStyleBackColor = true;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // bprimero
            // 
            this.bprimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bprimero.Location = new System.Drawing.Point(61, 190);
            this.bprimero.Name = "bprimero";
            this.bprimero.Size = new System.Drawing.Size(80, 30);
            this.bprimero.TabIndex = 18;
            this.bprimero.Text = "Primero";
            this.bprimero.UseVisualStyleBackColor = true;
            // 
            // banterior
            // 
            this.banterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banterior.Location = new System.Drawing.Point(147, 190);
            this.banterior.Name = "banterior";
            this.banterior.Size = new System.Drawing.Size(80, 30);
            this.banterior.TabIndex = 19;
            this.banterior.Text = "Anterior";
            this.banterior.UseVisualStyleBackColor = true;
            // 
            // bsiguiente
            // 
            this.bsiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiguiente.Location = new System.Drawing.Point(234, 190);
            this.bsiguiente.Name = "bsiguiente";
            this.bsiguiente.Size = new System.Drawing.Size(80, 30);
            this.bsiguiente.TabIndex = 20;
            this.bsiguiente.Text = "Siguiente";
            this.bsiguiente.UseVisualStyleBackColor = true;
            this.bsiguiente.Click += new System.EventHandler(this.bsiguiente_Click);
            // 
            // bultimo
            // 
            this.bultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bultimo.Location = new System.Drawing.Point(319, 190);
            this.bultimo.Name = "bultimo";
            this.bultimo.Size = new System.Drawing.Size(80, 30);
            this.bultimo.TabIndex = 21;
            this.bultimo.Text = "Ultimo";
            this.bultimo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Edad:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(491, 197);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 8;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(361, 5);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 29;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(361, 31);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(100, 20);
            this.txtclave.TabIndex = 30;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(361, 84);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 31;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(361, 110);
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
            this.lstsexo.Location = new System.Drawing.Point(361, 136);
            this.lstsexo.Name = "lstsexo";
            this.lstsexo.Size = new System.Drawing.Size(100, 21);
            this.lstsexo.TabIndex = 33;
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
            this.lstnivel.Location = new System.Drawing.Point(361, 57);
            this.lstnivel.Name = "lstnivel";
            this.lstnivel.Size = new System.Drawing.Size(100, 21);
            this.lstnivel.TabIndex = 34;
            // 
            // lstedad
            // 
            this.lstedad.FormattingEnabled = true;
            this.lstedad.Items.AddRange(new object[] {
            "18\t",
            "19\t",
            "20",
            "21\t",
            "22\t",
            "23\t",
            "24\t",
            "25\t",
            "26\t",
            "27\t",
            "28\t",
            "29\t",
            "30",
            "31\t",
            "32\t",
            "33\t",
            "34\t",
            "35\t",
            "36\t",
            "37\t",
            "38\t",
            "39\t",
            "40",
            "41\t",
            "42\t",
            "43\t",
            "44\t",
            "45\t",
            "46\t",
            "47\t",
            "48\t",
            "49\t",
            "50"});
            this.lstedad.Location = new System.Drawing.Point(361, 163);
            this.lstedad.Name = "lstedad";
            this.lstedad.Size = new System.Drawing.Size(100, 21);
            this.lstedad.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(841, 500);
            this.Controls.Add(this.lstedad);
            this.Controls.Add(this.lstnivel);
            this.Controls.Add(this.lstsexo);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bultimo);
            this.Controls.Add(this.bsiguiente);
            this.Controls.Add(this.banterior);
            this.Controls.Add(this.bprimero);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button bprimero;
        private System.Windows.Forms.Button banterior;
        private System.Windows.Forms.Button bsiguiente;
        private System.Windows.Forms.Button bultimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.ComboBox lstsexo;
        private System.Windows.Forms.ComboBox lstnivel;
        private System.Windows.Forms.ComboBox lstedad;
    }
}

