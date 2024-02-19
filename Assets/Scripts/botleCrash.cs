using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class botleCrash : MonoBehaviour
{
    public GameObject audioCrash;
    
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        audioCrash.SetActive(true);
        Destroy(gameObject);
       
    }

    void Update()
    {
        
    }
}
