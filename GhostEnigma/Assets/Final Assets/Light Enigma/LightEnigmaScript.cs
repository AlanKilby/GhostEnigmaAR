using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEnigmaScript : MonoBehaviour
{


    public GameObject lightOne, lightTwo, lightThree, lightFour;
    private bool lightOneb, lightTwob, lightThreeb, lightFourb;

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
        //if (lightOne && lightTwo && lightThree && lightFour)
        //{

        //}
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

}
