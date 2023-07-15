
namespace Aplicatie_client_AgImob
{
    partial class SearchTipProprietate
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
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_iesire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchName.Location = new System.Drawing.Point(626, 122);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(215, 29);
            this.txt_SearchName.TabIndex = 0;
            this.txt_SearchName.TextChanged += new System.EventHandler(this.txt_SearchName_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(886, 286);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_iesire
            // 
            this.button_iesire.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_iesire.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iesire.ForeColor = System.Drawing.Color.DarkRed;
            this.button_iesire.Location = new System.Drawing.Point(653, 551);
            this.button_iesire.Name = "button_iesire";
            this.button_iesire.Size = new System.Drawing.Size(208, 55);
            this.button_iesire.TabIndex = 4;
            this.button_iesire.Text = "Iesire";
            this.button_iesire.UseVisualStyleBackColor = false;
            this.button_iesire.Click += new System.EventHandler(this.button_iesire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cautare TIP IMOBIL dupa ID";
            // 
            // SearchTipProprietate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1563, 716);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_iesire);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_SearchName);
            this.Name = "SearchTipProprietate";
            this.Text = "SearchTipProprietate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_iesire;
        private System.Windows.Forms.Label label1;
    }
}