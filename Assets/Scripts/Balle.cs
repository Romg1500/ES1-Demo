using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JeuPoisson : MonoBehaviour
{

    [SerializeReference] private GameObject _sardine;

    // Start is called before the first frame update
    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ComparerPoissons()
    {
        Destroy(_sardine);
    }   
}