namespace MultApp.Windows
{
    partial class frmCalculadoraIMC
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
            this.picboxImc = new System.Windows.Forms.PictureBox();
            this.lblResultadoImc = new System.Windows.Forms.Label();
            this.btnCalcule = new System.Windows.Forms.Button();
            this.cmbIdade = new System.Windows.Forms.ComboBox();
            this.lblMenorIdade = new System.Windows.Forms.Label();
            this.lblAlturaKg = new System.Windows.Forms.Label();
            this.lblPesoKg = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblImcAdulto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.chkMasc = new System.Windows.Forms.CheckBox();
            this.chkFem = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkCrianca = new System.Windows.Forms.CheckBox();
            this.chkAdulto = new System.Windows.Forms.CheckBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picboxImc);
            this.panel1.Controls.Add(this.lblResultadoImc);
            this.panel1.Controls.Add(this.btnCalcule);
            this.panel1.Controls.Add(this.cmbIdade);
            this.panel1.Controls.Add(this.lblMenorIdade);
            this.panel1.Controls.Add(this.lblAlturaKg);
            this.panel1.Controls.Add(this.lblPesoKg);
            this.panel1.Controls.Add(this.txtAltura);
            this.panel1.Controls.Add(this.txtPeso);
            this.panel1.Controls.Add(this.lblImcAdulto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblIdade);
            this.panel1.Controls.Add(this.chkMasc);
            this.panel1.Controls.Add(this.chkFem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkCrianca);
            this.panel1.Controls.Add(this.chkAdulto);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // picboxImc
            // 
            this.picboxImc.Location = new System.Drawing.Point(412, 219);
            this.picboxImc.Name = "picboxImc";
            this.picboxImc.Size = new System.Drawing.Size(246, 207);
            this.picboxImc.TabIndex = 21;
            this.picboxImc.TabStop = false;
            // 
            // lblResultadoImc
            // 
            this.lblResultadoImc.AutoSize = true;
            this.lblResultadoImc.Location = new System.Drawing.Point(20, 317);
            this.lblResultadoImc.Name = "lblResultadoImc";
            this.lblResultadoImc.Size = new System.Drawing.Size(16, 13);
            this.lblResultadoImc.TabIndex = 20;
            this.lblResultadoImc.Text = "...";
            // 
            // btnCalcule
            // 
            this.btnCalcule.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCalcule.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcule.ForeColor = System.Drawing.Color.OldLace;
            this.btnCalcule.Location = new System.Drawing.Point(20, 277);
            this.btnCalcule.Name = "btnCalcule";
            this.btnCalcule.Size = new System.Drawing.Size(94, 26);
            this.btnCalcule.TabIndex = 18;
            this.btnCalcule.Text = "Calcule";
            this.btnCalcule.UseVisualStyleBackColor = false;
            this.btnCalcule.Click += new System.EventHandler(this.btnCalcule_Click);
            // 
            // cmbIdade
            // 
            this.cmbIdade.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdade.FormattingEnabled = true;
            this.cmbIdade.Items.AddRange(new object[] {
            "1 ano",
            "2 anos ",
            "3 anos ",
            "4 anos ",
            "5 anos ",
            "6 anos",
            "7 anos",
            "8 anos",
            "9 anos ",
            "10 anos ",
            "11 anos ",
            "12 anos",
            "13 anos",
            "14 anos",
            "15 anos ",
            "16 anos",
            "17 anos ",
            "18 anos "});
            this.cmbIdade.Location = new System.Drawing.Point(285, 236);
            this.cmbIdade.Name = "cmbIdade";
            this.cmbIdade.Size = new System.Drawing.Size(121, 24);
            this.cmbIdade.TabIndex = 17;
            // 
            // lblMenorIdade
            // 
            this.lblMenorIdade.AutoSize = true;
            this.lblMenorIdade.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenorIdade.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMenorIdade.Location = new System.Drawing.Point(282, 214);
            this.lblMenorIdade.Name = "lblMenorIdade";
            this.lblMenorIdade.Size = new System.Drawing.Size(36, 14);
            this.lblMenorIdade.TabIndex = 15;
            this.lblMenorIdade.Text = "Idade";
            // 
            // lblAlturaKg
            // 
            this.lblAlturaKg.AutoSize = true;
            this.lblAlturaKg.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlturaKg.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAlturaKg.Location = new System.Drawing.Point(140, 219);
            this.lblAlturaKg.Name = "lblAlturaKg";
            this.lblAlturaKg.Size = new System.Drawing.Size(61, 14);
            this.lblAlturaKg.TabIndex = 14;
            this.lblAlturaKg.Text = "Altura (M)";
            // 
            // lblPesoKg
            // 
            this.lblPesoKg.AutoSize = true;
            this.lblPesoKg.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoKg.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPesoKg.Location = new System.Drawing.Point(20, 219);
            this.lblPesoKg.Name = "lblPesoKg";
            this.lblPesoKg.Size = new System.Drawing.Size(58, 14);
            this.lblPesoKg.TabIndex = 13;
            this.lblPesoKg.Text = "Peso (KG)";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(143, 236);
            this.txtAltura.Multiline = true;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(124, 24);
            this.txtAltura.TabIndex = 11;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(20, 236);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 24);
            this.txtPeso.TabIndex = 10;
            // 
            // lblImcAdulto
            // 
            this.lblImcAdulto.AutoSize = true;
            this.lblImcAdulto.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImcAdulto.Location = new System.Drawing.Point(18, 191);
            this.lblImcAdulto.Name = "lblImcAdulto";
            this.lblImcAdulto.Size = new System.Drawing.Size(132, 19);
            this.lblImcAdulto.TabIndex = 8;
            this.lblImcAdulto.Text = "IMC para Adulto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Faixa Etária";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdade.Location = new System.Drawing.Point(19, 154);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(103, 16);
            this.lblIdade.TabIndex = 6;
            this.lblIdade.Text = "Acima de 19 anos";
            // 
            // chkMasc
            // 
            this.chkMasc.AutoSize = true;
            this.chkMasc.BackColor = System.Drawing.Color.Transparent;
            this.chkMasc.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMasc.ForeColor = System.Drawing.Color.DimGray;
            this.chkMasc.Location = new System.Drawing.Point(449, 107);
            this.chkMasc.Name = "chkMasc";
            this.chkMasc.Size = new System.Drawing.Size(129, 33);
            this.chkMasc.TabIndex = 5;
            this.chkMasc.Text = "Masculino";
            this.chkMasc.UseVisualStyleBackColor = false;
            this.chkMasc.Click += new System.EventHandler(this.chkMasc_CheckedChanged);
            // 
            // chkFem
            // 
            this.chkFem.AutoSize = true;
            this.chkFem.Checked = true;
            this.chkFem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFem.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFem.ForeColor = System.Drawing.Color.DarkOrange;
            this.chkFem.Location = new System.Drawing.Point(322, 107);
            this.chkFem.Name = "chkFem";
            this.chkFem.Size = new System.Drawing.Size(121, 33);
            this.chkFem.TabIndex = 4;
            this.chkFem.Text = "Feminino";
            this.chkFem.UseVisualStyleBackColor = true;
            this.chkFem.Click += new System.EventHandler(this.chkFem_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(318, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gênero";
            // 
            // chkCrianca
            // 
            this.chkCrianca.AutoSize = true;
            this.chkCrianca.BackColor = System.Drawing.Color.Transparent;
            this.chkCrianca.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrianca.ForeColor = System.Drawing.Color.DimGray;
            this.chkCrianca.Location = new System.Drawing.Point(116, 107);
            this.chkCrianca.Name = "chkCrianca";
            this.chkCrianca.Size = new System.Drawing.Size(103, 33);
            this.chkCrianca.TabIndex = 2;
            this.chkCrianca.Text = "Criança";
            this.chkCrianca.UseVisualStyleBackColor = false;
            this.chkCrianca.Click += new System.EventHandler(this.chkCrianca_CheckedChanged);
            // 
            // chkAdulto
            // 
            this.chkAdulto.AutoSize = true;
            this.chkAdulto.Checked = true;
            this.chkAdulto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdulto.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdulto.ForeColor = System.Drawing.Color.DarkOrange;
            this.chkAdulto.Location = new System.Drawing.Point(20, 107);
            this.chkAdulto.Name = "chkAdulto";
            this.chkAdulto.Size = new System.Drawing.Size(96, 33);
            this.chkAdulto.TabIndex = 1;
            this.chkAdulto.Text = "Adulto";
            this.chkAdulto.UseVisualStyleBackColor = true;
            this.chkAdulto.Click += new System.EventHandler(this.chkAdulto_CheckedChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl1.Location = new System.Drawing.Point(16, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(150, 39);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Selecione";
            // 
            // frmCalculadoraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmCalculadoraIMC";
            this.Text = "frmCalculadoraIMC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAdulto;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.CheckBox chkCrianca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFem;
        private System.Windows.Forms.CheckBox chkMasc;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblImcAdulto;
        private System.Windows.Forms.Label lblAlturaKg;
        private System.Windows.Forms.Label lblPesoKg;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.ComboBox cmbIdade;
        private System.Windows.Forms.Label lblMenorIdade;
        private System.Windows.Forms.Button btnCalcule;
        private System.Windows.Forms.Label lblResultadoImc;
        private System.Windows.Forms.PictureBox picboxImc;
    }
}