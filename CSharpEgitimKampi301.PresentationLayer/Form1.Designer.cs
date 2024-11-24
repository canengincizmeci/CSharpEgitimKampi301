namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rehber Id:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(303, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 361);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rehber Adı:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rehber Soyadı:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdd.Location = new System.Drawing.Point(126, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 29);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(126, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 29);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.Location = new System.Drawing.Point(126, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 29);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.Color.IndianRed;
            this.btnGetById.Location = new System.Drawing.Point(126, 269);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(154, 29);
            this.btnGetById.TabIndex = 11;
            this.btnGetById.Text = "Id\'ye Göre getir";
            this.btnGetById.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rehber İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetById;
    }
}

