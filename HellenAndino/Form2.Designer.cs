namespace HellenAndino
{
    partial class Form2
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
            this.Intereses = new System.Windows.Forms.ListBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.problema1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Intereses
            // 
            this.Intereses.BackColor = System.Drawing.Color.White;
            this.Intereses.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Intereses.FormattingEnabled = true;
            this.Intereses.ItemHeight = 15;
            this.Intereses.Location = new System.Drawing.Point(46, 106);
            this.Intereses.Name = "Intereses";
            this.Intereses.Size = new System.Drawing.Size(142, 184);
            this.Intereses.TabIndex = 0;
            this.Intereses.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Calcular
            // 
            this.Calcular.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calcular.Location = new System.Drawing.Point(233, 175);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(85, 27);
            this.Calcular.TabIndex = 1;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // problema1
            // 
            this.problema1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.problema1.Location = new System.Drawing.Point(119, 25);
            this.problema1.Name = "problema1";
            this.problema1.Size = new System.Drawing.Size(220, 30);
            this.problema1.TabIndex = 2;
            this.problema1.Text = "Ejercicio #1 ";
            this.problema1.UseVisualStyleBackColor = true;
            this.problema1.Click += new System.EventHandler(this.problema_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calcular Interés";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.problema1);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Intereses);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Intereses;
        private Button Calcular;
        private Button problema1;
        private Label label1;
    }
}