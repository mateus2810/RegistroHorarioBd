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
            this.SuspendLayout();
            // 
            // horarioInicio
            // 
            this.horarioInicio.CustomFormat = "dd-MM-yyyy HH:mm";
            this.horarioInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horarioInicio.Location = new System.Drawing.Point(321, 180);
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
            this.horarioFim.Location = new System.Drawing.Point(321, 240);
            this.horarioFim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.horarioFim.Name = "horarioFim";
            this.horarioFim.Size = new System.Drawing.Size(228, 27);
            this.horarioFim.TabIndex = 1;
            this.horarioFim.Value = new System.DateTime(2023, 12, 28, 11, 17, 46, 0);
            // 
            // Inicio
            // 
            this.Inicio.AutoSize = true;
            this.Inicio.Location = new System.Drawing.Point(233, 180);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(45, 20);
            this.Inicio.TabIndex = 2;
            this.Inicio.Text = "Inicio";
            // 
            // Fim
            // 
            this.Fim.AutoSize = true;
            this.Fim.Location = new System.Drawing.Point(243, 248);
            this.Fim.Name = "Fim";
            this.Fim.Size = new System.Drawing.Size(33, 20);
            this.Fim.TabIndex = 3;
            this.Fim.Text = "Fim";
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(509, 355);
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
            this.demandaRealizada.Location = new System.Drawing.Point(149, 108);
            this.demandaRealizada.Name = "demandaRealizada";
            this.demandaRealizada.Size = new System.Drawing.Size(143, 20);
            this.demandaRealizada.TabIndex = 5;
            this.demandaRealizada.Text = "Demanda Realizada";
            // 
            // textBoxDemanda
            // 
            this.textBoxDemanda.Location = new System.Drawing.Point(321, 104);
            this.textBoxDemanda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDemanda.Name = "textBoxDemanda";
            this.textBoxDemanda.Size = new System.Drawing.Size(185, 27);
            this.textBoxDemanda.TabIndex = 6;
            this.textBoxDemanda.Text = "\r\n--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
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
    }
}