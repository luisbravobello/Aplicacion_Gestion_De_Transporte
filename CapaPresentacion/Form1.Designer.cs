namespace CapaPresentacion
{
    partial class vtnVentana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vtnVentana));
            btnConsultar = new Button();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            cmb = new ComboBox();
            txtDestinoRutaFin = new TextBox();
            txtLugarRutaInicio = new TextBox();
            dtpHoraFin = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            txtCapacidad = new TextBox();
            txtRuta = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblCpacidad = new Label();
            lblRuta = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(715, 594);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(913, 594);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(1090, 594);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1265, 594);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(468, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1033, 523);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(cmb);
            groupBox1.Controls.Add(txtDestinoRutaFin);
            groupBox1.Controls.Add(txtLugarRutaInicio);
            groupBox1.Controls.Add(dtpHoraFin);
            groupBox1.Controls.Add(dtpHoraInicio);
            groupBox1.Controls.Add(txtCapacidad);
            groupBox1.Controls.Add(txtRuta);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblCpacidad);
            groupBox1.Controls.Add(lblRuta);
            groupBox1.Location = new Point(12, 294);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 356);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos: ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmb
            // 
            cmb.FormattingEnabled = true;
            cmb.Location = new Point(120, 124);
            cmb.Name = "cmb";
            cmb.Size = new Size(121, 23);
            cmb.TabIndex = 10;
            // 
            // txtDestinoRutaFin
            // 
            txtDestinoRutaFin.Location = new Point(120, 296);
            txtDestinoRutaFin.Name = "txtDestinoRutaFin";
            txtDestinoRutaFin.Size = new Size(100, 23);
            txtDestinoRutaFin.TabIndex = 9;
            // 
            // txtLugarRutaInicio
            // 
            txtLugarRutaInicio.Location = new Point(120, 216);
            txtLugarRutaInicio.Name = "txtLugarRutaInicio";
            txtLugarRutaInicio.Size = new Size(100, 23);
            txtLugarRutaInicio.TabIndex = 9;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.Location = new Point(120, 255);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.Size = new Size(215, 23);
            dtpHoraFin.TabIndex = 9;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.Location = new Point(120, 172);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.Size = new Size(215, 23);
            dtpHoraInicio.TabIndex = 9;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(120, 83);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(100, 23);
            txtCapacidad.TabIndex = 9;
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(120, 44);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(100, 23);
            txtRuta.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 304);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 9;
            label8.Text = "Lugar Ruta Fin: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 261);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 9;
            label7.Text = "Hora Destino Fin: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 219);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 9;
            label6.Text = "Lugar Ruta Inicio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 178);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 9;
            label5.Text = "Hora de Ruta Inicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 127);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 9;
            label4.Text = "Tipo De Transporte: ";
            // 
            // lblCpacidad
            // 
            lblCpacidad.AutoSize = true;
            lblCpacidad.Location = new Point(6, 91);
            lblCpacidad.Name = "lblCpacidad";
            lblCpacidad.Size = new Size(66, 15);
            lblCpacidad.TabIndex = 9;
            lblCpacidad.Text = "Capacidad:";
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Location = new Point(6, 47);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(97, 15);
            lblRuta.TabIndex = 9;
            lblRuta.Text = "Numero de Ruta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 47);
            label1.Name = "label1";
            label1.Size = new Size(320, 26);
            label1.TabIndex = 7;
            label1.Text = "Gestion De Transporte Lucho ";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = Properties.Resources.LogoTransporte;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(107, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 169);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // vtnVentana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1513, 793);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(btnConsultar);
            Name = "vtnVentana";
            Text = "Gestion De Transporte";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultar;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblCpacidad;
        private Label lblRuta;
        private DateTimePicker dtpHoraInicio;
        private TextBox txtCapacidad;
        private TextBox txtRuta;
        private TextBox txtDestinoRutaFin;
        private TextBox txtLugarRutaInicio;
        private DateTimePicker dtpHoraFin;
        private ComboBox cmb;
    }
}
