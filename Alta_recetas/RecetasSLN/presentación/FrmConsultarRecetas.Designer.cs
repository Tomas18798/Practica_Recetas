﻿
namespace RecetasSLN.presentación
{
    partial class FrmConsultarRecetas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoReceta = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cboIngredientes = new System.Windows.Forms.ComboBox();
            this.cantidadIngrediente = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarIngrediente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadIngrediente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboTipoReceta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(390, 53);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(279, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de receta:";
            // 
            // cboTipoReceta
            // 
            this.cboTipoReceta.FormattingEnabled = true;
            this.cboTipoReceta.Items.AddRange(new object[] {
            "1 - Comida china",
            "2 - Comimda arabe ",
            "3 - la que come la señora de polioto"});
            this.cboTipoReceta.Location = new System.Drawing.Point(104, 24);
            this.cboTipoReceta.Name = "cboTipoReceta";
            this.cboTipoReceta.Size = new System.Drawing.Size(176, 21);
            this.cboTipoReceta.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.grilla);
            this.groupBox2.Location = new System.Drawing.Point(13, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(372, 205);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total de recetas:";
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colTipo,
            this.colCheff,
            this.colBorrar});
            this.grilla.Location = new System.Drawing.Point(21, 19);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.Size = new System.Drawing.Size(479, 165);
            this.grilla.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(426, 388);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 388);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nueva Receta";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // cboIngredientes
            // 
            this.cboIngredientes.FormattingEnabled = true;
            this.cboIngredientes.Location = new System.Drawing.Point(34, 112);
            this.cboIngredientes.Name = "cboIngredientes";
            this.cboIngredientes.Size = new System.Drawing.Size(185, 21);
            this.cboIngredientes.TabIndex = 7;
            // 
            // cantidadIngrediente
            // 
            this.cantidadIngrediente.Location = new System.Drawing.Point(225, 112);
            this.cantidadIngrediente.Name = "cantidadIngrediente";
            this.cantidadIngrediente.Size = new System.Drawing.Size(170, 20);
            this.cantidadIngrediente.TabIndex = 8;
            // 
            // btnAgregarIngrediente
            // 
            this.btnAgregarIngrediente.Location = new System.Drawing.Point(402, 109);
            this.btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            this.btnAgregarIngrediente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarIngrediente.TabIndex = 9;
            this.btnAgregarIngrediente.Text = "button1";
            this.btnAgregarIngrediente.UseVisualStyleBackColor = true;
            this.btnAgregarIngrediente.Click += new System.EventHandler(this.btnAgregarIngrediente_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(390, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "cheffd";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Ingrediente";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Cantidad";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colCheff
            // 
            this.colCheff.HeaderText = "Acciones";
            this.colCheff.Name = "colCheff";
            this.colCheff.ReadOnly = true;
            // 
            // colBorrar
            // 
            this.colBorrar.HeaderText = "";
            this.colBorrar.Name = "colBorrar";
            this.colBorrar.ReadOnly = true;
            this.colBorrar.Text = "Eliminar";
            this.colBorrar.UseColumnTextForButtonValue = true;
            // 
            // FrmConsultarRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 415);
            this.Controls.Add(this.btnAgregarIngrediente);
            this.Controls.Add(this.cantidadIngrediente);
            this.Controls.Add(this.cboIngredientes);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultarRecetas";
            this.Text = "Consultar recetas";
            this.Load += new System.EventHandler(this.FrmConsultarRecetas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadIngrediente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoReceta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cboIngredientes;
        private System.Windows.Forms.NumericUpDown cantidadIngrediente;
        private System.Windows.Forms.Button btnAgregarIngrediente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheff;
        private System.Windows.Forms.DataGridViewButtonColumn colBorrar;
    }
}