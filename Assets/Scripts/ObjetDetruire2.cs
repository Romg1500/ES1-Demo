using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjetDetruire2 : MonoBehaviour
{
    public GameObject ObjetADetruire;

    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Rouge2")) 
        {
            Destroy(ObjetADetruire);
        } 
    }
}
