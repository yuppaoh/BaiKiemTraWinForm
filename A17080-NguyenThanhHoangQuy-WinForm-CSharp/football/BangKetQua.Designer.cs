namespace football
{
    partial class BangKetQua
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
            this.components = new System.ComponentModel.Container();
            this.footballsrcDataSet = new football.footballsrcDataSet();
            this.bangKetQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangKetQuaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.footballsrcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangKetQuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangKetQuaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // footballsrcDataSet
            // 
            this.footballsrcDataSet.DataSetName = "footballsrcDataSet";
            this.footballsrcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangKetQuaBindingSource
            // 
            this.bangKetQuaBindingSource.DataMember = "BangKetQua";
            this.bangKetQuaBindingSource.DataSource = this.footballsrcDataSet;
            // 
            // bangKetQuaDataGridView
            // 
            this.bangKetQuaDataGridView.AutoGenerateColumns = false;
            this.bangKetQuaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangKetQuaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.bangKetQuaDataGridView.DataSource = this.bangKetQuaBindingSource;
            this.bangKetQuaDataGridView.Location = new System.Drawing.Point(37, 116);
            this.bangKetQuaDataGridView.Name = "bangKetQuaDataGridView";
            this.bangKetQuaDataGridView.Size = new System.Drawing.Size(613, 220);
            this.bangKetQuaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Stt";
            this.dataGridViewTextBoxColumn1.HeaderText = "Stt";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenDoi";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenDoi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoTranDaDau";
            this.dataGridViewTextBoxColumn3.HeaderText = "SoTranDaDau";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HieuSo";
            this.dataGridViewTextBoxColumn4.HeaderText = "HieuSo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TongDiem";
            this.dataGridViewTextBoxColumn5.HeaderText = "TongDiem";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "BẢNG KẾT QUẢ";
            // 
            // BangKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bangKetQuaDataGridView);
            this.Name = "BangKetQua";
            this.Text = "BangKetQua";
            this.Load += new System.EventHandler(this.BangKetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.footballsrcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangKetQuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangKetQuaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private footballsrcDataSet footballsrcDataSet;
        private System.Windows.Forms.BindingSource bangKetQuaBindingSource;
        private System.Windows.Forms.DataGridView bangKetQuaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}