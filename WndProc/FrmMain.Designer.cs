
using System.Windows.Forms;

namespace WndProc
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.userTableTableAdapter = new WndProc.UserDataSetTableAdapters.UserTableTableAdapter();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.TsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtnModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvUser = new System.Windows.Forms.DataGridView();
            this.UserNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.DgvUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripStatusLabel1, this.toolStripSplitButton1, this.toolStripDropDownButton1, this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 712);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1368, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(195, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image) (resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(40, 28);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image) (resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(37, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 24);
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.TsBtnAdd, this.toolStripSeparator1, this.toolStripSeparator3, this.TsBtnModify, this.toolStripSeparator2, this.toolStripSeparator4, this.TsBtnDel, this.toolStripSeparator5, this.toolStripSeparator6, this.TsBtnExit});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1368, 63);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // TsBtnAdd
            // 
            this.TsBtnAdd.Image = ((System.Drawing.Image) (resources.GetObject("TsBtnAdd.Image")));
            this.TsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnAdd.Name = "TsBtnAdd";
            this.TsBtnAdd.Size = new System.Drawing.Size(74, 60);
            this.TsBtnAdd.Text = "添加";
            this.TsBtnAdd.Click += new System.EventHandler(this.TsBtnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 63);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 63);
            // 
            // TsBtnModify
            // 
            this.TsBtnModify.Image = ((System.Drawing.Image) (resources.GetObject("TsBtnModify.Image")));
            this.TsBtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnModify.Name = "TsBtnModify";
            this.TsBtnModify.Size = new System.Drawing.Size(74, 60);
            this.TsBtnModify.Text = "修改";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 63);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 63);
            // 
            // TsBtnDel
            // 
            this.TsBtnDel.Image = ((System.Drawing.Image) (resources.GetObject("TsBtnDel.Image")));
            this.TsBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnDel.Name = "TsBtnDel";
            this.TsBtnDel.Size = new System.Drawing.Size(74, 60);
            this.TsBtnDel.Text = "删除";
            this.TsBtnDel.Click += new System.EventHandler(this.TsBtnDel_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 63);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 63);
            // 
            // TsBtnExit
            // 
            this.TsBtnExit.Image = ((System.Drawing.Image) (resources.GetObject("TsBtnExit.Image")));
            this.TsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnExit.Name = "TsBtnExit";
            this.TsBtnExit.Size = new System.Drawing.Size(74, 60);
            this.TsBtnExit.Text = "退出";
            this.TsBtnExit.Click += new System.EventHandler(this.TsBtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(339, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 649);
            this.panel1.TabIndex = 4;
            // 
            // DgvUser
            // 
            this.DgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.UserNo, this.UserName, this.Telphone, this.RoleType, this.LoginTime, this.cStatus, this.Memo});
            this.DgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUser.Location = new System.Drawing.Point(0, 0);
            this.DgvUser.MultiSelect = false;
            this.DgvUser.Name = "DgvUser";
            this.DgvUser.RowHeadersVisible = false;
            this.DgvUser.RowHeadersWidth = 62;
            this.DgvUser.RowTemplate.Height = 30;
            this.DgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUser.Size = new System.Drawing.Size(1029, 649);
            this.DgvUser.TabIndex = 0;
            // 
            // UserNo
            // 
            this.UserNo.DataPropertyName = "UserNo";
            this.UserNo.FillWeight = 31.81818F;
            this.UserNo.HeaderText = "用户编号";
            this.UserNo.MaxInputLength = 50;
            this.UserNo.MinimumWidth = 8;
            this.UserNo.Name = "UserNo";
            this.UserNo.ReadOnly = true;
            this.UserNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "cUserName";
            this.UserName.FillWeight = 31.81818F;
            this.UserName.HeaderText = "用户名";
            this.UserName.MaxInputLength = 50;
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Telphone
            // 
            this.Telphone.DataPropertyName = "cTelPhone";
            this.Telphone.FillWeight = 31.81818F;
            this.Telphone.HeaderText = "电话号码";
            this.Telphone.MaxInputLength = 50;
            this.Telphone.MinimumWidth = 8;
            this.Telphone.Name = "Telphone";
            this.Telphone.ReadOnly = true;
            this.Telphone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RoleType
            // 
            this.RoleType.DataPropertyName = "nRoleType";
            this.RoleType.FillWeight = 31.81818F;
            this.RoleType.HeaderText = "角色类型";
            this.RoleType.MaxInputLength = 50;
            this.RoleType.MinimumWidth = 8;
            this.RoleType.Name = "RoleType";
            this.RoleType.ReadOnly = true;
            this.RoleType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LoginTime
            // 
            this.LoginTime.DataPropertyName = "cLoginTime";
            this.LoginTime.FillWeight = 300F;
            this.LoginTime.HeaderText = "登录时间";
            this.LoginTime.MaxInputLength = 100;
            this.LoginTime.MinimumWidth = 8;
            this.LoginTime.Name = "LoginTime";
            this.LoginTime.ReadOnly = true;
            this.LoginTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cStatus
            // 
            this.cStatus.DataPropertyName = "Status";
            this.cStatus.FillWeight = 31.81818F;
            this.cStatus.HeaderText = "状态";
            this.cStatus.MaxInputLength = 32766;
            this.cStatus.MinimumWidth = 8;
            this.cStatus.Name = "cStatus";
            this.cStatus.ReadOnly = true;
            this.cStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Memo
            // 
            this.Memo.DataPropertyName = "cMemo";
            this.Memo.FillWeight = 31.81818F;
            this.Memo.HeaderText = "备注";
            this.Memo.MaxInputLength = 32766;
            this.Memo.MinimumWidth = 8;
            this.Memo.Name = "Memo";
            this.Memo.ReadOnly = true;
            this.Memo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 649);
            this.panel2.TabIndex = 5;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(339, 649);
            this.webBrowser1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1368, 742);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainn";
            this.Load += new System.EventHandler(this.FrmMainn_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.DgvUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.WebBrowser webBrowser1;

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private UserDataSetTableAdapters.UserTableTableAdapter userTableTableAdapter;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStrip toolStrip2;
        private ToolStripButton TsBtnAdd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton TsBtnModify;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton TsBtnDel;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton TsBtnExit;
        private Panel panel1;
        public DataGridView DgvUser;
        private Panel panel2;
        private DataGridViewTextBoxColumn UserNo;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Telphone;
        private DataGridViewTextBoxColumn RoleType;
        private DataGridViewTextBoxColumn LoginTime;
        private DataGridViewTextBoxColumn cStatus;
        private DataGridViewTextBoxColumn Memo;
    }
}