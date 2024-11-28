using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarTexto10 : MonoBehaviour
{
   public Canvas Canvas10;

   void OnTriggerEnter(Collider Usuario){
       if(Usuario.tag == "Player"){
        Canvas10.enabled=true;
       }
   }

   void OnTriggerExit(Collider Usuario){
    if(Usuario.tag == "Player"){
        Canvas10.enabled=false;
       }
   }
}
