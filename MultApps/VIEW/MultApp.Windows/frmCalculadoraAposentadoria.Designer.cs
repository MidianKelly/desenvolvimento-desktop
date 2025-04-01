namespace MultApp.Windows
{
    partial class frmCalculadoraAposentadoria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContribuiçao = new System.Windows.Forms.TextBox();
            this.lblTempoContribuicao = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.btnAposentadoria = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtContribuiçao);
            this.panel1.Controls.Add(this.lblTempoContribuicao);
            this.panel1.Controls.Add(this.cmbGenero);
            this.panel1.Controls.Add(this.lblGenero);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblDataNascimento);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 406);
            this.panel1.TabIndex = 0;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.Location = new System.Drawing.Point(49, 285);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(29, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Veja se você tem direito a aposentadoria ";
            // 
            // txtContribuiçao
            // 
            this.txtContribuiçao.Location = new System.Drawing.Point(26, 248);
            this.txtContribuiçao.Multiline = true;
            this.txtContribuiçao.Name = "txtContribuiçao";
            this.txtContribuiçao.Size = new System.Drawing.Size(162, 21);
            this.txtContribuiçao.TabIndex = 5;
            // 
            // lblTempoContribuicao
            // 
            this.lblTempoContribuicao.AutoSize = true;
            this.lblTempoContribuicao.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoContribuicao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTempoContribuicao.Location = new System.Drawing.Point(22, 226);
            this.lblTempoContribuicao.Name = "lblTempoContribuicao";
            this.lblTempoContribuicao.Size = new System.Drawing.Size(169, 19);
            this.lblTempoContribuicao.TabIndex = 4;
            this.lblTempoContribuicao.Text = "Tempo de Contribuição:\r\n";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(26, 166);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 3;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGenero.Location = new System.Drawing.Point(22, 144);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(128, 19);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Gênero Biológico:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDataNascimento.Location = new System.Drawing.Point(22, 69);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(148, 19);
            this.lblDataNascimento.TabIndex = 0;
            this.lblDataNascimento.Text = "Data de Nascimento:\r\n";
            // 
            // btnAposentadoria
            // 
            this.btnAposentadoria.BackColor = System.Drawing.Color.Linen;
            this.btnAposentadoria.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAposentadoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAposentadoria.Location = new System.Drawing.Point(315, 382);
            this.btnAposentadoria.Name = "btnAposentadoria";
            this.btnAposentadoria.Size = new System.Drawing.Size(145, 56);
            this.btnAposentadoria.TabIndex = 7;
            this.btnAposentadoria.Text = "Clique Aqui!!";
            this.btnAposentadoria.UseVisualStyleBackColor = false;
            this.btnAposentadoria.Click += new System.EventHandler(this.btnAposentadoria_Click);
            // 
            // frmCalculadoraAposentadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAposentadoria);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmCalculadoraAposentadoria";
            this.Text = "calculadora_de_imc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtContribuiçao;
        private System.Windows.Forms.Label lblTempoContribuicao;
        private System.Windows.Forms.Button btnAposentadoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
    }
}