using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_PlayerHPbar : MonoBehaviour
{
    Image DetectorBar;

    SkullBoss SB;
    private int playerHPTotal;

    void Start()
    {
        SB = GameObject.Find("Boss").GetComponent<SkullBoss>();
        DetectorBar = GetComponent<Image>();
        DetectorBar.fillAmount = 0;
        playerHPTotal = SB.playerHP;
    }

    void Update()
    {
        DetectorBar.fillAmount = (float) SB.playerHP / playerHPTotal;
    }
}
