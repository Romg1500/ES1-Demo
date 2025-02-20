using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jouer : MonoBehaviour
{
    public GameObject ObjetADetruire;
    public void DetruireObjet(){
        Destroy(ObjetADetruire);
        
    }

    
}
