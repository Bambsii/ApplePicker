using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Papple : MonoBehaviour
{
    
    public static float bottomY = -20f;
   void Update()
    {
        if (transform.position.y < bottomY){
            Destroy(this.gameObject);
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
        }    
    }

    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Basket"))
        {
            
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            apScript.PappleCaught(); 
            
        }
    }
}