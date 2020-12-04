using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullBoss : MonoBehaviour
{
    public LayerMask eyes;
    public int bossHp;
    public GameObject youWin;
    public GameObject youDied;
    public int playerHP;
    bool isAlive;
    public GameObject explosion;
    public GameObject particleHolder;

    private Material matWhite;
    private Material matDefault;
    MeshRenderer mr;

    public float timer;
    private float timerHolder;

    public GameObject[] eyeList;

    public GameObject player;

    bool canLayout;

    void Start()
    {
        timerHolder = timer;
        isAlive = true;
        particleHolder = GameObject.FindGameObjectWithTag("particleHolder");
        mr = GetComponentInChildren<MeshRenderer>();
        matWhite = Resources.Load("BossFlash", typeof(Material)) as Material;
        matDefault = mr.material;
        player = GameObject.FindGameObjectWithTag("Player");
        canLayout = true;
        
    }

    void Update()
    {
        Vector3 lookVector = player.transform.position - transform.position;
        lookVector.y = transform.position.y;
        Quaternion rot = Quaternion.LookRotation(lookVector);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, 1);

        if (Input.GetMouseButtonDown(0) && isAlive)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo, Mathf.Infinity, eyes))
            {
                //var rig = hitInfo.collider.GetComponent<Rigidbody>();

                if(hitInfo.collider.GetComponent<EyeBehaviour>().isRed)
                {
                    hitInfo.collider.GetComponent<EyeBehaviour>().isRed = false;
                    //damageParticle.Play();
                    bossHp--;
                    mr.material = matWhite;
                    Invoke("ResetMaterial", 0.1f);


                    if (bossHp <= 0)
                    {
                        hitInfo.collider.GetComponent<EyeBehaviour>().canBecomeRed = false;
                    }
                }
            }
        }

        

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        if(timer <= 0)
        {
            timer = timerHolder;
            EyeBecomesRed();
            //CheckPlayerHP();
        }

        if (bossHp <= 0 && canLayout)
        {
            Instantiate(explosion, particleHolder.transform);
            Instantiate(youWin);
            canLayout = false;
            Destroy(gameObject);

        }

        if(playerHP <= 0 && canLayout)
        {
            PlayerDeath();
        }

        
    }

    void EyeBecomesRed()
    {
        int eye = Random.Range(0, eyeList.Length);

        eyeList[eye].GetComponent<EyeBehaviour>().isRed = true;

        timer = timerHolder;

        playerHP--;
    }

    void PlayerDeath()
    {
        Instantiate(youDied);
        isAlive = false;
        for (int i = 0; i < eyeList.Length; i++)
        {
            eyeList[i].GetComponent<EyeBehaviour>().isRed = true;
        }
        canLayout = false;
    }
    void ResetMaterial() 
    { 
        mr.material = matDefault;
    }
    void CheckPlayerHP()
    {
        for (int i = 0; i < eyeList.Length; i++)
        {
            if (eyeList[i].GetComponent<EyeBehaviour>().isRed == true)
            {
                playerHP--;
            }            
        }
    }
}
