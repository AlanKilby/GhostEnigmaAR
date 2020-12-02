using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    Vector3 phoneStartPos;

    public float minX;
    public float minY;
    public float minZ;
    public float maxX;
    public float maxY;
    public float maxZ;

    void Start()
    {
        gameObject.transform.position = GetRandomPosition();
    }

    void Update()
    {
        
    }

    Vector3 GetRandomPosition()
    {
        float randX = Random.Range(minX, maxX);
        float randY = Random.Range(minY, maxY);
        float randZ = Random.Range(minZ, maxZ);
        return new Vector3(randX, randY, randZ);
    }
}
