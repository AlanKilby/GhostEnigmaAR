using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectToSpawn;
    public GameObject currentObject;
    public float spaceSize;


    private void Start()
    {
        
        
        currentObject = Instantiate(objectToSpawn[0], new Vector3(Random.Range(-spaceSize, spaceSize), -0.7f, Random.Range(-spaceSize, spaceSize)), Quaternion.identity);
        
    }
    public void GenerateSecondChallenge()
    {
        currentObject = Instantiate(objectToSpawn[1], new Vector3(Random.Range(-spaceSize, spaceSize), -0.7f, Random.Range(-spaceSize, spaceSize)), Quaternion.identity);
    }

    public void GenerateThirdChallenge()
    {
        currentObject = Instantiate(objectToSpawn[2], new Vector3(Random.Range(-spaceSize, spaceSize), -0.7f, Random.Range(-spaceSize, spaceSize)), Quaternion.identity);
    }
}
