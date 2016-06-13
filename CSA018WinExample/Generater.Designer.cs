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
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtMessage2 = new System.Windows.Forms.TextBox();
            this.txtMessage1 = new System.Windows.Forms.TextBox();
            this.btnAddOrMoveParameter10 = new System.Windows.Forms.Button();
            this.btnAddOrMoveParameter9 = new System.Windows.Forms.Button();
            this.ckbParameterHex10 = new System.Windows.Forms.CheckBox();
            this.ckbParameter10 = new System.Windows.Forms.CheckBox();
            this.txtParameterValue10 = new System.Windows.Forms.TextBox();
            this.cboxParameterType10 = new System.Windows.Forms.ComboBox();
            this.ckbParameterHex9 = new System.Windows.Forms.CheckBox();
            this.ckbParameter9 = new System.Windows.Forms.CheckBox();
            this.txtParameterValue9 = new System.Windows.Forms.TextBox();
            this.cboxParameterType9 = new System.Windows.Forms.ComboBox();
            this.btnAddOrMoveParameter8 = new System.Windows.Forms.Button();
            this.btnAddOrMoveParameter7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtErrorInfo = new System.Windows.Forms.TextBox();
            this.cboxErrorCode = new System.Windows.Forms.ComboBox();
            this.gbErrorCodeAndInfo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbParameterHex8 = new System.Windows.Forms.CheckBox();
            this.ckbParameter8 = new System.Windows.Forms.CheckBox();
            this.txtParameterValue8 = new System.Windows.Forms.TextBox();
            this.cboxParameterType8 = new System.Windows.Forms.ComboBox();
            this.ckbParameterHex7 = new System.Windows.Forms.CheckBox();
            this.ckbParameter7 = new System.Windows.Forms.CheckBox();
            this.txtParameterValue7 = new System.Windows.Forms.TextBox();
            this.cboxParameterType7 = new System.Windows.Forms.ComboBox();
            this.btnAddOrMoveParameter6 = new System.Windows.Forms.Button();
            this.btnAddOrMoveParameter5 = new System.Windows.Forms.Button();
            this.btnAddOrMoveParameter4 = new System.Windows.Forms.Button();
            this.ckbParameterHex6 = new System.Windows.Forms.CheckBox();
            this.ckbParameter6 = new System.Windows.Forms.CheckBox();
            this.txtParameterValue6 = new System.Windows.Forms.TextBox();
            this.cboxParameterType6 = new System.Windows.Forms.ComboBox();
            this.ckbParameterHex5 = new System.Windows.Forms.CheckBox();
            this.rb0x = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbComma = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbBlank = new System.Windows.Forms.RadioButton();
            this.ckbParameter5 = new System.Windows.Forms.CheckBox();
            this.gbParameterList = new System.Windows.Forms.GroupBox();
            this.txtParameterValue5 = new System.Windows.Forms.TextBox();
            this.cboxParameterType5 = new System.Windows.Forms.ComboBox();
            this.ckbParameterHex4 = new System.Windows.Forms.CheckBox();
            this.ckbParameter4 = new System.Windows.Forms.CheckBox();
            this.txtParameterValue4 = new System.Windows.Forms.TextBox();
            this.cboxParameterType4 = new System.Windows.Forms.ComboBox();
            this.btnAddOrMoveParameter3 = new System.Windows.Forms.Button();
            this.btnAddOrMoveParameter2 = new System.Windows.Forms.Button();
            this.btnAddOrMoveParameter1 = new System.Windows.Forms.Button();
            this.ckbParameterHex3 = new System.Windows.Forms.CheckBox();
            this.ckbParameter3 = new System.Windows.Forms.CheckBox();
            this.txtParameterValue3 = new System.Windows.Forms.TextBox();
            this.cboxParameterType3 = new System.Windows.Forms.ComboBox();
            this.ckbParameterHex2 = new System.Windows.Forms.CheckBox();
            this.ckbParameter2 = new System.Windows.Forms.CheckBox();
            this.txtParameterValue2 = new System.Windows.Forms.TextBox();
            this.cboxParameterType2 = new System.Windows.Forms.ComboBox();
            this.ckbParameterHex1 = new System.Windows.Forms.CheckBox();
            this.ckbParameter1 = new System.Windows.Forms.CheckBox();
            this.txtParameterValue1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxParameterType1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxMessageId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxMessageType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLuminaireId = new System.Windows.Forms.TextBox();
            this.txtGatewayId = new System.Windows.Forms.TextBox();
            this.gbErrorCodeAndInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbParameterList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(707, 153);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(30, 40);
            this.btnCheck.TabIndex = 32;
            this.btnCheck.Text = "↓";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(592, 153);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 40);
            this.btnGenerate.TabIndex = 31;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(499, 153);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 40);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtMessage2
            // 
            this.txtMessage2.Location = new System.Drawing.Point(499, 200);
            this.txtMessage2.Multiline = true;
            this.txtMessage2.Name = "txtMessage2";
            this.txtMessage2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage2.Size = new System.Drawing.Size(273, 350);
            this.txtMessage2.TabIndex = 29;
            // 
            // txtMessage1
            // 
            this.txtMessage1.Location = new System.Drawing.Point(318, 12);
            this.txtMessage1.Multiline = true;
            this.txtMessage1.Name = "txtMessage1";
            this.txtMessage1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage1.Size = new System.Drawing.Size(454, 96);
            this.txtMessage1.TabIndex = 28;
            this.txtMessage1.TextChanged += new System.EventHandler(this.txtMessage1_TextChanged);
            // 
            // btnAddOrMoveParameter10
            // 
            this.btnAddOrMoveParameter10.Location = new System.Drawing.Point(410, 369);
            this.btnAddOrMoveParameter10.Name = "btnAddOrMoveParameter10";
            this.btnAddOrMoveParameter10.Size = new System.Drawing.Size(27, 23);
            this.btnAddOrMoveParameter10.TabIndex = 52;
            this.btnAddOrMoveParameter10.Text = "+";
            this.btnAddOrMoveParameter10.UseVisualStyleBackColor = true;
            this.btnAddOrMoveParameter10.Visible = false;
            this.btnAddOrMoveParameter10.Click += new System.EventHandler(this.btnAddOrMoveParameter_Click);
            // 
            // btnAddOrMoveParameter9
            // 
            this.btnAddOrMoveParameter9.Location = new System.Drawing.Point(410, 334);
            this.btnAddOrMoveParameter9.Name = "btnAddOrMoveParameter9";
            this.btnAddOrMoveParameter9.Size = new System.Drawing.Size(27, 23);
            this.btnAddOrMoveParameter9.TabIndex = 51;
            this.btnAddOrMoveParameter9.Text = "+";
            this.btnAddOrMoveParameter9.UseVisualStyleBackColor = true;
            this.btnAddOrMoveParameter9.Visible = false;
            this.btnAddOrMoveParameter9.Click += new System.EventHandler(this.btnAddOrMoveParameter_Click);
            // 
            // ckbParameterHex10
            // 
            this.ckbParameterHex10.AutoSize = true;
            this.ckbParameterHex10.Location = new System.Drawing.Point(362, 373);
            this.ckbParameterHex10.Name = "ckbParameterHex10";
            this.ckbParameterHex10.Size = new System.Drawing.Size(42, 16);
            this.ckbParameterHex10.TabIndex = 50;
            this.ckbParameterHex10.Text = "Hex";
            this.ckbParameterHex10.UseVisualStyleBackColor = true;
            this.ckbParameterHex10.Visible = false;
            this.ckbParameterHex10.CheckedChanged += new System.EventHandler(this.ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter10
            // 
            this.ckbParameter10.AutoSize = true;
            this.ckbParameter10.Location = new System.Drawing.Point(13, 373);
            this.ckbParameter10.Name = "ckbParameter10";
            this.ckbParameter10.Size = new System.Drawing.Size(15, 14);
            this.ckbParameter10.TabIndex = 49;
            this.ckbParameter10.UseVisualStyleBackColor = true;
            this.ckbParameter10.Visible = false;
            // 
            // txtParameterValue10
            // 
            this.txtParameterValue10.Location = new System.Drawing.Point(160, 369);
            this.txtParameterValue10.MaxLength = 256;
            this.txtParameterValue10.Name = "txtParameterValue10";
            this.txtParameterValue10.Size = new System.Drawing.Size(196, 21);
            this.txtParameterValue10.TabIndex = 48;
            this.txtParameterValue10.Visible = false;
            this.txtParameterValue10.TextChanged += new System.EventHandler(this.txtParameterValue_TextChanged);
            this.txtParameterValue10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkHexString_KeyPress);
            // 
            // cboxParameterType10
            // 
            this.cboxParameterType10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxParameterType10.FormattingEnabled = true;
            this.cboxParameterType10.Location = new System.Drawing.Point(34, 370);
            this.cboxParameterType10.Name = "cboxParameterType10";
            this.cboxParameterType10.Size = new System.Drawing.Size(120, 20);
            this.cboxParameterType10.TabIndex = 47;
            this.cboxParameterType10.Visible = false;
            this.cboxParameterType10.SelectedIndexChanged += new System.EventHandler(this.cboxParameterType_SelectedIndexChanged);
            // 
            // ckbParameterHex9
            // 
            this.ckbParameterHex9.AutoSize = true;
            this.ckbParameterHex9.Location = new System.Drawing.Point(362, 338);
            this.ckbParameterHex9.Name = "ckbParameterHex9";
            this.ckbParameterHex9.Size = new System.Drawing.Size(42, 16);
            this.ckbParameterHex9.TabIndex = 46;
            this.ckbParameterHex9.Text = "Hex";
            this.ckbParameterHex9.UseVisualStyleBackColor = true;
            this.ckbParameterHex9.Visible = false;
            this.ckbParameterHex9.CheckedChanged += new System.EventHandler(this.ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter9
            // 
            this.ckbParameter9.AutoSize = true;
            this.ckbParameter9.Location = new System.Drawing.Point(13, 338);
            this.ckbParameter9.Name = "ckbParameter9";
            this.ckbParameter9.Size = new System.Drawing.Size(15, 14);
            this.ckbParameter9.TabIndex = 45;
            this.ckbParameter9.UseVisualStyleBackColor = true;
            this.ckbParameter9.Visible = false;
            // 
            // txtParameterValue9
            // 
            this.txtParameterValue9.Location = new System.Drawing.Point(160, 334);
            this.txtParameterValue9.MaxLength = 256;
            this.txtParameterValue9.Name = "txtParameterValue9";
            this.txtParameterValue9.Size = new System.Drawing.Size(196, 21);
            this.txtParameterValue9.TabIndex = 44;
            this.txtParameterValue9.Visible = false;
            this.txtParameterValue9.TextChanged += new System.EventHandler(this.txtParameterValue_TextChanged);
            this.txtParameterValue9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkHexString_KeyPress);
            // 
            // cboxParameterType9
            // 
            this.cboxParameterType9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxParameterType9.FormattingEnabled = true;
            this.cboxParameterType9.Location = new System.Drawing.Point(34, 335);
            this.cboxParameterType9.Name = "cboxParameterType9";
            this.cboxParameterType9.Size = new System.Drawing.Size(120, 20);
            this.cboxParameterType9.TabIndex = 43;
            this.cboxParameterType9.Visible = false;
            this.cboxParameterType9.SelectedIndexChanged += new System.EventHandler(this.cboxParameterType_SelectedIndexChanged);
            // 
            // btnAddOrMoveParameter8
            // 
            this.btnAddOrMoveParameter8.Location = new System.Drawing.Point(410, 299);
            this.btnAddOrMoveParameter8.Name = "btnAddOrMoveParameter8";
            this.btnAddOrMoveParameter8.Size = new System.Drawing.Size(27, 23);
            this.btnAddOrMoveParameter8.TabIndex = 42;
            this.btnAddOrMoveParameter8.Text = "+";
            this.btnAddOrMoveParameter8.UseVisualStyleBackColor = true;
            this.btnAddOrMoveParameter8.Visible = false;
            this.btnAddOrMoveParameter8.Click += new System.EventHandler(this.btnAddOrMoveParameter_Click);
            // 
            // btnAddOrMoveParameter7
            // 
            this.btnAddOrMoveParameter7.Location = new System.Drawing.Point(410, 264);
            this.btnAddOrMoveParameter7.Name = "btnAddOrMoveParameter7";
            this.btnAddOrMoveParameter7.Size = new System.Drawing.Size(27, 23);
            this.btnAddOrMoveParameter7.TabIndex = 41;
            this.btnAddOrMoveParameter7.Text = "+";
            this.btnAddOrMoveParameter7.UseVisualStyleBackColor = true;
            this.btnAddOrMoveParameter7.Visible = false;
            this.btnAddOrMoveParameter7.Click += new System.EventHandler(this.btnAddOrMoveParameter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "错误信息";
            // 
            // txtErrorInfo
            // 
            this.txtErrorInfo.Location = new System.Drawing.Point(93, 86);
            this.txtErrorInfo.Multiline = true;
            this.txtErrorInfo.Name = "txtErrorInfo";
            this.txtErrorInfo.Size = new System.Drawing.Size(176, 68);
            this.txtErrorInfo.TabIndex = 3;
            // 
            // cboxErrorCode
            // 
            this.cboxErrorCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxErrorCode.FormattingEnabled = true;
            this.cboxErrorCode.Location = new System.Drawing.Point(93, 52);
            this.cboxErrorCode.Name = "cboxErrorCode";
            this.cboxErrorCode.Size = new System.Drawing.Size(176, 20);
            this.cboxErrorCode.TabIndex = 2;
            this.cboxErrorCode.SelectedIndexChanged += new System.EventHandler(this.cboxErrorCode_SelectedIndexChanged);
            // 
            // gbErrorCodeAndInfo
            // 
            this.gbErrorCodeAndInfo.Controls.Add(this.label8);
            this.gbErrorCodeAndInfo.Controls.Add(this.label7);
            this.gbErrorCodeAndInfo.Controls.Add(this.txtErrorInfo);
            this.gbErrorCodeAndInfo.Controls.Add(this.cboxErrorCode);
            this.gbErrorCodeAndInfo.Location = new System.Drawing.Point(14, 143);
            this.gbErrorCodeAndInfo.Name = "gbErrorCodeAndInfo";
            this.gbErrorCodeAndInfo.Size = new System.Drawing.Size(448, 407);
            this.gbErrorCodeAndInfo.TabIndex = 34;
            this.gbErrorCodeAndInfo.TabStop = false;
            this.gbErrorCodeAndInfo.Text = "返回结果";
            this.gbErrorCodeAndInfo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "错误代码";
            // 
            // ckbParameterHex8
            // 
            this.ckbParameterHex8.AutoSize = true;
            this.ckbParameterHex8.Location = new System.Drawing.Point(362, 303);
            this.ckbParameterHex8.Name = "ckbParameterHex8";
            this.ckbParameterHex8.Size = new System.Drawing.Size(42, 16);
            this.ckbParameterHex8.TabIndex = 40;
            this.ckbParameterHex8.Text = "Hex";
            this.ckbParameterHex8.UseVisualStyleBackColor = true;
            this.ckbParameterHex8.Visible = false;
            this.ckbParameterHex8.CheckedChanged += new System.EventHandler(this.ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter8
            // 
            this.ckbParameter8.AutoSize = true;
            this.ckbParameter8.Location = new System.Drawing.Point(13, 303);
            this.ckbParameter8.Name = "ckbParameter8";
            this.ckbParameter8.Size = new System.Drawing.Size(15, 14);
            this.ckbParameter8.TabIndex = 39;
            this.ckbParameter8.UseVisualStyleBackColor = true;
            this.ckbParameter8.Visible = false;
            // 
            // txtParameterValue8
            // 
            this.txtParameterValue8.Location = new System.Drawing.Point(160, 299);
            this.txtParameterValue8.MaxLength = 256;
            this.txtParameterValue8.Name = "txtParameterValue8";
            this.txtParameterValue8.Size = new System.Drawing.Size(196, 21);
            this.txtParameterValue8.TabIndex = 38;
            this.txtParameterValue8.Visible = false;
            this.txtParameterValue8.TextChanged += new System.EventHandler(this.txtParameterValue_TextChanged);
            this.txtParameterValue8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkHexString_KeyPress);
            // 
            // cboxParameterType8
            // 
            this.cboxParameterType8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxParameterType8.FormattingEnabled = true;
            this.cboxParameterType8.Location = new System.Drawing.Point(34, 300);
            this.cboxParameterType8.Name = "cboxParameterType8";
            this.cboxParameterType8.Size = new System.Drawing.Size(120, 20);
            this.cboxParameterType8.TabIndex = 37;
            this.cboxParameterType8.Visible = false;
            this.cboxParameterType8.SelectedIndexChanged += new System.EventHandler(this.cboxParameterType_SelectedIndexChanged);
            // 
            // ckbParameterHex7
            // 
            this.ckbParameterHex7.AutoSize = true;
            this.ckbParameterHex7.Location = new System.Drawing.Point(362, 268);
            this.ckbParameterHex7.Name = "ckbParameterHex7";
            this.ckbParameterHex7.Size = new System.Drawing.Size(42, 16);
            this.ckbParameterHex7.TabIndex = 36;
            this.ckbParameterHex7.Text = "Hex";
            this.ckbParameterHex7.UseVisualStyleBackColor = true;
            this.ckbParameterHex7.Visible = false;
            this.ckbParameterHex7.CheckedChanged += new System.EventHandler(this.ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter7
            // 
            this.ckbParameter7.AutoSize = true;
            this.ckbParameter7.Location = new System.Drawing.Point(13, 268);
            this.ckbParameter7.Name = "ckbParameter7";
            this.ckbParameter7.Size = new System.Drawing.Size(15, 14);
            this.ckbParameter7.TabIndex = 35;
            this.ckbParameter7.UseVisualStyleBackColor = true;
            this.ckbParameter7.Visible = false;
            // 
            // txtParameterValue7
            // 
            this.txtParameterValue7.Location = new System.Drawing.Point(160, 264);
            this.txtParameterValue7.MaxLength = 256;
            this.txtParameterValue7.Name = "txtParameterValue7";
            this.txtParameterValue7.Size = new System.Drawing.Size(196, 21);
            this.txtParameterValue7.TabIndex = 34;
            this.txtParameterValue7.Visible = false;
            this.txtParameterValue7.TextChanged += new System.EventHandler(this.txtParameterValue_TextChanged);
            this.txtParameterValue7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkHexString_KeyPress);
            // 
            // cboxParameterType7
            // 
            this.cboxParameterType7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxParameterType7.FormattingEnabled = true;
            this.cboxParameterType7.Location = new System.Drawing.Point(34, 265);
            this.cboxParameterType7.Name = "cboxParameterType7";
            this.cboxParameterType7.Size = new System.Drawing.Size(120, 20);
            this.cboxParameterType7.TabIndex = 33;
            this.cboxParameterType7.Visible = false;
            this.cboxParameterType7.SelectedIndexChanged += new System.EventHandler(this.cboxParameterType_SelectedIndexChanged);
            // 
            // btnAddOrMoveParameter6
            // 
            this.btnAddOrMoveParameter6.Location = new System.Drawing.Point(410, 229);
            this.btnAddOrMoveParameter6.Name = "btnAddOrMoveParameter6";
            this.btnAddOrMoveParameter6.Size = new System.Drawing.Size(27, 23);
            this.btnAddOrMoveParameter6.TabIndex = 32;
            this.btnAddOrMoveParameter6.Text = "+";
            this.btnAddOrMoveParameter6.UseVisualStyleBackColor = true;
            this.btnAddOrMoveParameter6.Visible = false;
            this.btnAddOrMoveParameter6.Click += new System.EventHandler(this.btnAddOrMoveParameter_Click);
            // 
            // btnAddOrMoveParameter5
            // 
            this.btnAddOrMoveParameter5.Location = new System.Drawing.Point(410, 194);
            this.btnAddOrMoveParameter5.Name = "btnAddOrMoveParameter5";
            this.btnAddOrMoveParameter5.Size = new System.Drawing.Size(27, 23);
            this.btnAddOrMoveParameter5.TabIndex = 31;
            this.btnAddOrMoveParameter5.Text = "+";
            this.btnAddOrMoveParameter5.UseVisualStyleBackColor = true;
            this.btnAddOrMoveParameter5.Visible = false;
            this.btnAddOrMoveParameter5.Click += new System.EventHandler(this.btnAddOrMoveParameter_Click);
            // 
            // btnAddOrMoveParameter4
            // 
            this.btnAddOrMoveParameter4.Location = new System.Drawing.Point(410, 159);
            this.btnAddOrMoveParameter4.Name = "btnAddOrMoveParameter4";
            this.btnAddOrMoveParameter4.Size = new System.Drawing.Size(27, 23);
            this.btnAddOrMoveParameter4.TabIndex = 30;
            this.btnAddOrMoveParameter4.Text = "+";
            this.btnAddOrMoveParameter4.UseVisualStyleBackColor = true;
            this.btnAddOrMoveParameter4.Visible = false;
            this.btnAddOrMoveParameter4.Click += new System.EventHandler(this.btnAddOrMoveParameter_Click);
            // 
            // ckbParameterHex6
            // 
            this.ckbParameterHex6.AutoSize = true;
            this.ckbParameterHex6.Location = new System.Drawing.Point(362, 233);
            this.ckbParameterHex6.Name = "ckbParameterHex6";
            this.ckbParameterHex6.Size = new System.Drawing.Size(42, 16);
            this.ckbParameterHex6.TabIndex = 29;
            this.ckbParameterHex6.Text = "Hex";
            this.ckbParameterHex6.UseVisualStyleBackColor = true;
            this.ckbParameterHex6.Visible = false;
            this.ckbParameterHex6.CheckedChanged += new System.EventHandler(this.ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter6
            // 
            this.ckbParameter6.AutoSize = true;
            this.ckbParameter6.Location = new System.Drawing.Point(13, 233);
            this.ckbParameter6.Name = "ckbParameter6";
            this.ckbParameter6.Size = new System.Drawing.Size(15, 14);
            this.ckbParameter6.TabIndex = 28;
            this.ckbParameter6.UseVisualStyleBackColor = true;
            this.ckbParameter6.Visible = false;
            // 
            // txtParameterValue6
            // 
            this.txtParameterValue6.Location = new System.Drawing.Point(160, 229);
            this.txtParameterValue6.MaxLength = 256;
            this.txtParameterValue6.Name = "txtParameterValue6";
            this.txtParameterValue6.Size = new System.Drawing.Size(196, 21);
            this.txtParameterValue6.TabIndex = 27;
            this.txtParameterValue6.Visible = false;
            this.txtParameterValue6.TextChanged += new System.EventHandler(this.txtParameterValue_TextChanged);
            this.txtParameterValue6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkHexString_KeyPress);
            // 
            // cboxParameterType6
            // 
            this.cboxParameterType6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxParameterType6.FormattingEnabled = true;
            this.cboxParameterType6.Location = new System.Drawing.Point(34, 230);
            this.cboxParameterType6.Name = "cboxParameterType6";
            this.cboxParameterType6.Size = new System.Drawing.Size(120, 20);
            this.cboxParameterType6.TabIndex = 26;
            this.cboxParameterType6.Visible = false;
            this.cboxParameterType6.SelectedIndexChanged += new System.EventHandler(this.cboxParameterType_SelectedIndexChanged);
            // 
            // ckbParameterHex5
            // 
            this.ckbParameterHex5.AutoSize = true;
            this.ckbParameterHex5.Location = new System.Drawing.Point(362, 198);
            this.ckbParameterHex5.Name = "ckbParameterHex5";
            this.ckbParameterHex5.Size = new System.Drawing.Size(42, 16);
            this.ckbParameterHex5.TabIndex = 25;
            this.ckbParameterHex5.Text = "Hex";
            this.ckbParameterHex5.UseVisualStyleBackColor = true;
            this.ckbParameterHex5.Visible = false;
            this.ckbParameterHex5.CheckedChanged += new System.EventHandler(this.ckbParameterHex_CheckedChanged);
            // 
            // rb0x
            // 
            this.rb0x.AutoSize = true;
            this.rb0x.Location = new System.Drawing.Point(155, 5);
            this.rb0x.Name = "rb0x";
            this.rb0x.Size = new System.Drawing.Size(35, 16);
            this.rb0x.TabIndex = 17;
            this.rb0x.TabStop = true;
            this.rb0x.Text = "0x";
            this.rb0x.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb0x);
            this.panel1.Controls.Add(this.rbComma);
            this.panel1.Controls.Add(this.rbNone);
            this.panel1.Controls.Add(this.rbBlank);
            this.panel1.Location = new System.Drawing.Point(499, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 26);
            this.panel1.TabIndex = 33;
            // 
            // rbComma
            // 
            this.rbComma.AutoSize = true;
            this.rbComma.Location = new System.Drawing.Point(84, 5);
            this.rbComma.Name = "rbComma";
            this.rbComma.Size = new System.Drawing.Size(47, 16);
            this.rbComma.TabIndex = 15;
            this.rbComma.Text = "逗号";
            this.rbComma.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(222, 5);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(35, 16);
            this.rbNone.TabIndex = 16;
            this.rbNone.Text = "无";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // rbBlank
            // 
            this.rbBlank.AutoSize = true;
            this.rbBlank.Checked = true;
            this.rbBlank.Location = new System.Drawing.Point(19, 5);
            this.rbBlank.Name = "rbBlank";
            this.rbBlank.Size = new System.Drawing.Size(47, 16);
            this.rbBlank.TabIndex = 14;
            this.rbBlank.TabStop = true;
            this.rbBlank.Text = "空格";
            this.rbBlank.UseVisualStyleBackColor = true;
            // 
            // ckbParameter5
            // 
            this.ckbParameter5.AutoSize = true;
            this.ckbParameter5.Location = new System.Drawing.Point(13, 198);
            this.ckbParameter5.Name = "ckbParameter5";
            this.ckbParameter5.Size = new System.Drawing.Size(15, 14);
            this.ckbParameter5.TabIndex = 24;
            this.ckbParameter5.UseVisualStyleBackColor = true;
            this.ckbParameter5.Visible = false;
            // 
            // gbParameterList
            // 
            this.gbParameterList.Controls.Add(this.btnAddOrMoveParameter10);
            this.gbParameterList.Controls.Add(this.btnAddOrMoveParameter9);
            this.gbParameterList.Controls.Add(this.ckbParameterHex10);
            this.gbParameterList.Controls.Add(this.ckbParameter10);
            this.gbParameterList.Controls.Add(this.txtParameterValue10);
            this.gbParameterList.Controls.Add(this.cboxParameterType10);
            this.gbParameterList.Controls.Add(this.ckbParameterHex9);
            this.gbParameterList.Controls.Add(this.ckbParameter9);
            this.gbParameterList.Controls.Add(this.txtParameterValue9);
            this.gbParameterList.Controls.Add(this.cboxParameterType9);
            this.gbParameterList.Controls.Add(this.btnAddOrMoveParameter8);
            this.gbParameterList.Controls.Add(this.btnAddOrMoveParameter7);
            this.gbParameterList.Controls.Add(this.ckbParameterHex8);
            this.gbParameterList.Controls.Add(this.ckbParameter8);
            this.gbParameterList.Controls.Add(this.txtParameterValue8);
            this.gbParameterList.Controls.Add(this.cboxParameterType8);
            this.gbParameterList.Controls.Add(this.ckbParameterHex7);
            this.gbParameterList.Controls.Add(this.ckbParameter7);
            this.gbParameterList.Controls.Add(this.txtParameterValue7);
            this.gbParameterList.Controls.Add(this.cboxParameterType7);
            this.gbParameterList.Controls.Add(this.btnAddOrMoveParameter6);
            this.gbParameterList.Controls.Add(this.btnAddOrMoveParameter5);
            this.gbParameterList.Controls.Add(this.btnAddOrMoveParameter4);
            this.gbParameterList.Controls.Add(this.ckbParameterHex6);
            this.gbParameterList.Controls.Add(this.ckbParameter6);
            this.gbParameterList.Controls.Add(this.txtParameterValue6);
            this.gbParameterList.Controls.Add(this.cboxParameterType6);
            this.gbParameterList.Controls.Add(this.ckbParameterHex5);
            this.gbParameterList.Controls.Add(this.ckbParameter5);
            this.gbParameterList.Controls.Add(this.txtParameterValue5);
            this.gbParameterList.Controls.Add(this.cboxParameterType5);
            this.gbParameterList.Controls.Add(this.ckbParameterHex4);
            this.gbParameterList.Controls.Add(this.ckbParameter4);
            this.gbParameterList.Controls.Add(this.txtParameterValue4);
            this.gbParameterList.Controls.Add(this.cboxParameterType4);
            this.gbParameterList.Controls.Add(this.btnAddOrMoveParameter3);
            this.gbParameterList.Controls.Add(this.btnAddOrMoveParameter2);
            this.gbParameterList.Controls.Add(this.btnAddOrMoveParameter1);
            this.gbParameterList.Controls.Add(this.ckbParameterHex3);
            this.gbParameterList.Controls.Add(this.ckbParameter3);
            this.gbParameterList.Controls.Add(this.txtParameterValue3);
            this.gbParameterList.Controls.Add(this.cboxParameterType3);
            this.gbParameterList.Controls.Add(this.ckbParameterHex2);
            this.gbParameterList.Controls.Add(this.ckbParameter2);
            this.gbParameterList.Controls.Add(this.txtParameterValue2);
            this.gbParameterList.Controls.Add(this.cboxParameterType2);
            this.gbParameterList.Controls.Add(this.ckbParameterHex1);
            this.gbParameterList.Controls.Add(this.ckbParameter1);
            this.gbParameterList.Controls.Add(this.txtParameterValue1);
            this.gbParameterList.Controls.Add(this.label6);
            this.gbParameterList.Controls.Add(this.cboxParameterType1);
            this.gbParameterList.Controls.Add(this.label5);
            this.gbParameterList.Location = new System.Drawing.Point(14, 143);
            this.gbParameterList.Name = "gbParameterList";
            this.gbParameterList.Size = new System.Drawing.Size(448, 407);
            this.gbParameterList.TabIndex = 27;
            this.gbParameterList.TabStop = false;
            this.gbParameterList.Text = "参数列表";
            // 
            // txtParameterValue5
            // 
            this.txtParameterValue5.Location = new System.Drawing.Point(160, 194);
            this.txtParameterValue5.MaxLength = 256;
            this.txtParameterValue5.Name = "txtParameterValue5";
            this.txtParameterValue5.Size = new System.Drawing.Size(196, 21);
            this.txtParameterValue5.TabIndex = 23;
            this.txtParameterValue5.Visible = false;
            this.txtParameterValue5.TextChanged += new System.EventHandler(this.txtParameterValue_TextChanged);
            this.txtParameterValue5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkHexString_KeyPress);
            // 
            // cboxParameterType5
            // 
            this.cboxParameterType5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxParameterType5.FormattingEnabled = true;
            this.cboxParameterType5.Location = new System.Drawing.Point(34, 195);
            this.cboxParameterType5.Name = "cboxParameterType5";
            this.cboxParameterType5.Size = new System.Drawing.Size(120, 20);
            this.cboxParameterType5.TabIndex = 22;
            this.cboxParameterType5.Visible = false;
            this.cboxParameterType5.SelectedIndexChanged += new System.EventHandler(this.cboxParameterType_SelectedIndexChanged);
            // 
            // ckbParameterHex4
            // 
            this.ckbParameterHex4.AutoSize = true;
            this.ckbParameterHex4.Location = new System.Drawing.Point(362, 163);
            this.ckbParameterHex4.Name = "ckbParameterHex4";
            this.ckbParameterHex4.Size = new System.Drawing.Size(42, 16);
            this.ckbParameterHex4.TabIndex = 21;
            this.ckbParameterHex4.Text = "Hex";
            this.ckbParameterHex4.UseVisualStyleBackColor = true;
            this.ckbParameterHex4.Visible = false;
            this.ckbParameterHex4.CheckedChanged += new System.EventHandler(this.ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter4
            // 
            this.ckbParameter4.AutoSize = true;
            this.ckbParameter4.Location = new System.Drawing.Point(13, 163);
            this.ckbParameter4.Name = "ckbParameter4";
            this.ckbParameter4.Size = new System.Drawing.Size(15, 14);
            this.ckbParameter4.TabIndex = 20;
            this.ckbParameter4.UseVisualStyleBackColor = true;
            this.ckbParameter4.Visible = false;
            // 
            // txtParameterValue4
            // 
            this.txtParameterValue4.Location = new System.Drawing.Point(160, 159);
            this.txtParameterValue4.MaxLength = 256;
            this.txtParameterValue4.Name = "txtParameterValue4";
            this.txtParameterValue4.Size = new System.Drawing.Size(196, 21);
            this.txtParameterValue4.TabIndex = 19;
            this.txtParameterValue4.Visible = false;
            this.txtParameterValue4.TextChanged += new System.EventHandler(this.txtParameterValue_TextChanged);
            this.txtParameterValue4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkHexString_KeyPress);
            // 
            // cboxParameterType4
            // 
            this.cboxParameterType4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxParameterType4.FormattingEnabled = true;
            this.cboxParameterType4.Location = new System.Drawing.Point(34, 160);
            this.cboxParameterType4.Name = "cboxParameterType4";
            this.cboxParameterType4.Size = new System.Drawing.Size(120, 20);
            this.cboxParameterType4.TabIndex = 18;
            this.cboxParameterType4.Visible = false;
            this.cboxParameterType4.SelectedIndexChanged += new System.EventHandler(this.cboxParameterType_SelectedIndexChanged);
            // 
            // btnAddOrMoveParameter3
            // 
            this.btnAddOrMoveParameter3.Location = new System.Drawing.Point(410, 124);
            this.btnAddOrMoveParameter3.Name = "btnAddOrMoveParameter3";
            this.btnAddOrMoveParameter3.Size = new System.Drawing.Size(27, 23);
            this.btnAddOrMoveParameter3.TabIndex = 16;
            this.btnAddOrMoveParameter3.Text = "+";
            this.btnAddOrMoveParameter3.UseVisualStyleBackColor = true;
            this.btnAddOrMoveParameter3.Visible = false;
            this.btnAddOrMoveParameter3.Click += new System.EventHandler(this.btnAddOrMoveParameter_Click);
            // 
            // btnAddOrMoveParameter2
            // 
            this.btnAddOrMoveParameter2.Location = new System.Drawing.Point(410, 89);
            this.btnAddOrMoveParameter2.Name = "btnAddOrMoveParameter2";
            this.btnAddOrMoveParameter2.Size = new System.Drawing.Size(27, 23);
            this.btnAddOrMoveParameter2.TabIndex = 15;
            this.btnAddOrMoveParameter2.Text = "+";
            this.btnAddOrMoveParameter2.UseVisualStyleBackColor = true;
            this.btnAddOrMoveParameter2.Click += new System.EventHandler(this.btnAddOrMoveParameter_Click);
            // 
            // btnAddOrMoveParameter1
            // 
            this.btnAddOrMoveParameter1.Location = new System.Drawing.Point(410, 54);
            this.btnAddOrMoveParameter1.Name = "btnAddOrMoveParameter1";
            this.btnAddOrMoveParameter1.Size = new System.Drawing.Size(27, 23);
            this.btnAddOrMoveParameter1.TabIndex = 14;
            this.btnAddOrMoveParameter1.Text = "－";
            this.btnAddOrMoveParameter1.UseVisualStyleBackColor = true;
            this.btnAddOrMoveParameter1.Click += new System.EventHandler(this.btnAddOrMoveParameter_Click);
            // 
            // ckbParameterHex3
            // 
            this.ckbParameterHex3.AutoSize = true;
            this.ckbParameterHex3.Location = new System.Drawing.Point(362, 128);
            this.ckbParameterHex3.Name = "ckbParameterHex3";
            this.ckbParameterHex3.Size = new System.Drawing.Size(42, 16);
            this.ckbParameterHex3.TabIndex = 13;
            this.ckbParameterHex3.Text = "Hex";
            this.ckbParameterHex3.UseVisualStyleBackColor = true;
            this.ckbParameterHex3.Visible = false;
            this.ckbParameterHex3.CheckedChanged += new System.EventHandler(this.ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter3
            // 
            this.ckbParameter3.AutoSize = true;
            this.ckbParameter3.Location = new System.Drawing.Point(13, 128);
            this.ckbParameter3.Name = "ckbParameter3";
            this.ckbParameter3.Size = new System.Drawing.Size(15, 14);
            this.ckbParameter3.TabIndex = 12;
            this.ckbParameter3.UseVisualStyleBackColor = true;
            this.ckbParameter3.Visible = false;
            // 
            // txtParameterValue3
            // 
            this.txtParameterValue3.Location = new System.Drawing.Point(160, 124);
            this.txtParameterValue3.MaxLength = 256;
            this.txtParameterValue3.Name = "txtParameterValue3";
            this.txtParameterValue3.Size = new System.Drawing.Size(196, 21);
            this.txtParameterValue3.TabIndex = 11;
            this.txtParameterValue3.Visible = false;
            this.txtParameterValue3.TextChanged += new System.EventHandler(this.txtParameterValue_TextChanged);
            this.txtParameterValue3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkHexString_KeyPress);
            // 
            // cboxParameterType3
            // 
            this.cboxParameterType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxParameterType3.FormattingEnabled = true;
            this.cboxParameterType3.Location = new System.Drawing.Point(34, 125);
            this.cboxParameterType3.Name = "cboxParameterType3";
            this.cboxParameterType3.Size = new System.Drawing.Size(120, 20);
            this.cboxParameterType3.TabIndex = 10;
            this.cboxParameterType3.Visible = false;
            this.cboxParameterType3.SelectedIndexChanged += new System.EventHandler(this.cboxParameterType_SelectedIndexChanged);
            // 
            // ckbParameterHex2
            // 
            this.ckbParameterHex2.AutoSize = true;
            this.ckbParameterHex2.Location = new System.Drawing.Point(362, 93);
            this.ckbParameterHex2.Name = "ckbParameterHex2";
            this.ckbParameterHex2.Size = new System.Drawing.Size(42, 16);
            this.ckbParameterHex2.TabIndex = 9;
            this.ckbParameterHex2.Text = "Hex";
            this.ckbParameterHex2.UseVisualStyleBackColor = true;
            this.ckbParameterHex2.Visible = false;
            this.ckbParameterHex2.CheckedChanged += new System.EventHandler(this.ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter2
            // 
            this.ckbParameter2.AutoSize = true;
            this.ckbParameter2.Location = new System.Drawing.Point(13, 93);
            this.ckbParameter2.Name = "ckbParameter2";
            this.ckbParameter2.Size = new System.Drawing.Size(15, 14);
            this.ckbParameter2.TabIndex = 8;
            this.ckbParameter2.UseVisualStyleBackColor = true;
            this.ckbParameter2.Visible = false;
            // 
            // txtParameterValue2
            // 
            this.txtParameterValue2.Location = new System.Drawing.Point(160, 89);
            this.txtParameterValue2.MaxLength = 256;
            this.txtParameterValue2.Name = "txtParameterValue2";
            this.txtParameterValue2.Size = new System.Drawing.Size(196, 21);
            this.txtParameterValue2.TabIndex = 7;
            this.txtParameterValue2.Visible = false;
            this.txtParameterValue2.TextChanged += new System.EventHandler(this.txtParameterValue_TextChanged);
            this.txtParameterValue2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkHexString_KeyPress);
            // 
            // cboxParameterType2
            // 
            this.cboxParameterType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxParameterType2.FormattingEnabled = true;
            this.cboxParameterType2.Location = new System.Drawing.Point(34, 90);
            this.cboxParameterType2.Name = "cboxParameterType2";
            this.cboxParameterType2.Size = new System.Drawing.Size(120, 20);
            this.cboxParameterType2.TabIndex = 6;
            this.cboxParameterType2.Visible = false;
            this.cboxParameterType2.SelectedIndexChanged += new System.EventHandler(this.cboxParameterType_SelectedIndexChanged);
            // 
            // ckbParameterHex1
            // 
            this.ckbParameterHex1.AutoSize = true;
            this.ckbParameterHex1.Location = new System.Drawing.Point(362, 58);
            this.ckbParameterHex1.Name = "ckbParameterHex1";
            this.ckbParameterHex1.Size = new System.Drawing.Size(42, 16);
            this.ckbParameterHex1.TabIndex = 5;
            this.ckbParameterHex1.Text = "Hex";
            this.ckbParameterHex1.UseVisualStyleBackColor = true;
            this.ckbParameterHex1.CheckedChanged += new System.EventHandler(this.ckbParameterHex_CheckedChanged);
            // 
            // ckbParameter1
            // 
            this.ckbParameter1.AutoSize = true;
            this.ckbParameter1.Location = new System.Drawing.Point(13, 58);
            this.ckbParameter1.Name = "ckbParameter1";
            this.ckbParameter1.Size = new System.Drawing.Size(15, 14);
            this.ckbParameter1.TabIndex = 4;
            this.ckbParameter1.UseVisualStyleBackColor = true;
            // 
            // txtParameterValue1
            // 
            this.txtParameterValue1.Location = new System.Drawing.Point(160, 54);
            this.txtParameterValue1.MaxLength = 256;
            this.txtParameterValue1.Name = "txtParameterValue1";
            this.txtParameterValue1.Size = new System.Drawing.Size(196, 21);
            this.txtParameterValue1.TabIndex = 3;
            this.txtParameterValue1.TextChanged += new System.EventHandler(this.txtParameterValue_TextChanged);
            this.txtParameterValue1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkHexString_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "参数值";
            // 
            // cboxParameterType1
            // 
            this.cboxParameterType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxParameterType1.FormattingEnabled = true;
            this.cboxParameterType1.Location = new System.Drawing.Point(34, 55);
            this.cboxParameterType1.Name = "cboxParameterType1";
            this.cboxParameterType1.Size = new System.Drawing.Size(120, 20);
            this.cboxParameterType1.TabIndex = 1;
            this.cboxParameterType1.SelectedIndexChanged += new System.EventHandler(this.cboxParameterType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "参数类型";
            // 
            // cboxMessageId
            // 
            this.cboxMessageId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMessageId.FormattingEnabled = true;
            this.cboxMessageId.Location = new System.Drawing.Point(83, 49);
            this.cboxMessageId.Name = "cboxMessageId";
            this.cboxMessageId.Size = new System.Drawing.Size(200, 20);
            this.cboxMessageId.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "消息ID：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "消息类型：";
            // 
            // cboxMessageType
            // 
            this.cboxMessageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMessageType.FormattingEnabled = true;
            this.cboxMessageType.Location = new System.Drawing.Point(83, 11);
            this.cboxMessageType.Name = "cboxMessageType";
            this.cboxMessageType.Size = new System.Drawing.Size(200, 20);
            this.cboxMessageType.TabIndex = 23;
            this.cboxMessageType.SelectedIndexChanged += new System.EventHandler(this.cboxMessageType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "灯具ID：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "网关ID：";
            // 
            // txtLuminaireId
            // 
            this.txtLuminaireId.Location = new System.Drawing.Point(223, 87);
            this.txtLuminaireId.MaxLength = 8;
            this.txtLuminaireId.Name = "txtLuminaireId";
            this.txtLuminaireId.Size = new System.Drawing.Size(60, 21);
            this.txtLuminaireId.TabIndex = 20;
            this.txtLuminaireId.Text = "FFFFFFFF";
            this.txtLuminaireId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkHexString_KeyPress);
            // 
            // txtGatewayId
            // 
            this.txtGatewayId.Location = new System.Drawing.Point(83, 87);
            this.txtGatewayId.MaxLength = 8;
            this.txtGatewayId.Name = "txtGatewayId";
            this.txtGatewayId.Size = new System.Drawing.Size(60, 21);
            this.txtGatewayId.TabIndex = 19;
            this.txtGatewayId.Text = "00000001";
            this.txtGatewayId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkHexString_KeyPress);
            // 
            // Generater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtMessage2);
            this.Controls.Add(this.txtMessage1);
            this.Controls.Add(this.gbErrorCodeAndInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbParameterList);
            this.Controls.Add(this.cboxMessageId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxMessageType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLuminaireId);
            this.Controls.Add(this.txtGatewayId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Generater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSA018命令生成/解析器";
            this.Load += new System.EventHandler(this.Generater_Load);
            this.gbErrorCodeAndInfo.ResumeLayout(false);
            this.gbErrorCodeAndInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbParameterList.ResumeLayout(false);
            this.gbParameterList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

