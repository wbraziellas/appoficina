namespace lm.oficina
{
    partial class FrmPrincipal
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPesquisarOs = new System.Windows.Forms.Button();
            this.grdListaServicos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnPesquisarOs
            // 
            this.btnPesquisarOs.Location = new System.Drawing.Point(585, 54);
            this.btnPesquisarOs.Name = "btnPesquisarOs";
            this.btnPesquisarOs.Size = new System.Drawing.Size(136, 35);
            this.btnPesquisarOs.TabIndex = 1;
            this.btnPesquisarOs.Text = "button1";
            this.btnPesquisarOs.UseVisualStyleBackColor = true;
            // 
            // grdListaServicos
            // 
            this.grdListaServicos.Location = new System.Drawing.Point(62, 122);
            this.grdListaServicos.Name = "grdListaServicos";
            this.grdListaServicos.Size = new System.Drawing.Size(659, 219);
            this.grdListaServicos.TabIndex = 2;
            this.grdListaServicos.UseCompatibleStateImageBehavior = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 377);
            this.Controls.Add(this.grdListaServicos);
            this.Controls.Add(this.btnPesquisarOs);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisarOs;
        private System.Windows.Forms.ListView grdListaServicos;
    }
}

