namespace football
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tenBangLabel;
            System.Windows.Forms.Label tenDoiLabel;
            System.Windows.Forms.Label tenDoiDoiThuLabel;
            System.Windows.Forms.Label tiSoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bangDiemThiDauBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bangDiemThiDauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footballsrcDataSet = new football.footballsrcDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bangDiemThiDauBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tenBangTextBox = new System.Windows.Forms.TextBox();
            this.tenDoiTextBox = new System.Windows.Forms.TextBox();
            this.tenDoiDoiThuTextBox = new System.Windows.Forms.TextBox();
            this.tiSoTextBox = new System.Windows.Forms.TextBox();
            this.bangDiemThiDauDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnKetqua = new System.Windows.Forms.Button();
            this.bangDiemThiDauTableAdapter = new football.footballsrcDataSetTableAdapters.BangDiemThiDauTableAdapter();
            this.tableAdapterManager = new football.footballsrcDataSetTableAdapters.TableAdapterManager();
            tenBangLabel = new System.Windows.Forms.Label();
            tenDoiLabel = new System.Windows.Forms.Label();
            tenDoiDoiThuLabel = new System.Windows.Forms.Label();
            tiSoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingNavigator)).BeginInit();
            this.bangDiemThiDauBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballsrcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tenBangLabel
            // 
            tenBangLabel.AutoSize = true;
            tenBangLabel.Location = new System.Drawing.Point(44, 69);
            tenBangLabel.Name = "tenBangLabel";
            tenBangLabel.Size = new System.Drawing.Size(57, 13);
            tenBangLabel.TabIndex = 3;
            tenBangLabel.Text = "Ten Bang:";
            // 
            // tenDoiLabel
            // 
            tenDoiLabel.AutoSize = true;
            tenDoiLabel.Location = new System.Drawing.Point(53, 95);
            tenDoiLabel.Name = "tenDoiLabel";
            tenDoiLabel.Size = new System.Drawing.Size(48, 13);
            tenDoiLabel.TabIndex = 5;
            tenDoiLabel.Text = "Ten Doi:";
            // 
            // tenDoiDoiThuLabel
            // 
            tenDoiDoiThuLabel.AutoSize = true;
            tenDoiDoiThuLabel.Location = new System.Drawing.Point(12, 121);
            tenDoiDoiThuLabel.Name = "tenDoiDoiThuLabel";
            tenDoiDoiThuLabel.Size = new System.Drawing.Size(89, 13);
            tenDoiDoiThuLabel.TabIndex = 7;
            tenDoiDoiThuLabel.Text = "Ten Doi Doi Thu:";
            // 
            // tiSoLabel
            // 
            tiSoLabel.AutoSize = true;
            tiSoLabel.Location = new System.Drawing.Point(66, 147);
            tiSoLabel.Name = "tiSoLabel";
            tiSoLabel.Size = new System.Drawing.Size(35, 13);
            tiSoLabel.TabIndex = 9;
            tiSoLabel.Text = "Ti So:";
            // 
            // bangDiemThiDauBindingNavigator
            // 
            this.bangDiemThiDauBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bangDiemThiDauBindingNavigator.BindingSource = this.bangDiemThiDauBindingSource;
            this.bangDiemThiDauBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bangDiemThiDauBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bangDiemThiDauBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bangDiemThiDauBindingNavigatorSaveItem});
            this.bangDiemThiDauBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bangDiemThiDauBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bangDiemThiDauBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bangDiemThiDauBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bangDiemThiDauBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bangDiemThiDauBindingNavigator.Name = "bangDiemThiDauBindingNavigator";
            this.bangDiemThiDauBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bangDiemThiDauBindingNavigator.Size = new System.Drawing.Size(870, 25);
            this.bangDiemThiDauBindingNavigator.TabIndex = 0;
            this.bangDiemThiDauBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bangDiemThiDauBindingSource
            // 
            this.bangDiemThiDauBindingSource.DataMember = "BangDiemThiDau";
            this.bangDiemThiDauBindingSource.DataSource = this.footballsrcDataSet;
            // 
            // footballsrcDataSet
            // 
            this.footballsrcDataSet.DataSetName = "footballsrcDataSet";
            this.footballsrcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bangDiemThiDauBindingNavigatorSaveItem
            // 
            this.bangDiemThiDauBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bangDiemThiDauBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bangDiemThiDauBindingNavigatorSaveItem.Image")));
            this.bangDiemThiDauBindingNavigatorSaveItem.Name = "bangDiemThiDauBindingNavigatorSaveItem";
            this.bangDiemThiDauBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bangDiemThiDauBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // tenBangTextBox
            // 
            this.tenBangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource, "TenBang", true));
            this.tenBangTextBox.Location = new System.Drawing.Point(107, 66);
            this.tenBangTextBox.Name = "tenBangTextBox";
            this.tenBangTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenBangTextBox.TabIndex = 4;
            // 
            // tenDoiTextBox
            // 
            this.tenDoiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource, "TenDoi", true));
            this.tenDoiTextBox.Location = new System.Drawing.Point(107, 92);
            this.tenDoiTextBox.Name = "tenDoiTextBox";
            this.tenDoiTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenDoiTextBox.TabIndex = 6;
            // 
            // tenDoiDoiThuTextBox
            // 
            this.tenDoiDoiThuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource, "TenDoiDoiThu", true));
            this.tenDoiDoiThuTextBox.Location = new System.Drawing.Point(107, 118);
            this.tenDoiDoiThuTextBox.Name = "tenDoiDoiThuTextBox";
            this.tenDoiDoiThuTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenDoiDoiThuTextBox.TabIndex = 8;
            // 
            // tiSoTextBox
            // 
            this.tiSoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bangDiemThiDauBindingSource, "TiSo", true));
            this.tiSoTextBox.Location = new System.Drawing.Point(107, 144);
            this.tiSoTextBox.Name = "tiSoTextBox";
            this.tiSoTextBox.Size = new System.Drawing.Size(100, 20);
            this.tiSoTextBox.TabIndex = 10;
            // 
            // bangDiemThiDauDataGridView
            // 
            this.bangDiemThiDauDataGridView.AutoGenerateColumns = false;
            this.bangDiemThiDauDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangDiemThiDauDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.bangDiemThiDauDataGridView.DataSource = this.bangDiemThiDauBindingSource;
            this.bangDiemThiDauDataGridView.Location = new System.Drawing.Point(12, 201);
            this.bangDiemThiDauDataGridView.Name = "bangDiemThiDauDataGridView";
            this.bangDiemThiDauDataGridView.Size = new System.Drawing.Size(845, 220);
            this.bangDiemThiDauDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenBang";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenBang";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenDoi";
            this.dataGridViewTextBoxColumn3.HeaderText = "TenDoi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenDoiDoiThu";
            this.dataGridViewTextBoxColumn4.HeaderText = "TenDoiDoiThu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TiSo";
            this.dataGridViewTextBoxColumn5.HeaderText = "TiSo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SoTranDaThiDau";
            this.dataGridViewTextBoxColumn6.HeaderText = "SoTranDaThiDau";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HieuSo";
            this.dataGridViewTextBoxColumn7.HeaderText = "HieuSo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Diem";
            this.dataGridViewTextBoxColumn8.HeaderText = "Diem";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(268, 66);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(268, 95);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(268, 124);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(268, 153);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnKetqua
            // 
            this.btnKetqua.Location = new System.Drawing.Point(366, 153);
            this.btnKetqua.Name = "btnKetqua";
            this.btnKetqua.Size = new System.Drawing.Size(97, 23);
            this.btnKetqua.TabIndex = 18;
            this.btnKetqua.Text = "Xem kết quả";
            this.btnKetqua.UseVisualStyleBackColor = true;
            this.btnKetqua.Click += new System.EventHandler(this.btnKetqua_Click);
            // 
            // bangDiemThiDauTableAdapter
            // 
            this.bangDiemThiDauTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemThiDauTableAdapter = this.bangDiemThiDauTableAdapter;
            this.tableAdapterManager.UpdateOrder = football.footballsrcDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 469);
            this.Controls.Add(this.btnKetqua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.bangDiemThiDauDataGridView);
            this.Controls.Add(tiSoLabel);
            this.Controls.Add(this.tiSoTextBox);
            this.Controls.Add(tenDoiDoiThuLabel);
            this.Controls.Add(this.tenDoiDoiThuTextBox);
            this.Controls.Add(tenDoiLabel);
            this.Controls.Add(this.tenDoiTextBox);
            this.Controls.Add(tenBangLabel);
            this.Controls.Add(this.tenBangTextBox);
            this.Controls.Add(this.bangDiemThiDauBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Football";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingNavigator)).EndInit();
            this.bangDiemThiDauBindingNavigator.ResumeLayout(false);
            this.bangDiemThiDauBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballsrcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private footballsrcDataSet footballsrcDataSet;
        private System.Windows.Forms.BindingSource bangDiemThiDauBindingSource;
        private footballsrcDataSetTableAdapters.BangDiemThiDauTableAdapter bangDiemThiDauTableAdapter;
        private footballsrcDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bangDiemThiDauBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bangDiemThiDauBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tenBangTextBox;
        private System.Windows.Forms.TextBox tenDoiTextBox;
        private System.Windows.Forms.TextBox tenDoiDoiThuTextBox;
        private System.Windows.Forms.TextBox tiSoTextBox;
        private System.Windows.Forms.DataGridView bangDiemThiDauDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnKetqua;
    }
}

