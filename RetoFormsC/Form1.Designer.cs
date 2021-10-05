
namespace RetoFormsC
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
            this.Datos = new System.Windows.Forms.GroupBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBucarAutor = new System.Windows.Forms.TextBox();
            this.txtBuscarTitulo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModific = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.Datos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.txtTitulo);
            this.Datos.Controls.Add(this.txtAutor);
            this.Datos.Controls.Add(this.txtEditorial);
            this.Datos.Controls.Add(this.txtPrecio);
            this.Datos.Controls.Add(this.txtCantidad);
            this.Datos.Controls.Add(this.txtCodigo);
            this.Datos.Controls.Add(this.label6);
            this.Datos.Controls.Add(this.label5);
            this.Datos.Controls.Add(this.label4);
            this.Datos.Controls.Add(this.label3);
            this.Datos.Controls.Add(this.label2);
            this.Datos.Controls.Add(this.label1);
            this.Datos.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(12, 12);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(364, 256);
            this.Datos.TabIndex = 0;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(124, 67);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(209, 31);
            this.txtTitulo.TabIndex = 12;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(124, 104);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(209, 31);
            this.txtAutor.TabIndex = 11;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.Location = new System.Drawing.Point(124, 141);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(209, 31);
            this.txtEditorial.TabIndex = 10;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(124, 178);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(209, 31);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(124, 215);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(209, 31);
            this.txtCantidad.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(124, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(209, 31);
            this.txtCodigo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Título:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Editorial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBucarAutor);
            this.groupBox1.Controls.Add(this.txtBuscarTitulo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtBucarAutor
            // 
            this.txtBucarAutor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBucarAutor.Location = new System.Drawing.Point(113, 70);
            this.txtBucarAutor.Name = "txtBucarAutor";
            this.txtBucarAutor.Size = new System.Drawing.Size(209, 31);
            this.txtBucarAutor.TabIndex = 15;
            this.txtBucarAutor.TextChanged += new System.EventHandler(this.txtBucarAutor_TextChanged);
            // 
            // txtBuscarTitulo
            // 
            this.txtBuscarTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarTitulo.Location = new System.Drawing.Point(113, 33);
            this.txtBuscarTitulo.Name = "txtBuscarTitulo";
            this.txtBuscarTitulo.Size = new System.Drawing.Size(209, 31);
            this.txtBuscarTitulo.TabIndex = 13;
            this.txtBuscarTitulo.TextChanged += new System.EventHandler(this.txtBuscarTitulo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Autor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Título:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(383, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 426);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(602, 398);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 275);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(301, 275);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModific
            // 
            this.btnModific.Location = new System.Drawing.Point(203, 275);
            this.btnModific.Name = "btnModific";
            this.btnModific.Size = new System.Drawing.Size(75, 23);
            this.btnModific.TabIndex = 5;
            this.btnModific.Text = "Modificar";
            this.btnModific.UseVisualStyleBackColor = true;
            this.btnModific.Click += new System.EventHandler(this.btnModific_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(105, 274);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnModific);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Datos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBucarAutor;
        private System.Windows.Forms.TextBox txtBuscarTitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModific;
        private System.Windows.Forms.Button btnRegistrar;
    }
}

