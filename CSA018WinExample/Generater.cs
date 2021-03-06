﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using ThisCoder.CSA018;

namespace ThisCoder.CSA018WinExample
{
    public partial class Generater : Form
    {
        public uint SeqNumber { get; set; }

        public Generater()
        {
            InitializeComponent();
        }

        private void Generater_Load(object sender, EventArgs e)
        {
            BindingCombox(cboxMessageType, typeof(MessageType));
            BindingCombox(cboxMessageId, typeof(MessageId));

            cboxParameterType1.SelectedIndexChanged -= cboxParameterType_SelectedIndexChanged;
            cboxParameterType2.SelectedIndexChanged -= cboxParameterType_SelectedIndexChanged;
            cboxParameterType3.SelectedIndexChanged -= cboxParameterType_SelectedIndexChanged;
            cboxParameterType4.SelectedIndexChanged -= cboxParameterType_SelectedIndexChanged;
            cboxParameterType5.SelectedIndexChanged -= cboxParameterType_SelectedIndexChanged;
            cboxParameterType6.SelectedIndexChanged -= cboxParameterType_SelectedIndexChanged;
            cboxParameterType7.SelectedIndexChanged -= cboxParameterType_SelectedIndexChanged;
            cboxParameterType8.SelectedIndexChanged -= cboxParameterType_SelectedIndexChanged;
            cboxParameterType9.SelectedIndexChanged -= cboxParameterType_SelectedIndexChanged;
            cboxParameterType10.SelectedIndexChanged -= cboxParameterType_SelectedIndexChanged;

            BindingCombox(cboxParameterType1, typeof(ParameterType));
            BindingCombox(cboxParameterType2, typeof(ParameterType));
            BindingCombox(cboxParameterType3, typeof(ParameterType));
            BindingCombox(cboxParameterType4, typeof(ParameterType));
            BindingCombox(cboxParameterType5, typeof(ParameterType));
            BindingCombox(cboxParameterType6, typeof(ParameterType));
            BindingCombox(cboxParameterType7, typeof(ParameterType));
            BindingCombox(cboxParameterType8, typeof(ParameterType));
            BindingCombox(cboxParameterType9, typeof(ParameterType));
            BindingCombox(cboxParameterType10, typeof(ParameterType));

            cboxParameterType1.SelectedIndexChanged += cboxParameterType_SelectedIndexChanged;
            cboxParameterType2.SelectedIndexChanged += cboxParameterType_SelectedIndexChanged;
            cboxParameterType3.SelectedIndexChanged += cboxParameterType_SelectedIndexChanged;
            cboxParameterType4.SelectedIndexChanged += cboxParameterType_SelectedIndexChanged;
            cboxParameterType5.SelectedIndexChanged += cboxParameterType_SelectedIndexChanged;
            cboxParameterType6.SelectedIndexChanged += cboxParameterType_SelectedIndexChanged;
            cboxParameterType7.SelectedIndexChanged += cboxParameterType_SelectedIndexChanged;
            cboxParameterType8.SelectedIndexChanged += cboxParameterType_SelectedIndexChanged;
            cboxParameterType9.SelectedIndexChanged += cboxParameterType_SelectedIndexChanged;
            cboxParameterType10.SelectedIndexChanged += cboxParameterType_SelectedIndexChanged;

            BindingCombox(cboxErrorCode, typeof(ErrorCode));
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtMessage1.Text = "";
            txtMessage2.Text = "";
            MessageType messageType;
            byte[] cmd;
            KeyValuePair<string, string> msgTypeItem;

            try
            {
                msgTypeItem = (KeyValuePair<string, string>)cboxMessageType.SelectedItem;
            }
            catch
            {
                MessageBox.Show("请选择消息类型！");
                return;
            }

            if (Enum.TryParse(msgTypeItem.Key, out messageType))
            {
                if (messageType == MessageType.HeartbeatData)
                {
                    cmd = new byte[] {
                        new CreateCommand().GetHeartbeatDataCommand()
                    };
                }
                else if (messageType == MessageType.HeartbeatResponse)
                {
                    cmd = new byte[] {
                        new CreateCommand().GetHeartbeatResponseCommand()
                    };
                }
                else if (messageType == MessageType.CommandACK)
                {
                    cmd = new CreateCommand(messageType).GetResponseCommand(SeqNumber);
                }
                else if (messageType == MessageType.EventACK)
                {
                    cmd = new CreateCommand(messageType).GetEventResponseCommand(SeqNumber);
                }
                else
                {
                    string gatewayIdString = txtGatewayId.Text.Trim();

                    if (gatewayIdString.IsNullOrEmpty())
                    {
                        MessageBox.Show("网关ID不能为空！");
                        return;
                    }

                    byte[] gatewayIdByteArray = gatewayIdString.ToByteArray(true);
                    byte[] luminaireIdByteArray = txtLuminaireId.Text.Trim().ToByteArray(true);
                    uint gatewayId = 0;
                    uint luminaireId = 0;
                    MessageId messageId;
                    KeyValuePair<string, string> msgIdItem;

                    try
                    {
                        msgIdItem = (KeyValuePair<string, string>)cboxMessageId.SelectedItem;
                    }
                    catch
                    {
                        MessageBox.Show("请选择消息ID！");
                        return;
                    }

                    for (int i = gatewayIdByteArray.Length - 1, j = 0; i >= 0 && j < 4; i--, j++)
                    {
                        gatewayId += (uint)(gatewayIdByteArray[i] << (8 * j));
                    }

                    for (int k = luminaireIdByteArray.Length - 1, l = 0; k >= 0 && l < 4; k--, l++)
                    {
                        luminaireId += (uint)(luminaireIdByteArray[k] << (8 * l));
                    }

                    if (Enum.TryParse(msgIdItem.Key, out messageId))
                    {
                        CreateCommand cc = new CreateCommand(messageType, gatewayId, luminaireId);

                        if (messageType == MessageType.CommandResult)
                        {
                            ErrorCode errorCode;
                            KeyValuePair<string, string> errorCodeItem;

                            try
                            {
                                errorCodeItem = (KeyValuePair<string, string>)cboxErrorCode.SelectedItem;
                            }
                            catch
                            {
                                MessageBox.Show("错误代码不能为空！");
                                return;
                            }

                            if (Enum.TryParse(errorCodeItem.Key, out errorCode))
                            {
                                cmd = cc.GetResultCommand(SeqNumber, messageId, errorCode, txtErrorInfo.Text.Trim());
                            }
                            else
                            {
                                MessageBox.Show("错误代码不能为空！");
                                return;
                            }
                        }
                        else
                        {
                            List<Parameter> parameterList = new List<Parameter>();

                            try
                            {
                                SetParameterList(ref parameterList, ckbParameter1, cboxParameterType1, txtParameterValue1, ckbParameterHex1, cboxParameterValue1);
                                SetParameterList(ref parameterList, ckbParameter2, cboxParameterType2, txtParameterValue2, ckbParameterHex2, cboxParameterValue2);
                                SetParameterList(ref parameterList, ckbParameter3, cboxParameterType3, txtParameterValue3, ckbParameterHex3, cboxParameterValue3);
                                SetParameterList(ref parameterList, ckbParameter4, cboxParameterType4, txtParameterValue4, ckbParameterHex4, cboxParameterValue4);
                                SetParameterList(ref parameterList, ckbParameter5, cboxParameterType5, txtParameterValue5, ckbParameterHex5, cboxParameterValue5);
                                SetParameterList(ref parameterList, ckbParameter6, cboxParameterType6, txtParameterValue6, ckbParameterHex6, cboxParameterValue6);
                                SetParameterList(ref parameterList, ckbParameter7, cboxParameterType7, txtParameterValue7, ckbParameterHex7, cboxParameterValue7);
                                SetParameterList(ref parameterList, ckbParameter8, cboxParameterType8, txtParameterValue8, ckbParameterHex8, cboxParameterValue8);
                                SetParameterList(ref parameterList, ckbParameter9, cboxParameterType9, txtParameterValue9, ckbParameterHex9, cboxParameterValue9);
                                SetParameterList(ref parameterList, ckbParameter10, cboxParameterType10, txtParameterValue10, ckbParameterHex10, cboxParameterValue10);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return;
                            }

                            if (messageType == MessageType.Command)
                            {
                                cmd = cc.GetRequestCommand(messageId, parameterList);
                            }
                            else
                            {
                                cmd = cc.GetEventCommand(messageId, parameterList);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选择消息ID！");
                        return;
                    }
                }

                string separator = rbBlank.Checked ? " " : (rbComma.Checked ? "," : (rb0x.Checked ? ",0x" : ""));
                txtMessage1.Text = (rb0x.Checked ? "0x" : "") + cmd.ToHexString(separator);

                try
                {
                    ParseCommand pc = new ParseCommand(cmd);
                    pc.DatagramProcess += Oa_DatagramProcess;
                    pc.OnDatagramProcess();
                }
                catch (Exception ex)
                {
                    txtMessage1.Clear();
                    MessageBox.Show(ex.Message + "\n" + ex.InnerException?.Message);
                }
            }
            else
            {
                MessageBox.Show("请选择消息类型！");
            }
        }

        private void SetParameterList(ref List<Parameter> parameterList, CheckBox ckbParameter, ComboBox cboxParameterType, TextBox txtParameterValue, CheckBox ckbParameterHex, ComboBox cboxParameterValue)
        {
            ParameterType parameterType;
            string parameterValue;
            KeyValuePair<string, string> parTypeItme;

            try
            {
                parTypeItme = (KeyValuePair<string, string>)cboxParameterType.SelectedItem;
            }
            catch
            {
                return;
            }

            if (ckbParameter.Visible && ckbParameter.Checked && Enum.TryParse(parTypeItme.Key, out parameterType))
            {
                int resType = GetResourceType(cboxParameterType);

                if (resType == 0)
                {
                    parameterValue = txtParameterValue.Text.Trim();

                    if (!parameterValue.IsNullOrEmpty())
                    {
                        if (ckbParameterHex.Checked)
                        {
                            parameterList.Add(new Parameter(parameterType, parameterValue.ToByteArray(true)));
                        }
                        else
                        {
                            parameterList.Add(new Parameter(parameterType, parameterValue));
                        }
                    }
                }
                else
                {
                    KeyValuePair<string, string> parValueItme;

                    try
                    {
                        parValueItme = (KeyValuePair<string, string>)cboxParameterValue.SelectedItem;
                    }
                    catch
                    {
                        return;
                    }

                    if (resType == 1)
                    {
                        parameterValue = Encoding.UTF8.GetString(((uint)((ResourceType)Enum.Parse(typeof(ResourceType), parValueItme.Key))).ToString("X4").ToByteArray(true));
                    }
                    else if (resType == 2)
                    {
                        parameterValue = Encoding.UTF8.GetString(((uint)((ResourceType2)Enum.Parse(typeof(ResourceType2), parValueItme.Key))).ToString("X4").ToByteArray(true));
                    }
                    else if (resType == 3)
                    {
                        parameterValue = Encoding.UTF8.GetString(((uint)((StrategyType)Enum.Parse(typeof(StrategyType), parValueItme.Key))).ToString("X4").ToByteArray(true));
                    }
                    else
                    {
                        return;
                    }

                    parameterList.Add(new Parameter(parameterType, parameterValue));
                }
            }
        }

        private void Oa_DatagramProcess(object sender, DatagramEventArgs e)
        {
            if (e.DatagramList.Count > 0)
            {
                string cmdRemarkString = "--------------------------------------";

                foreach (var datagram in e.DatagramList)
                {
                    if (datagram.Head.Type == MessageType.HeartbeatData)
                    {
                        cmdRemarkString += "\r\n| 心跳包数据：FF                     |";
                    }
                    else if (datagram.Head.Type == MessageType.HeartbeatResponse)
                    {
                        cmdRemarkString += "\r\n| 心跳包响应：FE                     |";
                    }
                    else
                    {
                        cmdRemarkString += "\r\n|                 起始符：" + datagram.Stx.ToString("X2") + "         |";
                        cmdRemarkString += "\r\n|------------------------------------|";
                        cmdRemarkString += "\r\n|    |          消息类型：" + ((ushort)(datagram.Head.Type)).ToString("X2") + "         |" + "<-" + GetEnumValueDescription(typeof(MessageType), datagram.Head.Type.ToString());
                        cmdRemarkString += "\r\n| 消 |          消息序号：" + datagram.Head.SeqNumber.ToString("X8") + "   |";
                        cmdRemarkString += "\r\n| 息 |        消息体长度：" + datagram.Head.Length.ToString("X4") + "       |";
                        cmdRemarkString += "\r\n| 头 |              预留：" + datagram.Head.Reserved.ToString("X10") + " |";
                        cmdRemarkString += "\r\n|    |     消息体CRC校验：" + datagram.Head.Crc32.ToString("X8") + "   |";

                        if (datagram.Head.Type != MessageType.CommandACK
                            && datagram.Head.Type != MessageType.EventACK)
                        {
                            cmdRemarkString += "\r\n|------------------------------------|";
                            cmdRemarkString += "\r\n| 消 |            消息ID：" + ((ushort)(datagram.Body.MessageId)).ToString("X4") + "       |" + "<-" + GetEnumValueDescription(typeof(MessageId), datagram.Body.MessageId.ToString());
                            cmdRemarkString += "\r\n| 息 |            网关ID：" + datagram.Body.GatewayId.ToString("X8") + "   |";
                            cmdRemarkString += "\r\n| 体 |            灯具ID：" + datagram.Body.LuminaireId.ToString("X8") + "   |";

                            if (datagram.Head.Type != MessageType.CommandResult)
                            {
                                SeqNumber = datagram.Head.SeqNumber;

                                for (int i = 0; i < datagram.Body.ParameterList?.Count; i++)
                                {
                                    cmdRemarkString += "\r\n|    |-------------------------------|";
                                    cmdRemarkString += "\r\n|    | 参 ｜    参数类型：" + ((ushort)datagram.Body.ParameterList[i].Type).ToString("X4") + "       |" + "<-" + GetEnumValueDescription(typeof(ParameterType), datagram.Body.ParameterList[i].Type.ToString());

                                    if (datagram.Body.ParameterList[i].Type == ParameterType.GatewayId
                                        || datagram.Body.ParameterList[i].Type == ParameterType.LuminaireId)
                                    {
                                        cmdRemarkString += "\r\n|    | 数 ｜      参数值：" + datagram.Body.ParameterList[i].Value.ToHexString("") + "   |";
                                    }
                                    else
                                    {
                                        cmdRemarkString += "\r\n|    | 数 ｜      参数值：\"" + DisplayParameterValue(datagram.Body.ParameterList[i].Value.ToString2()) + "|" + GetParameterValueDescription(datagram.Body.ParameterList[i].Type, datagram.Body.ParameterList[i].Value.ToString2());
                                    }

                                    cmdRemarkString += "\r\n|    | " + (i + 1).ToString().PadRight(2, ' ') + " | 参数值结束符：" + datagram.Body.ParameterList[i].End.ToString("X2") + "         |";
                                }
                            }
                            else
                            {
                                cmdRemarkString += "\r\n|    |          错误代码：\""
                                    + Encoding.UTF8.GetString(
                                        new byte[] {
                                            (byte)((uint)(datagram.Body.ErrorCode) >> 24),
                                            (byte)((uint)(datagram.Body.ErrorCode) >> 16),
                                            (byte)((uint)(datagram.Body.ErrorCode) >> 8),
                                            (byte)(datagram.Body.ErrorCode)
                                        }) + "\"     |";

                                if (datagram.Body.ErrorInfo != null)
                                {
                                    cmdRemarkString += "\r\n|    |          错误信息：\"" + datagram.Body.ErrorInfo.TrimEnd('\0') + "\"     |";
                                }
                            }
                        }

                        cmdRemarkString += "\r\n|------------------------------------|";
                        cmdRemarkString += "\r\n|                 结束符：" + datagram.Etx.ToString("X2") + "         |";
                    }

                    cmdRemarkString += "\r\n--------------------------------------";
                }

                txtMessage2.Text = cmdRemarkString;
            }
            else
            {
                MessageBox.Show("命令错误!");
            }
        }

        private string DisplayParameterValue(string value)
        {
            string blankString = string.Empty;

            if (value.Length < 9)
            {
                for (int i = 0; i < 9 - value.Length; i++)
                {
                    blankString += " ";
                }
            }

            return value + "\"" + blankString;
        }

        private string GetParameterValueDescription(ParameterType parType, string parValue)
        {
            if (parType == ParameterType.ResourceType)
            {
                foreach (var fieldInfo in typeof(ResourceType).GetFields())
                {
                    if (fieldInfo.FieldType.IsEnum && Encoding.UTF8.GetString(((ushort)((ResourceType)(Enum.Parse(typeof(ResourceType), fieldInfo.Name)))).ToString("X4").ToByteArray(true)) == parValue)
                    {
                        foreach (var attr in fieldInfo.GetCustomAttributes(false))
                        {
                            if (attr is DescriptionAttribute)
                            {
                                return "<-" + (attr as DescriptionAttribute)?.Description;
                            }
                        }
                    }
                }
            }
            else if (parType == ParameterType.ResourceType2)
            {
                foreach (var fieldInfo in typeof(ResourceType2).GetFields())
                {
                    if (fieldInfo.FieldType.IsEnum && Encoding.UTF8.GetString(((ushort)((ResourceType2)(Enum.Parse(typeof(ResourceType2), fieldInfo.Name)))).ToString("X4").ToByteArray(true)) == parValue)
                    {
                        foreach (var attr in fieldInfo.GetCustomAttributes(false))
                        {
                            if (attr is DescriptionAttribute)
                            {
                                return "<-" + (attr as DescriptionAttribute)?.Description;
                            }
                        }
                    }
                }
            }
            else if (parType == ParameterType.StrategyType)
            {
                foreach (var fieldInfo in typeof(StrategyType).GetFields())
                {
                    if (fieldInfo.FieldType.IsEnum && Encoding.UTF8.GetString(((ushort)((StrategyType)(Enum.Parse(typeof(StrategyType), fieldInfo.Name)))).ToString("X4").ToByteArray(true)) == parValue)
                    {
                        foreach (var attr in fieldInfo.GetCustomAttributes(false))
                        {
                            if (attr is DescriptionAttribute)
                            {
                                return "<-" + (attr as DescriptionAttribute)?.Description;
                            }
                        }
                    }
                }
            }
            else
            {
                return string.Empty;
            }

            return string.Empty;
        }

        private string GetEnumValueDescription(Type type, string enumString)
        {
            foreach (var fieldInfo in type.GetFields())
            {
                if (fieldInfo.FieldType.IsEnum && fieldInfo.Name == enumString)
                {
                    foreach (var attr in fieldInfo.GetCustomAttributes(false))
                    {
                        if (attr is DescriptionAttribute)
                        {
                            return (attr as DescriptionAttribute)?.Description;
                        }
                    }
                }
            }

            return enumString;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboxMessageType.SelectedIndex = 0;
            cboxMessageId.SelectedIndex = 0;
            txtGatewayId.Text = "00000001";
            txtLuminaireId.Text = "FFFFFFFF";
            ckbParameter1.Checked = false;
            ckbParameter1.Visible = true;
            ckbParameter2.Checked = false;
            ckbParameter2.Visible = false;
            ckbParameter3.Checked = false;
            ckbParameter3.Visible = false;
            ckbParameter4.Checked = false;
            ckbParameter4.Visible = false;
            ckbParameter5.Checked = false;
            ckbParameter5.Visible = false;
            ckbParameter6.Checked = false;
            ckbParameter6.Visible = false;
            ckbParameter7.Checked = false;
            ckbParameter7.Visible = false;
            ckbParameter8.Checked = false;
            ckbParameter8.Visible = false;
            ckbParameter9.Checked = false;
            ckbParameter9.Visible = false;
            ckbParameter10.Checked = false;
            ckbParameter10.Visible = false;
            cboxParameterType1.SelectedIndex = 0;
            cboxParameterType1.Visible = true;
            cboxParameterType2.SelectedIndex = 0;
            cboxParameterType2.Visible = false;
            cboxParameterType3.SelectedIndex = 0;
            cboxParameterType3.Visible = false;
            cboxParameterType4.SelectedIndex = 0;
            cboxParameterType4.Visible = false;
            cboxParameterType5.SelectedIndex = 0;
            cboxParameterType5.Visible = false;
            cboxParameterType6.SelectedIndex = 0;
            cboxParameterType6.Visible = false;
            cboxParameterType7.SelectedIndex = 0;
            cboxParameterType7.Visible = false;
            cboxParameterType8.SelectedIndex = 0;
            cboxParameterType8.Visible = false;
            cboxParameterType9.SelectedIndex = 0;
            cboxParameterType9.Visible = false;
            cboxParameterType10.SelectedIndex = 0;
            cboxParameterType10.Visible = false;
            txtParameterValue1.Text = "";
            txtParameterValue1.Visible = true;
            txtParameterValue2.Text = "";
            txtParameterValue2.Visible = false;
            txtParameterValue3.Text = "";
            txtParameterValue3.Visible = false;
            txtParameterValue4.Text = "";
            txtParameterValue4.Visible = false;
            txtParameterValue5.Text = "";
            txtParameterValue5.Visible = false;
            txtParameterValue6.Text = "";
            txtParameterValue6.Visible = false;
            txtParameterValue7.Text = "";
            txtParameterValue7.Visible = false;
            txtParameterValue8.Text = "";
            txtParameterValue8.Visible = false;
            txtParameterValue9.Text = "";
            txtParameterValue9.Visible = false;
            txtParameterValue10.Text = "";
            txtParameterValue10.Visible = false;
            ckbParameterHex1.Checked = false;
            ckbParameterHex1.Visible = true;
            ckbParameterHex2.Checked = false;
            ckbParameterHex2.Visible = false;
            ckbParameterHex3.Checked = false;
            ckbParameterHex3.Visible = false;
            ckbParameterHex4.Checked = false;
            ckbParameterHex4.Visible = false;
            ckbParameterHex5.Checked = false;
            ckbParameterHex5.Visible = false;
            ckbParameterHex6.Checked = false;
            ckbParameterHex6.Visible = false;
            ckbParameterHex7.Checked = false;
            ckbParameterHex7.Visible = false;
            ckbParameterHex8.Checked = false;
            ckbParameterHex8.Visible = false;
            ckbParameterHex9.Checked = false;
            ckbParameterHex9.Visible = false;
            ckbParameterHex10.Checked = false;
            ckbParameterHex10.Visible = false;
            cboxParameterValue1.Visible = false;
            cboxParameterValue2.Visible = false;
            cboxParameterValue3.Visible = false;
            cboxParameterValue4.Visible = false;
            cboxParameterValue5.Visible = false;
            cboxParameterValue6.Visible = false;
            cboxParameterValue7.Visible = false;
            cboxParameterValue8.Visible = false;
            cboxParameterValue9.Visible = false;
            cboxParameterValue10.Visible = false;
            btnAddOrMoveParameter1.Text = "-";
            btnAddOrMoveParameter1.Visible = true;
            btnAddOrMoveParameter2.Text = "+";
            btnAddOrMoveParameter2.Visible = true;
            btnAddOrMoveParameter3.Text = "+";
            btnAddOrMoveParameter3.Visible = false;
            btnAddOrMoveParameter4.Text = "+";
            btnAddOrMoveParameter4.Visible = false;
            btnAddOrMoveParameter5.Text = "+";
            btnAddOrMoveParameter5.Visible = false;
            btnAddOrMoveParameter6.Text = "+";
            btnAddOrMoveParameter6.Visible = false;
            btnAddOrMoveParameter7.Text = "+";
            btnAddOrMoveParameter7.Visible = false;
            btnAddOrMoveParameter8.Text = "+";
            btnAddOrMoveParameter8.Visible = false;
            btnAddOrMoveParameter9.Text = "+";
            btnAddOrMoveParameter9.Visible = false;
            btnAddOrMoveParameter10.Text = "+";
            btnAddOrMoveParameter10.Visible = false;
            txtMessage1.Text = "";
            txtMessage2.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            txtMessage2.Text = "";
            string cmdString = txtMessage1.Text.Trim();

            if (!cmdString.IsNullOrEmpty())
            {
                try
                {
                    ParseCommand oa = new ParseCommand(cmdString.ToByteArray(true));
                    oa.DatagramProcess += Oa_DatagramProcess;
                    oa.OnDatagramProcess();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("命令不能为空！");
            }
        }

        private void BindingCombox(ComboBox cbox, Type type)
        {
            cbox.Items.Add("------请选择------");
            string tempString = string.Empty;

            if (type.IsEnum)
            {
                if (type.Equals(typeof(MessageType))
                    || type.Equals(typeof(MessageId))
                    || type.Equals(typeof(ParameterType))
                    || type.Equals(typeof(ResourceType))
                    || type.Equals(typeof(ResourceType2))
                    || type.Equals(typeof(StrategyType)))
                {
                    foreach (var fieldInfo in type.GetFields())
                    {
                        if (fieldInfo.FieldType.IsEnum)
                        {
                            if (type.Equals(typeof(MessageType)))
                            {
                                tempString = ((byte)((MessageType)Enum.Parse(type, fieldInfo.Name))).ToString("X2");
                            }
                            else if (type.Equals(typeof(MessageId)))
                            {
                                tempString = ((ushort)((MessageId)Enum.Parse(type, fieldInfo.Name))).ToString("X4");
                            }
                            else if (type.Equals(typeof(ParameterType)))
                            {
                                tempString = ((ushort)((ParameterType)Enum.Parse(type, fieldInfo.Name))).ToString("X4");
                            }
                            else if (type.Equals(typeof(ResourceType)))
                            {
                                tempString = "\"" + Encoding.UTF8.GetString(((uint)((ResourceType)Enum.Parse(type, fieldInfo.Name))).ToString("X4").ToByteArray(true)) + "\"";
                            }
                            else if (type.Equals(typeof(ResourceType2)))
                            {
                                tempString = "\"" + Encoding.UTF8.GetString(((uint)((ResourceType2)Enum.Parse(type, fieldInfo.Name))).ToString("X4").ToByteArray(true)) + "\"";
                            }
                            else if (type.Equals(typeof(StrategyType)))
                            {
                                tempString = "\"" + Encoding.UTF8.GetString(((uint)((StrategyType)Enum.Parse(type, fieldInfo.Name))).ToString("X4").ToByteArray(true)) + "\"";
                            }
                            else
                            {
                                tempString = string.Empty;
                            }

                            foreach (var attr in fieldInfo.GetCustomAttributes(false))
                            {
                                if (attr is DescriptionAttribute)
                                {
                                    KeyValuePair<string, string> item = new KeyValuePair<string, string>(
                                        fieldInfo.Name,
                                        tempString + "-" + (attr as DescriptionAttribute)?.Description
                                        );

                                    if (!cbox.Items.Contains(item))
                                    {
                                        cbox.Items.Add(item);
                                    }
                                }
                            }
                        }
                    }

                    cbox.DisplayMember = "Value";
                }
                else
                {
                    if (type.Equals(typeof(ErrorCode)))
                    {
                        foreach (var value in Enum.GetValues(type))
                        {
                            KeyValuePair<string, string> item = new KeyValuePair<string, string>(
                                value.ToString(),
                                "\"" + Encoding.UTF8.GetString(((uint)((ErrorCode)value)).ToString("X8").ToByteArray(true)) + "\"-" + value
                                );

                            if (!cbox.Items.Contains(item))
                            {
                                cbox.Items.Add(item);
                            }
                        }

                        cbox.DisplayMember = "Value";
                    }
                    else
                    {
                        foreach (var item in Enum.GetValues(type))
                        {
                            if (!cbox.Items.Contains(item))
                            {
                                cbox.Items.Add(item);
                            }
                        }
                    }
                }
            }

            cbox.SelectedIndex = 0;
        }

        private void cboxParameterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbox = sender as ComboBox;
            bool check = cbox.SelectedIndex > 0;
            int resType = GetResourceType(cbox);

            if (cbox.Name.EndsWith("1"))
            {
                cboxParameterValue1.Items.Clear();

                if (resType == 0)
                {
                    txtParameterValue1.Visible = true;
                    ckbParameterHex1.Visible = true;
                    cboxParameterValue1.Visible = false;
                    ckbParameter1.Checked = check && txtParameterValue1.Text.Trim().Length > 0;
                }
                else
                {
                    txtParameterValue1.Visible = false;
                    ckbParameterHex1.Visible = false;
                    cboxParameterValue1.Visible = true;
                    ckbParameter1.Checked = check && cboxParameterValue1.SelectedIndex > 0;

                    if (resType == 1)
                    {
                        BindingCombox(cboxParameterValue1, typeof(ResourceType));
                    }
                    else if (resType == 2)
                    {
                        BindingCombox(cboxParameterValue1, typeof(ResourceType2));
                    }
                    else if (resType == 3)
                    {
                        BindingCombox(cboxParameterValue1, typeof(StrategyType));
                    }
                    else
                    {
                    }
                }
            }
            else if (cbox.Name.EndsWith("2"))
            {
                cboxParameterValue2.Items.Clear();

                if (resType == 0)
                {
                    txtParameterValue2.Visible = true;
                    ckbParameterHex2.Visible = true;
                    cboxParameterValue2.Visible = false;
                    ckbParameter2.Checked = check && txtParameterValue2.Text.Trim().Length > 0;
                }
                else
                {
                    txtParameterValue2.Visible = false;
                    ckbParameterHex2.Visible = false;
                    cboxParameterValue2.Visible = true;
                    ckbParameter2.Checked = check && cboxParameterValue2.SelectedIndex > 0;

                    if (resType == 1)
                    {
                        BindingCombox(cboxParameterValue2, typeof(ResourceType));
                    }
                    else if (resType == 2)
                    {
                        BindingCombox(cboxParameterValue2, typeof(ResourceType2));
                    }
                    else if (resType == 3)
                    {
                        BindingCombox(cboxParameterValue2, typeof(StrategyType));
                    }
                    else
                    {
                    }
                }
            }
            else if (cbox.Name.EndsWith("3"))
            {
                cboxParameterValue3.Items.Clear();

                if (resType == 0)
                {
                    txtParameterValue3.Visible = true;
                    ckbParameterHex3.Visible = true;
                    cboxParameterValue3.Visible = false;
                    ckbParameter3.Checked = check && txtParameterValue3.Text.Trim().Length > 0;
                }
                else
                {
                    txtParameterValue3.Visible = false;
                    ckbParameterHex3.Visible = false;
                    cboxParameterValue3.Visible = true;
                    ckbParameter3.Checked = check && cboxParameterValue3.SelectedIndex > 0;

                    if (resType == 1)
                    {
                        BindingCombox(cboxParameterValue3, typeof(ResourceType));
                    }
                    else if (resType == 2)
                    {
                        BindingCombox(cboxParameterValue3, typeof(ResourceType2));
                    }
                    else if (resType == 3)
                    {
                        BindingCombox(cboxParameterValue3, typeof(StrategyType));
                    }
                    else
                    {
                    }
                }
            }
            else if (cbox.Name.EndsWith("4"))
            {
                cboxParameterValue4.Items.Clear();

                if (resType == 0)
                {
                    txtParameterValue4.Visible = true;
                    ckbParameterHex4.Visible = true;
                    cboxParameterValue4.Visible = false;
                    ckbParameter4.Checked = check && txtParameterValue4.Text.Trim().Length > 0;
                }
                else
                {
                    txtParameterValue4.Visible = false;
                    ckbParameterHex4.Visible = false;
                    cboxParameterValue4.Visible = true;
                    ckbParameter4.Checked = check && cboxParameterValue4.SelectedIndex > 0;

                    if (resType == 1)
                    {
                        BindingCombox(cboxParameterValue4, typeof(ResourceType));
                    }
                    else if (resType == 2)
                    {
                        BindingCombox(cboxParameterValue4, typeof(ResourceType2));
                    }
                    else if (resType == 3)
                    {
                        BindingCombox(cboxParameterValue4, typeof(StrategyType));
                    }
                    else
                    {
                    }
                }
            }
            else if (cbox.Name.EndsWith("5"))
            {
                cboxParameterValue5.Items.Clear();

                if (resType == 0)
                {
                    txtParameterValue5.Visible = true;
                    ckbParameterHex5.Visible = true;
                    cboxParameterValue5.Visible = false;
                    ckbParameter5.Checked = check && txtParameterValue5.Text.Trim().Length > 0;
                }
                else
                {
                    txtParameterValue5.Visible = false;
                    ckbParameterHex5.Visible = false;
                    cboxParameterValue5.Visible = true;
                    ckbParameter5.Checked = check && cboxParameterValue5.SelectedIndex > 0;

                    if (resType == 1)
                    {
                        BindingCombox(cboxParameterValue5, typeof(ResourceType));
                    }
                    else if (resType == 2)
                    {
                        BindingCombox(cboxParameterValue5, typeof(ResourceType2));
                    }
                    else if (resType == 3)
                    {
                        BindingCombox(cboxParameterValue5, typeof(StrategyType));
                    }
                    else
                    {
                    }
                }
            }
            else if (cbox.Name.EndsWith("6"))
            {
                cboxParameterValue6.Items.Clear();

                if (resType == 0)
                {
                    txtParameterValue6.Visible = true;
                    ckbParameterHex6.Visible = true;
                    cboxParameterValue6.Visible = false;
                    ckbParameter6.Checked = check && txtParameterValue6.Text.Trim().Length > 0;
                }
                else
                {
                    txtParameterValue6.Visible = false;
                    ckbParameterHex6.Visible = false;
                    cboxParameterValue6.Visible = true;
                    ckbParameter6.Checked = check && cboxParameterValue6.SelectedIndex > 0;

                    if (resType == 1)
                    {
                        BindingCombox(cboxParameterValue6, typeof(ResourceType));
                    }
                    else if (resType == 2)
                    {
                        BindingCombox(cboxParameterValue6, typeof(ResourceType2));
                    }
                    else if (resType == 3)
                    {
                        BindingCombox(cboxParameterValue6, typeof(StrategyType));
                    }
                    else
                    {
                    }
                }
            }
            else if (cbox.Name.EndsWith("7"))
            {
                cboxParameterValue7.Items.Clear();

                if (resType == 0)
                {
                    txtParameterValue7.Visible = true;
                    ckbParameterHex7.Visible = true;
                    cboxParameterValue7.Visible = false;
                    ckbParameter7.Checked = check && txtParameterValue7.Text.Trim().Length > 0;
                }
                else
                {
                    txtParameterValue7.Visible = false;
                    ckbParameterHex7.Visible = false;
                    cboxParameterValue7.Visible = true;
                    ckbParameter7.Checked = check && cboxParameterValue7.SelectedIndex > 0;

                    if (resType == 1)
                    {
                        BindingCombox(cboxParameterValue7, typeof(ResourceType));
                    }
                    else if (resType == 2)
                    {
                        BindingCombox(cboxParameterValue7, typeof(ResourceType2));
                    }
                    else if (resType == 3)
                    {
                        BindingCombox(cboxParameterValue7, typeof(StrategyType));
                    }
                    else
                    {
                    }
                }
            }
            else if (cbox.Name.EndsWith("8"))
            {
                cboxParameterValue8.Items.Clear();

                if (resType == 0)
                {
                    txtParameterValue8.Visible = true;
                    ckbParameterHex8.Visible = true;
                    cboxParameterValue8.Visible = false;
                    ckbParameter8.Checked = check && txtParameterValue8.Text.Trim().Length > 0;
                }
                else
                {
                    txtParameterValue8.Visible = false;
                    ckbParameterHex8.Visible = false;
                    cboxParameterValue8.Visible = true;
                    ckbParameter8.Checked = check && cboxParameterValue8.SelectedIndex > 0;

                    if (resType == 1)
                    {
                        BindingCombox(cboxParameterValue8, typeof(ResourceType));
                    }
                    else if (resType == 2)
                    {
                        BindingCombox(cboxParameterValue8, typeof(ResourceType2));
                    }
                    else if (resType == 3)
                    {
                        BindingCombox(cboxParameterValue8, typeof(StrategyType));
                    }
                    else
                    {
                    }
                }
            }
            else if (cbox.Name.EndsWith("9"))
            {
                cboxParameterValue9.Items.Clear();

                if (resType == 0)
                {
                    txtParameterValue9.Visible = true;
                    ckbParameterHex9.Visible = true;
                    cboxParameterValue9.Visible = false;
                    ckbParameter9.Checked = check && txtParameterValue9.Text.Trim().Length > 0;
                }
                else
                {
                    txtParameterValue9.Visible = false;
                    ckbParameterHex9.Visible = false;
                    cboxParameterValue9.Visible = true;
                    ckbParameter9.Checked = check && cboxParameterValue9.SelectedIndex > 0;

                    if (resType == 1)
                    {
                        BindingCombox(cboxParameterValue9, typeof(ResourceType));
                    }
                    else if (resType == 2)
                    {
                        BindingCombox(cboxParameterValue9, typeof(ResourceType2));
                    }
                    else if (resType == 3)
                    {
                        BindingCombox(cboxParameterValue9, typeof(StrategyType));
                    }
                    else
                    {
                    }
                }
            }
            else
            {
                cboxParameterValue10.Items.Clear();

                if (resType == 0)
                {
                    txtParameterValue10.Visible = true;
                    ckbParameterHex10.Visible = true;
                    cboxParameterValue10.Visible = false;
                    ckbParameter10.Checked = check && txtParameterValue10.Text.Trim().Length > 0;
                }
                else
                {
                    txtParameterValue10.Visible = false;
                    ckbParameterHex10.Visible = false;
                    cboxParameterValue10.Visible = true;
                    ckbParameter10.Checked = check && cboxParameterValue10.SelectedIndex > 0;

                    if (resType == 1)
                    {
                        BindingCombox(cboxParameterValue10, typeof(ResourceType));
                    }
                    else if (resType == 2)
                    {
                        BindingCombox(cboxParameterValue10, typeof(ResourceType2));
                    }
                    else if (resType == 3)
                    {
                        BindingCombox(cboxParameterValue10, typeof(StrategyType));
                    }
                    else
                    {
                    }
                }
            }
        }

        private static int GetResourceType(ComboBox cbox)
        {
            KeyValuePair<string, string> parTypeItem;
            int resType = 0;

            try
            {
                parTypeItem = (KeyValuePair<string, string>)cbox.SelectedItem;

                if (parTypeItem.Key == ParameterType.ResourceType.ToString())
                {
                    resType = 1;
                }
                else if (parTypeItem.Key == ParameterType.ResourceType2.ToString())
                {
                    resType = 2;
                }
                else if (parTypeItem.Key == ParameterType.StrategyType.ToString())
                {
                    resType = 3;
                }
                else
                {
                    resType = 0;
                }
            }
            catch
            {
                resType = 0;
            }

            return resType;
        }

        private void txtParameterValue_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            bool hasValue = txt.Text.Trim().Length > 0;

            if (txt.Name.EndsWith("1"))
            {
                ckbParameter1.Checked = hasValue && cboxParameterType1.SelectedIndex > 0;
            }
            else if (txt.Name.EndsWith("2"))
            {
                ckbParameter2.Checked = hasValue && cboxParameterType2.SelectedIndex > 0;
            }
            else if (txt.Name.EndsWith("3"))
            {
                ckbParameter3.Checked = hasValue && cboxParameterType3.SelectedIndex > 0;
            }
            else if (txt.Name.EndsWith("4"))
            {
                ckbParameter4.Checked = hasValue && cboxParameterType4.SelectedIndex > 0;
            }
            else if (txt.Name.EndsWith("5"))
            {
                ckbParameter5.Checked = hasValue && cboxParameterType5.SelectedIndex > 0;
            }
            else if (txt.Name.EndsWith("6"))
            {
                ckbParameter6.Checked = hasValue && cboxParameterType6.SelectedIndex > 0;
            }
            else if (txt.Name.EndsWith("7"))
            {
                ckbParameter7.Checked = hasValue && cboxParameterType7.SelectedIndex > 0;
            }
            else if (txt.Name.EndsWith("8"))
            {
                ckbParameter8.Checked = hasValue && cboxParameterType8.SelectedIndex > 0;
            }
            else if (txt.Name.EndsWith("9"))
            {
                ckbParameter9.Checked = hasValue && cboxParameterType9.SelectedIndex > 0;
            }
            else
            {
                ckbParameter10.Checked = hasValue && cboxParameterType10.SelectedIndex > 0;
            }
        }

        private void checkHexString_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (txt.Name.StartsWith("txtParameterValue"))
            {
                CheckBox cbox = null;
                string ctrlNumber = txt.Name.Substring("txtParameterValue".Length);

                foreach (Control item in gbParameterList.Controls)
                {
                    if (item is CheckBox && item.Name == "ckbParameterHex" + ctrlNumber)
                    {
                        cbox = item as CheckBox;
                        break;
                    }
                }

                if (cbox != null && !cbox.Checked)
                {
                    return;
                }
            }

            if ((e.KeyChar >= 'a' && e.KeyChar <= 'f'))
            {
                e.KeyChar = (char)(e.KeyChar - 32);
            }

            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9')
                || (e.KeyChar >= 'A' && e.KeyChar <= 'F')
                || e.KeyChar == '\b');
        }

