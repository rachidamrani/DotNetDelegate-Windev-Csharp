namespace MyLib
{
    public class Notifier
    {
        public event MessageSentEvent MessageSent;
        public void Fire(string msg) => MessageSent?.Invoke(this, new MyEventArgs(msg));
    }
}