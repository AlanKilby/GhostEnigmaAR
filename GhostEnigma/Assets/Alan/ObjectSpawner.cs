using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject[] objectList;
    public float spaceSize;


    private void Start()
    {
        
        
        objectList[0] = Instantiate(objectToSpawn, new Vector3(Random.Range(-spaceSize, spaceSize), -0.7f, Random.Range(-spaceSize, spaceSize)), Quaternion.identity);
        
    }
    public void GenerateNewObject()
    {
        objectList[0] = Instantiate(objectToSpawn, new Vector3(Random.Range(-spaceSize, spaceSize), -0.7f, Random.Range(-spaceSize, spaceSize)), Quaternion.identity);
    }
}
