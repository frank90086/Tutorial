using System;
using System.Collections.Generic;
namespace Tutorial
{
    public class Ring
    {
        private IEvtHandler _handler;
        public Ring(IEvtHandler handler){
            _handler = handler;
        }
        public void OnSendMessage(Func<List<string>, List<People>> family, List<string> names, string msg){
            List<People> fs = family(names);
            foreach (People f in fs)
                _handler.Evt += f.Do;
            _do(msg);
            foreach (People f in fs)
                _handler.Evt -= f.Do;
        }

        public void OnSendMessage(Func<Dictionary<int, string>, List<People>> student, Dictionary<int, string> stDic, string msg){
            List<People> sts = student(stDic);
            foreach (People st in sts)
                _handler.Evt += st.Do;
            _do(msg);
            foreach (People st in sts)
                _handler.Evt -= st.Do;
        }

        private void _do(string msg)
        {
            _handler.Do(new EvtArgs(msg));
            Console.WriteLine("Finish!");
        }
    }
}
