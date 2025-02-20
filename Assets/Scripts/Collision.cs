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
            Invoke("Cinq", 0f);
            Invoke("Quatre", 1f);
            Invoke("Trois", 2f);
            Invoke("deux", 3f);
            Invoke("un", 4f);
            Invoke("zero", 5f);
        } 
    }
    
    void Replay(){
        SceneManager.LoadScene("ES1-Demo");
    }

    void Cinq(){
        Debug.Log("5");
    }

    void Quatre(){
        Debug.Log("4");
    }

    void Trois(){
        Debug.Log("3");
    }

    void deux(){
        Debug.Log("2");
    }

    void un(){
        Debug.Log("1");
    }

    void zero(){
        Debug.Log("0");
    }
}
