
namespace Aplicatie_client_AgImob
{
    partial class SearchProprietar
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
            this.txt_SearchName2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button_iesire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_SearchName2
            // 
            this.txt_SearchName2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchName2.Location = new System.Drawing.Point(653, 79);
            this.txt_SearchName2.Name = "txt_SearchName2";
            this.txt_SearchName2.Size = new System.Drawing.Size(245, 32);
            this.txt_SearchName2.TabIndex = 0;
            this.txt_SearchName2.TextChanged += new System.EventHandler(this.txt_SearchName2_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(218, 169);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1124, 370);
            this.dataGridView2.TabIndex = 1;
            // 
            // button_iesire
            // 
            this.button_iesire.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_iesire.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iesire.ForeColor = System.Drawing.Color.DarkRed;
            this.button_iesire.Location = new System.Drawing.Point(681, 587);
            this.button_iesire.Name = "button_iesire";
            this.button_iesire.Size = new System.Drawing.Size(208, 55);
            this.button_iesire.TabIndex = 5;
            this.button_iesire.Text = "Iesire";
            this.button_iesire.UseVisualStyleBackColor = false;
            this.button_iesire.Click += new System.EventHandler(this.button_iesire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cautare PROPRIETAR dupa CNP";
            // 
            // SearchProprietar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1550, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_iesire);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txt_SearchName2);
            this.Name = "SearchProprietar";
            this.Text = "SearchProprietar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SearchName2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button_iesire;
        private System.Windows.Forms.Label label1;
    }
}