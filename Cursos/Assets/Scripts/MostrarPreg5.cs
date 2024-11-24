using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarTexto5 : MonoBehaviour
{
   public Canvas Canvas5;

   void OnTriggerEnter(Collider Usuario){
       if(Usuario.tag == "Player"){
        Canvas5.enabled=true;
       }
   }

   void OnTriggerExit(Collider Usuario){
    if(Usuario.tag == "Player"){
        Canvas5.enabled=false;
       }
   }
}
