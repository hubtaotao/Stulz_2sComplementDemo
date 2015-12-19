using System;
using System.Collections.Generic;
using System.Text;

namespace Stulz_2sComplementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string rec = string.Empty;
            while (true)
            {
                Console.WriteLine("输入要计算的值(回车结果，多个值之间用空格分隔)：");
                rec = Console.ReadLine();
                if (rec.Equals("q")) break;
                string[] bs = rec.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                short[] js = new short[bs.Length];
                for (int i = 0; i < bs.Length; i++)
                    js[i] = Convert.ToInt16(bs[i], 16);

                string val = CS_CheckSum(js);
                Console.WriteLine("CS:LB:{0}  HB:{1}", val.Substring(2, 2), val.Substring(0, 2));
            }
            Console.Read();
        }


        static string CS_CheckSum(params short[] data)
        {
            string val = string.Empty;
            short sum = 0;
            for (int i = 0; i < data.Length; i++)
                sum += data[i];            
            short v = (short)((~sum) + 1);            
            val = string.Format("{0:x}", v).ToUpper();
            return val;
        }

    }
}
