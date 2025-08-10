using MyLib;

var notifier = new Notifier();

notifier.MessageSent += OnMessageSentHandler;

// Perform action
notifier.Fire("This is the message I want to send !");


void OnMessageSentHandler(object sender, MyEventArgs e)
{
    Console.WriteLine(e.Message);
}
