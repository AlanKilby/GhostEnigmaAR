using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    public float enigmaValidator;

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
