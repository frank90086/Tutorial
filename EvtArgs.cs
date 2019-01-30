using System;
namespace Tutorial
{
    public class EvtArgs : EventArgs
    {
        public EvtArgs(string msg){
            Message = msg;
        }
        public string Message { get; set; }
    }
}
