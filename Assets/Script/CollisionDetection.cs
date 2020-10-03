using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
        void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Finished Line"){
        
         SceneManager.LoadScene("SceneWin");
        }
        else if(collision.gameObject.tag=="Item"){
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.tag=="Hole"){
            Destroy(this.gameObject);
        
            SceneManager.LoadScene("SceneLose");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
