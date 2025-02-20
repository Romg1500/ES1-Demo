using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Finish")) 
        {
            Invoke("Replay", 5f);
        } 
    }
    
    void Replay(){
        SceneManager.LoadScene("ES1-Demo");
    }
}
