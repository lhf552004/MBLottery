using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
    public class RandomExt
    {
        public string GetRandomCode()
        {
            char[] chars = {
                                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'M', 'N', 'P', 'Q', 'R', 'S',
                                'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '2', '3', '4', '5', '6', '7', '8', '9'
                            };
            string code = string.Empty;
            
            for (int i = 0; i < 4; i++)
            {
                //这里是关键，传入一个seed参数即可保证生成的随机数不同            
                //Random rnd = new Random(unchecked((int)DateTime.Now.Ticks));
                Random rnd = new Random(GetRandomSeed());
               
            }
            return code;
        }
        private static System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
        private static Random rnd;
        /// <summary>
        /// 加密随机数生成器 生成随机种子
        /// </summary>
        /// <returns></returns>
        public static int GetRandomSeed(int max = 0)
        {
            int seed = int.MinValue;
            decimal _base = (decimal)long.MaxValue;
            byte[] bytes = new byte[4];
            rng.GetBytes(bytes);
            if (max == 0)
            {
                seed = BitConverter.ToInt32(bytes, 0);
            }
            else
            {
                seed = (int)(Math.Abs(BitConverter.ToInt32(bytes, 0)) / _base * (max + 1));
            }
           
            return seed;
            //return BitConverter.ToInt32(bytes, 0);
        }
        public static int getRandomNumber(int max)
        {
            int rnn =-1;
            rnd = new Random(GetRandomSeed());
            rnn = rnd.Next(max);
            return rnn;
        }
        public static List<int> getRandomNumberList(int count ,int max)
        {
            List<int> rnnList = new List<int>();
            int rnn = -1;
            while (rnnList.Count < count)
            {
                rnn = getRandomNumber(max);
                if (!rnnList.Contains(rnn))
                {
                    rnnList.Add(rnn);
                }
            }
            return rnnList;
        }
        //获取指定数量的随机组合 洗牌程序 思路
        public static IList<string> CreateChargeCodeNo(string PromotionChargeCodeNo, int Count)
        {
            List<string> lis = new List<string>();
            if (string.IsNullOrEmpty(PromotionChargeCodeNo))
            {
                return lis;
            }
            string ChargeCodeNo = PromotionChargeCodeNo;
            int length = 10 - PromotionChargeCodeNo.Length;
            while (lis.Count < Count)
            {
                int[] numbers = new int[length * 2];
                for (int i = 0; i < length * 2; i++)
                    numbers[i] = i + 1;
                for (int i = 0; i < length * 2; i++)//二倍体洗牌
                {
                    Random rand = new Random(GetRandomSeed());
                    int temp = rand.Next(length * 2);
                    int tempNumber = numbers[i];
                    numbers[i] = numbers[temp];
                    numbers[temp] = tempNumber;
                }
                string code = "";
                for (int x = 0; code.Length < length; x++)
                {
                    code += numbers[x];
                }
                code = code.Substring(0, length);
                string s = ChargeCodeNo + code;
                if (lis.Contains(s))
                {
                    continue;
                }
                lis.Add(ChargeCodeNo + code);
            }
            return lis;
        }
    }
}
