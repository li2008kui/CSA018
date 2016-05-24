using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ThisCoder.CSA018WinExample
{
    partial class Generater
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private IContainer components = null;

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
            btnCheck = new Button();
            btnGenerate = new Button();
            btnReset = new Button();
            txtMessage2 = new TextBox();
            txtMessage1 = new TextBox();
            btnAddOrMoveParameter10 = new Button();
            btnAddOrMoveParameter9 = new Button();
            ckbParameterHex10 = new CheckBox();
            ckbParameter10 = new CheckBox();
            txtParameterValue10 = new TextBox();
            cboxParameterType10 = new ComboBox();
            ckbParameterHex9 = new CheckBox();
            ckbParameter9 = new CheckBox();
            txtParameterValue9 = new TextBox();
            cboxParameterType9 = new ComboBox();
            btnAddOrMoveParameter8 = new Button();
            btnAddOrMoveParameter7 = new Button();
            label8 = new Label();
            txtErrorInfo = new TextBox();
            cboxErrorCode = new ComboBox();
            gbErrorCodeAndInfo = new GroupBox();
            label7 = new Label();
            ckbParameterHex8 = new CheckBox();
            ckbParameter8 = new CheckBox();
            txtParameterValue8 = new TextBox();
            cboxParameterType8 = new ComboBox();
            ckbParameterHex7 = new CheckBox();
            ckbParameter7 = new CheckBox();
            txtParameterValue7 = new TextBox();
            cboxParameterType7 = new ComboBox();
            btnAddOrMoveParameter6 = new Button();
            btnAddOrMoveParameter5 = new Button();
            btnAddOrMoveParameter4 = new Button();
            ckbParameterHex6 = new CheckBox();
            ckbParameter6 = new CheckBox();
            txtParameterValue6 = new TextBox();
            cboxParameterType6 = new ComboBox();
            ckbParameterHex5 = new CheckBox();
            rb0x = new RadioButton();
            panel1 = new Panel();
            rbComma = new RadioButton();
            rbNone = new RadioButton();
            rbBlank = new RadioButton();
            ckbParameter5 = new CheckBox();
            gbParameterList = new GroupBox();
            txtParameterValue5 = new TextBox();
            cboxParameterType5 = new ComboBox();
            ckbParameterHex4 = new CheckBox();
            ckbParameter4 = new CheckBox();
            txtParameterValue4 = new TextBox();
            cboxParameterType4 = new ComboBox();
            btnAddOrMoveParameter3 = new Button();
            btnAddOrMoveParameter2 = new Button();
            btnAddOrMoveParameter1 = new Button();
            ckbParameterHex3 = new CheckBox();
            ckbParameter3 = new CheckBox();
            txtParameterValue3 = new TextBox();
            cboxParameterType3 = new ComboBox();
            ckbParameterHex2 = new CheckBox();
            ckbParameter2 = new CheckBox();
            txtParameterValue2 = new TextBox();
            cboxParameterType2 = new ComboBox();
            ckbParameterHex1 = new CheckBox();
            ckbParameter1 = new CheckBox();
            txtParameterValue1 = new TextBox();
            label6 = new Label();
            cboxParameterType1 = new ComboBox();
            label5 = new Label();
            cboxMessageId = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            cboxMessageType = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtLuminaireId = new TextBox();
            txtGatewayId = new TextBox();
            gbErrorCodeAndInfo.SuspendLayout();
            panel1.SuspendLayout();
            gbParameterList.SuspendLayout();
            SuspendLayout();
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(707, 153);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(30, 40);
            btnCheck.TabIndex = 32;
            btnCheck.Text = "↓";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Visible = false;
            btnCheck.Click += new EventHandler(btnCheck_Click);
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(592, 153);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 40);
            btnGenerate.TabIndex = 31;
            btnGenerate.Text = "生成";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += new EventHandler(btnGenerate_Click);
            // 
            // btnReset
            // 
            btnReset.Location = new Point(499, 153);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 40);
            btnReset.TabIndex = 30;
            btnReset.Text = "重置";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += new EventHandler(btnReset_Click);
            // 
            // txtMessage2
            // 
            txtMessage2.Location = new Point(499, 200);
            txtMessage2.Multiline = true;
            txtMessage2.Name = "txtMessage2";
            txtMessage2.ScrollBars = ScrollBars.Vertical;
            txtMessage2.Size = new Size(273, 350);
            txtMessage2.TabIndex = 29;
            // 
            // txtMessage1
            // 
            txtMessage1.Location = new Point(318, 12);
            txtMessage1.Multiline = true;
            txtMessage1.Name = "txtMessage1";
            txtMessage1.ScrollBars = ScrollBars.Vertical;
            txtMessage1.Size = new Size(454, 96);
            txtMessage1.TabIndex = 28;
            // 
            // btnAddOrMoveParameter10
            // 
            btnAddOrMoveParameter10.Location = new Point(410, 369);
            btnAddOrMoveParameter10.Name = "btnAddOrMoveParameter10";
            btnAddOrMoveParameter10.Size = new Size(27, 23);
            btnAddOrMoveParameter10.TabIndex = 52;
            btnAddOrMoveParameter10.Text = "+";
            btnAddOrMoveParameter10.UseVisualStyleBackColor = true;
            btnAddOrMoveParameter10.Visible = false;
            btnAddOrMoveParameter10.Click += new EventHandler(btnAddOrMoveParameter_Click);
            // 
            // btnAddOrMoveParameter9
            // 
            btnAddOrMoveParameter9.Location = new Point(410, 334);
            btnAddOrMoveParameter9.Name = "btnAddOrMoveParameter9";
            btnAddOrMoveParameter9.Size = new Size(27, 23);
            btnAddOrMoveParameter9.TabIndex = 51;
            btnAddOrMoveParameter9.Text = "+";
            btnAddOrMoveParameter9.UseVisualStyleBackColor = true;
            btnAddOrMoveParameter9.Visible = false;
            btnAddOrMoveParameter9.Click += new EventHandler(btnAddOrMoveParameter_Click);
            // 
            // ckbParameterHex10
            // 
            ckbParameterHex10.AutoSize = true;
            ckbParameterHex10.Location = new Point(362, 373);
            ckbParameterHex10.Name = "ckbParameterHex10";
            ckbParameterHex10.Size = new Size(42, 16);
            ckbParameterHex10.TabIndex = 50;
            ckbParameterHex10.Text = "Hex";
            ckbParameterHex10.UseVisualStyleBackColor = true;
            ckbParameterHex10.Visible = false;
            ckbParameterHex10.CheckedChanged += new EventHandler(ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter10
            // 
            ckbParameter10.AutoSize = true;
            ckbParameter10.Location = new Point(13, 373);
            ckbParameter10.Name = "ckbParameter10";
            ckbParameter10.Size = new Size(15, 14);
            ckbParameter10.TabIndex = 49;
            ckbParameter10.UseVisualStyleBackColor = true;
            ckbParameter10.Visible = false;
            // 
            // txtParameterValue10
            // 
            txtParameterValue10.Location = new Point(160, 369);
            txtParameterValue10.MaxLength = 256;
            txtParameterValue10.Name = "txtParameterValue10";
            txtParameterValue10.Size = new Size(196, 21);
            txtParameterValue10.TabIndex = 48;
            txtParameterValue10.Visible = false;
            txtParameterValue10.TextChanged += new EventHandler(txtParameterValue_TextChanged);
            txtParameterValue10.KeyPress += new KeyPressEventHandler(checkHexString_KeyPress);
            // 
            // cboxParameterType10
            // 
            cboxParameterType10.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxParameterType10.FormattingEnabled = true;
            cboxParameterType10.Location = new Point(34, 370);
            cboxParameterType10.Name = "cboxParameterType10";
            cboxParameterType10.Size = new Size(120, 20);
            cboxParameterType10.TabIndex = 47;
            cboxParameterType10.Visible = false;
            cboxParameterType10.SelectedIndexChanged += new EventHandler(cboxParameterType_SelectedIndexChanged);
            // 
            // ckbParameterHex9
            // 
            ckbParameterHex9.AutoSize = true;
            ckbParameterHex9.Location = new Point(362, 338);
            ckbParameterHex9.Name = "ckbParameterHex9";
            ckbParameterHex9.Size = new Size(42, 16);
            ckbParameterHex9.TabIndex = 46;
            ckbParameterHex9.Text = "Hex";
            ckbParameterHex9.UseVisualStyleBackColor = true;
            ckbParameterHex9.Visible = false;
            ckbParameterHex9.CheckedChanged += new EventHandler(ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter9
            // 
            ckbParameter9.AutoSize = true;
            ckbParameter9.Location = new Point(13, 338);
            ckbParameter9.Name = "ckbParameter9";
            ckbParameter9.Size = new Size(15, 14);
            ckbParameter9.TabIndex = 45;
            ckbParameter9.UseVisualStyleBackColor = true;
            ckbParameter9.Visible = false;
            // 
            // txtParameterValue9
            // 
            txtParameterValue9.Location = new Point(160, 334);
            txtParameterValue9.MaxLength = 256;
            txtParameterValue9.Name = "txtParameterValue9";
            txtParameterValue9.Size = new Size(196, 21);
            txtParameterValue9.TabIndex = 44;
            txtParameterValue9.Visible = false;
            txtParameterValue9.TextChanged += new EventHandler(txtParameterValue_TextChanged);
            txtParameterValue9.KeyPress += new KeyPressEventHandler(checkHexString_KeyPress);
            // 
            // cboxParameterType9
            // 
            cboxParameterType9.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxParameterType9.FormattingEnabled = true;
            cboxParameterType9.Location = new Point(34, 335);
            cboxParameterType9.Name = "cboxParameterType9";
            cboxParameterType9.Size = new Size(120, 20);
            cboxParameterType9.TabIndex = 43;
            cboxParameterType9.Visible = false;
            cboxParameterType9.SelectedIndexChanged += new EventHandler(cboxParameterType_SelectedIndexChanged);
            // 
            // btnAddOrMoveParameter8
            // 
            btnAddOrMoveParameter8.Location = new Point(410, 299);
            btnAddOrMoveParameter8.Name = "btnAddOrMoveParameter8";
            btnAddOrMoveParameter8.Size = new Size(27, 23);
            btnAddOrMoveParameter8.TabIndex = 42;
            btnAddOrMoveParameter8.Text = "+";
            btnAddOrMoveParameter8.UseVisualStyleBackColor = true;
            btnAddOrMoveParameter8.Visible = false;
            btnAddOrMoveParameter8.Click += new EventHandler(btnAddOrMoveParameter_Click);
            // 
            // btnAddOrMoveParameter7
            // 
            btnAddOrMoveParameter7.Location = new Point(410, 264);
            btnAddOrMoveParameter7.Name = "btnAddOrMoveParameter7";
            btnAddOrMoveParameter7.Size = new Size(27, 23);
            btnAddOrMoveParameter7.TabIndex = 41;
            btnAddOrMoveParameter7.Text = "+";
            btnAddOrMoveParameter7.UseVisualStyleBackColor = true;
            btnAddOrMoveParameter7.Visible = false;
            btnAddOrMoveParameter7.Click += new EventHandler(btnAddOrMoveParameter_Click);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 97);
            label8.Name = "label8";
            label8.Size = new Size(53, 12);
            label8.TabIndex = 5;
            label8.Text = "错误信息";
            // 
            // txtErrorInfo
            // 
            txtErrorInfo.Location = new Point(93, 86);
            txtErrorInfo.Multiline = true;
            txtErrorInfo.Name = "txtErrorInfo";
            txtErrorInfo.Size = new Size(176, 68);
            txtErrorInfo.TabIndex = 3;
            txtErrorInfo.Text = "成功";
            // 
            // cboxErrorCode
            // 
            cboxErrorCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxErrorCode.FormattingEnabled = true;
            cboxErrorCode.Location = new Point(93, 52);
            cboxErrorCode.Name = "cboxErrorCode";
            cboxErrorCode.Size = new Size(176, 20);
            cboxErrorCode.TabIndex = 2;
            // 
            // gbErrorCodeAndInfo
            // 
            gbErrorCodeAndInfo.Controls.Add(label8);
            gbErrorCodeAndInfo.Controls.Add(label7);
            gbErrorCodeAndInfo.Controls.Add(txtErrorInfo);
            gbErrorCodeAndInfo.Controls.Add(cboxErrorCode);
            gbErrorCodeAndInfo.Location = new Point(14, 143);
            gbErrorCodeAndInfo.Name = "gbErrorCodeAndInfo";
            gbErrorCodeAndInfo.Size = new Size(448, 407);
            gbErrorCodeAndInfo.TabIndex = 34;
            gbErrorCodeAndInfo.TabStop = false;
            gbErrorCodeAndInfo.Text = "返回结果";
            gbErrorCodeAndInfo.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 55);
            label7.Name = "label7";
            label7.Size = new Size(53, 12);
            label7.TabIndex = 4;
            label7.Text = "错误代码";
            // 
            // ckbParameterHex8
            // 
            ckbParameterHex8.AutoSize = true;
            ckbParameterHex8.Location = new Point(362, 303);
            ckbParameterHex8.Name = "ckbParameterHex8";
            ckbParameterHex8.Size = new Size(42, 16);
            ckbParameterHex8.TabIndex = 40;
            ckbParameterHex8.Text = "Hex";
            ckbParameterHex8.UseVisualStyleBackColor = true;
            ckbParameterHex8.Visible = false;
            ckbParameterHex8.CheckedChanged += new EventHandler(ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter8
            // 
            ckbParameter8.AutoSize = true;
            ckbParameter8.Location = new Point(13, 303);
            ckbParameter8.Name = "ckbParameter8";
            ckbParameter8.Size = new Size(15, 14);
            ckbParameter8.TabIndex = 39;
            ckbParameter8.UseVisualStyleBackColor = true;
            ckbParameter8.Visible = false;
            // 
            // txtParameterValue8
            // 
            txtParameterValue8.Location = new Point(160, 299);
            txtParameterValue8.MaxLength = 256;
            txtParameterValue8.Name = "txtParameterValue8";
            txtParameterValue8.Size = new Size(196, 21);
            txtParameterValue8.TabIndex = 38;
            txtParameterValue8.Visible = false;
            txtParameterValue8.TextChanged += new EventHandler(txtParameterValue_TextChanged);
            txtParameterValue8.KeyPress += new KeyPressEventHandler(checkHexString_KeyPress);
            // 
            // cboxParameterType8
            // 
            cboxParameterType8.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxParameterType8.FormattingEnabled = true;
            cboxParameterType8.Location = new Point(34, 300);
            cboxParameterType8.Name = "cboxParameterType8";
            cboxParameterType8.Size = new Size(120, 20);
            cboxParameterType8.TabIndex = 37;
            cboxParameterType8.Visible = false;
            cboxParameterType8.SelectedIndexChanged += new EventHandler(cboxParameterType_SelectedIndexChanged);
            // 
            // ckbParameterHex7
            // 
            ckbParameterHex7.AutoSize = true;
            ckbParameterHex7.Location = new Point(362, 268);
            ckbParameterHex7.Name = "ckbParameterHex7";
            ckbParameterHex7.Size = new Size(42, 16);
            ckbParameterHex7.TabIndex = 36;
            ckbParameterHex7.Text = "Hex";
            ckbParameterHex7.UseVisualStyleBackColor = true;
            ckbParameterHex7.Visible = false;
            ckbParameterHex7.CheckedChanged += new EventHandler(ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter7
            // 
            ckbParameter7.AutoSize = true;
            ckbParameter7.Location = new Point(13, 268);
            ckbParameter7.Name = "ckbParameter7";
            ckbParameter7.Size = new Size(15, 14);
            ckbParameter7.TabIndex = 35;
            ckbParameter7.UseVisualStyleBackColor = true;
            ckbParameter7.Visible = false;
            // 
            // txtParameterValue7
            // 
            txtParameterValue7.Location = new Point(160, 264);
            txtParameterValue7.MaxLength = 256;
            txtParameterValue7.Name = "txtParameterValue7";
            txtParameterValue7.Size = new Size(196, 21);
            txtParameterValue7.TabIndex = 34;
            txtParameterValue7.Visible = false;
            txtParameterValue7.TextChanged += new EventHandler(txtParameterValue_TextChanged);
            txtParameterValue7.KeyPress += new KeyPressEventHandler(checkHexString_KeyPress);
            // 
            // cboxParameterType7
            // 
            cboxParameterType7.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxParameterType7.FormattingEnabled = true;
            cboxParameterType7.Location = new Point(34, 265);
            cboxParameterType7.Name = "cboxParameterType7";
            cboxParameterType7.Size = new Size(120, 20);
            cboxParameterType7.TabIndex = 33;
            cboxParameterType7.Visible = false;
            cboxParameterType7.SelectedIndexChanged += new EventHandler(cboxParameterType_SelectedIndexChanged);
            // 
            // btnAddOrMoveParameter6
            // 
            btnAddOrMoveParameter6.Location = new Point(410, 229);
            btnAddOrMoveParameter6.Name = "btnAddOrMoveParameter6";
            btnAddOrMoveParameter6.Size = new Size(27, 23);
            btnAddOrMoveParameter6.TabIndex = 32;
            btnAddOrMoveParameter6.Text = "+";
            btnAddOrMoveParameter6.UseVisualStyleBackColor = true;
            btnAddOrMoveParameter6.Visible = false;
            btnAddOrMoveParameter6.Click += new EventHandler(btnAddOrMoveParameter_Click);
            // 
            // btnAddOrMoveParameter5
            // 
            btnAddOrMoveParameter5.Location = new Point(410, 194);
            btnAddOrMoveParameter5.Name = "btnAddOrMoveParameter5";
            btnAddOrMoveParameter5.Size = new Size(27, 23);
            btnAddOrMoveParameter5.TabIndex = 31;
            btnAddOrMoveParameter5.Text = "+";
            btnAddOrMoveParameter5.UseVisualStyleBackColor = true;
            btnAddOrMoveParameter5.Visible = false;
            btnAddOrMoveParameter5.Click += new EventHandler(btnAddOrMoveParameter_Click);
            // 
            // btnAddOrMoveParameter4
            // 
            btnAddOrMoveParameter4.Location = new Point(410, 159);
            btnAddOrMoveParameter4.Name = "btnAddOrMoveParameter4";
            btnAddOrMoveParameter4.Size = new Size(27, 23);
            btnAddOrMoveParameter4.TabIndex = 30;
            btnAddOrMoveParameter4.Text = "+";
            btnAddOrMoveParameter4.UseVisualStyleBackColor = true;
            btnAddOrMoveParameter4.Visible = false;
            btnAddOrMoveParameter4.Click += new EventHandler(btnAddOrMoveParameter_Click);
            // 
            // ckbParameterHex6
            // 
            ckbParameterHex6.AutoSize = true;
            ckbParameterHex6.Location = new Point(362, 233);
            ckbParameterHex6.Name = "ckbParameterHex6";
            ckbParameterHex6.Size = new Size(42, 16);
            ckbParameterHex6.TabIndex = 29;
            ckbParameterHex6.Text = "Hex";
            ckbParameterHex6.UseVisualStyleBackColor = true;
            ckbParameterHex6.Visible = false;
            ckbParameterHex6.CheckedChanged += new EventHandler(ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter6
            // 
            ckbParameter6.AutoSize = true;
            ckbParameter6.Location = new Point(13, 233);
            ckbParameter6.Name = "ckbParameter6";
            ckbParameter6.Size = new Size(15, 14);
            ckbParameter6.TabIndex = 28;
            ckbParameter6.UseVisualStyleBackColor = true;
            ckbParameter6.Visible = false;
            // 
            // txtParameterValue6
            // 
            txtParameterValue6.Location = new Point(160, 229);
            txtParameterValue6.MaxLength = 256;
            txtParameterValue6.Name = "txtParameterValue6";
            txtParameterValue6.Size = new Size(196, 21);
            txtParameterValue6.TabIndex = 27;
            txtParameterValue6.Visible = false;
            txtParameterValue6.TextChanged += new EventHandler(txtParameterValue_TextChanged);
            txtParameterValue6.KeyPress += new KeyPressEventHandler(checkHexString_KeyPress);
            // 
            // cboxParameterType6
            // 
            cboxParameterType6.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxParameterType6.FormattingEnabled = true;
            cboxParameterType6.Location = new Point(34, 230);
            cboxParameterType6.Name = "cboxParameterType6";
            cboxParameterType6.Size = new Size(120, 20);
            cboxParameterType6.TabIndex = 26;
            cboxParameterType6.Visible = false;
            cboxParameterType6.SelectedIndexChanged += new EventHandler(cboxParameterType_SelectedIndexChanged);
            // 
            // ckbParameterHex5
            // 
            ckbParameterHex5.AutoSize = true;
            ckbParameterHex5.Location = new Point(362, 198);
            ckbParameterHex5.Name = "ckbParameterHex5";
            ckbParameterHex5.Size = new Size(42, 16);
            ckbParameterHex5.TabIndex = 25;
            ckbParameterHex5.Text = "Hex";
            ckbParameterHex5.UseVisualStyleBackColor = true;
            ckbParameterHex5.Visible = false;
            ckbParameterHex5.CheckedChanged += new EventHandler(ckbParameterHex_CheckedChanged);
            // 
            // rb0x
            // 
            rb0x.AutoSize = true;
            rb0x.Location = new Point(155, 5);
            rb0x.Name = "rb0x";
            rb0x.Size = new Size(35, 16);
            rb0x.TabIndex = 17;
            rb0x.TabStop = true;
            rb0x.Text = "0x";
            rb0x.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rb0x);
            panel1.Controls.Add(rbComma);
            panel1.Controls.Add(rbNone);
            panel1.Controls.Add(rbBlank);
            panel1.Location = new Point(499, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 26);
            panel1.TabIndex = 33;
            // 
            // rbComma
            // 
            rbComma.AutoSize = true;
            rbComma.Location = new Point(84, 5);
            rbComma.Name = "rbComma";
            rbComma.Size = new Size(47, 16);
            rbComma.TabIndex = 15;
            rbComma.Text = "逗号";
            rbComma.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            rbNone.AutoSize = true;
            rbNone.Location = new Point(222, 5);
            rbNone.Name = "rbNone";
            rbNone.Size = new Size(35, 16);
            rbNone.TabIndex = 16;
            rbNone.Text = "无";
            rbNone.UseVisualStyleBackColor = true;
            // 
            // rbBlank
            // 
            rbBlank.AutoSize = true;
            rbBlank.Checked = true;
            rbBlank.Location = new Point(19, 5);
            rbBlank.Name = "rbBlank";
            rbBlank.Size = new Size(47, 16);
            rbBlank.TabIndex = 14;
            rbBlank.TabStop = true;
            rbBlank.Text = "空格";
            rbBlank.UseVisualStyleBackColor = true;
            // 
            // ckbParameter5
            // 
            ckbParameter5.AutoSize = true;
            ckbParameter5.Location = new Point(13, 198);
            ckbParameter5.Name = "ckbParameter5";
            ckbParameter5.Size = new Size(15, 14);
            ckbParameter5.TabIndex = 24;
            ckbParameter5.UseVisualStyleBackColor = true;
            ckbParameter5.Visible = false;
            // 
            // gbParameterList
            // 
            gbParameterList.Controls.Add(btnAddOrMoveParameter10);
            gbParameterList.Controls.Add(btnAddOrMoveParameter9);
            gbParameterList.Controls.Add(ckbParameterHex10);
            gbParameterList.Controls.Add(ckbParameter10);
            gbParameterList.Controls.Add(txtParameterValue10);
            gbParameterList.Controls.Add(cboxParameterType10);
            gbParameterList.Controls.Add(ckbParameterHex9);
            gbParameterList.Controls.Add(ckbParameter9);
            gbParameterList.Controls.Add(txtParameterValue9);
            gbParameterList.Controls.Add(cboxParameterType9);
            gbParameterList.Controls.Add(btnAddOrMoveParameter8);
            gbParameterList.Controls.Add(btnAddOrMoveParameter7);
            gbParameterList.Controls.Add(ckbParameterHex8);
            gbParameterList.Controls.Add(ckbParameter8);
            gbParameterList.Controls.Add(txtParameterValue8);
            gbParameterList.Controls.Add(cboxParameterType8);
            gbParameterList.Controls.Add(ckbParameterHex7);
            gbParameterList.Controls.Add(ckbParameter7);
            gbParameterList.Controls.Add(txtParameterValue7);
            gbParameterList.Controls.Add(cboxParameterType7);
            gbParameterList.Controls.Add(btnAddOrMoveParameter6);
            gbParameterList.Controls.Add(btnAddOrMoveParameter5);
            gbParameterList.Controls.Add(btnAddOrMoveParameter4);
            gbParameterList.Controls.Add(ckbParameterHex6);
            gbParameterList.Controls.Add(ckbParameter6);
            gbParameterList.Controls.Add(txtParameterValue6);
            gbParameterList.Controls.Add(cboxParameterType6);
            gbParameterList.Controls.Add(ckbParameterHex5);
            gbParameterList.Controls.Add(ckbParameter5);
            gbParameterList.Controls.Add(txtParameterValue5);
            gbParameterList.Controls.Add(cboxParameterType5);
            gbParameterList.Controls.Add(ckbParameterHex4);
            gbParameterList.Controls.Add(ckbParameter4);
            gbParameterList.Controls.Add(txtParameterValue4);
            gbParameterList.Controls.Add(cboxParameterType4);
            gbParameterList.Controls.Add(btnAddOrMoveParameter3);
            gbParameterList.Controls.Add(btnAddOrMoveParameter2);
            gbParameterList.Controls.Add(btnAddOrMoveParameter1);
            gbParameterList.Controls.Add(ckbParameterHex3);
            gbParameterList.Controls.Add(ckbParameter3);
            gbParameterList.Controls.Add(txtParameterValue3);
            gbParameterList.Controls.Add(cboxParameterType3);
            gbParameterList.Controls.Add(ckbParameterHex2);
            gbParameterList.Controls.Add(ckbParameter2);
            gbParameterList.Controls.Add(txtParameterValue2);
            gbParameterList.Controls.Add(cboxParameterType2);
            gbParameterList.Controls.Add(ckbParameterHex1);
            gbParameterList.Controls.Add(ckbParameter1);
            gbParameterList.Controls.Add(txtParameterValue1);
            gbParameterList.Controls.Add(label6);
            gbParameterList.Controls.Add(cboxParameterType1);
            gbParameterList.Controls.Add(label5);
            gbParameterList.Location = new Point(14, 143);
            gbParameterList.Name = "gbParameterList";
            gbParameterList.Size = new Size(448, 407);
            gbParameterList.TabIndex = 27;
            gbParameterList.TabStop = false;
            gbParameterList.Text = "参数列表";
            // 
            // txtParameterValue5
            // 
            txtParameterValue5.Location = new Point(160, 194);
            txtParameterValue5.MaxLength = 256;
            txtParameterValue5.Name = "txtParameterValue5";
            txtParameterValue5.Size = new Size(196, 21);
            txtParameterValue5.TabIndex = 23;
            txtParameterValue5.Visible = false;
            txtParameterValue5.TextChanged += new EventHandler(txtParameterValue_TextChanged);
            txtParameterValue5.KeyPress += new KeyPressEventHandler(checkHexString_KeyPress);
            // 
            // cboxParameterType5
            // 
            cboxParameterType5.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxParameterType5.FormattingEnabled = true;
            cboxParameterType5.Location = new Point(34, 195);
            cboxParameterType5.Name = "cboxParameterType5";
            cboxParameterType5.Size = new Size(120, 20);
            cboxParameterType5.TabIndex = 22;
            cboxParameterType5.Visible = false;
            cboxParameterType5.SelectedIndexChanged += new EventHandler(cboxParameterType_SelectedIndexChanged);
            // 
            // ckbParameterHex4
            // 
            ckbParameterHex4.AutoSize = true;
            ckbParameterHex4.Location = new Point(362, 163);
            ckbParameterHex4.Name = "ckbParameterHex4";
            ckbParameterHex4.Size = new Size(42, 16);
            ckbParameterHex4.TabIndex = 21;
            ckbParameterHex4.Text = "Hex";
            ckbParameterHex4.UseVisualStyleBackColor = true;
            ckbParameterHex4.Visible = false;
            ckbParameterHex4.CheckedChanged += new EventHandler(ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter4
            // 
            ckbParameter4.AutoSize = true;
            ckbParameter4.Location = new Point(13, 163);
            ckbParameter4.Name = "ckbParameter4";
            ckbParameter4.Size = new Size(15, 14);
            ckbParameter4.TabIndex = 20;
            ckbParameter4.UseVisualStyleBackColor = true;
            ckbParameter4.Visible = false;
            // 
            // txtParameterValue4
            // 
            txtParameterValue4.Location = new Point(160, 159);
            txtParameterValue4.MaxLength = 256;
            txtParameterValue4.Name = "txtParameterValue4";
            txtParameterValue4.Size = new Size(196, 21);
            txtParameterValue4.TabIndex = 19;
            txtParameterValue4.Visible = false;
            txtParameterValue4.TextChanged += new EventHandler(txtParameterValue_TextChanged);
            txtParameterValue4.KeyPress += new KeyPressEventHandler(checkHexString_KeyPress);
            // 
            // cboxParameterType4
            // 
            cboxParameterType4.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxParameterType4.FormattingEnabled = true;
            cboxParameterType4.Location = new Point(34, 160);
            cboxParameterType4.Name = "cboxParameterType4";
            cboxParameterType4.Size = new Size(120, 20);
            cboxParameterType4.TabIndex = 18;
            cboxParameterType4.Visible = false;
            cboxParameterType4.SelectedIndexChanged += new EventHandler(cboxParameterType_SelectedIndexChanged);
            // 
            // btnAddOrMoveParameter3
            // 
            btnAddOrMoveParameter3.Location = new Point(410, 124);
            btnAddOrMoveParameter3.Name = "btnAddOrMoveParameter3";
            btnAddOrMoveParameter3.Size = new Size(27, 23);
            btnAddOrMoveParameter3.TabIndex = 16;
            btnAddOrMoveParameter3.Text = "+";
            btnAddOrMoveParameter3.UseVisualStyleBackColor = true;
            btnAddOrMoveParameter3.Visible = false;
            btnAddOrMoveParameter3.Click += new EventHandler(btnAddOrMoveParameter_Click);
            // 
            // btnAddOrMoveParameter2
            // 
            btnAddOrMoveParameter2.Location = new Point(410, 89);
            btnAddOrMoveParameter2.Name = "btnAddOrMoveParameter2";
            btnAddOrMoveParameter2.Size = new Size(27, 23);
            btnAddOrMoveParameter2.TabIndex = 15;
            btnAddOrMoveParameter2.Text = "+";
            btnAddOrMoveParameter2.UseVisualStyleBackColor = true;
            btnAddOrMoveParameter2.Click += new EventHandler(btnAddOrMoveParameter_Click);
            // 
            // btnAddOrMoveParameter1
            // 
            btnAddOrMoveParameter1.Location = new Point(410, 54);
            btnAddOrMoveParameter1.Name = "btnAddOrMoveParameter1";
            btnAddOrMoveParameter1.Size = new Size(27, 23);
            btnAddOrMoveParameter1.TabIndex = 14;
            btnAddOrMoveParameter1.Text = "－";
            btnAddOrMoveParameter1.UseVisualStyleBackColor = true;
            btnAddOrMoveParameter1.Click += new EventHandler(btnAddOrMoveParameter_Click);
            // 
            // ckbParameterHex3
            // 
            ckbParameterHex3.AutoSize = true;
            ckbParameterHex3.Location = new Point(362, 128);
            ckbParameterHex3.Name = "ckbParameterHex3";
            ckbParameterHex3.Size = new Size(42, 16);
            ckbParameterHex3.TabIndex = 13;
            ckbParameterHex3.Text = "Hex";
            ckbParameterHex3.UseVisualStyleBackColor = true;
            ckbParameterHex3.Visible = false;
            ckbParameterHex3.CheckedChanged += new EventHandler(ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter3
            // 
            ckbParameter3.AutoSize = true;
            ckbParameter3.Location = new Point(13, 128);
            ckbParameter3.Name = "ckbParameter3";
            ckbParameter3.Size = new Size(15, 14);
            ckbParameter3.TabIndex = 12;
            ckbParameter3.UseVisualStyleBackColor = true;
            ckbParameter3.Visible = false;
            // 
            // txtParameterValue3
            // 
            txtParameterValue3.Location = new Point(160, 124);
            txtParameterValue3.MaxLength = 256;
            txtParameterValue3.Name = "txtParameterValue3";
            txtParameterValue3.Size = new Size(196, 21);
            txtParameterValue3.TabIndex = 11;
            txtParameterValue3.Visible = false;
            txtParameterValue3.TextChanged += new EventHandler(txtParameterValue_TextChanged);
            txtParameterValue3.KeyPress += new KeyPressEventHandler(checkHexString_KeyPress);
            // 
            // cboxParameterType3
            // 
            cboxParameterType3.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxParameterType3.FormattingEnabled = true;
            cboxParameterType3.Location = new Point(34, 125);
            cboxParameterType3.Name = "cboxParameterType3";
            cboxParameterType3.Size = new Size(120, 20);
            cboxParameterType3.TabIndex = 10;
            cboxParameterType3.Visible = false;
            cboxParameterType3.SelectedIndexChanged += new EventHandler(cboxParameterType_SelectedIndexChanged);
            // 
            // ckbParameterHex2
            // 
            ckbParameterHex2.AutoSize = true;
            ckbParameterHex2.Location = new Point(362, 93);
            ckbParameterHex2.Name = "ckbParameterHex2";
            ckbParameterHex2.Size = new Size(42, 16);
            ckbParameterHex2.TabIndex = 9;
            ckbParameterHex2.Text = "Hex";
            ckbParameterHex2.UseVisualStyleBackColor = true;
            ckbParameterHex2.Visible = false;
            ckbParameterHex2.CheckedChanged += new EventHandler(ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter2
            // 
            ckbParameter2.AutoSize = true;
            ckbParameter2.Location = new Point(13, 93);
            ckbParameter2.Name = "ckbParameter2";
            ckbParameter2.Size = new Size(15, 14);
            ckbParameter2.TabIndex = 8;
            ckbParameter2.UseVisualStyleBackColor = true;
            ckbParameter2.Visible = false;
            // 
            // txtParameterValue2
            // 
            txtParameterValue2.Location = new Point(160, 89);
            txtParameterValue2.MaxLength = 256;
            txtParameterValue2.Name = "txtParameterValue2";
            txtParameterValue2.Size = new Size(196, 21);
            txtParameterValue2.TabIndex = 7;
            txtParameterValue2.Visible = false;
            txtParameterValue2.TextChanged += new EventHandler(txtParameterValue_TextChanged);
            txtParameterValue2.KeyPress += new KeyPressEventHandler(checkHexString_KeyPress);
            // 
            // cboxParameterType2
            // 
            cboxParameterType2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxParameterType2.FormattingEnabled = true;
            cboxParameterType2.Location = new Point(34, 90);
            cboxParameterType2.Name = "cboxParameterType2";
            cboxParameterType2.Size = new Size(120, 20);
            cboxParameterType2.TabIndex = 6;
            cboxParameterType2.Visible = false;
            cboxParameterType2.SelectedIndexChanged += new EventHandler(cboxParameterType_SelectedIndexChanged);
            // 
            // ckbParameterHex1
            // 
            ckbParameterHex1.AutoSize = true;
            ckbParameterHex1.Location = new Point(362, 58);
            ckbParameterHex1.Name = "ckbParameterHex1";
            ckbParameterHex1.Size = new Size(42, 16);
            ckbParameterHex1.TabIndex = 5;
            ckbParameterHex1.Text = "Hex";
            ckbParameterHex1.UseVisualStyleBackColor = true;
            ckbParameterHex1.CheckedChanged += new EventHandler(ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter1
            // 
            ckbParameter1.AutoSize = true;
            ckbParameter1.Location = new Point(13, 58);
            ckbParameter1.Name = "ckbParameter1";
            ckbParameter1.Size = new Size(15, 14);
            ckbParameter1.TabIndex = 4;
            ckbParameter1.UseVisualStyleBackColor = true;
            // 
            // txtParameterValue1
            // 
            txtParameterValue1.Location = new Point(160, 54);
            txtParameterValue1.MaxLength = 256;
            txtParameterValue1.Name = "txtParameterValue1";
            txtParameterValue1.Size = new Size(196, 21);
            txtParameterValue1.TabIndex = 3;
            txtParameterValue1.TextChanged += new EventHandler(txtParameterValue_TextChanged);
            txtParameterValue1.KeyPress += new KeyPressEventHandler(checkHexString_KeyPress);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 30);
            label6.Name = "label6";
            label6.Size = new Size(41, 12);
            label6.TabIndex = 2;
            label6.Text = "参数值";
            // 
            // cboxParameterType1
            // 
            cboxParameterType1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxParameterType1.FormattingEnabled = true;
            cboxParameterType1.Location = new Point(34, 55);
            cboxParameterType1.Name = "cboxParameterType1";
            cboxParameterType1.Size = new Size(120, 20);
            cboxParameterType1.TabIndex = 1;
            cboxParameterType1.SelectedIndexChanged += new EventHandler(cboxParameterType_SelectedIndexChanged);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 30);
            label5.Name = "label5";
            label5.Size = new Size(53, 12);
            label5.TabIndex = 0;
            label5.Text = "参数类型";
            // 
            // cboxMessageId
            // 
            cboxMessageId.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxMessageId.FormattingEnabled = true;
            cboxMessageId.Location = new Point(83, 49);
            cboxMessageId.Name = "cboxMessageId";
            cboxMessageId.Size = new Size(200, 20);
            cboxMessageId.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 53);
            label4.Name = "label4";
            label4.Size = new Size(53, 12);
            label4.TabIndex = 25;
            label4.Text = "消息ID：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 15);
            label3.Name = "label3";
            label3.Size = new Size(65, 12);
            label3.TabIndex = 24;
            label3.Text = "消息类型：";
            // 
            // cboxMessageType
            // 
            cboxMessageType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxMessageType.FormattingEnabled = true;
            cboxMessageType.Location = new Point(83, 11);
            cboxMessageType.Name = "cboxMessageType";
            cboxMessageType.Size = new Size(200, 20);
            cboxMessageType.TabIndex = 23;
            cboxMessageType.SelectedIndexChanged += new EventHandler(cboxMessageType_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 91);
            label2.Name = "label2";
            label2.Size = new Size(53, 12);
            label2.TabIndex = 22;
            label2.Text = "灯具ID：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 91);
            label1.Name = "label1";
            label1.Size = new Size(53, 12);
            label1.TabIndex = 21;
            label1.Text = "网关ID：";
            // 
            // txtLuminaireId
            // 
            txtLuminaireId.Location = new Point(223, 87);
            txtLuminaireId.MaxLength = 8;
            txtLuminaireId.Name = "txtLuminaireId";
            txtLuminaireId.Size = new Size(60, 21);
            txtLuminaireId.TabIndex = 20;
            txtLuminaireId.Text = "FFFFFFFF";
            txtLuminaireId.KeyPress += new KeyPressEventHandler(checkHexString_KeyPress);
            // 
            // txtGatewayId
            // 
            txtGatewayId.Location = new Point(83, 87);
            txtGatewayId.MaxLength = 8;
            txtGatewayId.Name = "txtGatewayId";
            txtGatewayId.Size = new Size(60, 21);
            txtGatewayId.TabIndex = 19;
            txtGatewayId.Text = "00000001";
            txtGatewayId.KeyPress += new KeyPressEventHandler(checkHexString_KeyPress);
            // 
            // Generater
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnCheck);
            Controls.Add(btnGenerate);
            Controls.Add(btnReset);
            Controls.Add(txtMessage2);
            Controls.Add(txtMessage1);
            Controls.Add(gbErrorCodeAndInfo);
            Controls.Add(panel1);
            Controls.Add(gbParameterList);
            Controls.Add(cboxMessageId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboxMessageType);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLuminaireId);
            Controls.Add(txtGatewayId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Generater";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CSA018命令生成/解析器";
            Load += new EventHandler(Generater_Load);
            gbErrorCodeAndInfo.ResumeLayout(false);
            gbErrorCodeAndInfo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gbParameterList.ResumeLayout(false);
            gbParameterList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnCheck;
        private Button btnGenerate;
        private Button btnReset;
        private TextBox txtMessage2;
        private TextBox txtMessage1;
        private Button btnAddOrMoveParameter10;
        private Button btnAddOrMoveParameter9;
        private CheckBox ckbParameterHex10;
        private CheckBox ckbParameter10;
        private TextBox txtParameterValue10;
        private ComboBox cboxParameterType10;
        private CheckBox ckbParameterHex9;
        private CheckBox ckbParameter9;
        private TextBox txtParameterValue9;
        private ComboBox cboxParameterType9;
        private Button btnAddOrMoveParameter8;
        private Button btnAddOrMoveParameter7;
        private Label label8;
        private TextBox txtErrorInfo;
        private ComboBox cboxErrorCode;
        private GroupBox gbErrorCodeAndInfo;
        private Label label7;
        private CheckBox ckbParameterHex8;
        private CheckBox ckbParameter8;
        private TextBox txtParameterValue8;
        private ComboBox cboxParameterType8;
        private CheckBox ckbParameterHex7;
        private CheckBox ckbParameter7;
        private TextBox txtParameterValue7;
        private ComboBox cboxParameterType7;
        private Button btnAddOrMoveParameter6;
        private Button btnAddOrMoveParameter5;
        private Button btnAddOrMoveParameter4;
        private CheckBox ckbParameterHex6;
        private CheckBox ckbParameter6;
        private TextBox txtParameterValue6;
        private ComboBox cboxParameterType6;
        private CheckBox ckbParameterHex5;
        private RadioButton rb0x;
        private Panel panel1;
        private RadioButton rbComma;
        private RadioButton rbNone;
        private RadioButton rbBlank;
        private CheckBox ckbParameter5;
        private GroupBox gbParameterList;
        private TextBox txtParameterValue5;
        private ComboBox cboxParameterType5;
        private CheckBox ckbParameterHex4;
        private CheckBox ckbParameter4;
        private TextBox txtParameterValue4;
        private ComboBox cboxParameterType4;
        private Button btnAddOrMoveParameter3;
        private Button btnAddOrMoveParameter2;
        private Button btnAddOrMoveParameter1;
        private CheckBox ckbParameterHex3;
        private CheckBox ckbParameter3;
        private TextBox txtParameterValue3;
        private ComboBox cboxParameterType3;
        private CheckBox ckbParameterHex2;
        private CheckBox ckbParameter2;
        private TextBox txtParameterValue2;
        private ComboBox cboxParameterType2;
        private CheckBox ckbParameterHex1;
        private CheckBox ckbParameter1;
        private TextBox txtParameterValue1;
        private Label label6;
        private ComboBox cboxParameterType1;
        private Label label5;
        private ComboBox cboxMessageId;
        private Label label4;
        private Label label3;
        private ComboBox cboxMessageType;
        private Label label2;
        private Label label1;
        private TextBox txtLuminaireId;
        private TextBox txtGatewayId;
    }
}

