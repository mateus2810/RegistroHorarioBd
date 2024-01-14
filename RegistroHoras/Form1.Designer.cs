namespace RegistroHoras
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
            this.horarioInicio = new System.Windows.Forms.DateTimePicker();
            this.horarioFim = new System.Windows.Forms.DateTimePicker();
            this.Inicio = new System.Windows.Forms.Label();
            this.Fim = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.demandaRealizada = new System.Windows.Forms.Label();
            this.textBoxDemanda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.totalHorasDia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // horarioInicio
            // 
            this.horarioInicio.CustomFormat = "dd-MM-yyyy HH:mm";
            this.horarioInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horarioInicio.Location = new System.Drawing.Point(162, 78);
            this.horarioInicio.Name = "horarioInicio";
            this.horarioInicio.Size = new System.Drawing.Size(200, 23);
            this.horarioInicio.TabIndex = 0;
            this.horarioInicio.Value = new System.DateTime(2023, 12, 28, 11, 17, 39, 0);
            // 
            // horarioFim
            // 
            this.horarioFim.CustomFormat = "dd-MM-yyyy HH:mm";
            this.horarioFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horarioFim.Location = new System.Drawing.Point(162, 104);
            this.horarioFim.Name = "horarioFim";
            this.horarioFim.Size = new System.Drawing.Size(200, 23);
            this.horarioFim.TabIndex = 1;
            this.horarioFim.Value = new System.DateTime(2023, 12, 28, 11, 17, 46, 0);
            // 
            // Inicio
            // 
            this.Inicio.AutoSize = true;
            this.Inicio.Location = new System.Drawing.Point(108, 82);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(36, 15);
            this.Inicio.TabIndex = 2;
            this.Inicio.Text = "Inicio";
            // 
            // Fim
            // 
            this.Fim.AutoSize = true;
            this.Fim.Location = new System.Drawing.Point(119, 108);
            this.Fim.Name = "Fim";
            this.Fim.Size = new System.Drawing.Size(27, 15);
            this.Fim.TabIndex = 3;
            this.Fim.Text = "Fim";
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(286, 148);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 4;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // demandaRealizada
            // 
            this.demandaRealizada.AutoSize = true;
            this.demandaRealizada.Location = new System.Drawing.Point(23, 49);
            this.demandaRealizada.Name = "demandaRealizada";
            this.demandaRealizada.Size = new System.Drawing.Size(110, 15);
            this.demandaRealizada.TabIndex = 5;
            this.demandaRealizada.Text = "Demanda Realizada";
            // 
            // textBoxDemanda
            // 
            this.textBoxDemanda.Location = new System.Drawing.Point(162, 44);
            this.textBoxDemanda.Name = "textBoxDemanda";
            this.textBoxDemanda.Size = new System.Drawing.Size(200, 23);
            this.textBoxDemanda.TabIndex = 6;
            this.textBoxDemanda.Text = "\r\n--";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.TotalHoras});
            this.dataGridView1.Location = new System.Drawing.Point(23, 208);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(692, 191);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Demanda Realizada";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Horario Inicio";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Horario Fim";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 170;
            // 
            // TotalHoras
            // 
            this.TotalHoras.HeaderText = "Total de Horas";
            this.TotalHoras.MinimumWidth = 6;
            this.TotalHoras.Name = "TotalHoras";
            this.TotalHoras.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total horas dia:";
            // 
            // totalHorasDia
            // 
            this.totalHorasDia.AutoSize = true;
            this.totalHorasDia.Location = new System.Drawing.Point(831, 208);
            this.totalHorasDia.Name = "totalHorasDia";
            this.totalHorasDia.Size = new System.Drawing.Size(17, 15);
            this.totalHorasDia.TabIndex = 9;
            this.totalHorasDia.Text = "--";
            this.totalHorasDia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.totalHorasDia.Click += new System.EventHandler(this.totalHorasDia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.totalHorasDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxDemanda);
            this.Controls.Add(this.demandaRealizada);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Fim);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.horarioFim);
            this.Controls.Add(this.horarioInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker horarioInicio;
        private DateTimePicker horarioFim;
        private Label Inicio;
        private Label Fim;
        private Button Salvar;
        private Label demandaRealizada;
        private TextBox textBoxDemanda;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn TotalHoras;
        private Label label1;
        private Label totalHorasDia;
    }
}