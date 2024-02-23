using UnityEngine;


    public class Jugador : MonoBehaviour, IRadiacion
    {
        public void Saludar()
        {
            print("Holi");
        }
        
        public void RecibirRadiacion()
        {
            print("Me insole :c");
        }
    }
