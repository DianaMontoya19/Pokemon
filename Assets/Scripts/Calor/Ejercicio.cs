using System;
using UnityEngine;

 public class Ejercicio : MonoBehaviour
 {
     public GameObject[] objetosQueSeVanAQuemar;
        
     private void Start()
     {
        foreach (var objetoAQuemar in objetosQueSeVanAQuemar)
        {
            IRadiacion Objeto = objetoAQuemar.GetComponent<IRadiacion>();

            (Objeto as Jugador)?.RecibirRadiacion();
            (Objeto as Jugador)?.Saludar();

            if(Objeto is PlantaVegetacion)
            {
                PlantaVegetacion ObjetoCasteado = (PlantaVegetacion) Objeto;
                
                ObjetoCasteado.name = ("Planta1");
               ObjetoCasteado.RecibirRadiacion();
                
            }
            if (Objeto is PlantaVegetacion)
            {
                PlantaVegetacion ObjetoCasteado2 = (PlantaVegetacion)Objeto;
                ObjetoCasteado2.name = ("Planta3");
                ObjetoCasteado2.RecibirRadiacion();
            }

            (Objeto as PlantaAcuatica)?.RecibirRadiacion();
            //(Objeto as PlantaAcuatica)?.RecibirRadiacion();
            (Objeto as PlantaDesertica)?.RecibirRadiacion();
            //(Objeto as PlantaDesertica)?.RecibirRadiacion();
            (Objeto as Suelo)?.SerSuelo();
            (Objeto as Suelo)?.RecibirRadiacion();

        }
             
      }
 }
