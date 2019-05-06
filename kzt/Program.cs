using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kzt
{
    //定义委托，它定义了可以代表的方法的类型
    public delegate void GreetingDelegate(string name);

    class Program
    {
        static void Main(string[] args)
        {

            var dic = new Dictionary<int, string>();
            dic.Add(7, "aaa");
            dic.Add(8, "bbb");

            var dicNew = new Dictionary<int, string>()
            {
                [7]="aaa",
                [8]="bbb"
            };
        }
    }
}
