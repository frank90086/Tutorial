using System;
namespace Tutorial
{
    public class Family : People
    {
        public string Name { get; set; }
        public Family(string name){
            Name = name;
        }
        public override void Do(object sender, EvtArgs e){
            Console.WriteLine($"{Name} {e.Message} !");
        }
    }
}
