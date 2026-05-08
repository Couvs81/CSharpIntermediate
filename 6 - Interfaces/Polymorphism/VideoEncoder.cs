namespace Polymorphism
{
    public class VideoEncoder
    {
        //private readonly MailService _mailservice;  // use an interface instead of this
        private readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncoder()
        {
            //_mailservice = new MailService();
            _notificationChannels = new List<INotificationChannel>();
        }
        public void Encode(Video video)
        {
            // Video encoding logic...

            //_mailservice.Send(new Mail());
            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }

        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
