namespace MultApp.Windows
{
    partial class Principal
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
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCalculadoraImc = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraAposentadoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lojaDeAçaíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lojaDeAçaíToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.carteirinhaDoParqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carteiraDeIdentificaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.BackColor = System.Drawing.Color.Lavender;
            this.menuStripPrincipal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.lojaDeAçaíToolStripMenuItem,
            this.carteiraDeIdentificaçãoToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(1067, 31);
            this.menuStripPrincipal.TabIndex = 1;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCalculadoraImc,
            this.calculadoraAposentadoriaToolStripMenuItem});
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // MenuCalculadoraImc
            // 
            this.MenuCalculadoraImc.Name = "MenuCalculadoraImc";
            this.MenuCalculadoraImc.Size = new System.Drawing.Size(273, 26);
            this.MenuCalculadoraImc.Text = "Calculadora IMC";
            this.MenuCalculadoraImc.Click += new System.EventHandler(this.MenuCalculadoraImc_Click);
            // 
            // calculadoraAposentadoriaToolStripMenuItem
            // 
            this.calculadoraAposentadoriaToolStripMenuItem.Name = "calculadoraAposentadoriaToolStripMenuItem";
            this.calculadoraAposentadoriaToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.calculadoraAposentadoriaToolStripMenuItem.Text = "Calculadora Aposentadoria";
            this.calculadoraAposentadoriaToolStripMenuItem.Click += new System.EventHandler(this.calculadoraAposentadoriaToolStripMenuItem_Click);
            // 
            // lojaDeAçaíToolStripMenuItem
            // 
            this.lojaDeAçaíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lojaDeAçaíToolStripMenuItem1});
            this.lojaDeAçaíToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lojaDeAçaíToolStripMenuItem.Name = "lojaDeAçaíToolStripMenuItem";
            this.lojaDeAçaíToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.lojaDeAçaíToolStripMenuItem.Text = "Lojas";
            // 
            // lojaDeAçaíToolStripMenuItem1
            // 
            this.lojaDeAçaíToolStripMenuItem1.Name = "lojaDeAçaíToolStripMenuItem1";
            this.lojaDeAçaíToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.lojaDeAçaíToolStripMenuItem1.Text = "Loja de Açaí";
            // 
            // carteirinhaDoParqueToolStripMenuItem
            // 
            this.carteirinhaDoParqueToolStripMenuItem.Name = "carteirinhaDoParqueToolStripMenuItem";
            this.carteirinhaDoParqueToolStripMenuItem.Size = new System.Drawing.Size(301, 28);
            this.carteirinhaDoParqueToolStripMenuItem.Text = "Carteirinha do Parque";
            this.carteirinhaDoParqueToolStripMenuItem.Click += new System.EventHandler(this.carteirinhaDoParqueToolStripMenuItem_Click);
            // 
            // carteiraDeIdentificaçãoToolStripMenuItem
            // 
            this.carteiraDeIdentificaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carteirinhaDoParqueToolStripMenuItem});
            this.carteiraDeIdentificaçãoToolStripMenuItem.Name = "carteiraDeIdentificaçãoToolStripMenuItem";
            this.carteiraDeIdentificaçãoToolStripMenuItem.Size = new System.Drawing.Size(249, 27);
            this.carteiraDeIdentificaçãoToolStripMenuItem.Text = "Carteira de Identificação";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStripPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Principal_Shown);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCalculadoraImc;
        private System.Windows.Forms.ToolStripMenuItem calculadoraAposentadoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lojaDeAçaíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lojaDeAçaíToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem carteiraDeIdentificaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carteirinhaDoParqueToolStripMenuItem;
    }
}