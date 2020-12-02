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
            transform.Rotate(0f, 0f, rotationOnClick);
        }
    }
}
