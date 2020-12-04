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
    public AudioSource audioPlayer;
    public AudioClip bossSpawnSound;

    private void Start()
    {
        enigmaValidator = 0;
    }


    private void Update()
    {
        if(enigmaValidator >= 3)
        {
            Boss();
            enigmaValidator = 0;
        }
    }



    void Boss()
    {
        audioPlayer.PlayOneShot(bossSpawnSound);
        Instantiate(boss,spawnHolder.transform.position, Quaternion.identity, bossSpawn.transform);
    }
}
