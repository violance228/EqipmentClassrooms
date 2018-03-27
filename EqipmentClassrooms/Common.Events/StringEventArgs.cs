using System;

namespace Common.Events
{
    public class StringEventArgs : EventArgs
    {

        public readonly string Value;

        public StringEventArgs(string value)
        {
            this.Value = value;
        }
    }
}
