namespace Aula_Express_2._0
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btnmostrar = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.Btnborrar = new System.Windows.Forms.Button();
            this.Btnguardar = new System.Windows.Forms.Button();
            this.groupBoxDatCurs = new System.Windows.Forms.GroupBox();
            this.textDescricion = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrarsecion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textObjetivo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textImparte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxDatCurs.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(683, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(306, 246);
            this.dataGridView1.TabIndex = 25;
            // 
            // Btnmostrar
            // 
            this.Btnmostrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnmostrar.Location = new System.Drawing.Point(531, 397);
            this.Btnmostrar.Name = "Btnmostrar";
            this.Btnmostrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btnmostrar.Size = new System.Drawing.Size(79, 23);
            this.Btnmostrar.TabIndex = 24;
            this.Btnmostrar.Text = "Mostrar";
            this.Btnmostrar.UseVisualStyleBackColor = true;
            this.Btnmostrar.Click += new System.EventHandler(this.Btnmostrar_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsalir.Location = new System.Drawing.Point(383, 397);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(79, 23);
            this.Btnsalir.TabIndex = 23;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Btnborrar
            // 
            this.Btnborrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnborrar.Location = new System.Drawing.Point(256, 397);
            this.Btnborrar.Name = "Btnborrar";
            this.Btnborrar.Size = new System.Drawing.Size(79, 23);
            this.Btnborrar.TabIndex = 22;
            this.Btnborrar.Text = "Borrar";
            this.Btnborrar.UseVisualStyleBackColor = true;
            this.Btnborrar.Click += new System.EventHandler(this.Btnborrar_Click);
            // 
            // Btnguardar
            // 
            this.Btnguardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnguardar.Location = new System.Drawing.Point(140, 397);
            this.Btnguardar.Name = "Btnguardar";
            this.Btnguardar.Size = new System.Drawing.Size(79, 23);
            this.Btnguardar.TabIndex = 21;
            this.Btnguardar.Text = "Guardar";
            this.Btnguardar.UseVisualStyleBackColor = true;
            this.Btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // groupBoxDatCurs
            // 
            this.groupBoxDatCurs.Controls.Add(this.textImparte);
            this.groupBoxDatCurs.Controls.Add(this.label7);
            this.groupBoxDatCurs.Controls.Add(this.textObjetivo);
            this.groupBoxDatCurs.Controls.Add(this.label6);
            this.groupBoxDatCurs.Controls.Add(this.textDescricion);
            this.groupBoxDatCurs.Controls.Add(this.textNombre);
            this.groupBoxDatCurs.Controls.Add(this.textCodigo);
            this.groupBoxDatCurs.Controls.Add(this.label5);
            this.groupBoxDatCurs.Controls.Add(this.label4);
            this.groupBoxDatCurs.Controls.Add(this.label3);
            this.groupBoxDatCurs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatCurs.Location = new System.Drawing.Point(12, 109);
            this.groupBoxDatCurs.Name = "groupBoxDatCurs";
            this.groupBoxDatCurs.Size = new System.Drawing.Size(665, 262);
            this.groupBoxDatCurs.TabIndex = 20;
            this.groupBoxDatCurs.TabStop = false;
            this.groupBoxDatCurs.Text = "Datos Del Curso";
            // 
            // textDescricion
            // 
            this.textDescricion.Location = new System.Drawing.Point(212, 73);
            this.textDescricion.Multiline = true;
            this.textDescricion.Name = "textDescricion";
            this.textDescricion.Size = new System.Drawing.Size(238, 75);
            this.textDescricion.TabIndex = 8;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(12, 197);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(194, 39);
            this.textNombre.TabIndex = 7;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(12, 73);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(194, 39);
            this.textCodigo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "INSTRUCTOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "AULA EXPRESS";
            // 
            // BtnCerrarsecion
            // 
            this.BtnCerrarsecion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarsecion.Location = new System.Drawing.Point(856, 9);
            this.BtnCerrarsecion.Name = "BtnCerrarsecion";
            this.BtnCerrarsecion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCerrarsecion.Size = new System.Drawing.Size(133, 23);
            this.BtnCerrarsecion.TabIndex = 26;
            this.BtnCerrarsecion.Text = "Cerrar Sesion";
            this.BtnCerrarsecion.UseVisualStyleBackColor = true;
            this.BtnCerrarsecion.Click += new System.EventHandler(this.BtnCerrarsecion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Objetivo";
            // 
            // textObjetivo
            // 
            this.textObjetivo.Location = new System.Drawing.Point(212, 197);
            this.textObjetivo.Multiline = true;
            this.textObjetivo.Name = "textObjetivo";
            this.textObjetivo.Size = new System.Drawing.Size(434, 39);
            this.textObjetivo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Imparte";
            // 
            // textImparte
            // 
            this.textImparte.Location = new System.Drawing.Point(465, 73);
            this.textImparte.Multiline = true;
            this.textImparte.Name = "textImparte";
            this.textImparte.Size = new System.Drawing.Size(194, 39);
            this.textImparte.TabIndex = 13;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.BtnCerrarsecion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btnmostrar);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btnborrar);
            this.Controls.Add(this.Btnguardar);
            this.Controls.Add(this.groupBoxDatCurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "ViewCurso";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxDatCurs.ResumeLayout(false);
            this.groupBoxDatCurs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btnmostrar;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Button Btnborrar;
        private System.Windows.Forms.Button Btnguardar;
        private System.Windows.Forms.GroupBox groupBoxDatCurs;
        private System.Windows.Forms.TextBox textDescricion;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCerrarsecion;
        private System.Windows.Forms.TextBox textImparte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textObjetivo;
        private System.Windows.Forms.Label label6;
    }
}