using System;
using TwitterUCU;

namespace PII_Herencia
{
    /// <summary>
    /// Clase encargada de brindar las operaciones necesarias para publicar pasajeros y conductores en Twitter
    /// </summary>
    public class TwitterPublisher: IPublisher
    {
        private const string ConsumerKey = "CkovShLMNVCY0STsZlcRUFu99";
        private const string ConsumerKeySecret = "6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
        private const string AccessToken = "1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";
        private const string AccessTokenSecret = "gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
        private TwitterImage twitter;
        private PictureValidator pictureValidator;

        public TwitterPublisher()
        {
            this.twitter = new TwitterImage(ConsumerKey, ConsumerKeySecret, AccessToken, AccessTokenSecret);
            this.pictureValidator = new PictureValidator();
        }

        public void PublishPerson(Person person, IPersonPublisher personPublisher)
        {
            personPublisher.Publish(person, this);
        }
        public void PublishDriver(Driver driver){
            
            if(this.pictureValidator.ValidatePictureContainFaceSmiling(driver.Image))
            {
                Console.WriteLine(twitter.PublishToTwitter($"Bienvenido! \n {driver.Biography}", driver.Image));
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
                Console.WriteLine(twitter.PublishToTwitter(passenger.Name, passenger.Image));
            }
            else
            {
                Console.WriteLine($"La imagen de {passenger.Name} no contiene una cara");
            }
        }
    }
}