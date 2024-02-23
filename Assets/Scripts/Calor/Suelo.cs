using UnityEngine;


    public class Suelo : MonoBehaviour, IRadiacion
    {
        public void SerSuelo()
        {
            print("Soy suelo");
        }
        
        public void RecibirRadiacion()
        {
            print("Me puse amarillo");
        }
    }
