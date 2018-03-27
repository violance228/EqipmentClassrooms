using System;

namespace Common.Events
{
    public class StringChangingEventArgs : EventArgs
    {
        public readonly string OldValue;
        public readonly string NewValue;
        public bool Cancel;

        public StringChangingEventArgs(
            string oldValue, string newValue)
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }
    }
}