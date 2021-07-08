using System;

namespace  Session5
{
    public class MessageService
    {
        public static void SendMessage(object source,EventArgs e)
        {
            Console.WriteLine("Text message sent");
        }
    } 
    
}