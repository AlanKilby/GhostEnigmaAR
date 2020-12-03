using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationJigsaw : MonoBehaviour
{
    [SerializeField] private GameObject[] pictures;

    Vector3 winRotation;

    [SerializeField] float margeDErreur;

    public static bool jigsawWinned;

    void Start()
    {
        jigsawWinned = false;
    }

    void Update()
    {
        /*foreach (Transform pieces in pictures)
        {
            if (pieces.rotation.z != 0)
            {
                return;
            }
        }*/
        for(int i = 0; i<pictures.Length; i++)
        {

            //float xTransformRotation = pictures[i].transform.eulerAngles.x;
            //float xTransformRotation = pictures[i].transform.localEulerAngles.x;
            float xTransformRotation = pictures[i].transform.localEulerAngles.x;
            Debug.Log("Object "+i+" current rotation "+xTransformRotation);
            if (-margeDErreur< xTransformRotation && xTransformRotation < margeDErreur)
            {
                Debug.Log("check" + i);
            }
            else
            {
                Debug.Log("return" + i);
                return;
            }
        }
        jigsawWinned = true;
        Debug.Log(jigsawWinned);
    }
}
