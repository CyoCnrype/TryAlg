using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySortDic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>();
            myDict.Add("RR", 1);
            myDict.Add("EE", 4);
            myDict.Add("WW", 2);
            myDict.Add("QQ", 3);

            var sortedDict = from entry in myDict orderby entry.Value descending select entry;

            int requestNum = 3; //取前n個
            List<string> BaiDui = new List<string>();           

            //Dictionary<string, int> myDict2 = new Dictionary<string, int>();
            foreach (var item in sortedDict)          
            {
                BaiDui.Add(item.Key);
            }

            for (var i = 0; i < requestNum; i++)
            {
                Console.WriteLine(BaiDui[i]);
            }

            //Console.WriteLine(sortedDict.Count());
            Console.ReadLine();
        }
    }
}
