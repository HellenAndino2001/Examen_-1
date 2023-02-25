namespace HellenAndino
{
    partial class Form4
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
            this.BE3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BE3
            // 
            this.BE3.Location = new System.Drawing.Point(190, 22);
            this.BE3.Name = "BE3";
            this.BE3.Size = new System.Drawing.Size(241, 28);
            this.BE3.TabIndex = 0;
            this.BE3.Text = "Ejercicio #3";
            this.BE3.UseVisualStyleBackColor = true;
            this.BE3.Click += new System.EventHandler(this.BE3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(110, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 364);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BM
            // 
            this.BM.Location = new System.Drawing.Point(365, 111);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(132, 37);
            this.BM.TabIndex = 2;
            this.BM.Text = "Mostrar";
            this.BM.UseVisualStyleBackColor = true;
            this.BM.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Números del 1-100";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BM);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BE3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BE3;
        private ListBox listBox1;
        private Button BM;
        private Label label1;
    }
}