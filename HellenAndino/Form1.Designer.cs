namespace HellenAndino
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalcularInteres = new System.Windows.Forms.ToolStripMenuItem();
            this.formulario2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuento = new System.Windows.Forms.ToolStripMenuItem();
            this.formulario3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejeToolStripMenuItem,
            this.formulario2ToolStripMenuItem,
            this.formulario3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(349, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejeToolStripMenuItem
            // 
            this.ejeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalcularInteres});
            this.ejeToolStripMenuItem.Name = "ejeToolStripMenuItem";
            this.ejeToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.ejeToolStripMenuItem.Text = "Ejercicio 1 ";
            this.ejeToolStripMenuItem.Click += new System.EventHandler(this.ejeToolStripMenuItem_Click);
            // 
            // CalcularInteres
            // 
            this.CalcularInteres.Name = "CalcularInteres";
            this.CalcularInteres.Size = new System.Drawing.Size(180, 22);
            this.CalcularInteres.Text = "Calcular Interes";
            this.CalcularInteres.Click += new System.EventHandler(this.holaToolStripMenuItem_Click);
            // 
            // formulario2ToolStripMenuItem
            // 
            this.formulario2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descuento});
            this.formulario2ToolStripMenuItem.Name = "formulario2ToolStripMenuItem";
            this.formulario2ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.formulario2ToolStripMenuItem.Text = "Ejercicio 2";
            this.formulario2ToolStripMenuItem.Click += new System.EventHandler(this.formulario2ToolStripMenuItem_Click);
            // 
            // descuento
            // 
            this.descuento.Name = "descuento";
            this.descuento.Size = new System.Drawing.Size(130, 22);
            this.descuento.Text = "Descuento";
            this.descuento.Click += new System.EventHandler(this.descuentosToolStripMenuItem_Click);
            // 
            // formulario3ToolStripMenuItem
            // 
            this.formulario3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multiplo});
            this.formulario3ToolStripMenuItem.Name = "formulario3ToolStripMenuItem";
            this.formulario3ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.formulario3ToolStripMenuItem.Text = "Ejercicio 3";
            this.formulario3ToolStripMenuItem.Click += new System.EventHandler(this.formulario3ToolStripMenuItem_Click);
            // 
            // multiplo
            // 
            this.multiplo.Name = "multiplo";
            this.multiplo.Size = new System.Drawing.Size(124, 22);
            this.multiplo.Text = "Multiplos";
            this.multiplo.Click += new System.EventHandler(this.multiplo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 148);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ejeToolStripMenuItem;
        private ToolStripMenuItem formulario2ToolStripMenuItem;
        private ToolStripMenuItem formulario3ToolStripMenuItem;
        private ToolStripMenuItem CalcularInteres;
        private ToolStripMenuItem multiplo;
        private ToolStripMenuItem descuento;
    }
}