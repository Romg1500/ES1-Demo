using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjetDetruire : MonoBehaviour
{
    public GameObject ObjetADetruire;
    public GameObject ObjetADetruire2;
    public GameObject ObjetADetruire3;

    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Rouge")) 
        {
            Destroy(ObjetADetruire);
            Destroy(ObjetADetruire2);
            Invoke("Destroy", 3f);
        } 

        
    }

    void Destroy(){
            Destroy(ObjetADetruire3);
        }
}
