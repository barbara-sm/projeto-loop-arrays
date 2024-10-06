namespace projeto_loop_arrays
{
    partial class Frm_Tela6
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
            this.Lbl_Matrizes = new System.Windows.Forms.Label();
            this.Lbl_Bidimensional = new System.Windows.Forms.Label();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Matriz1 = new System.Windows.Forms.Label();
            this.Lbl_Matriz2 = new System.Windows.Forms.Label();
            this.List_Matriz1 = new System.Windows.Forms.ListBox();
            this.List_Matriz2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Lbl_Matrizes
            // 
            this.Lbl_Matrizes.AutoSize = true;
            this.Lbl_Matrizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Matrizes.Location = new System.Drawing.Point(180, 36);
            this.Lbl_Matrizes.Name = "Lbl_Matrizes";
            this.Lbl_Matrizes.Size = new System.Drawing.Size(118, 25);
            this.Lbl_Matrizes.TabIndex = 0;
            this.Lbl_Matrizes.Text = "MATRIZES";
            // 
            // Lbl_Bidimensional
            // 
            this.Lbl_Bidimensional.AutoSize = true;
            this.Lbl_Bidimensional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bidimensional.Location = new System.Drawing.Point(186, 72);
            this.Lbl_Bidimensional.Name = "Lbl_Bidimensional";
            this.Lbl_Bidimensional.Size = new System.Drawing.Size(107, 20);
            this.Lbl_Bidimensional.TabIndex = 1;
            this.Lbl_Bidimensional.Text = "Bidimensional";
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(484, 40);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Voltar.TabIndex = 2;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Lbl_Matriz1
            // 
            this.Lbl_Matriz1.AutoSize = true;
            this.Lbl_Matriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Matriz1.Location = new System.Drawing.Point(209, 129);
            this.Lbl_Matriz1.Name = "Lbl_Matriz1";
            this.Lbl_Matriz1.Size = new System.Drawing.Size(73, 20);
            this.Lbl_Matriz1.TabIndex = 3;
            this.Lbl_Matriz1.Text = "Matriz 1";
            // 
            // Lbl_Matriz2
            // 
            this.Lbl_Matriz2.AutoSize = true;
            this.Lbl_Matriz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Matriz2.Location = new System.Drawing.Point(486, 129);
            this.Lbl_Matriz2.Name = "Lbl_Matriz2";
            this.Lbl_Matriz2.Size = new System.Drawing.Size(73, 20);
            this.Lbl_Matriz2.TabIndex = 4;
            this.Lbl_Matriz2.Text = "Matriz 2";
            // 
            // List_Matriz1
            // 
            this.List_Matriz1.FormattingEnabled = true;
            this.List_Matriz1.Location = new System.Drawing.Point(168, 152);
            this.List_Matriz1.Name = "List_Matriz1";
            this.List_Matriz1.Size = new System.Drawing.Size(155, 199);
            this.List_Matriz1.TabIndex = 7;
            // 
            // List_Matriz2
            // 
            this.List_Matriz2.FormattingEnabled = true;
            this.List_Matriz2.Location = new System.Drawing.Point(442, 152);
            this.List_Matriz2.Name = "List_Matriz2";
            this.List_Matriz2.Size = new System.Drawing.Size(155, 199);
            this.List_Matriz2.TabIndex = 8;
            // 
            // Frm_Tela6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.List_Matriz2);
            this.Controls.Add(this.List_Matriz1);
            this.Controls.Add(this.Lbl_Matriz2);
            this.Controls.Add(this.Lbl_Matriz1);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_Bidimensional);
            this.Controls.Add(this.Lbl_Matrizes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Tela6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Frm_Tela6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Matrizes;
        private System.Windows.Forms.Label Lbl_Bidimensional;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_Matriz1;
        private System.Windows.Forms.Label Lbl_Matriz2;
        private System.Windows.Forms.ListBox List_Matriz1;
        private System.Windows.Forms.ListBox List_Matriz2;
    }
}