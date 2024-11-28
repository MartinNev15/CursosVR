using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarTexto3 : MonoBehaviour
{
   public Canvas Canvas3;

   void OnTriggerEnter(Collider Usuario){
       if(Usuario.tag == "Player"){
        Canvas3.enabled=true;
       }
   }

   void OnTriggerExit(Collider Usuario){
    if(Usuario.tag == "Player"){
        Canvas3.enabled=false;
       }
   }
}
