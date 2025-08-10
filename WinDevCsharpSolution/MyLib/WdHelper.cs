using System;

namespace MyLib
{
    public static class WdHelpers
    {
        public static string GetDelegateAQN() =>
            typeof(EventHandler<MyEventArgs>).AssemblyQualifiedName;
    }
}