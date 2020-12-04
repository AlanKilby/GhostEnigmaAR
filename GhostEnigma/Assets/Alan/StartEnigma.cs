using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEnigma : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerInteractions>().enigmaList[other.GetComponent<PlayerInteractions>().enigmaValidator].SetActive(true);
            //Instantiate(enigma, other.transform);
            //enigma.SetActive(true);
            Debug.Log("hit");
            Destroy(gameObject);
        }   
    }


}
