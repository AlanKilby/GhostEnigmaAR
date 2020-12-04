using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEnigmaScript : MonoBehaviour
{


    public GameObject lightOne, lightTwo, lightThree, lightFour;
    private bool lightOneb, lightTwob, lightThreeb, lightFourb;

    public GameObject player;
    public GameObject objectSpawner;

    public float timer;

    public InstantiateIcon icon;

    public GameObject upsideDown;


    void Start()
    {
        lightOne.SetActive(false);
        lightTwo.SetActive(false);
        lightThree.SetActive(false);
        lightFour.SetActive(false);

        lightOneb = false;
        lightTwob = false;
        lightThreeb = false;
        lightFourb = false;
    }


    void Update()
    {

        // when the "if" function beneath is good, then the enigma is solved.
        if (lightOneb && lightTwob && lightThreeb && lightFourb && timer > 0)
        {
            timer -= Time.deltaTime;
        }

        if (lightOneb && lightTwob && lightThreeb && lightFourb && timer < 0)
        {


            player.GetComponent<PlayerInteractions>().enigmaValidator++;
            objectSpawner.GetComponent<ObjectSpawner>().GenerateChallenge();
            DistanceToObject.canDetect = true;
            icon.InstatiateIcon();
            upsideDown = GameObject.FindGameObjectWithTag("upsidedown");
            Destroy(upsideDown);
            gameObject.SetActive(false);
        }
    }




    public void ButtonOne()
    {
        if (!lightOneb && !lightTwob && !lightThreeb && !lightFourb)
        {
            lightOne.SetActive(true);
            lightOneb = true;
        }
        else
        {
            lightOne.SetActive(false);
            lightTwo.SetActive(false);
            lightThree.SetActive(false);
            lightFour.SetActive(false);

            lightOneb = false;
            lightTwob = false;
            lightThreeb = false;
            lightFourb = false;
        }

    }

    public void ButtonTwo()
    {
        if (lightOneb && !lightTwob && !lightThreeb && !lightFourb)
        {
            lightTwo.SetActive(true);
            lightTwob = true;
        }
        else
        {
            lightOne.SetActive(false);
            lightTwo.SetActive(false);
            lightThree.SetActive(false);
            lightFour.SetActive(false);

            lightOneb = false;
            lightTwob = false;
            lightThreeb = false;
            lightFourb = false;
        }
    }

    public void ButtonThree()
    {
        if (lightOneb && lightTwob && !lightThreeb && !lightFourb)
        {
            lightThree.SetActive(true);
            lightThreeb = true;
        }
        else
        {
            lightOne.SetActive(false);
            lightTwo.SetActive(false);
            lightThree.SetActive(false);
            lightFour.SetActive(false);

            lightOneb = false;
            lightTwob = false;
            lightThreeb = false;
            lightFourb = false;
        }
    }

    public void ButtonFour()
    {
        if (lightOneb && lightTwob && lightThreeb && !lightFourb)
        {
            lightFour.SetActive(true);
            lightFourb = true;
        }
        else
        {
            lightOne.SetActive(false);
            lightTwo.SetActive(false);
            lightThree.SetActive(false);
            lightFour.SetActive(false);

            lightOneb = false;
            lightTwob = false;
            lightThreeb = false;
            lightFourb = false;
        }
    }


    void Victory()
    {  
    }

}
