using System;

namespace MyLib
{
    public class MyEventArgs : EventArgs 
    { 
        public string Message { get; }
        public MyEventArgs(string message) { Message = message; }
    }
}