using System;
namespace Tutorial
{
    public class EvtHandler : IEvtHandler
    {
        public event EventHandler<EvtArgs> Evt;

        public void Do(EvtArgs e){
            if (Evt != null)
                Evt.Invoke(this, e);
        }
    }
}
