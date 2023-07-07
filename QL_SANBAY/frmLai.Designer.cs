﻿namespace QL_SANBAY
{
    partial class frmLai
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label mALOAILabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.dSSB = new QL_SANBAY.DSSB();
            this.sP_DANHSACH_LAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DANHSACH_LAITableAdapter = new QL_SANBAY.DSSBTableAdapters.SP_DANHSACH_LAITableAdapter();
            this.tableAdapterManager = new QL_SANBAY.DSSBTableAdapters.TableAdapterManager();
            this.sP_DANHSACH_LAIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASOBANGLAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lAITableAdapter = new QL_SANBAY.DSSBTableAdapters.LAITableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPhiCong = new System.Windows.Forms.ComboBox();
            this.cbxLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLoai = new DevExpress.XtraEditors.TextEdit();
            this.btnChiDinh = new System.Windows.Forms.Button();
            this.btnHuyLai = new System.Windows.Forms.Button();
            cMNDLabel = new System.Windows.Forms.Label();
            mALOAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_LAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_LAIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sP_DANHSACH_LAIGridControl);
            this.panelControl1.Location = new System.Drawing.Point(12, 44);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1114, 372);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnChiDinh);
            this.panelControl2.Controls.Add(cMNDLabel);
            this.panelControl2.Controls.Add(this.txtCMND);
            this.panelControl2.Controls.Add(mALOAILabel);
            this.panelControl2.Controls.Add(this.txtMaLoai);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.cbxLoai);
            this.panelControl2.Controls.Add(this.cbxPhiCong);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Location = new System.Drawing.Point(12, 420);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1114, 250);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnHuyLai);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Location = new System.Drawing.Point(12, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1114, 33);
            this.panelControl3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách phi công được chỉ định lái loại máy bay";
            // 
            // dSSB
            // 
            this.dSSB.DataSetName = "DSSB";
            this.dSSB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_DANHSACH_LAIBindingSource
            // 
            this.sP_DANHSACH_LAIBindingSource.DataMember = "SP_DANHSACH_LAI";
            this.sP_DANHSACH_LAIBindingSource.DataSource = this.dSSB;
            // 
            // sP_DANHSACH_LAITableAdapter
            // 
            this.sP_DANHSACH_LAITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAOTRITableAdapter = null;
            this.tableAdapterManager.CHUTableAdapter = null;
            this.tableAdapterManager.CHUYENVETableAdapter = null;
            this.tableAdapterManager.CTNHANVIENBAOTRITableAdapter = null;
            this.tableAdapterManager.DICHVUBAOTRITableAdapter = null;
            this.tableAdapterManager.DOANHNGHIEPTableAdapter = null;
            this.tableAdapterManager.LAITableAdapter = this.lAITableAdapter;
            this.tableAdapterManager.LOAITableAdapter = null;
            this.tableAdapterManager.MAYBAYTableAdapter = null;
            this.tableAdapterManager.NGUOITableAdapter = null;
            this.tableAdapterManager.NHACHUATableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHICONGTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_SANBAY.DSSBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_DANHSACH_LAIGridControl
            // 
            this.sP_DANHSACH_LAIGridControl.DataSource = this.sP_DANHSACH_LAIBindingSource;
            this.sP_DANHSACH_LAIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_DANHSACH_LAIGridControl.Location = new System.Drawing.Point(2, 2);
            this.sP_DANHSACH_LAIGridControl.MainView = this.gridView1;
            this.sP_DANHSACH_LAIGridControl.Name = "sP_DANHSACH_LAIGridControl";
            this.sP_DANHSACH_LAIGridControl.Size = new System.Drawing.Size(1110, 368);
            this.sP_DANHSACH_LAIGridControl.TabIndex = 0;
            this.sP_DANHSACH_LAIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHOTEN,
            this.colMASOBANGLAI,
            this.colMALOAI,
            this.colTENLOAI});
            this.gridView1.GridControl = this.sP_DANHSACH_LAIGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 94;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 25;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 94;
            // 
            // colMASOBANGLAI
            // 
            this.colMASOBANGLAI.FieldName = "MASOBANGLAI";
            this.colMASOBANGLAI.MinWidth = 25;
            this.colMASOBANGLAI.Name = "colMASOBANGLAI";
            this.colMASOBANGLAI.Visible = true;
            this.colMASOBANGLAI.VisibleIndex = 2;
            this.colMASOBANGLAI.Width = 94;
            // 
            // colMALOAI
            // 
            this.colMALOAI.FieldName = "MALOAI";
            this.colMALOAI.MinWidth = 25;
            this.colMALOAI.Name = "colMALOAI";
            this.colMALOAI.Visible = true;
            this.colMALOAI.VisibleIndex = 3;
            this.colMALOAI.Width = 94;
            // 
            // colTENLOAI
            // 
            this.colTENLOAI.FieldName = "TENLOAI";
            this.colTENLOAI.MinWidth = 25;
            this.colTENLOAI.Name = "colTENLOAI";
            this.colTENLOAI.Visible = true;
            this.colTENLOAI.VisibleIndex = 4;
            this.colTENLOAI.Width = 94;
            // 
            // lAIBindingSource
            // 
            this.lAIBindingSource.DataMember = "LAI";
            this.lAIBindingSource.DataSource = this.dSSB;
            // 
            // lAITableAdapter
            // 
            this.lAITableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chỉ định Loại máy bay Phi công có thể lái";
            // 
            // cbxPhiCong
            // 
            this.cbxPhiCong.FormattingEnabled = true;
            this.cbxPhiCong.Location = new System.Drawing.Point(225, 78);
            this.cbxPhiCong.Name = "cbxPhiCong";
            this.cbxPhiCong.Size = new System.Drawing.Size(336, 24);
            this.cbxPhiCong.TabIndex = 1;
            this.cbxPhiCong.SelectedIndexChanged += new System.EventHandler(this.cbxPhiCong_SelectedIndexChanged);
            // 
            // cbxLoai
            // 
            this.cbxLoai.FormattingEnabled = true;
            this.cbxLoai.Location = new System.Drawing.Point(225, 139);
            this.cbxLoai.Name = "cbxLoai";
            this.cbxLoai.Size = new System.Drawing.Size(336, 24);
            this.cbxLoai.TabIndex = 2;
            this.cbxLoai.SelectedIndexChanged += new System.EventHandler(this.cbxLoai_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn phi công :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chọn loại máy bay :";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(630, 81);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(46, 16);
            cMNDLabel.TabIndex = 5;
            cMNDLabel.Text = "CMND:";
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lAIBindingSource, "CMND", true));
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(704, 78);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(125, 22);
            this.txtCMND.TabIndex = 6;
            // 
            // mALOAILabel
            // 
            mALOAILabel.AutoSize = true;
            mALOAILabel.Location = new System.Drawing.Point(630, 144);
            mALOAILabel.Name = "mALOAILabel";
            mALOAILabel.Size = new System.Drawing.Size(57, 16);
            mALOAILabel.TabIndex = 7;
            mALOAILabel.Text = "MALOAI:";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lAIBindingSource, "MALOAI", true));
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Location = new System.Drawing.Point(704, 141);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(125, 22);
            this.txtMaLoai.TabIndex = 8;
            // 
            // btnChiDinh
            // 
            this.btnChiDinh.Location = new System.Drawing.Point(935, 175);
            this.btnChiDinh.Name = "btnChiDinh";
            this.btnChiDinh.Size = new System.Drawing.Size(75, 23);
            this.btnChiDinh.TabIndex = 9;
            this.btnChiDinh.Text = "Chỉ định";
            this.btnChiDinh.UseVisualStyleBackColor = true;
            this.btnChiDinh.Click += new System.EventHandler(this.btnChiDinh_Click);
            // 
            // btnHuyLai
            // 
            this.btnHuyLai.Location = new System.Drawing.Point(966, 5);
            this.btnHuyLai.Name = "btnHuyLai";
            this.btnHuyLai.Size = new System.Drawing.Size(85, 23);
            this.btnHuyLai.TabIndex = 1;
            this.btnHuyLai.Text = "Hủy lái";
            this.btnHuyLai.UseVisualStyleBackColor = true;
            this.btnHuyLai.Click += new System.EventHandler(this.btnHuyLai_Click);
            // 
            // frmLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 694);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmLai";
            this.Text = "frmLai";
            this.Load += new System.EventHandler(this.frmLai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_LAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACH_LAIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label1;
        private DSSB dSSB;
        private System.Windows.Forms.BindingSource sP_DANHSACH_LAIBindingSource;
        private DSSBTableAdapters.SP_DANHSACH_LAITableAdapter sP_DANHSACH_LAITableAdapter;
        private DSSBTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_DANHSACH_LAIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMASOBANGLAI;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAI;
        private DSSBTableAdapters.LAITableAdapter lAITableAdapter;
        private System.Windows.Forms.BindingSource lAIBindingSource;
        private System.Windows.Forms.Button btnChiDinh;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtMaLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxLoai;
        private System.Windows.Forms.ComboBox cbxPhiCong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuyLai;
    }
}