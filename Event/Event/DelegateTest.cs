namespace Event
{
    //public class DelegatePublish
    //{
    //    public int Value
    //    {
    //        get => _value;
    //        set
    //        {
    //            _value = value;
    //            OnChanged?.Invoke(this,new ValueArgs(_value));
    //        }
    //    }

    //    private int _value { get; set; }

    //    public event EventHandler<ValueArgs> OnChanged; 

    //    public class ValueArgs:EventArgs
    //    {
    //        public ValueArgs(int newValue)
    //        {
    //            NewValue = newValue;
    //        }

    //        public int NewValue { get; set; }
    //    }
    //}

    public class DelegatePublish
    {
        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                _OnChanged?.Invoke(this, new ValueArgs(_value));
            }
        }

        public event EventHandler<ValueArgs> OnChanged
        {
            add => _OnChanged = (ChangedHandler)Delegate.Combine(value, _OnChanged);
            remove => _OnChanged = (ChangedHandler)Delegate.Remove(_OnChanged, value)!;
        }

        public delegate void ChangedHandler(object sender, ValueArgs newValue);

        private int _value { get; set; }

        protected event ChangedHandler? _OnChanged;

        public class ValueArgs : EventArgs
        {
            public ValueArgs(int newValue)
            {
                NewValue = newValue;
            }

            public int NewValue { get; set; }
        }
    }

    public class DelegateSubscribe
    {
        public void ValueChanged(int value)
        {
            Console.WriteLine(value);
        }
    }
}
