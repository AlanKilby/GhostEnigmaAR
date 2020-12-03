using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePieces : MonoBehaviour
{
    public float rotationOnClick;

    private void OnMouseDown()
    {
        if (!RotationJigsaw.jigsawWinned)
        {
            transform.Rotate(rotationOnClick, 0f, 0f, Space.World);
            //gameObject.transform.rotation(transform.rotation.x + rotationOnClick, 0f, 0f);
        }
    }
}
