using System;

namespace Common.Events
{
    public class CommandSelectingEventArgs : EventArgs
    {

        public string Message { get; set; }
        public bool Cancel { get; set; }
        public readonly string Name;

        public CommandSelectingEventArgs(string name)
        {
            this.Name = name;
        }
    }
}