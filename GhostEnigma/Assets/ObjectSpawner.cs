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

    private void Update()
    {
        //if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        //{
        //    GameObject obj = Instantiate(objectToSpawn, placementIndicator.transform.position, placementIndicator.transform.rotation);
        //}


    }

    public void GenerateNewObject()
    {
        objectList[0] = Instantiate(objectToSpawn, new Vector3(Random.Range(-spaceSize, spaceSize), -0.7f, Random.Range(-spaceSize, spaceSize)), Quaternion.identity);
    }
}
