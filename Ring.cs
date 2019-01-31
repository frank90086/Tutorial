using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tutorial
{
    public class Ring
    {
        private IEvtHandler _handler;
        public Ring(IEvtHandler handler){
            _handler = handler;
        }
        public async void OnSendMessage(Func<List<string>, List<People>> family, List<string> names, string msg){
            List<People> fs = family(names);
            await Task.Delay(500);
            foreach (People f in fs)
                _handler.Evt += f.Do;
            Console.WriteLine($"Family {Thread.CurrentThread.ManagedThreadId}");
            
            _do(msg);
        }

        public async void OnSendMessage(Func<Dictionary<int, string>, List<People>> student, Dictionary<int, string> stDic, string msg){
            List<People> sts = student(stDic);
            await Task.Delay(200);
            foreach (People st in sts)
                _handler.Evt += st.Do;
            Console.WriteLine($"Student {Thread.CurrentThread.ManagedThreadId}");
            _do(msg);
        }

        private void _do(string msg)
        {
            _handler.Do(new EvtArgs(msg));
            Console.WriteLine("Finish!");
        }
    }
}
