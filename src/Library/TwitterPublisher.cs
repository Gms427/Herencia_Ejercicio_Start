using System;
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
        private PictureValidator pictureValidator;

        public TwitterPublisher()
        {
            this.twitter = new TwitterImage(ConsumerKey, ConsumerKeySecret, AccessToken, AccessTokenSecret);
            this.pictureValidator = new PictureValidator();
        }
        public void PublishDriver(Driver driver){
            
            if(this.pictureValidator.ValidatePictureContainFaceSmiling(driver.Image))
            {
                twitter.PublishToTwitter($"Bienvenido! /n {driver.Biography}", driver.Image);
            }
            else
            {
                Console.WriteLine($"La imagen de {driver.Name} no contiene una cara, o la cara que contiene no está sonriendo");
            }
        }

        public void PublishPassenger(Passenger passenger)
        {
            if(this.pictureValidator.ValidatePictureContainFace(passenger.Image))
            {
                twitter.PublishToTwitter(passenger.Name, passenger.Image);
            }
            else
            {
                Console.WriteLine($"La imagen de {passenger.Name} no contiene una cara");
            }
        }
    }
}