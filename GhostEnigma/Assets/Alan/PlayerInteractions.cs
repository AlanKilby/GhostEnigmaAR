using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    public int enigmaValidator;
    public GameObject[] enigmaList;
    public GameObject boss;
    public GameObject bossSpawn;
    public GameObject spawnHolder;

    private void Start()
    {
        enigmaValidator = 0;
        Boss();
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
        Instantiate(boss,spawnHolder.transform.position, Quaternion.identity, bossSpawn.transform);
    }
}
