using System;
using CognitiveCoreUCU;

namespace PII_Herencia
{

    /// <summary>
    /// Clase con los métodos necesarios para validar fotos utilizando la CognitiveAPI
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PictureValidator
    {
        private CognitiveFace cogFace;

        public PictureValidator(string key = "620e818a46524ceb92628cde08068242")
        {
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
