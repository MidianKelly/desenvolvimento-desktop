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
            this.lbl1 = new System.Windows.Forms.Label();
            this.chkAdulto = new System.Windows.Forms.CheckBox();
            this.chkCrianca = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFem = new System.Windows.Forms.CheckBox();
            this.chkMasc = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
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
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl1.Location = new System.Drawing.Point(16, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(105, 27);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Selecione";
            // 
            // chkAdulto
            // 
            this.chkAdulto.AutoSize = true;
            this.chkAdulto.Checked = true;
            this.chkAdulto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdulto.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdulto.ForeColor = System.Drawing.Color.DarkOrange;
            this.chkAdulto.Location = new System.Drawing.Point(21, 57);
            this.chkAdulto.Name = "chkAdulto";
            this.chkAdulto.Size = new System.Drawing.Size(73, 23);
            this.chkAdulto.TabIndex = 1;
            this.chkAdulto.Text = "Adulto";
            this.chkAdulto.UseVisualStyleBackColor = true;
            this.chkAdulto.CheckedChanged += new System.EventHandler(this.chkAdulto_CheckedChanged);
            // 
            // chkCrianca
            // 
            this.chkCrianca.AutoSize = true;
            this.chkCrianca.BackColor = System.Drawing.Color.Transparent;
            this.chkCrianca.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrianca.ForeColor = System.Drawing.Color.DimGray;
            this.chkCrianca.Location = new System.Drawing.Point(100, 57);
            this.chkCrianca.Name = "chkCrianca";
            this.chkCrianca.Size = new System.Drawing.Size(77, 23);
            this.chkCrianca.TabIndex = 2;
            this.chkCrianca.Text = "Criança";
            this.chkCrianca.UseVisualStyleBackColor = false;
            this.chkCrianca.CheckedChanged += new System.EventHandler(this.chkCrianca_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(345, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gênero";
            // 
            // chkFem
            // 
            this.chkFem.AutoSize = true;
            this.chkFem.Checked = true;
            this.chkFem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFem.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFem.ForeColor = System.Drawing.Color.DarkOrange;
            this.chkFem.Location = new System.Drawing.Point(350, 57);
            this.chkFem.Name = "chkFem";
            this.chkFem.Size = new System.Drawing.Size(89, 23);
            this.chkFem.TabIndex = 4;
            this.chkFem.Text = "Feminino";
            this.chkFem.UseVisualStyleBackColor = true;
            // 
            // chkMasc
            // 
            this.chkMasc.AutoSize = true;
            this.chkMasc.BackColor = System.Drawing.Color.Transparent;
            this.chkMasc.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMasc.ForeColor = System.Drawing.Color.DimGray;
            this.chkMasc.Location = new System.Drawing.Point(445, 57);
            this.chkMasc.Name = "chkMasc";
            this.chkMasc.Size = new System.Drawing.Size(95, 23);
            this.chkMasc.TabIndex = 5;
            this.chkMasc.Text = "Masculino";
            this.chkMasc.UseVisualStyleBackColor = false;
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
    }
}