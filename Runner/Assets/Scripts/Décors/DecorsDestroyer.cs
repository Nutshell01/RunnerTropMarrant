using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorsDestroyer : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
       if(other.gameObject.tag == "Generated")
       {
           Destroy(other.gameObject);
       }
   }
}
