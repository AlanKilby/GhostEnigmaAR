using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationJigsaw : MonoBehaviour
{
    [SerializeField] private Transform[] pictures;

    Vector3 winRotation;

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
            if(pictures[i].rotation.z != 0)
            {
                return;
            }
        }
        jigsawWinned = true;
    }
}
