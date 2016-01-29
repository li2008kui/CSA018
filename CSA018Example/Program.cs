using System;
using System.Collections.Generic;
using System.Text;
using ThisCoder.CSA018;

namespace ThisCoder.CSA018Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // 实例化创建消息命令类的对象。
            CreateCommand ca1 = new CreateCommand();
            CreateCommand ca2 = new CreateCommand();
            CreateCommand ca3 = new CreateCommand(MessageType.Command, 0x00000001);
            CreateCommand ca4 = new CreateCommand(MessageType.CommandACK);
            CreateCommand ca5 = new CreateCommand(MessageType.CommandResult, 0x00000001);

            // 采用 DES 密钥加密。
            DESHelper des = new DESHelper();
            byte[] desKey = des.GetSecretKey();
            CreateCommand ca6 = new CreateCommand(MessageType.Event, desKey, 0x00000001);
            CreateCommand ca7 = new CreateCommand(MessageType.EventACK);

            // 获取数据报文字节数组。
            byte[] cmd1 = new byte[] { ca1.GetHeartbeatDataCommand() };
            byte[] cmd2 = new byte[] { ca2.GetHeartbeatResponseCommand() };
            byte[] cmd3 = ca3.GetRequestCommand(MessageId.RealTimeControlLuminaire, ParameterType.Brightness, "100");
            byte[] cmd4 = ca4.GetResponseCommand(0x0);
            byte[] cmd5 = ca5.GetResultCommand(0x0, MessageId.RealTimeControlLuminaire, ErrorCode.Succeed, "成功");
            byte[] cmd6 = ca6.GetEventCommand(MessageId.DataCollection, new List<Parameter> { new Parameter(ParameterType.ResourceType, "05"), new Parameter(ParameterType.ResourceValue, "100") });
            byte[] cmd7 = ca7.GetEventResponseCommand(0x01);

            // 将字节数组转成十六进制字符串形式并打印。
            Console.WriteLine("一、生成命令\n1、心跳包数据\n" + cmd1.ToHexString()
                + "\n\n2、心跳包响应\n" + cmd2.ToHexString()
                + "\n\n3、请求命令\n" + cmd3.ToHexString()
                + "\n\n4、响应命令\n" + cmd4.ToHexString()
                + "\n\n5、结果命令\n" + cmd5.ToHexString()
                + "\n\n6、事件命令\n" + cmd6.ToHexString()
                + "\n\n7、事件响应\n" + cmd7.ToHexString());

            // 订阅消息报文处理事件。
            ParseCommand pa1 = new ParseCommand(cmd1);
            ParseCommand pa2 = new ParseCommand(cmd2);
            ParseCommand pa3 = new ParseCommand(cmd3);
            ParseCommand pa4 = new ParseCommand(cmd4);
            ParseCommand pa5 = new ParseCommand(cmd5);

            // 采用 DES 密钥解密。
            ParseCommand pa6 = new ParseCommand(cmd6, desKey);
            ParseCommand pa7 = new ParseCommand(cmd7);

            pa1.DatagramProcess += Oa_DatagramProcess;
            pa2.DatagramProcess += Oa_DatagramProcess;
            pa3.DatagramProcess += Oa_DatagramProcess;
            pa4.DatagramProcess += Oa_DatagramProcess;
            pa5.DatagramProcess += Oa_DatagramProcess;
            pa6.DatagramProcess += Oa_DatagramProcess;
            pa7.DatagramProcess += Oa_DatagramProcess;

            // 触发消息报文处理事件。
            Console.WriteLine("\n\n二、解析命令\n1、心跳包数据");
            pa1.OnDatagramProcess();
            Console.WriteLine("\n2、心跳包响应");
            pa2.OnDatagramProcess();
            Console.WriteLine("\n3、请求命令");
            pa3.OnDatagramProcess();
            Console.WriteLine("\n4、响应命令");
            pa4.OnDatagramProcess();
            Console.WriteLine("\n5、结果命令");
            pa5.OnDatagramProcess();
            Console.WriteLine("\n6、事件命令");
            pa6.OnDatagramProcess();
            Console.WriteLine("\n7、事件响应");
            pa7.OnDatagramProcess();

            // 等待用户按键退出。
            Console.ReadKey();
        }

        private static void Oa_DatagramProcess(object sender, DatagramEventArgs e)
        {
            if (e.DatagramList.Count > 0)
            {
                string cmdRemarkString = "--------------------------------------";

                foreach (var datagram in e.DatagramList)
                {
                    if (datagram.Head.Type == MessageType.HeartbeatData)
                    {
                        cmdRemarkString += "\n| 心跳包数据：FF                     |";
                    }
                    else if (datagram.Head.Type == MessageType.HeartbeatResponse)
                    {
                        cmdRemarkString += "\n| 心跳包响应：FE                     |";
                    }
                    else
                    {
                        cmdRemarkString += "\n|                 起始符：" + datagram.Stx.ToString("X2") + "         |";
                        cmdRemarkString += "\n|------------------------------------|";
                        cmdRemarkString += "\n|    |          消息类型：" + ((ushort)(datagram.Head.Type)).ToString("X2") + "         |";
                        cmdRemarkString += "\n| 消 |          消息序号：" + datagram.Head.SeqNumber.ToString("X8") + "   |";
                        cmdRemarkString += "\n| 息 |        消息体长度：" + datagram.Head.Length.ToString("X4") + "       |";
                        cmdRemarkString += "\n| 头 |              预留：" + datagram.Head.Reserved.ToString("X10") + " |";
                        cmdRemarkString += "\n|    |     消息体CRC校验：" + datagram.Head.Crc32.ToString("X8") + "   |";

                        if (datagram.Head.Type != MessageType.CommandACK
                            && datagram.Head.Type != MessageType.EventACK)
                        {
                            cmdRemarkString += "\n|------------------------------------|";
                            cmdRemarkString += "\n| 消 |            消息ID：" + ((ushort)(datagram.Body.MessageId)).ToString("X4") + "       |";
                            cmdRemarkString += "\n| 息 |            网关ID：" + datagram.Body.GatewayId.ToString("X8") + "   |";
                            cmdRemarkString += "\n| 体 |            灯具ID：" + datagram.Body.LuminaireId.ToString("X8") + "   |";

                            if (datagram.Head.Type != MessageType.CommandResult)
                            {
                                for (int i = 0; i < datagram.Body.ParameterList.Count; i++)
                                {
                                    cmdRemarkString += "\n|    |-------------------------------|";
                                    cmdRemarkString += "\n|    | 参 ｜    参数类型：" + ((ushort)datagram.Body.ParameterList[i].Type).ToString("X4") + "       |";
                                    cmdRemarkString += "\n|    | 数 ｜      参数值：\"" + datagram.Body.ParameterList[i].Value + "\"      |";
                                    cmdRemarkString += "\n|    | " + (i + 1).ToString().PadRight(2, ' ') + " | 参数值结束符：" + datagram.Body.ParameterList[i].End.ToString("X2") + "         |";
                                }
                            }
                            else
                            {
                                cmdRemarkString += "\n|    |          错误代码：\""
                                    + Encoding.UTF8.GetString(
                                        new byte[] {
                                            (byte)((uint)(datagram.Body.ErrorCode) >> 24),
                                            (byte)((uint)(datagram.Body.ErrorCode) >> 16),
                                            (byte)((uint)(datagram.Body.ErrorCode) >> 8),
                                            (byte)(datagram.Body.ErrorCode)
                                        }) + "\"     |";

                                if (datagram.Body.ErrorInfo != null)
                                {
                                    cmdRemarkString += "\n|    |          错误信息：\"" + datagram.Body.ErrorInfo + "\"     |";
                                }
                            }
                        }

                        cmdRemarkString += "\n|------------------------------------|";
                        cmdRemarkString += "\n|                 结束符：" + datagram.Etx.ToString("X2") + "         |";
                    }

                    cmdRemarkString += "\n--------------------------------------";
                }

                Console.WriteLine(cmdRemarkString);
            }
            else
            {
                Console.WriteLine("没有数据");
            }
        }
    }
}