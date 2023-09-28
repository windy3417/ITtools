
namespace ITtools.UI.BoxCode
{
    partial class FrmBoxCodeList
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.boxCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natruralFlowCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFlow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.txtInvCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boxCode,
            this.makeDate,
            this.invCode,
            this.invName,
            this.invStd,
            this.natruralFlowCode,
            this.dataFlow,
            this.createUser});
            this.dgv.Location = new System.Drawing.Point(4, 172);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(792, 275);
            this.dgv.TabIndex = 0;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            // 
            // boxCode
            // 
            this.boxCode.HeaderText = "装箱单号";
            this.boxCode.Name = "boxCode";
            // 
            // makeDate
            // 
            this.makeDate.HeaderText = "装箱日期";
            this.makeDate.Name = "makeDate";
            this.makeDate.ReadOnly = true;
            // 
            // invCode
            // 
            this.invCode.HeaderText = "存货编码";
            this.invCode.Name = "invCode";
            this.invCode.ReadOnly = true;
            // 
            // invName
            // 
            this.invName.HeaderText = "存货名称";
            this.invName.Name = "invName";
            this.invName.ReadOnly = true;
            // 
            // invStd
            // 
            this.invStd.HeaderText = "规格型号";
            this.invStd.Name = "invStd";
            this.invStd.ReadOnly = true;
            // 
            // natruralFlowCode
            // 
            this.natruralFlowCode.HeaderText = "自然流水箱号";
            this.natruralFlowCode.Name = "natruralFlowCode";
            this.natruralFlowCode.ReadOnly = true;
            // 
            // dataFlow
            // 
            this.dataFlow.HeaderText = "日期流水号";
            this.dataFlow.Name = "dataFlow";
            this.dataFlow.ReadOnly = true;
            // 
            // createUser
            // 
            this.createUser.HeaderText = "制单人";
            this.createUser.Name = "createUser";
            this.createUser.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbQuery
            // 
            this.tsbQuery.Image = global::ITtools.Properties.Resources.Search;
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(53, 22);
            this.tsbQuery.Text = "查询";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.btnRef);
            this.groupBox1.Controls.Add(this.txtInvCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(683, 42);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(195, 38);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(24, 23);
            this.btnRef.TabIndex = 2;
            this.btnRef.Text = "…";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // txtInvCode
            // 
            this.txtInvCode.Location = new System.Drawing.Point(93, 39);
            this.txtInvCode.Name = "txtInvCode";
            this.txtInvCode.Size = new System.Drawing.Size(100, 21);
            this.txtInvCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "存货编码";
            // 
            // FrmBoxCodeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv);
            this.Name = "FrmBoxCodeList";
            this.Text = "箱码列表";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.TextBox txtInvCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn invCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn invName;
        private System.Windows.Forms.DataGridViewTextBoxColumn invStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn natruralFlowCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFlow;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUser;
    }
}