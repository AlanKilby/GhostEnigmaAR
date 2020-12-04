using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeBehaviour : MonoBehaviour
{
    public bool isRed;
    public Material red;
    public Material white;
    public GameObject skull;
    public bool canBecomeRed;

    

    // Start is called before the first frame update
    void Start()
    {
        canBecomeRed = true;
        isRed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRed && canBecomeRed)
        {
            GetComponent<MeshRenderer>().material = red;
        }
        else
        {
            GetComponent<MeshRenderer>().material = white;
        }

        
    }
}
