using UnityEngine;


    public abstract class Planta : MonoBehaviour, IRadiacion
    {
        public virtual void RecibirRadiacion()
        {
            print($"La planta {name}: Me estoy secando, ayuda");
        }
    }
