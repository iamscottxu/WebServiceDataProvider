namespace Scottxu.WebServiceDataProvider.Demo
{
    partial class FormDemo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCode = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCodeURL = new System.Windows.Forms.TextBox();
            this.connectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelCodeURL = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxCodeUseDefaultCredentials = new System.Windows.Forms.CheckBox();
            this.labelCodeUserName = new System.Windows.Forms.Label();
            this.textBoxCodeUserName = new System.Windows.Forms.TextBox();
            this.labelCodePassword = new System.Windows.Forms.Label();
            this.textCodeBoxPassword = new System.Windows.Forms.TextBox();
            this.labelCodeDomain = new System.Windows.Forms.Label();
            this.textCodeBoxDomain = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCodeCode = new System.Windows.Forms.Label();
            this.textEditorControlCodeCode = new ICSharpCode.TextEditor.TextEditorControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCodeQuery = new System.Windows.Forms.Button();
            this.buttonCodeParameters = new System.Windows.Forms.Button();
            this.buttonCodeResult = new System.Windows.Forms.Button();
            this.buttonCodeErrorList = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPageCode.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageCode);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(978, 744);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageCode
            // 
            this.tabPageCode.Controls.Add(this.tableLayoutPanel1);
            this.tabPageCode.Location = new System.Drawing.Point(4, 28);
            this.tabPageCode.Name = "tabPageCode";
            this.tabPageCode.Padding = new System.Windows.Forms.Padding(20);
            this.tabPageCode.Size = new System.Drawing.Size(970, 712);
            this.tabPageCode.TabIndex = 0;
            this.tabPageCode.Text = "动态编译代码调用";
            this.tabPageCode.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 672);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxCodeURL, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelCodeURL, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(924, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBoxCodeURL
            // 
            this.textBoxCodeURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCodeURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.connectionBindingSource, "URL", true));
            this.textBoxCodeURL.Location = new System.Drawing.Point(63, 3);
            this.textBoxCodeURL.Name = "textBoxCodeURL";
            this.textBoxCodeURL.Size = new System.Drawing.Size(858, 28);
            this.textBoxCodeURL.TabIndex = 1;
            // 
            // connectionBindingSource
            // 
            this.connectionBindingSource.DataSource = typeof(Scottxu.WebServiceDataProvider.Connection);
            // 
            // labelCodeURL
            // 
            this.labelCodeURL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCodeURL.AutoSize = true;
            this.labelCodeURL.Location = new System.Drawing.Point(4, 8);
            this.labelCodeURL.Name = "labelCodeURL";
            this.labelCodeURL.Size = new System.Drawing.Size(53, 18);
            this.labelCodeURL.TabIndex = 0;
            this.labelCodeURL.Text = "URL：";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.checkBoxCodeUseDefaultCredentials, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelCodeUserName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxCodeUserName, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelCodePassword, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.textCodeBoxPassword, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelCodeDomain, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textCodeBoxDomain, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(924, 74);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // checkBoxCodeUseDefaultCredentials
            // 
            this.checkBoxCodeUseDefaultCredentials.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxCodeUseDefaultCredentials.AutoSize = true;
            this.checkBoxCodeUseDefaultCredentials.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.connectionBindingSource, "UseDefaultCredentials", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCodeUseDefaultCredentials.Location = new System.Drawing.Point(3, 7);
            this.checkBoxCodeUseDefaultCredentials.Name = "checkBoxCodeUseDefaultCredentials";
            this.checkBoxCodeUseDefaultCredentials.Size = new System.Drawing.Size(194, 22);
            this.checkBoxCodeUseDefaultCredentials.TabIndex = 0;
            this.checkBoxCodeUseDefaultCredentials.Text = "不使用默认身份认证";
            this.checkBoxCodeUseDefaultCredentials.UseVisualStyleBackColor = true;
            // 
            // labelCodeUserName
            // 
            this.labelCodeUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCodeUserName.AutoSize = true;
            this.labelCodeUserName.Location = new System.Drawing.Point(207, 9);
            this.labelCodeUserName.Name = "labelCodeUserName";
            this.labelCodeUserName.Size = new System.Drawing.Size(80, 18);
            this.labelCodeUserName.TabIndex = 1;
            this.labelCodeUserName.Text = "用户名：";
            // 
            // textBoxCodeUserName
            // 
            this.textBoxCodeUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCodeUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.connectionBindingSource, "UserName", true));
            this.textBoxCodeUserName.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.connectionBindingSource, "UseDefaultCredentials", true));
            this.textBoxCodeUserName.Location = new System.Drawing.Point(293, 4);
            this.textBoxCodeUserName.Name = "textBoxCodeUserName";
            this.textBoxCodeUserName.Size = new System.Drawing.Size(266, 28);
            this.textBoxCodeUserName.TabIndex = 2;
            // 
            // labelCodePassword
            // 
            this.labelCodePassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCodePassword.AutoSize = true;
            this.labelCodePassword.Location = new System.Drawing.Point(587, 9);
            this.labelCodePassword.Name = "labelCodePassword";
            this.labelCodePassword.Size = new System.Drawing.Size(62, 18);
            this.labelCodePassword.TabIndex = 3;
            this.labelCodePassword.Text = "密码：";
            // 
            // textCodeBoxPassword
            // 
            this.textCodeBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textCodeBoxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.connectionBindingSource, "Password", true));
            this.textCodeBoxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.connectionBindingSource, "UseDefaultCredentials", true));
            this.textCodeBoxPassword.Location = new System.Drawing.Point(655, 4);
            this.textCodeBoxPassword.Name = "textCodeBoxPassword";
            this.textCodeBoxPassword.Size = new System.Drawing.Size(266, 28);
            this.textCodeBoxPassword.TabIndex = 4;
            // 
            // labelCodeDomain
            // 
            this.labelCodeDomain.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCodeDomain.AutoSize = true;
            this.labelCodeDomain.Location = new System.Drawing.Point(243, 46);
            this.labelCodeDomain.Name = "labelCodeDomain";
            this.labelCodeDomain.Size = new System.Drawing.Size(44, 18);
            this.labelCodeDomain.TabIndex = 5;
            this.labelCodeDomain.Text = "域：";
            // 
            // textCodeBoxDomain
            // 
            this.textCodeBoxDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textCodeBoxDomain.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.connectionBindingSource, "Domain", true));
            this.textCodeBoxDomain.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.connectionBindingSource, "UseDefaultCredentials", true));
            this.textCodeBoxDomain.Location = new System.Drawing.Point(293, 41);
            this.textCodeBoxDomain.Name = "textCodeBoxDomain";
            this.textCodeBoxDomain.Size = new System.Drawing.Size(266, 28);
            this.textCodeBoxDomain.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.labelCodeCode, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textEditorControlCodeCode, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(924, 491);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // labelCodeCode
            // 
            this.labelCodeCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCodeCode.AutoSize = true;
            this.labelCodeCode.Location = new System.Drawing.Point(3, 6);
            this.labelCodeCode.Name = "labelCodeCode";
            this.labelCodeCode.Size = new System.Drawing.Size(62, 18);
            this.labelCodeCode.TabIndex = 0;
            this.labelCodeCode.Text = "代码：";
            // 
            // textEditorControlCodeCode
            // 
            this.textEditorControlCodeCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEditorControlCodeCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditorControlCodeCode.IsReadOnly = false;
            this.textEditorControlCodeCode.Location = new System.Drawing.Point(3, 33);
            this.textEditorControlCodeCode.Name = "textEditorControlCodeCode";
            this.textEditorControlCodeCode.Size = new System.Drawing.Size(918, 455);
            this.textEditorControlCodeCode.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonCodeQuery);
            this.flowLayoutPanel1.Controls.Add(this.buttonCodeParameters);
            this.flowLayoutPanel1.Controls.Add(this.buttonCodeResult);
            this.flowLayoutPanel1.Controls.Add(this.buttonCodeErrorList);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 620);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(924, 49);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // buttonCodeQuery
            // 
            this.buttonCodeQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonCodeQuery.Location = new System.Drawing.Point(740, 8);
            this.buttonCodeQuery.Name = "buttonCodeQuery";
            this.buttonCodeQuery.Size = new System.Drawing.Size(181, 35);
            this.buttonCodeQuery.TabIndex = 3;
            this.buttonCodeQuery.Text = "调用WebService(&Q)";
            this.buttonCodeQuery.UseVisualStyleBackColor = true;
            this.buttonCodeQuery.Click += new System.EventHandler(this.buttonCodeQuery_Click);
            // 
            // buttonCodeParameters
            // 
            this.buttonCodeParameters.Location = new System.Drawing.Point(604, 8);
            this.buttonCodeParameters.Name = "buttonCodeParameters";
            this.buttonCodeParameters.Size = new System.Drawing.Size(130, 35);
            this.buttonCodeParameters.TabIndex = 2;
            this.buttonCodeParameters.Text = "参数列表(&P)";
            this.buttonCodeParameters.UseVisualStyleBackColor = true;
            this.buttonCodeParameters.Click += new System.EventHandler(this.buttonCodeParameters_Click);
            // 
            // buttonCodeResult
            // 
            this.buttonCodeResult.Location = new System.Drawing.Point(468, 8);
            this.buttonCodeResult.Name = "buttonCodeResult";
            this.buttonCodeResult.Size = new System.Drawing.Size(130, 35);
            this.buttonCodeResult.TabIndex = 1;
            this.buttonCodeResult.Text = "返回结果(&R)";
            this.buttonCodeResult.UseVisualStyleBackColor = true;
            // 
            // buttonCodeErrorList
            // 
            this.buttonCodeErrorList.Location = new System.Drawing.Point(332, 8);
            this.buttonCodeErrorList.Name = "buttonCodeErrorList";
            this.buttonCodeErrorList.Size = new System.Drawing.Size(130, 35);
            this.buttonCodeErrorList.TabIndex = 0;
            this.buttonCodeErrorList.Text = "错误列表(&E)";
            this.buttonCodeErrorList.UseVisualStyleBackColor = true;
            this.buttonCodeErrorList.Click += new System.EventHandler(this.buttonCodeErrorList_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(970, 712);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "方法名调用";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormDemo";
            this.Text = "WebServiceDataProvider Demo";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCode.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCode;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxCodeURL;
        private System.Windows.Forms.Label labelCodeURL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBoxCodeUseDefaultCredentials;
        private System.Windows.Forms.Label labelCodeUserName;
        private System.Windows.Forms.Label labelCodePassword;
        private System.Windows.Forms.Label labelCodeDomain;
        private System.Windows.Forms.TextBox textBoxCodeUserName;
        private System.Windows.Forms.TextBox textCodeBoxPassword;
        private System.Windows.Forms.TextBox textCodeBoxDomain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelCodeCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonCodeQuery;
        private System.Windows.Forms.Button buttonCodeResult;
        private System.Windows.Forms.Button buttonCodeErrorList;
        private ICSharpCode.TextEditor.TextEditorControl textEditorControlCodeCode;
        private System.Windows.Forms.BindingSource connectionBindingSource;
        private System.Windows.Forms.Button buttonCodeParameters;
    }
}

