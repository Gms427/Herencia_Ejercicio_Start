using System;
using CognitiveCoreUCU;

namespace PII_Herencia
{

    /// <summary>
    /// Clase con los métodos necesarios para validar fotos utilizando la CognitiveAPI
    /// 
    /// Decidimos crear esta clase que se encargue de las validaciones sobre las fotos para no romper con el principio SRP,
    /// ya que si no creabamos la clase había que agregarle una responsabilidad adicional a una de las ya existentes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PictureValidator
    {
        private CognitiveFace cogFace;

        public PictureValidator(string key = "620e818a46524ceb92628cde08068242")
        {
            // Acá aplicamos el patrón creator, la clase PictureValidator se encarga de crear la instancia de CognitiveFace ya
            // que es la clase que va a guardar dicha instancia
            this.cogFace = new CognitiveFace(key);
        }

        public bool ValidatePictureContainFace(string path)
        {
            this.cogFace.Recognize(path);
            return this.cogFace.FaceFound;
        }

        public bool ValidatePictureContainFaceSmiling(string path)
        {
            this.cogFace.Recognize(path);
            return (this.cogFace.FaceFound && this.cogFace.SmileFound);
        }
    }
}
