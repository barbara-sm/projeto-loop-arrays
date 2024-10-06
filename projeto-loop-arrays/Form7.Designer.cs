namespace projeto_loop_arrays
{
    partial class Frm_Tela7
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Vetor5 = new System.Windows.Forms.Label();
            this.Lbl_Vetor6 = new System.Windows.Forms.Label();
            this.List_Vetor5 = new System.Windows.Forms.ListBox();
            this.List_Vetor6 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "VETORES";
            // 
            // Lbl_Vetor5
            // 
            this.Lbl_Vetor5.AutoSize = true;
            this.Lbl_Vetor5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Vetor5.Location = new System.Drawing.Point(225, 140);
            this.Lbl_Vetor5.Name = "Lbl_Vetor5";
            this.Lbl_Vetor5.Size = new System.Drawing.Size(120, 16);
            this.Lbl_Vetor5.TabIndex = 1;
            this.Lbl_Vetor5.Text = "Vetor 5 - Sem Laço";
            // 
            // Lbl_Vetor6
            // 
            this.Lbl_Vetor6.AutoSize = true;
            this.Lbl_Vetor6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Vetor6.Location = new System.Drawing.Point(455, 140);
            this.Lbl_Vetor6.Name = "Lbl_Vetor6";
            this.Lbl_Vetor6.Size = new System.Drawing.Size(120, 16);
            this.Lbl_Vetor6.TabIndex = 2;
            this.Lbl_Vetor6.Text = "Vetor 6 - Com Laço";
            // 
            // List_Vetor5
            // 
            this.List_Vetor5.FormattingEnabled = true;
            this.List_Vetor5.Location = new System.Drawing.Point(203, 174);
            this.List_Vetor5.Name = "List_Vetor5";
            this.List_Vetor5.Size = new System.Drawing.Size(165, 212);
            this.List_Vetor5.TabIndex = 3;
            // 
            // List_Vetor6
            // 
            this.List_Vetor6.FormattingEnabled = true;
            this.List_Vetor6.Location = new System.Drawing.Point(433, 174);
            this.List_Vetor6.Name = "List_Vetor6";
            this.List_Vetor6.Size = new System.Drawing.Size(165, 212);
            this.List_Vetor6.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dias de Semana";
            // 
            // Frm_Tela7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.List_Vetor6);
            this.Controls.Add(this.List_Vetor5);
            this.Controls.Add(this.Lbl_Vetor6);
            this.Controls.Add(this.Lbl_Vetor5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Tela7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Frm_Tela7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Vetor5;
        private System.Windows.Forms.Label Lbl_Vetor6;
        private System.Windows.Forms.ListBox List_Vetor5;
        private System.Windows.Forms.ListBox List_Vetor6;
        private System.Windows.Forms.Label label4;
    }
}