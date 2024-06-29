namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabGeneral = new TabControl();
            tabPage1 = new TabPage();
            txtBuscar = new TextBox();
            lblTotal = new Label();
            dgvEmpleado = new DataGridView();
            Seleccionar = new DataGridViewCheckBoxColumn();
            tabPage2 = new TabPage();
            btnBuscar = new Button();
            TabGeneral.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).BeginInit();
            SuspendLayout();
            // 
            // TabGeneral
            // 
            TabGeneral.Controls.Add(tabPage1);
            TabGeneral.Controls.Add(tabPage2);
            TabGeneral.Location = new Point(10, 8);
            TabGeneral.Name = "TabGeneral";
            TabGeneral.SelectedIndex = 0;
            TabGeneral.Size = new Size(787, 458);
            TabGeneral.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(txtBuscar);
            tabPage1.Controls.Add(lblTotal);
            tabPage1.Controls.Add(dgvEmpleado);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(779, 430);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listado";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(24, 42);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(414, 23);
            txtBuscar.TabIndex = 2;
            txtBuscar.Text = "Ingrese datos";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(636, 395);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total: ";
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.AllowUserToAddRows = false;
            dgvEmpleado.AllowUserToDeleteRows = false;
            dgvEmpleado.AllowUserToOrderColumns = true;
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado.Columns.AddRange(new DataGridViewColumn[] { Seleccionar });
            dgvEmpleado.Location = new Point(24, 96);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.ReadOnly = true;
            dgvEmpleado.RowTemplate.Height = 25;
            dgvEmpleado.Size = new Size(727, 280);
            dgvEmpleado.TabIndex = 0;
            // 
            // Seleccionar
            // 
            Seleccionar.HeaderText = "Seleccionar";
            Seleccionar.Name = "Seleccionar";
            Seleccionar.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(779, 430);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mantenimiento";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(455, 42);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(162, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 478);
            Controls.Add(TabGeneral);
            Name = "Form1";
            Text = "Datos  para el registro de los Empleados";
            Load += Form1_Load;
            TabGeneral.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabGeneral;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblTotal;
        private DataGridView dgvEmpleado;
        private TextBox txtBuscar;
        private DataGridViewCheckBoxColumn Seleccionar;
        private Button btnBuscar;
    }
}