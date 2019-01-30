using System;
namespace Tutorial
{
    public delegate void EventHandler<EvtArgs>(object sender, EvtArgs e);
    public interface IEvtHandler
    {
        event EventHandler<EvtArgs> Evt;
        void Do(EvtArgs e);
    }
}
