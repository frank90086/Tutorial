using System;
using System.Collections.Generic;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring ring = new Ring(new EvtHandler());
            List<string> names = new List<string>() { "Father", "Mother", "Son"};
            Dictionary<int, string> stdic = new Dictionary<int, string>() { { 18, "Frank"}, { 19, "Fuck"}, { 20, "Sky" } };

            Func<List<string>, List<People>> func = (ns) => {
                List<People> fs = new List<People>();
                foreach (string name in ns)
                    fs.Add(new Family(name));
                return fs;
            };
            ring.OnSendMessage(func, names, "起床");

            Func<Dictionary<int, string>, List<People>> func1 = (dic) => {
                List<People> sts = new List<People>();
                foreach (var st in dic)
                    sts.Add(new Student(st.Key, st.Value));
                return sts;
            };
            ring.OnSendMessage(func1, stdic, "下課了");
        }
    }
}
