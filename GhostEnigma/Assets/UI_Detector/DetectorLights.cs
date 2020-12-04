using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectorLights : MonoBehaviour
{
    Image DetectorBar;

    DistanceToObject DTO;

    void Start()
    {
        DTO = GameObject.Find("Proximity").GetComponent<DistanceToObject>();
        DetectorBar = GetComponent<Image>();
        DetectorBar.fillAmount = 0;
    }

    void Update()
    {
        DetectorBar.fillAmount = 1 / DTO.trueDistance;
    }
}
