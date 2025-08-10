namespace MyLib
{
    public class Notifier
    {
        public event MessageSentEvent SomethingHappened;
        public void Fire(string msg) => SomethingHappened?.Invoke(this, new MyEventArgs(msg));
    }
}