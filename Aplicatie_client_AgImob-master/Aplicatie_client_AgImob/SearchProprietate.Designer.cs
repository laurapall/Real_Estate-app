
namespace Aplicatie_client_AgImob
{
    partial class SearchProprietate
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
            this.txt_SearchName3 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_iesire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_SearchName3
            // 
            this.txt_SearchName3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchName3.Location = new System.Drawing.Point(658, 113);
            this.txt_SearchName3.Name = "txt_SearchName3";
            this.txt_SearchName3.Size = new System.Drawing.Size(173, 32);
            this.txt_SearchName3.TabIndex = 0;
            this.txt_SearchName3.TextChanged += new System.EventHandler(this.txt_SearchName3_TextChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(197, 176);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1092, 396);
            this.dataGridView3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cautare IMOBIL dupa ID";
            // 
            // button_iesire
            // 
            this.button_iesire.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_iesire.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iesire.ForeColor = System.Drawing.Color.DarkRed;
            this.button_iesire.Location = new System.Drawing.Point(658, 604);
            this.button_iesire.Name = "button_iesire";
            this.button_iesire.Size = new System.Drawing.Size(208, 55);
            this.button_iesire.TabIndex = 7;
            this.button_iesire.Text = "Iesire";
            this.button_iesire.UseVisualStyleBackColor = false;
            this.button_iesire.Click += new System.EventHandler(this.button_iesire_Click);
            // 
            // SearchProprietate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1554, 708);
            this.Controls.Add(this.button_iesire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.txt_SearchName3);
            this.Name = "SearchProprietate";
            this.Text = "SearchProprietate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SearchName3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_iesire;
    }
}