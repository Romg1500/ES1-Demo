using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjetDetruire : MonoBehaviour
{
    public GameObject ObjetADetruire;
    public GameObject ObjetADetruire2;

    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Rouge")) 
        {
            Destroy(ObjetADetruire);
            Destroy(ObjetADetruire2);
        } 
    }
}
