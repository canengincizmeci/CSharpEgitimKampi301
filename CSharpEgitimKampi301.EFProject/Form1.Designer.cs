namespace CSharpEgitimKampi301.EFProject
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
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.Color.IndianRed;
            this.btnGetById.Location = new System.Drawing.Point(124, 277);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(154, 29);
            this.btnGetById.TabIndex = 22;
            this.btnGetById.Text = "Id\'ye Göre getir";
            this.btnGetById.UseVisualStyleBackColor = false;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.Location = new System.Drawing.Point(124, 242);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 29);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(124, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 29);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdd.Location = new System.Drawing.Point(124, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 29);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(114, 94);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(164, 20);
            this.txtSurname.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rehber Soyadı:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 20);
            this.txtName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rehber Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(301, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 361);
            this.dataGridView1.TabIndex = 14;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(114, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(164, 20);
            this.txtId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Rehber Id:";
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.IndianRed;
            this.btnList.Location = new System.Drawing.Point(124, 131);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(154, 29);
            this.btnList.TabIndex = 23;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList;
    }
}

