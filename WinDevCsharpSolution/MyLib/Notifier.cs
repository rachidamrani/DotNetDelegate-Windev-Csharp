namespace MyLib
{
    public class Notifier
    {
        public event MessageSentHandler SomethingHappened;
        public void Fire(string msg) => SomethingHappened?.Invoke(this, new MyEventArgs(msg));
    }
}