using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptForExemple : MonoBehaviour
{
    InstantiateIcon II;

    void Start()
    {
        II = GetComponent<InstantiateIcon>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            II.InstatiateIcon();
        }
    }
}
