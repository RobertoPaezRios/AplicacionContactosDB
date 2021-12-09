
namespace aplicacionContactosDB
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.DataGridViewAficiones = new System.Windows.Forms.DataGridView();
            this.BorrarAficion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditarAficion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnActualizarAficion = new System.Windows.Forms.Button();
            this.btnRefrescarAficion = new System.Windows.Forms.Button();
            this.btnInsertarAficion = new System.Windows.Forms.Button();
            this.txtNombreAficion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAficiones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 341);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(588, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(69, 384);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(588, 20);
            this.txtTelefono.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Location = new System.Drawing.Point(12, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "INSERT";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Blue;
            this.btnRefrescar.Location = new System.Drawing.Point(99, 315);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(82, 23);
            this.btnRefrescar.TabIndex = 14;
            this.btnRefrescar.Text = "REFRESH";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrar,
            this.Editar,
            this.Ver});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 294);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // borrar
            // 
            this.borrar.HeaderText = "Borrar";
            this.borrar.Name = "borrar";
            this.borrar.ReadOnly = true;
            this.borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.borrar.Text = "Borrar";
            this.borrar.UseColumnTextForButtonValue = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Text = "Ver";
            this.Ver.ToolTipText = "Ver";
            this.Ver.UseColumnTextForButtonValue = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Orange;
            this.btnActualizar.Location = new System.Drawing.Point(187, 315);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 23);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "UPDATE";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.Location = new System.Drawing.Point(275, 315);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(81, 23);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "DELETE";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // DataGridViewAficiones
            // 
            this.DataGridViewAficiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAficiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BorrarAficion,
            this.EditarAficion});
            this.DataGridViewAficiones.Location = new System.Drawing.Point(12, 421);
            this.DataGridViewAficiones.Name = "DataGridViewAficiones";
            this.DataGridViewAficiones.Size = new System.Drawing.Size(645, 311);
            this.DataGridViewAficiones.TabIndex = 23;
            this.DataGridViewAficiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAficiones_CellContentClick_1);
            // 
            // BorrarAficion
            // 
            this.BorrarAficion.HeaderText = "Borrar";
            this.BorrarAficion.Name = "BorrarAficion";
            this.BorrarAficion.Text = "Borrar";
            this.BorrarAficion.ToolTipText = "Borrar";
            this.BorrarAficion.UseColumnTextForButtonValue = true;
            // 
            // EditarAficion
            // 
            this.EditarAficion.HeaderText = "Editar";
            this.EditarAficion.Name = "EditarAficion";
            this.EditarAficion.Text = "Editar";
            this.EditarAficion.ToolTipText = "Editar";
            this.EditarAficion.UseColumnTextForButtonValue = true;
            // 
            // btnActualizarAficion
            // 
            this.btnActualizarAficion.BackColor = System.Drawing.Color.Orange;
            this.btnActualizarAficion.Location = new System.Drawing.Point(187, 738);
            this.btnActualizarAficion.Name = "btnActualizarAficion";
            this.btnActualizarAficion.Size = new System.Drawing.Size(82, 23);
            this.btnActualizarAficion.TabIndex = 26;
            this.btnActualizarAficion.Text = "UPDATE";
            this.btnActualizarAficion.UseVisualStyleBackColor = false;
            this.btnActualizarAficion.Click += new System.EventHandler(this.btnActualizarAficion_Click);
            // 
            // btnRefrescarAficion
            // 
            this.btnRefrescarAficion.BackColor = System.Drawing.Color.Blue;
            this.btnRefrescarAficion.Location = new System.Drawing.Point(99, 738);
            this.btnRefrescarAficion.Name = "btnRefrescarAficion";
            this.btnRefrescarAficion.Size = new System.Drawing.Size(82, 23);
            this.btnRefrescarAficion.TabIndex = 25;
            this.btnRefrescarAficion.Text = "REFRESH";
            this.btnRefrescarAficion.UseVisualStyleBackColor = false;
            this.btnRefrescarAficion.Click += new System.EventHandler(this.btnRefrescarAficion_Click);
            // 
            // btnInsertarAficion
            // 
            this.btnInsertarAficion.BackColor = System.Drawing.Color.LightGreen;
            this.btnInsertarAficion.Location = new System.Drawing.Point(12, 738);
            this.btnInsertarAficion.Name = "btnInsertarAficion";
            this.btnInsertarAficion.Size = new System.Drawing.Size(81, 23);
            this.btnInsertarAficion.TabIndex = 24;
            this.btnInsertarAficion.Text = "INSERT";
            this.btnInsertarAficion.UseVisualStyleBackColor = false;
            this.btnInsertarAficion.Click += new System.EventHandler(this.btnInsertarAficion_Click);
            // 
            // txtNombreAficion
            // 
            this.txtNombreAficion.Location = new System.Drawing.Point(69, 779);
            this.txtNombreAficion.Name = "txtNombreAficion";
            this.txtNombreAficion.Size = new System.Drawing.Size(588, 20);
            this.txtNombreAficion.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 782);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Afición:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 815);
            this.Controls.Add(this.txtNombreAficion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnActualizarAficion);
            this.Controls.Add(this.btnRefrescarAficion);
            this.Controls.Add(this.btnInsertarAficion);
            this.Controls.Add(this.DataGridViewAficiones);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAficiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridView DataGridViewAficiones;
        private System.Windows.Forms.DataGridViewButtonColumn BorrarAficion;
        private System.Windows.Forms.DataGridViewButtonColumn EditarAficion;
        private System.Windows.Forms.Button btnActualizarAficion;
        private System.Windows.Forms.Button btnRefrescarAficion;
        private System.Windows.Forms.Button btnInsertarAficion;
        private System.Windows.Forms.TextBox txtNombreAficion;
        private System.Windows.Forms.Label label3;
    }
}