        private void txtParameterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if ((txt.Name.EndsWith("1") && ckbParameterHex1.Checked)
                || (txt.Name.EndsWith("2") && ckbParameterHex2.Checked)
                || (txt.Name.EndsWith("3") && ckbParameterHex3.Checked)
                || (txt.Name.EndsWith("4") && ckbParameterHex4.Checked)
                || (txt.Name.EndsWith("5") && ckbParameterHex5.Checked)
                || (txt.Name.EndsWith("6") && ckbParameterHex6.Checked)
                || (txt.Name.EndsWith("7") && ckbParameterHex7.Checked)
                || (txt.Name.EndsWith("8") && ckbParameterHex8.Checked)
                || (txt.Name.EndsWith("9") && ckbParameterHex9.Checked)
                || (txt.Name.EndsWith("10") && ckbParameterHex10.Checked))
            {
                checkHexString_KeyPress(sender, e);
            }
        }

        private void ckbParameterHex_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ckb = sender as CheckBox;

            if (ckb.Name.EndsWith("1"))
            {
                if (!txtParameterValue1.Text.IsHexString())
                {
                    txtParameterValue1.Text = "";
                }
            }
            else if (ckb.Name.EndsWith("2"))
            {
                if (!txtParameterValue2.Text.IsHexString())
                {
                    txtParameterValue2.Text = "";
                }
            }
            else if (ckb.Name.EndsWith("3"))
            {
                if (!txtParameterValue3.Text.IsHexString())
                {
                    txtParameterValue3.Text = "";
                }
            }
            else if (ckb.Name.EndsWith("4"))
            {
                if (!txtParameterValue4.Text.IsHexString())
                {
                    txtParameterValue4.Text = "";
                }
            }
            else if (ckb.Name.EndsWith("5"))
            {
                if (!txtParameterValue5.Text.IsHexString())
                {
                    txtParameterValue5.Text = "";
                }
            }
            else if (ckb.Name.EndsWith("6"))
            {
                if (!txtParameterValue6.Text.IsHexString())
                {
                    txtParameterValue6.Text = "";
                }
            }
            else if (ckb.Name.EndsWith("7"))
            {
                if (!txtParameterValue7.Text.IsHexString())
                {
                    txtParameterValue7.Text = "";
                }
            }
            else if (ckb.Name.EndsWith("8"))
            {
                if (!txtParameterValue8.Text.IsHexString())
                {
                    txtParameterValue8.Text = "";
                }
            }
            else if (ckb.Name.EndsWith("9"))
            {
                if (!txtParameterValue9.Text.IsHexString())
                {
                    txtParameterValue9.Text = "";
                }
            }
            else
            {
                if (!txtParameterValue10.Text.IsHexString())
                {
                    txtParameterValue10.Text = "";
                }
            }
        }

        private void btnAddOrMoveParameter_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            bool visible;

            if (btn.Text != "+")
            {
                visible = false;
                btn.Text = "+";
            }
            else
            {
                visible = true;
                btn.Text = "-";
            }

            if (btn.Name.EndsWith("1"))
            {
                if (GetResourceType(cboxParameterType1) == 0)
                {
                    txtParameterValue1.Visible = visible;
                    ckbParameterHex1.Visible = visible;
                }
                else
                {
                    cboxParameterValue1.Visible = visible;
                }

                ckbParameter1.Visible = visible;
                cboxParameterType1.Visible = visible;
                btnAddOrMoveParameter2.Visible = visible;
            }
            else if (btn.Name.EndsWith("2"))
            {
                if (GetResourceType(cboxParameterType2) == 0)
                {
                    txtParameterValue2.Visible = visible;
                    ckbParameterHex2.Visible = visible;
                }
                else
                {
                    cboxParameterValue2.Visible = visible;
                }

                ckbParameter2.Visible = visible;
                cboxParameterType2.Visible = visible;
                btnAddOrMoveParameter1.Visible = !visible;
                btnAddOrMoveParameter3.Visible = visible;
            }
            else if (btn.Name.EndsWith("3"))
            {
                if (GetResourceType(cboxParameterType3) == 0)
                {
                    txtParameterValue3.Visible = visible;
                    ckbParameterHex3.Visible = visible;
                }
                else
                {
                    cboxParameterValue3.Visible = visible;
                }

                ckbParameter3.Visible = visible;
                cboxParameterType3.Visible = visible;
                btnAddOrMoveParameter2.Visible = !visible;
                btnAddOrMoveParameter4.Visible = visible;
            }
            else if (btn.Name.EndsWith("4"))
            {
                if (GetResourceType(cboxParameterType4) == 0)
                {
                    txtParameterValue4.Visible = visible;
                    ckbParameterHex4.Visible = visible;
                }
                else
                {
                    cboxParameterValue4.Visible = visible;
                }

                ckbParameter4.Visible = visible;
                cboxParameterType4.Visible = visible;
                btnAddOrMoveParameter3.Visible = !visible;
                btnAddOrMoveParameter5.Visible = visible;
            }
            else if (btn.Name.EndsWith("5"))
            {
                if (GetResourceType(cboxParameterType5) == 0)
                {
                    txtParameterValue5.Visible = visible;
                    ckbParameterHex5.Visible = visible;
                }
                else
                {
                    cboxParameterValue5.Visible = visible;
                }

                ckbParameter5.Visible = visible;
                cboxParameterType5.Visible = visible;
                btnAddOrMoveParameter4.Visible = !visible;
                btnAddOrMoveParameter6.Visible = visible;
            }
            else if (btn.Name.EndsWith("6"))
            {
                if (GetResourceType(cboxParameterType6) == 0)
                {
                    txtParameterValue6.Visible = visible;
                    ckbParameterHex6.Visible = visible;
                }
                else
                {
                    cboxParameterValue6.Visible = visible;
                }

                ckbParameter6.Visible = visible;
                cboxParameterType6.Visible = visible;
                btnAddOrMoveParameter5.Visible = !visible;
                btnAddOrMoveParameter7.Visible = visible;
            }
            else if (btn.Name.EndsWith("7"))
            {
                if (GetResourceType(cboxParameterType7) == 0)
                {
                    txtParameterValue7.Visible = visible;
                    ckbParameterHex7.Visible = visible;
                }
                else
                {
                    cboxParameterValue7.Visible = visible;
                }

                ckbParameter7.Visible = visible;
                cboxParameterType7.Visible = visible;
                btnAddOrMoveParameter6.Visible = !visible;
                btnAddOrMoveParameter8.Visible = visible;
            }
            else if (btn.Name.EndsWith("8"))
            {
                if (GetResourceType(cboxParameterType8) == 0)
                {
                    txtParameterValue8.Visible = visible;
                    ckbParameterHex8.Visible = visible;
                }
                else
                {
                    cboxParameterValue8.Visible = visible;
                }

                ckbParameter8.Visible = visible;
                cboxParameterType8.Visible = visible;
                btnAddOrMoveParameter7.Visible = !visible;
                btnAddOrMoveParameter9.Visible = visible;
            }
            else if (btn.Name.EndsWith("9"))
            {
                if (GetResourceType(cboxParameterType9) == 0)
                {
                    txtParameterValue9.Visible = visible;
                    ckbParameterHex9.Visible = visible;
                }
                else
                {
                    cboxParameterValue9.Visible = visible;
                }

                ckbParameter9.Visible = visible;
                cboxParameterType9.Visible = visible;
                btnAddOrMoveParameter8.Visible = !visible;
                btnAddOrMoveParameter10.Visible = visible;
            }
            else
            {
                if (GetResourceType(cboxParameterType10) == 0)
                {
                    txtParameterValue10.Visible = visible;
                    ckbParameterHex10.Visible = visible;
                }
                else
                {
                    cboxParameterValue10.Visible = visible;
                }

                ckbParameter10.Visible = visible;
                cboxParameterType10.Visible = visible;
                btnAddOrMoveParameter9.Visible = !visible;
            }
        }

        private void txtMessage1_TextChanged(object sender, EventArgs e)
        {
            btnCheck.Visible = txtMessage1.Text.Trim().Length > 0;
        }

        private void cboxMessageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxMessageId.Enabled = true;
            txtGatewayId.Enabled = true;
            txtLuminaireId.Enabled = true;
            MessageType messageType;
            KeyValuePair<string, string> msgTypeItem;

            try
            {
                msgTypeItem = (KeyValuePair<string, string>)cboxMessageType.SelectedItem;
            }
            catch
            {
                gbErrorCodeAndInfo.Visible = false;
                gbParameterList.Visible = true;
                return;
            }

            if (Enum.TryParse(msgTypeItem.Key, out messageType))
            {
                switch (messageType)
                {
                    case MessageType.Command:
                    case MessageType.Event:
                        gbErrorCodeAndInfo.Visible = false;
                        gbParameterList.Visible = true;
                        break;
                    case MessageType.CommandResult:
                        gbErrorCodeAndInfo.Visible = true;
                        gbParameterList.Visible = false;
                        break;
                    case MessageType.HeartbeatData:
                    case MessageType.HeartbeatResponse:
                    case MessageType.CommandACK:
                    case MessageType.EventACK:
                    default:
                        cboxMessageId.Enabled = false;
                        txtGatewayId.Enabled = false;
                        txtLuminaireId.Enabled = false;
                        gbErrorCodeAndInfo.Visible = false;
                        gbParameterList.Visible = false;
                        break;
                }
            }
            else
            {
                gbErrorCodeAndInfo.Visible = false;
                gbParameterList.Visible = true;
            }
        }

        private void cboxErrorCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, string> errorCodeItem;

            try
            {
                errorCodeItem = (KeyValuePair<string, string>)cboxErrorCode.SelectedItem;
            }
            catch
            {
                txtErrorInfo.Clear();
                return;
            }

            foreach (var fieldInfo in typeof(ErrorCode).GetFields())
            {
                if (fieldInfo.FieldType.IsEnum && fieldInfo.Name == errorCodeItem.Key)
                {
                    foreach (var attr in fieldInfo.GetCustomAttributes(false))
                    {
                        if (attr is DescriptionAttribute)
                        {
                            txtErrorInfo.Text = (attr as DescriptionAttribute)?.Description;
                            return;
                        }
                    }
                }
            }
        }

        private void cboxParameterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbox = sender as ComboBox;
            bool check = cbox.SelectedIndex > 0;

            if (cbox.Name.EndsWith("1"))
            {
                ckbParameter1.Checked = check && cboxParameterType1.SelectedIndex > 0;
            }
            else if (cbox.Name.EndsWith("2"))
            {
                ckbParameter2.Checked = check && cboxParameterType2.SelectedIndex > 0;
            }
            else if (cbox.Name.EndsWith("3"))
            {
                ckbParameter3.Checked = check && cboxParameterType3.SelectedIndex > 0;
            }
            else if (cbox.Name.EndsWith("4"))
            {
                ckbParameter4.Checked = check && cboxParameterType4.SelectedIndex > 0;
            }
            else if (cbox.Name.EndsWith("5"))
            {
                ckbParameter5.Checked = check && cboxParameterType5.SelectedIndex > 0;
            }
            else if (cbox.Name.EndsWith("6"))
            {
                ckbParameter6.Checked = check && cboxParameterType6.SelectedIndex > 0;
            }
            else if (cbox.Name.EndsWith("7"))
            {
                ckbParameter7.Checked = check && cboxParameterType7.SelectedIndex > 0;
            }
            else if (cbox.Name.EndsWith("8"))
            {
                ckbParameter8.Checked = check && cboxParameterType8.SelectedIndex > 0;
            }
            else if (cbox.Name.EndsWith("9"))
            {
                ckbParameter9.Checked = check && cboxParameterType9.SelectedIndex > 0;
            }
            else
            {
                ckbParameter10.Checked = check && cboxParameterType10.SelectedIndex > 0;
            }
        }
    }
}