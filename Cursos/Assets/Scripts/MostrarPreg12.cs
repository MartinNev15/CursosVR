using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarTexto12 : MonoBehaviour
{
   public Canvas Canvas12;

   void OnTriggerEnter(Collider Usuario){
       if(Usuario.tag == "Player"){
        Canvas12.enabled=true;
       }
   }

   void OnTriggerExit(Collider Usuario){
    if(Usuario.tag == "Player"){
        Canvas12.enabled=false;
       }
   }
}
