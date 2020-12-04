using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToObject : MonoBehaviour
{
    public ObjectSpawner objectSpawner;
    public AudioClip[] beep;
    public AudioSource audioBeep;
    public float distanceHolder;
    public float trueDistance;
    static public bool canDetect;

    private void Start()
    {
        distanceHolder = Vector3.Distance(transform.position, objectSpawner.currentObject.transform.position)/2;
        trueDistance = Vector3.Distance(transform.position, objectSpawner.currentObject.transform.position);
        canDetect = true;
    }

    private void Update()
    {
        //if (Vector3.Distance(transform.position, objectSpawner.objectList[0].transform.position) > 2)
        //{
        //    if(audioBeep.clip != beep[0])
        //    {
        //        audioBeep.clip = beep[0];
        //        audioBeep.Play();
        //    }
        //}
        //else if(Vector3.Distance(transform.position,objectSpawner.objectList[0].transform.position) < 2 &&  (Vector3.Distance(transform.position, objectSpawner.objectList[0].transform.position) > 0.5))
        //{
        //    if (audioBeep.clip != beep[1])
        //    {
        //        audioBeep.clip = beep[1];
        //        audioBeep.Play();
        //    }

        //}
        //else if (Vector3.Distance(transform.position, objectSpawner.objectList[0].transform.position) < 0.5)
        //{
        //    if (audioBeep.clip != beep[2])
        //    {
        //        audioBeep.clip = beep[2];
        //        audioBeep.Play();
        //    }
        //}
        trueDistance = Vector3.Distance(transform.position, objectSpawner.currentObject.transform.position);

        if (distanceHolder >= 0)
        {
            distanceHolder -= Time.deltaTime;
        }

        if(distanceHolder <= 0 && canDetect)
        {
            audioBeep.clip = beep[0];
            audioBeep.Play();
            distanceHolder = Vector3.Distance(transform.position, objectSpawner.currentObject.transform.position)/2;
        }
        

    }
}
