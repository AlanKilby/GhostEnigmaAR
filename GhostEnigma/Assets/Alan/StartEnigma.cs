using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEnigma : MonoBehaviour
{
    public GameObject enigma;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enigma.SetActive(true);
            Debug.Log("hit");
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
            
        
    }


}
