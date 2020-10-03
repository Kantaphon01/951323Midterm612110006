using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player"){
        
         SceneManager.LoadScene("SceneWin2");
        }
}
}

