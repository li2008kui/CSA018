using System;
using System.Collections.Generic;
using ThisCoder.CSA018;

namespace ThisCoder.CSA018Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // 实例化操作动作行为类的对象
            OperateAction oa1 = new OperateAction(MessageType.HeartbeatData);
            OperateAction oa2 = new OperateAction(MessageType.HeartbeatResponse);
            OperateAction oa3 = new OperateAction(MessageType.Request, 0x00000001);
            OperateAction oa4 = new OperateAction(MessageType.Response);
            OperateAction oa5 = new OperateAction(MessageType.Event, 0x00000001);
            OperateAction oa6 = new OperateAction(MessageType.EventResponse);
            OperateAction oa7 = new OperateAction(MessageType.Result, 0x00000001);

            // 获取数据报文字节数组
            byte[] cmd1 = oa1.GetOperateCommand();
            byte[] cmd2 = oa2.GetOperateCommand();
            byte[] cmd3 = oa3.GetOperateCommand(MessageId.RealTimeControlLuminaire, ParameterType.Brightness, "100");
            byte[] cmd4 = oa4.GetOperateCommand(0x1234);
            byte[] cmd5 = oa5.GetOperateCommand(MessageId.DataCollection, new List<Parameter> { new Parameter(ParameterType.ResourceType, "05"), new Parameter(ParameterType.ResourceValue, "100") });
            byte[] cmd6 = oa6.GetOperateCommand(0x1234);
            byte[] cmd7 = oa7.GetOperateCommand(MessageId.RealTimeControlLuminaire, (uint)0x00000000, "成功");

            // 将字节数组转成十六进制字符串形式并打印
            Console.WriteLine("一、生成命令\n1、心跳包数据：\n" + cmd1.ToHexString()
                + "\n\n2、心跳包响应\n" + cmd2.ToHexString()
                + "\n\n3、请求命令\n" + cmd3.ToHexString()
                + "\n\n4、响应命令\n" + cmd4.ToHexString()
                + "\n\n5、事件命令\n" + cmd5.ToHexString()
                + "\n\n6、事件响应\n" + cmd6.ToHexString()
                + "\n\n7、结果命令\n" + cmd7.ToHexString());

            // 订阅消息报文处理事件
            oa1.DatagramProcess += Oa_DatagramProcess;
            oa2.DatagramProcess += Oa_DatagramProcess;
            oa3.DatagramProcess += Oa_DatagramProcess;
            oa4.DatagramProcess += Oa_DatagramProcess;
            oa5.DatagramProcess += Oa_DatagramProcess;
            oa6.DatagramProcess += Oa_DatagramProcess;
            oa7.DatagramProcess += Oa_DatagramProcess;

            // 触发消息报文处理事件
            Console.WriteLine("\n\n二、解析命令\n1、心跳包数据");
            oa1.OnDatagramProcess(new DatagramEventArgs(cmd1));
            Console.WriteLine("\n2、心跳包响应");
            oa2.OnDatagramProcess(new DatagramEventArgs(cmd2));
            Console.WriteLine("\n3、请求命令");
            oa3.OnDatagramProcess(new DatagramEventArgs(cmd3));
            Console.WriteLine("\n4、响应命令");
            oa4.OnDatagramProcess(new DatagramEventArgs(cmd4));
            Console.WriteLine("\n5、事件命令");
            oa5.OnDatagramProcess(new DatagramEventArgs(cmd5));
            Console.WriteLine("\n6、事件响应");
            oa6.OnDatagramProcess(new DatagramEventArgs(cmd6));
            Console.WriteLine("\n7、结果命令");
            oa7.OnDatagramProcess(new DatagramEventArgs(cmd7));

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
                        cmdRemarkString += "\n|    |           CRC校验：" + datagram.Head.Crc32.ToString("X8") + "   |";

                        if (datagram.Head.Type != MessageType.Response
                            && datagram.Head.Type != MessageType.EventResponse)
                        {
                            cmdRemarkString += "\n|------------------------------------|";
                            cmdRemarkString += "\n| 消 |            消息ID：" + ((ushort)(datagram.Body.MessageId)).ToString("X4") + "       |";
                            cmdRemarkString += "\n| 息 |            网关ID：" + datagram.Body.GatewayId.ToString("X8") + "   |";
                            cmdRemarkString += "\n| 体 |            灯具ID：" + datagram.Body.LuminaireId.ToString("X8") + "   |";

                            if (datagram.Head.Type != MessageType.Result)
                            {
                                for (int i = 0; i < datagram.Body.ParameterList.Count; i++)
                                {
                                    cmdRemarkString += "\n|    |-------------------------------|";
                                    cmdRemarkString += "\n|    | 参 ｜    参数类型：" + ((ushort)datagram.Body.ParameterList[i].Type).ToString("X4") + "       |";
                                    cmdRemarkString += "\n|    | 数 ｜      参数值：" + datagram.Body.ParameterList[i].Value + "        |";
                                    cmdRemarkString += "\n|    | " + (i + 1).ToString().PadRight(2, ' ') + " | 参数值结束符：" + datagram.Body.ParameterList[i].End.ToString("X2") + "         |";
                                }
                            }
                            else
                            {
                                cmdRemarkString += "\n|    |          错误代码：" + datagram.Body.ErrorCode.ToString("X8") + "   |";

                                if (datagram.Body.ErrorInfo != null)
                                {
                                    cmdRemarkString += "\n|    |          错误信息：" + datagram.Body.ErrorInfo + "   |";
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