using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEnigma : MonoBehaviour
{
    public GameObject newSpawner;
    public GameObject upsideDown;

    private void Start()
    {
        newSpawner = GameObject.FindGameObjectWithTag("Spawner");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerInteractions>().enigmaList[other.GetComponent<PlayerInteractions>().enigmaValidator].SetActive(true);
            //Instantiate(enigma, other.transform);
            //enigma.SetActive(true);           
            Instantiate(upsideDown);          
            newSpawner.GetComponent<ObjectSpawner>().currentObject = null;
            Debug.Log("hit");
            DistanceToObject.canDetect = false;
            Destroy(gameObject);
        }   
    }


}
