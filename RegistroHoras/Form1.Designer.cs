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
            this.label1 = new System.Windows.Forms.Label();
            this.totalHorasDiaLabel = new System.Windows.Forms.Label();
            this.dataListagemDatePicker = new System.Windows.Forms.DateTimePicker();
            this.listarButton = new System.Windows.Forms.Button();
            this.DeletarButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFimTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // horarioInicio
            // 
            this.horarioInicio.CustomFormat = "dd-MM-yyyy HH:mm";
            this.horarioInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horarioInicio.Location = new System.Drawing.Point(185, 104);
            this.horarioInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.horarioInicio.Name = "horarioInicio";
            this.horarioInicio.Size = new System.Drawing.Size(228, 27);
            this.horarioInicio.TabIndex = 0;
            this.horarioInicio.Value = new System.DateTime(2023, 12, 28, 11, 17, 39, 0);
            // 
            // horarioFim
            // 
            this.horarioFim.CustomFormat = "dd-MM-yyyy HH:mm";
            this.horarioFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horarioFim.Location = new System.Drawing.Point(185, 139);
            this.horarioFim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.horarioFim.Name = "horarioFim";
            this.horarioFim.Size = new System.Drawing.Size(228, 27);
            this.horarioFim.TabIndex = 1;
            this.horarioFim.Value = new System.DateTime(2023, 12, 28, 11, 17, 46, 0);
            // 
            // Inicio
            // 
            this.Inicio.AutoSize = true;
            this.Inicio.Location = new System.Drawing.Point(123, 109);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(45, 20);
            this.Inicio.TabIndex = 2;
            this.Inicio.Text = "Inicio";
            // 
            // Fim
            // 
            this.Fim.AutoSize = true;
            this.Fim.Location = new System.Drawing.Point(136, 144);
            this.Fim.Name = "Fim";
            this.Fim.Size = new System.Drawing.Size(33, 20);
            this.Fim.TabIndex = 3;
            this.Fim.Text = "Fim";
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(327, 197);
            this.Salvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(86, 31);
            this.Salvar.TabIndex = 4;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // demandaRealizada
            // 
            this.demandaRealizada.AutoSize = true;
            this.demandaRealizada.Location = new System.Drawing.Point(26, 65);
            this.demandaRealizada.Name = "demandaRealizada";
            this.demandaRealizada.Size = new System.Drawing.Size(143, 20);
            this.demandaRealizada.TabIndex = 5;
            this.demandaRealizada.Text = "Demanda Realizada";
            // 
            // textBoxDemanda
            // 
            this.textBoxDemanda.Location = new System.Drawing.Point(185, 59);
            this.textBoxDemanda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDemanda.Name = "textBoxDemanda";
            this.textBoxDemanda.Size = new System.Drawing.Size(228, 27);
            this.textBoxDemanda.TabIndex = 6;
            this.textBoxDemanda.Text = "\r\n--";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.horaInicioTextBoxColumn,
            this.horaFimTextBoxColumn,
            this.TotalHoras});
            this.dataGridView1.Location = new System.Drawing.Point(26, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(791, 255);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(824, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total horas dia:";
            // 
            // totalHorasDiaLabel
            // 
            this.totalHorasDiaLabel.AutoSize = true;
            this.totalHorasDiaLabel.Location = new System.Drawing.Point(949, 319);
            this.totalHorasDiaLabel.Name = "totalHorasDiaLabel";
            this.totalHorasDiaLabel.Size = new System.Drawing.Size(21, 20);
            this.totalHorasDiaLabel.TabIndex = 9;
            this.totalHorasDiaLabel.Text = "--";
            this.totalHorasDiaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.totalHorasDiaLabel.Click += new System.EventHandler(this.totalHorasDia_Click);
            // 
            // dataListagemDatePicker
            // 
            this.dataListagemDatePicker.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dataListagemDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataListagemDatePicker.Location = new System.Drawing.Point(26, 264);
            this.dataListagemDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataListagemDatePicker.Name = "dataListagemDatePicker";
            this.dataListagemDatePicker.Size = new System.Drawing.Size(228, 27);
            this.dataListagemDatePicker.TabIndex = 10;
            // 
            // listarButton
            // 
            this.listarButton.Location = new System.Drawing.Point(294, 264);
            this.listarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(86, 31);
            this.listarButton.TabIndex = 11;
            this.listarButton.Text = "Listar";
            this.listarButton.UseVisualStyleBackColor = true;
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // DeletarButton
            // 
            this.DeletarButton.Location = new System.Drawing.Point(854, 166);
            this.DeletarButton.Name = "DeletarButton";
            this.DeletarButton.Size = new System.Drawing.Size(94, 29);
            this.DeletarButton.TabIndex = 12;
            this.DeletarButton.Text = "Deletar";
            this.DeletarButton.UseVisualStyleBackColor = true;
            this.DeletarButton.Click += new System.EventHandler(this.DeletarButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Demanda Realizada";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // horaInicioTextBoxColumn
            // 
            this.horaInicioTextBoxColumn.HeaderText = "Horario Inicio";
            this.horaInicioTextBoxColumn.MinimumWidth = 6;
            this.horaInicioTextBoxColumn.Name = "horaInicioTextBoxColumn";
            this.horaInicioTextBoxColumn.Width = 170;
            // 
            // horaFimTextBoxColumn
            // 
            this.horaFimTextBoxColumn.HeaderText = "Horario Fim";
            this.horaFimTextBoxColumn.MinimumWidth = 6;
            this.horaFimTextBoxColumn.Name = "horaFimTextBoxColumn";
            this.horaFimTextBoxColumn.Width = 170;
            // 
            // TotalHoras
            // 
            this.TotalHoras.HeaderText = "Total de Horas";
            this.TotalHoras.MinimumWidth = 6;
            this.TotalHoras.Name = "TotalHoras";
            this.TotalHoras.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 600);
            this.Controls.Add(this.DeletarButton);
            this.Controls.Add(this.listarButton);
            this.Controls.Add(this.dataListagemDatePicker);
            this.Controls.Add(this.totalHorasDiaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxDemanda);
            this.Controls.Add(this.demandaRealizada);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Fim);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.horarioFim);
            this.Controls.Add(this.horarioInicio);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private Label label1;
        private Label totalHorasDiaLabel;
        private DateTimePicker dataListagemDatePicker;
        private Button listarButton;
        private Button DeletarButton;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn horaInicioTextBoxColumn;
        private DataGridViewTextBoxColumn horaFimTextBoxColumn;
        private DataGridViewTextBoxColumn TotalHoras;
    }
}