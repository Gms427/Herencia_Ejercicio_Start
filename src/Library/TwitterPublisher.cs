using TwitterUCU;

namespace PII_Herencia
{
    public class TwitterPublisher: IPublisher
    {
        private const string ConsumerKey = "";
        private const string ConsumerKeySecret = "";
        private const string AccessToken = "";
        private const string AccessTokenSecret = "";

        private TwitterImage twitter;

        public TwitterPublisher()
        {
            this.twitter = new TwitterImage(ConsumerKey, ConsumerKeySecret, AccessToken, AccessTokenSecret);
        }
        public void PublishDriver(Driver driver){
            
            twitter.PublishToTwitter($"Bienvenido! /n {driver.Biography}", driver.Image);
        }

        public void PublishPassenger(Passenger passenger)
        {
            twitter.PublishToTwitter(passenger.Name, passenger.Image);
        }
    }
}