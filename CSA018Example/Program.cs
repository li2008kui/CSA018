using System;
using ThisCoder.CSA018;

namespace ThisCoder.CSA018Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // 实例化操作动作行为类的对象
            OperateAction oa = new OperateAction(MessageType.Request, 0x00000001);

            // 获取数据报文字节数组
            byte[] cmd = oa.GetOperateCommand(MessageId.RealTimeControlLuminaire, ParameterType.Brightness, "70");

            // 将字节数组转成十六进制字符串形式并打印
            Console.WriteLine("生成命令：\n" + cmd.ToHexString());

            // 订阅消息报文处理事件
            oa.DatagramProcess += Oa_DatagramProcess;

            // 触发消息报文处理事件
            oa.OnDatagramProcess(new DatagramEventArgs(cmd));

            // 等待用户按键退出
            Console.ReadKey();
        }

        private static void Oa_DatagramProcess(object sender, DatagramEventArgs e)
        {
            if (e.DatagramList.Count > 0)
            {
                string cmdRemarkString = "\n解析命令：\n--------------------------------------";

                foreach (var datagram in e.DatagramList)
                {
                    cmdRemarkString += "\n|                 起始符：" + datagram.Stx.ToString("X2") + "         |";
                    cmdRemarkString += "\n|------------------------------------|";
                    cmdRemarkString += "\n|    |          消息类型：" + ((ushort)(datagram.Head.Type)).ToString("X2") + "         |";
                    cmdRemarkString += "\n| 消 |          消息序号：" + datagram.Head.SeqNumber.ToString("X8") + "   |";
                    cmdRemarkString += "\n| 息 |        消息体长度：" + datagram.Head.Length.ToString("X4") + "       |";
                    cmdRemarkString += "\n| 头 |              预留：" + datagram.Head.Reserved.ToString("X10") + " |";
                    cmdRemarkString += "\n|    |           CRC校验：" + datagram.Head.Crc32.ToString("X8") + "   |";
                    cmdRemarkString += "\n|------------------------------------|";
                    cmdRemarkString += "\n| 消 |            消息ID：" + ((ushort)(datagram.Body.MessageId)).ToString("X4") + "       |";
                    cmdRemarkString += "\n| 息 |            网关ID：" + datagram.Body.GatewayId.ToString("X8") + "   |";
                    cmdRemarkString += "\n| 体 |            灯具ID：" + datagram.Body.LuminaireId.ToString("X8") + "   |";

                    for (int i = 0; i < datagram.Body.ParameterList.Count; i++)
                    {
                        cmdRemarkString += "\n|    |-------------------------------|";
                        cmdRemarkString += "\n|    | 参 ｜    参数类型：" + ((ushort)datagram.Body.ParameterList[i].Type).ToString("X4") + "       |";
                        cmdRemarkString += "\n|    | 数 ｜      参数值：";

                        foreach (var value in datagram.Body.ParameterList[i].Value.ToArray())
                        {
                            cmdRemarkString += value.ToString("X2");
                        }

                        cmdRemarkString += "       |\n|    | " + (i + 1).ToString().PadRight(2, ' ') + " | 参数值结束符：" + datagram.Body.ParameterList[i].End.ToString("X2") + "         |";
                    }

                    cmdRemarkString += "\n|------------------------------------|";
                    cmdRemarkString += "\n|                 结束符：" + datagram.Etx.ToString("X2") + "         |";
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