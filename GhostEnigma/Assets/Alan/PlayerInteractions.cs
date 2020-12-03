using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    public int enigmaValidator;
    public GameObject[] enigmaList;

    private void Start()
    {
        enigmaValidator = 0;
    }


    private void Update()
    {
        if(enigmaValidator >= 3)
        {
            Boss();
        }
    }



    void Boss()
    {

    }
}
