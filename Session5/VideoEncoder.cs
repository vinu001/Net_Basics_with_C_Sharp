using System;
using System.Threading;

namespace Session5
{
    public class VideoEncoder
    {

      public delegate void VideoEncoded (object obj,EventArgs e);

        public event VideoEncoded OnVideoEncodedHandler;

        public  void Encode(Video  video)
        {
            Console.WriteLine("Encoding is in progress....");
         // Thread.Sleep(3000);
            OnVideoEncoded();

            // Console.WriteLine("Video " + video.Title + " is encoded");

            // MailService.SendEmail();
            // MessageService.SendMessage();
        }
        public  void OnVideoEncoded()
        {
            Console.WriteLine("Video encoded completed");
            OnVideoEncodedHandler (this, EventArgs.Empty);
        }
    }
    
}