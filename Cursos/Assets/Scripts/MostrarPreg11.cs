using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarTexto11 : MonoBehaviour
{
   public Canvas Canvas11;

   void OnTriggerEnter(Collider Usuario){
       if(Usuario.tag == "Player"){
        Canvas11.enabled=true;
       }
   }

   void OnTriggerExit(Collider Usuario){
    if(Usuario.tag == "Player"){
        Canvas11.enabled=false;
       }
   }
}
