using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{ public Rigidbody enemyRb;


      public void OnCollisionEnter(Collision collision)
    { 
     
        if(collision.gameObject.tag == "enemy")   
    
        Destroy(collision.gameObject);
        
    }
}
