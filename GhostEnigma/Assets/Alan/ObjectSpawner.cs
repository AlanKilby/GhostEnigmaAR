using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject currentObject;
    public float spaceSize;


    private void Start()
    {   
        currentObject = Instantiate(objectToSpawn, new Vector3(Random.Range(-spaceSize, spaceSize), 0, Random.Range(-spaceSize, spaceSize)), Quaternion.identity);     
    }
    public void GenerateChallenge()
    {
        currentObject = Instantiate(objectToSpawn, new Vector3(Random.Range(-spaceSize, spaceSize), 0, Random.Range(-spaceSize, spaceSize)), Quaternion.identity);
    }

    

    
}
