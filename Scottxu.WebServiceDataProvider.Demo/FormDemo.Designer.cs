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
            this.tableLayoutPanelCode = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelCodeURL = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCodeURL = new System.Windows.Forms.TextBox();
            this.connectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelCodeURL = new System.Windows.Forms.Label();
            this.tableLayoutPanelCodeCredentials = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxCodeUseDefaultCredentials = new System.Windows.Forms.CheckBox();
            this.labelCodeUserName = new System.Windows.Forms.Label();
            this.textBoxCodeUserName = new System.Windows.Forms.TextBox();
            this.labelCodePassword = new System.Windows.Forms.Label();
            this.textCodeBoxPassword = new System.Windows.Forms.TextBox();
            this.labelCodeDomain = new System.Windows.Forms.Label();
            this.textCodeBoxDomain = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelCodeCode = new System.Windows.Forms.TableLayoutPanel();
            this.labelCodeCode = new System.Windows.Forms.Label();
            this.textEditorControlCodeCode = new ICSharpCode.TextEditor.TextEditorControl();
            this.flowLayoutPanelCodeButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCodeQuery = new System.Windows.Forms.Button();
            this.buttonCodeParameters = new System.Windows.Forms.Button();
            this.buttonCodeResult = new System.Windows.Forms.Button();
            this.buttonCodeErrorList = new System.Windows.Forms.Button();
            this.tabPageMethod = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelMethod = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMethodURL = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxMethodURL = new System.Windows.Forms.TextBox();
            this.labelMethodURL = new System.Windows.Forms.Label();
            this.tableLayoutPanelMethodCredentials = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxMethodUseDefaultCredentials = new System.Windows.Forms.CheckBox();
            this.labelMethodUserName = new System.Windows.Forms.Label();
            this.textBoxMethodUserName = new System.Windows.Forms.TextBox();
            this.labelMethodPassword = new System.Windows.Forms.Label();
            this.textBoxMethodPassword = new System.Windows.Forms.TextBox();
            this.labelMethoeDomain = new System.Windows.Forms.Label();
            this.textBoxMethodDomain = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMethodParameters = new System.Windows.Forms.TableLayoutPanel();
            this.labelMethodParameters = new System.Windows.Forms.Label();
            this.dataGridViewMethodParameters = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelMethodButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonMethodQuery = new System.Windows.Forms.Button();
            this.buttonMethodResult = new System.Windows.Forms.Button();
            this.buttonMethodErrorList = new System.Windows.Forms.Button();
            this.tableLayoutPanelMethodMethod = new System.Windows.Forms.TableLayoutPanel();
            this.labelMethodMethod = new System.Windows.Forms.Label();
            this.buttonMethodMethodRefresh = new System.Windows.Forms.Button();
            this.comboBoxMethodMedthod = new System.Windows.Forms.ComboBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageCode.SuspendLayout();
            this.tableLayoutPanelCode.SuspendLayout();
            this.tableLayoutPanelCodeURL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).BeginInit();
            this.tableLayoutPanelCodeCredentials.SuspendLayout();
            this.tableLayoutPanelCodeCode.SuspendLayout();
            this.flowLayoutPanelCodeButtons.SuspendLayout();
            this.tabPageMethod.SuspendLayout();
            this.tableLayoutPanelMethod.SuspendLayout();
            this.tableLayoutPanelMethodURL.SuspendLayout();
            this.tableLayoutPanelMethodCredentials.SuspendLayout();
            this.tableLayoutPanelMethodParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMethodParameters)).BeginInit();
            this.flowLayoutPanelMethodButtons.SuspendLayout();
            this.tableLayoutPanelMethodMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageCode);
            this.tabControlMain.Controls.Add(this.tabPageMethod);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(978, 744);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageCode
            // 
            this.tabPageCode.Controls.Add(this.tableLayoutPanelCode);
            this.tabPageCode.Location = new System.Drawing.Point(4, 28);
            this.tabPageCode.Name = "tabPageCode";
            this.tabPageCode.Padding = new System.Windows.Forms.Padding(20);
            this.tabPageCode.Size = new System.Drawing.Size(970, 712);
            this.tabPageCode.TabIndex = 0;
            this.tabPageCode.Text = "动态编译代码调用";
            this.tabPageCode.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCode
            // 
            this.tableLayoutPanelCode.ColumnCount = 1;
            this.tableLayoutPanelCode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCode.Controls.Add(this.tableLayoutPanelCodeURL, 0, 0);
            this.tableLayoutPanelCode.Controls.Add(this.tableLayoutPanelCodeCredentials, 0, 1);
            this.tableLayoutPanelCode.Controls.Add(this.tableLayoutPanelCodeCode, 0, 2);
            this.tableLayoutPanelCode.Controls.Add(this.flowLayoutPanelCodeButtons, 0, 3);
            this.tableLayoutPanelCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCode.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanelCode.Name = "tableLayoutPanelCode";
            this.tableLayoutPanelCode.RowCount = 4;
            this.tableLayoutPanelCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelCode.Size = new System.Drawing.Size(930, 672);
            this.tableLayoutPanelCode.TabIndex = 0;
            // 
            // tableLayoutPanelCodeURL
            // 
            this.tableLayoutPanelCodeURL.ColumnCount = 2;
            this.tableLayoutPanelCodeURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelCodeURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCodeURL.Controls.Add(this.textBoxCodeURL, 1, 0);
            this.tableLayoutPanelCodeURL.Controls.Add(this.labelCodeURL, 0, 0);
            this.tableLayoutPanelCodeURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCodeURL.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelCodeURL.Name = "tableLayoutPanelCodeURL";
            this.tableLayoutPanelCodeURL.RowCount = 1;
            this.tableLayoutPanelCodeURL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCodeURL.Size = new System.Drawing.Size(924, 34);
            this.tableLayoutPanelCodeURL.TabIndex = 0;
            // 
            // textBoxCodeURL
            // 
            this.textBoxCodeURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCodeURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.connectionBindingSource, "URL", true));
            this.textBoxCodeURL.Location = new System.Drawing.Point(73, 3);
            this.textBoxCodeURL.Name = "textBoxCodeURL";
            this.textBoxCodeURL.Size = new System.Drawing.Size(848, 28);
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
            this.labelCodeURL.Location = new System.Drawing.Point(14, 8);
            this.labelCodeURL.Name = "labelCodeURL";
            this.labelCodeURL.Size = new System.Drawing.Size(53, 18);
            this.labelCodeURL.TabIndex = 0;
            this.labelCodeURL.Text = "URL：";
            // 
            // tableLayoutPanelCodeCredentials
            // 
            this.tableLayoutPanelCodeCredentials.ColumnCount = 5;
            this.tableLayoutPanelCodeCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelCodeCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelCodeCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCodeCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelCodeCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCodeCredentials.Controls.Add(this.checkBoxCodeUseDefaultCredentials, 0, 0);
            this.tableLayoutPanelCodeCredentials.Controls.Add(this.labelCodeUserName, 1, 0);
            this.tableLayoutPanelCodeCredentials.Controls.Add(this.textBoxCodeUserName, 2, 0);
            this.tableLayoutPanelCodeCredentials.Controls.Add(this.labelCodePassword, 3, 0);
            this.tableLayoutPanelCodeCredentials.Controls.Add(this.textCodeBoxPassword, 4, 0);
            this.tableLayoutPanelCodeCredentials.Controls.Add(this.labelCodeDomain, 1, 1);
            this.tableLayoutPanelCodeCredentials.Controls.Add(this.textCodeBoxDomain, 2, 1);
            this.tableLayoutPanelCodeCredentials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCodeCredentials.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanelCodeCredentials.Name = "tableLayoutPanelCodeCredentials";
            this.tableLayoutPanelCodeCredentials.RowCount = 2;
            this.tableLayoutPanelCodeCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCodeCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCodeCredentials.Size = new System.Drawing.Size(924, 74);
            this.tableLayoutPanelCodeCredentials.TabIndex = 1;
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
            // tableLayoutPanelCodeCode
            // 
            this.tableLayoutPanelCodeCode.ColumnCount = 1;
            this.tableLayoutPanelCodeCode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCodeCode.Controls.Add(this.labelCodeCode, 0, 0);
            this.tableLayoutPanelCodeCode.Controls.Add(this.textEditorControlCodeCode, 0, 1);
            this.tableLayoutPanelCodeCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCodeCode.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanelCodeCode.Name = "tableLayoutPanelCodeCode";
            this.tableLayoutPanelCodeCode.RowCount = 2;
            this.tableLayoutPanelCodeCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelCodeCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCodeCode.Size = new System.Drawing.Size(924, 491);
            this.tableLayoutPanelCodeCode.TabIndex = 2;
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
            // flowLayoutPanelCodeButtons
            // 
            this.flowLayoutPanelCodeButtons.Controls.Add(this.buttonCodeQuery);
            this.flowLayoutPanelCodeButtons.Controls.Add(this.buttonCodeParameters);
            this.flowLayoutPanelCodeButtons.Controls.Add(this.buttonCodeResult);
            this.flowLayoutPanelCodeButtons.Controls.Add(this.buttonCodeErrorList);
            this.flowLayoutPanelCodeButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCodeButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelCodeButtons.Location = new System.Drawing.Point(3, 620);
            this.flowLayoutPanelCodeButtons.Name = "flowLayoutPanelCodeButtons";
            this.flowLayoutPanelCodeButtons.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.flowLayoutPanelCodeButtons.Size = new System.Drawing.Size(924, 49);
            this.flowLayoutPanelCodeButtons.TabIndex = 3;
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
            this.buttonCodeResult.Text = "返回结果(&E)";
            this.buttonCodeResult.UseVisualStyleBackColor = true;
            this.buttonCodeResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonCodeErrorList
            // 
            this.buttonCodeErrorList.Location = new System.Drawing.Point(332, 8);
            this.buttonCodeErrorList.Name = "buttonCodeErrorList";
            this.buttonCodeErrorList.Size = new System.Drawing.Size(130, 35);
            this.buttonCodeErrorList.TabIndex = 0;
            this.buttonCodeErrorList.Text = "错误列表(&E)";
            this.buttonCodeErrorList.UseVisualStyleBackColor = true;
            this.buttonCodeErrorList.Click += new System.EventHandler(this.buttonErrorList_Click);
            // 
            // tabPageMethod
            // 
            this.tabPageMethod.Controls.Add(this.tableLayoutPanelMethod);
            this.tabPageMethod.Location = new System.Drawing.Point(4, 28);
            this.tabPageMethod.Name = "tabPageMethod";
            this.tabPageMethod.Padding = new System.Windows.Forms.Padding(20);
            this.tabPageMethod.Size = new System.Drawing.Size(970, 712);
            this.tabPageMethod.TabIndex = 1;
            this.tabPageMethod.Text = "方法名调用";
            this.tabPageMethod.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelMethod
            // 
            this.tableLayoutPanelMethod.ColumnCount = 1;
            this.tableLayoutPanelMethod.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMethod.Controls.Add(this.tableLayoutPanelMethodURL, 0, 0);
            this.tableLayoutPanelMethod.Controls.Add(this.tableLayoutPanelMethodCredentials, 0, 1);
            this.tableLayoutPanelMethod.Controls.Add(this.tableLayoutPanelMethodParameters, 0, 3);
            this.tableLayoutPanelMethod.Controls.Add(this.flowLayoutPanelMethodButtons, 0, 4);
            this.tableLayoutPanelMethod.Controls.Add(this.tableLayoutPanelMethodMethod, 0, 2);
            this.tableLayoutPanelMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMethod.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanelMethod.Name = "tableLayoutPanelMethod";
            this.tableLayoutPanelMethod.RowCount = 5;
            this.tableLayoutPanelMethod.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMethod.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelMethod.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMethod.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMethod.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelMethod.Size = new System.Drawing.Size(930, 672);
            this.tableLayoutPanelMethod.TabIndex = 0;
            // 
            // tableLayoutPanelMethodURL
            // 
            this.tableLayoutPanelMethodURL.ColumnCount = 2;
            this.tableLayoutPanelMethodURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelMethodURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMethodURL.Controls.Add(this.textBoxMethodURL, 1, 0);
            this.tableLayoutPanelMethodURL.Controls.Add(this.labelMethodURL, 0, 0);
            this.tableLayoutPanelMethodURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMethodURL.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelMethodURL.Name = "tableLayoutPanelMethodURL";
            this.tableLayoutPanelMethodURL.RowCount = 1;
            this.tableLayoutPanelMethodURL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMethodURL.Size = new System.Drawing.Size(924, 34);
            this.tableLayoutPanelMethodURL.TabIndex = 2;
            // 
            // textBoxMethodURL
            // 
            this.textBoxMethodURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMethodURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.connectionBindingSource, "URL", true));
            this.textBoxMethodURL.Location = new System.Drawing.Point(73, 3);
            this.textBoxMethodURL.Name = "textBoxMethodURL";
            this.textBoxMethodURL.Size = new System.Drawing.Size(848, 28);
            this.textBoxMethodURL.TabIndex = 0;
            // 
            // labelMethodURL
            // 
            this.labelMethodURL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMethodURL.AutoSize = true;
            this.labelMethodURL.Location = new System.Drawing.Point(14, 8);
            this.labelMethodURL.Name = "labelMethodURL";
            this.labelMethodURL.Size = new System.Drawing.Size(53, 18);
            this.labelMethodURL.TabIndex = 1;
            this.labelMethodURL.Text = "URL：";
            // 
            // tableLayoutPanelMethodCredentials
            // 
            this.tableLayoutPanelMethodCredentials.ColumnCount = 5;
            this.tableLayoutPanelMethodCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelMethodCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelMethodCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMethodCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelMethodCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMethodCredentials.Controls.Add(this.checkBoxMethodUseDefaultCredentials, 0, 0);
            this.tableLayoutPanelMethodCredentials.Controls.Add(this.labelMethodUserName, 1, 0);
            this.tableLayoutPanelMethodCredentials.Controls.Add(this.textBoxMethodUserName, 2, 0);
            this.tableLayoutPanelMethodCredentials.Controls.Add(this.labelMethodPassword, 3, 0);
            this.tableLayoutPanelMethodCredentials.Controls.Add(this.textBoxMethodPassword, 4, 0);
            this.tableLayoutPanelMethodCredentials.Controls.Add(this.labelMethoeDomain, 1, 1);
            this.tableLayoutPanelMethodCredentials.Controls.Add(this.textBoxMethodDomain, 2, 1);
            this.tableLayoutPanelMethodCredentials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMethodCredentials.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanelMethodCredentials.Name = "tableLayoutPanelMethodCredentials";
            this.tableLayoutPanelMethodCredentials.RowCount = 2;
            this.tableLayoutPanelMethodCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMethodCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMethodCredentials.Size = new System.Drawing.Size(924, 74);
            this.tableLayoutPanelMethodCredentials.TabIndex = 3;
            // 
            // checkBoxMethodUseDefaultCredentials
            // 
            this.checkBoxMethodUseDefaultCredentials.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxMethodUseDefaultCredentials.AutoSize = true;
            this.checkBoxMethodUseDefaultCredentials.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.connectionBindingSource, "UseDefaultCredentials", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxMethodUseDefaultCredentials.Location = new System.Drawing.Point(3, 7);
            this.checkBoxMethodUseDefaultCredentials.Name = "checkBoxMethodUseDefaultCredentials";
            this.checkBoxMethodUseDefaultCredentials.Size = new System.Drawing.Size(194, 22);
            this.checkBoxMethodUseDefaultCredentials.TabIndex = 0;
            this.checkBoxMethodUseDefaultCredentials.Text = "不使用默认身份认证";
            this.checkBoxMethodUseDefaultCredentials.UseVisualStyleBackColor = true;
            // 
            // labelMethodUserName
            // 
            this.labelMethodUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMethodUserName.AutoSize = true;
            this.labelMethodUserName.Location = new System.Drawing.Point(207, 9);
            this.labelMethodUserName.Name = "labelMethodUserName";
            this.labelMethodUserName.Size = new System.Drawing.Size(80, 18);
            this.labelMethodUserName.TabIndex = 1;
            this.labelMethodUserName.Text = "用户名：";
            // 
            // textBoxMethodUserName
            // 
            this.textBoxMethodUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMethodUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.connectionBindingSource, "UserName", true));
            this.textBoxMethodUserName.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.connectionBindingSource, "UseDefaultCredentials", true));
            this.textBoxMethodUserName.Location = new System.Drawing.Point(293, 4);
            this.textBoxMethodUserName.Name = "textBoxMethodUserName";
            this.textBoxMethodUserName.Size = new System.Drawing.Size(266, 28);
            this.textBoxMethodUserName.TabIndex = 2;
            // 
            // labelMethodPassword
            // 
            this.labelMethodPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMethodPassword.AutoSize = true;
            this.labelMethodPassword.Location = new System.Drawing.Point(587, 9);
            this.labelMethodPassword.Name = "labelMethodPassword";
            this.labelMethodPassword.Size = new System.Drawing.Size(62, 18);
            this.labelMethodPassword.TabIndex = 3;
            this.labelMethodPassword.Text = "密码：";
            // 
            // textBoxMethodPassword
            // 
            this.textBoxMethodPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMethodPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.connectionBindingSource, "Password", true));
            this.textBoxMethodPassword.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.connectionBindingSource, "UseDefaultCredentials", true));
            this.textBoxMethodPassword.Location = new System.Drawing.Point(655, 4);
            this.textBoxMethodPassword.Name = "textBoxMethodPassword";
            this.textBoxMethodPassword.Size = new System.Drawing.Size(266, 28);
            this.textBoxMethodPassword.TabIndex = 4;
            // 
            // labelMethoeDomain
            // 
            this.labelMethoeDomain.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMethoeDomain.AutoSize = true;
            this.labelMethoeDomain.Location = new System.Drawing.Point(243, 46);
            this.labelMethoeDomain.Name = "labelMethoeDomain";
            this.labelMethoeDomain.Size = new System.Drawing.Size(44, 18);
            this.labelMethoeDomain.TabIndex = 5;
            this.labelMethoeDomain.Text = "域：";
            // 
            // textBoxMethodDomain
            // 
            this.textBoxMethodDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMethodDomain.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.connectionBindingSource, "Domain", true));
            this.textBoxMethodDomain.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.connectionBindingSource, "UseDefaultCredentials", true));
            this.textBoxMethodDomain.Location = new System.Drawing.Point(293, 41);
            this.textBoxMethodDomain.Name = "textBoxMethodDomain";
            this.textBoxMethodDomain.Size = new System.Drawing.Size(266, 28);
            this.textBoxMethodDomain.TabIndex = 6;
            // 
            // tableLayoutPanelMethodParameters
            // 
            this.tableLayoutPanelMethodParameters.ColumnCount = 1;
            this.tableLayoutPanelMethodParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMethodParameters.Controls.Add(this.labelMethodParameters, 0, 0);
            this.tableLayoutPanelMethodParameters.Controls.Add(this.dataGridViewMethodParameters, 0, 1);
            this.tableLayoutPanelMethodParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMethodParameters.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanelMethodParameters.Name = "tableLayoutPanelMethodParameters";
            this.tableLayoutPanelMethodParameters.RowCount = 2;
            this.tableLayoutPanelMethodParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMethodParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMethodParameters.Size = new System.Drawing.Size(924, 451);
            this.tableLayoutPanelMethodParameters.TabIndex = 0;
            // 
            // labelMethodParameters
            // 
            this.labelMethodParameters.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMethodParameters.AutoSize = true;
            this.labelMethodParameters.Location = new System.Drawing.Point(3, 6);
            this.labelMethodParameters.Name = "labelMethodParameters";
            this.labelMethodParameters.Size = new System.Drawing.Size(62, 18);
            this.labelMethodParameters.TabIndex = 0;
            this.labelMethodParameters.Text = "参数：";
            // 
            // dataGridViewMethodParameters
            // 
            this.dataGridViewMethodParameters.AllowUserToAddRows = false;
            this.dataGridViewMethodParameters.AllowUserToDeleteRows = false;
            this.dataGridViewMethodParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMethodParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMethodParameters.Location = new System.Drawing.Point(3, 33);
            this.dataGridViewMethodParameters.Name = "dataGridViewMethodParameters";
            this.dataGridViewMethodParameters.RowTemplate.Height = 30;
            this.dataGridViewMethodParameters.Size = new System.Drawing.Size(918, 415);
            this.dataGridViewMethodParameters.TabIndex = 1;
            // 
            // flowLayoutPanelMethodButtons
            // 
            this.flowLayoutPanelMethodButtons.Controls.Add(this.buttonMethodQuery);
            this.flowLayoutPanelMethodButtons.Controls.Add(this.buttonMethodResult);
            this.flowLayoutPanelMethodButtons.Controls.Add(this.buttonMethodErrorList);
            this.flowLayoutPanelMethodButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMethodButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelMethodButtons.Location = new System.Drawing.Point(3, 620);
            this.flowLayoutPanelMethodButtons.Name = "flowLayoutPanelMethodButtons";
            this.flowLayoutPanelMethodButtons.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.flowLayoutPanelMethodButtons.Size = new System.Drawing.Size(924, 49);
            this.flowLayoutPanelMethodButtons.TabIndex = 1;
            // 
            // buttonMethodQuery
            // 
            this.buttonMethodQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonMethodQuery.Location = new System.Drawing.Point(740, 8);
            this.buttonMethodQuery.Name = "buttonMethodQuery";
            this.buttonMethodQuery.Size = new System.Drawing.Size(181, 35);
            this.buttonMethodQuery.TabIndex = 2;
            this.buttonMethodQuery.Text = "调用WebService(&Q)";
            this.buttonMethodQuery.UseVisualStyleBackColor = true;
            // 
            // buttonMethodResult
            // 
            this.buttonMethodResult.Location = new System.Drawing.Point(604, 8);
            this.buttonMethodResult.Name = "buttonMethodResult";
            this.buttonMethodResult.Size = new System.Drawing.Size(130, 35);
            this.buttonMethodResult.TabIndex = 1;
            this.buttonMethodResult.Text = "返回结果(&E)";
            this.buttonMethodResult.UseVisualStyleBackColor = true;
            this.buttonMethodResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonMethodErrorList
            // 
            this.buttonMethodErrorList.Location = new System.Drawing.Point(468, 8);
            this.buttonMethodErrorList.Name = "buttonMethodErrorList";
            this.buttonMethodErrorList.Size = new System.Drawing.Size(130, 35);
            this.buttonMethodErrorList.TabIndex = 0;
            this.buttonMethodErrorList.Text = "错误列表(&E)";
            this.buttonMethodErrorList.UseVisualStyleBackColor = true;
            this.buttonMethodErrorList.Click += new System.EventHandler(this.buttonErrorList_Click);
            // 
            // tableLayoutPanelMethodMethod
            // 
            this.tableLayoutPanelMethodMethod.ColumnCount = 3;
            this.tableLayoutPanelMethodMethod.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelMethodMethod.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMethodMethod.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMethodMethod.Controls.Add(this.labelMethodMethod, 0, 0);
            this.tableLayoutPanelMethodMethod.Controls.Add(this.buttonMethodMethodRefresh, 2, 0);
            this.tableLayoutPanelMethodMethod.Controls.Add(this.comboBoxMethodMedthod, 1, 0);
            this.tableLayoutPanelMethodMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMethodMethod.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanelMethodMethod.Name = "tableLayoutPanelMethodMethod";
            this.tableLayoutPanelMethodMethod.RowCount = 1;
            this.tableLayoutPanelMethodMethod.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMethodMethod.Size = new System.Drawing.Size(924, 34);
            this.tableLayoutPanelMethodMethod.TabIndex = 4;
            // 
            // labelMethodMethod
            // 
            this.labelMethodMethod.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMethodMethod.AutoSize = true;
            this.labelMethodMethod.Location = new System.Drawing.Point(5, 8);
            this.labelMethodMethod.Name = "labelMethodMethod";
            this.labelMethodMethod.Size = new System.Drawing.Size(62, 18);
            this.labelMethodMethod.TabIndex = 2;
            this.labelMethodMethod.Text = "方法：";
            // 
            // buttonMethodMethodRefresh
            // 
            this.buttonMethodMethodRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMethodMethodRefresh.Location = new System.Drawing.Point(824, 0);
            this.buttonMethodMethodRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMethodMethodRefresh.Name = "buttonMethodMethodRefresh";
            this.buttonMethodMethodRefresh.Size = new System.Drawing.Size(100, 34);
            this.buttonMethodMethodRefresh.TabIndex = 1;
            this.buttonMethodMethodRefresh.Text = "刷新(&R)";
            this.buttonMethodMethodRefresh.UseVisualStyleBackColor = true;
            // 
            // comboBoxMethodMedthod
            // 
            this.comboBoxMethodMedthod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMethodMedthod.FormattingEnabled = true;
            this.comboBoxMethodMedthod.Location = new System.Drawing.Point(73, 4);
            this.comboBoxMethodMedthod.Name = "comboBoxMethodMedthod";
            this.comboBoxMethodMedthod.Size = new System.Drawing.Size(748, 26);
            this.comboBoxMethodMedthod.TabIndex = 0;
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
            this.tableLayoutPanelCode.ResumeLayout(false);
            this.tableLayoutPanelCodeURL.ResumeLayout(false);
            this.tableLayoutPanelCodeURL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).EndInit();
            this.tableLayoutPanelCodeCredentials.ResumeLayout(false);
            this.tableLayoutPanelCodeCredentials.PerformLayout();
            this.tableLayoutPanelCodeCode.ResumeLayout(false);
            this.tableLayoutPanelCodeCode.PerformLayout();
            this.flowLayoutPanelCodeButtons.ResumeLayout(false);
            this.tabPageMethod.ResumeLayout(false);
            this.tableLayoutPanelMethod.ResumeLayout(false);
            this.tableLayoutPanelMethodURL.ResumeLayout(false);
            this.tableLayoutPanelMethodURL.PerformLayout();
            this.tableLayoutPanelMethodCredentials.ResumeLayout(false);
            this.tableLayoutPanelMethodCredentials.PerformLayout();
            this.tableLayoutPanelMethodParameters.ResumeLayout(false);
            this.tableLayoutPanelMethodParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMethodParameters)).EndInit();
            this.flowLayoutPanelMethodButtons.ResumeLayout(false);
            this.tableLayoutPanelMethodMethod.ResumeLayout(false);
            this.tableLayoutPanelMethodMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCode;
        private System.Windows.Forms.TabPage tabPageMethod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCodeURL;
        private System.Windows.Forms.TextBox textBoxCodeURL;
        private System.Windows.Forms.Label labelCodeURL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCodeCredentials;
        private System.Windows.Forms.CheckBox checkBoxCodeUseDefaultCredentials;
        private System.Windows.Forms.Label labelCodeUserName;
        private System.Windows.Forms.Label labelCodePassword;
        private System.Windows.Forms.Label labelCodeDomain;
        private System.Windows.Forms.TextBox textBoxCodeUserName;
        private System.Windows.Forms.TextBox textCodeBoxPassword;
        private System.Windows.Forms.TextBox textCodeBoxDomain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCodeCode;
        private System.Windows.Forms.Label labelCodeCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCodeButtons;
        private System.Windows.Forms.Button buttonCodeQuery;
        private System.Windows.Forms.Button buttonCodeResult;
        private System.Windows.Forms.Button buttonCodeErrorList;
        private ICSharpCode.TextEditor.TextEditorControl textEditorControlCodeCode;
        private System.Windows.Forms.BindingSource connectionBindingSource;
        private System.Windows.Forms.Button buttonCodeParameters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMethod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMethodURL;
        private System.Windows.Forms.TextBox textBoxMethodURL;
        private System.Windows.Forms.Label labelMethodURL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMethodCredentials;
        private System.Windows.Forms.CheckBox checkBoxMethodUseDefaultCredentials;
        private System.Windows.Forms.Label labelMethodUserName;
        private System.Windows.Forms.TextBox textBoxMethodUserName;
        private System.Windows.Forms.Label labelMethodPassword;
        private System.Windows.Forms.TextBox textBoxMethodPassword;
        private System.Windows.Forms.Label labelMethoeDomain;
        private System.Windows.Forms.TextBox textBoxMethodDomain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMethodParameters;
        private System.Windows.Forms.Label labelMethodParameters;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMethodButtons;
        private System.Windows.Forms.Button buttonMethodQuery;
        private System.Windows.Forms.Button buttonMethodResult;
        private System.Windows.Forms.Button buttonMethodErrorList;
        private System.Windows.Forms.DataGridView dataGridViewMethodParameters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMethodMethod;
        private System.Windows.Forms.Label labelMethodMethod;
        private System.Windows.Forms.Button buttonMethodMethodRefresh;
        private System.Windows.Forms.ComboBox comboBoxMethodMedthod;
    }
}

