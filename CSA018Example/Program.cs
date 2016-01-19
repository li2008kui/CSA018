using System;
using System.Collections.Generic;
using ThisCoder.CSA018;

namespace ThisCoder.CSA018Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // 实例化创建消息动作行为类的对象
            CreateAction ca1 = new CreateAction();
            CreateAction ca2 = new CreateAction();
            CreateAction ca3 = new CreateAction(MessageType.Request, 0x00000001);
            CreateAction ca4 = new CreateAction(MessageType.Response);
            CreateAction ca5 = new CreateAction(MessageType.Result, 0x00000001);
            CreateAction ca6 = new CreateAction(MessageType.Event, 0x00000001);
            CreateAction ca7 = new CreateAction(MessageType.EventResponse);

            // 获取数据报文字节数组
            byte[] cmd1 = new byte[] { ca1.GetHeartbeatDataCommand() };
            byte[] cmd2 = new byte[] { ca2.GetHeartbeatResponseCommand() };
            byte[] cmd3 = ca3.GetRequestCommand(MessageId.RealTimeControlLuminaire, ParameterType.Brightness, "100");
            byte[] cmd4 = ca4.GetResponseCommand(0x0);
            byte[] cmd5 = ca5.GetResultCommand(0x0, MessageId.RealTimeControlLuminaire, ParameterType.ErrorCode, "0000");
            byte[] cmd6 = ca6.GetEventCommand(MessageId.DataCollection, new List<Parameter> { new Parameter(ParameterType.ResourceType, "05"), new Parameter(ParameterType.ResourceValue, "100") });
            byte[] cmd7 = ca7.GetEventResponseCommand(0x01);

            // 将字节数组转成十六进制字符串形式并打印
            Console.WriteLine("一、生成命令\n1、心跳包数据\n" + cmd1.ToHexString()
                + "\n\n2、心跳包响应\n" + cmd2.ToHexString()
                + "\n\n3、请求命令\n" + cmd3.ToHexString()
                + "\n\n4、响应命令\n" + cmd4.ToHexString()
                + "\n\n5、结果命令\n" + cmd5.ToHexString()
                + "\n\n6、事件命令\n" + cmd6.ToHexString()
                + "\n\n7、事件响应\n" + cmd7.ToHexString());

            // 订阅消息报文处理事件
            ParseAction pa = new ParseAction();
            pa.DatagramProcess += Oa_DatagramProcess;

            // 触发消息报文处理事件
            Console.WriteLine("\n\n二、解析命令\n1、心跳包数据");
            pa.OnDatagramProcess(cmd1);
            Console.WriteLine("\n2、心跳包响应");
            pa.OnDatagramProcess(cmd2);
            Console.WriteLine("\n3、请求命令");
            pa.OnDatagramProcess(cmd3);
            Console.WriteLine("\n4、响应命令");
            pa.OnDatagramProcess(cmd4);
            Console.WriteLine("\n5、结果命令");
            pa.OnDatagramProcess(cmd5);
            Console.WriteLine("\n6、事件命令");
            pa.OnDatagramProcess(cmd6);
            Console.WriteLine("\n7、事件响应");
            pa.OnDatagramProcess(cmd7);

            // 等待用户按键退出
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

                        if (datagram.Head.Type != MessageType.Response
                            && datagram.Head.Type != MessageType.EventResponse)
                        {
                            cmdRemarkString += "\n|------------------------------------|";
                            cmdRemarkString += "\n| 消 |            消息ID：" + ((ushort)(datagram.Body.MessageId)).ToString("X4") + "       |";
                            cmdRemarkString += "\n| 息 |            网关ID：" + datagram.Body.GatewayId.ToString("X8") + "   |";
                            cmdRemarkString += "\n| 体 |            灯具ID：" + datagram.Body.LuminaireId.ToString("X8") + "   |";

                            for (int i = 0; i < datagram.Body.ParameterList.Count; i++)
                            {
                                cmdRemarkString += "\n|    |-------------------------------|";
                                cmdRemarkString += "\n|    | 参 ｜    参数类型：" + ((ushort)datagram.Body.ParameterList[i].Type).ToString("X4") + "       |";
                                cmdRemarkString += "\n|    | 数 ｜      参数值：\"" + datagram.Body.ParameterList[i].Value + "\"      |";
                                cmdRemarkString += "\n|    | " + (i + 1).ToString().PadRight(2, ' ') + " | 参数值结束符：" + datagram.Body.ParameterList[i].End.ToString("X2") + "         |";
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