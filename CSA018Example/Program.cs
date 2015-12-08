using System;
using ThisCoder.CSA018;

namespace ThisCoder.CSA018Example
{
    class Program
    {
        static void Main(string[] args)
        {
            OperateAction oa = new OperateAction(MessageType.Request, 0x00000001);
            byte[] cmd = oa.GetOperateCommand(MessageId.RealTimeControlLamp, ParameterType.Brightness, "70");

            Console.WriteLine(cmd.ToHexString());
            Console.ReadKey();
        }
    }
}