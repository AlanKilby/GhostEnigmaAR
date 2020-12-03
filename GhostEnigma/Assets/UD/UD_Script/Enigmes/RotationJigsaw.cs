using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationJigsaw : MonoBehaviour
{
    [SerializeField] private GameObject[] pictures;

    [SerializeField] float margeDErreur;

    public static bool jigsawWinned = false;

    void Update()
    {
        int checkedJig = 0;
        foreach (GameObject obj in pictures)
        {
            if (obj == pictures[0])
            {
                if ((270 - margeDErreur < obj.GetComponent<Transform>().transform.rotation.eulerAngles.x && obj.GetComponent<Transform>().transform.rotation.eulerAngles.x < 270 + margeDErreur) || (90 - margeDErreur < obj.GetComponent<Transform>().transform.rotation.eulerAngles.x && obj.GetComponent<Transform>().transform.rotation.eulerAngles.x < 90 + margeDErreur)) checkedJig++;
            }
            else
            {
                if (270 - margeDErreur < obj.GetComponent<Transform>().transform.rotation.eulerAngles.x && obj.GetComponent<Transform>().transform.rotation.eulerAngles.x < 270 + margeDErreur) checkedJig++;
            }
        }
        if (checkedJig == pictures.Length) jigsawWinned = true;
    }
}
