
namespace ITtools.UI.U8mantinance
{
    partial class FrmAuditFlowModify
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
            this.cmbVoucherType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperationType = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panInput = new System.Windows.Forms.Panel();
            this.panInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbVoucherType
            // 
            this.cmbVoucherType.FormattingEnabled = true;
            this.cmbVoucherType.Items.AddRange(new object[] {
            "采购订单",
            "供应商存货调价单"});
            this.cmbVoucherType.Location = new System.Drawing.Point(117, 17);
            this.cmbVoucherType.Name = "cmbVoucherType";
            this.cmbVoucherType.Size = new System.Drawing.Size(223, 20);
            this.cmbVoucherType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "单据类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "单据号：";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(463, 20);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(191, 21);
            this.txtVoucherNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "操作类型：";
            // 
            // cmbOperationType
            // 
            this.cmbOperationType.FormattingEnabled = true;
            this.cmbOperationType.Items.AddRange(new object[] {
            "未提交",
            "已提交"});
            this.cmbOperationType.Location = new System.Drawing.Point(117, 75);
            this.cmbOperationType.Name = "cmbOperationType";
            this.cmbOperationType.Size = new System.Drawing.Size(223, 20);
            this.cmbOperationType.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(297, 232);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panInput
            // 
            this.panInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panInput.Controls.Add(this.label1);
            this.panInput.Controls.Add(this.cmbVoucherType);
            this.panInput.Controls.Add(this.txtVoucherNo);
            this.panInput.Controls.Add(this.cmbOperationType);
            this.panInput.Controls.Add(this.label2);
            this.panInput.Controls.Add(this.label3);
            this.panInput.Location = new System.Drawing.Point(12, 12);
            this.panInput.Name = "panInput";
            this.panInput.Size = new System.Drawing.Size(684, 183);
            this.panInput.TabIndex = 4;
            // 
            // FrmAuditFlowModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.panInput);
            this.Controls.Add(this.btnUpdate);
            this.Name = "FrmAuditFlowModify";
            this.Text = "审批流维护";
            this.panInput.ResumeLayout(false);
            this.panInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVoucherType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOperationType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panInput;
    }
}