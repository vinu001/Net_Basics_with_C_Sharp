using System;

namespace Session5
{
    class Program
    {
        static void Main(string[] args)
        {
        //     Delegate del = new Delegate();
        //     del.printDel = del.Print; //single cast delegate
        //     del.printDel("ABCD");

        //   //  del.printDel += del.PrintNumber;
        //     del.printDel =  del.PrintNumber;
        //     del.printDel -= del.PrintNumber;
        //     del.printDel("1562");
        Video video = new Video { Title = "Delegates"};

        VideoEncoder encoder= new VideoEncoder();

        
    encoder.OnVideoEncodedHandler += MailService.SendEmail();
    encoder.OnVideoEncodedHandler += MessageService.SendMessage();
    encoder.Encode(video);


        }
    }
}
