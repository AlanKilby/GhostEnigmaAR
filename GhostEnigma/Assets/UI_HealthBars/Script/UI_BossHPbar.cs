using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_BossHPbar : MonoBehaviour
{
    Image DetectorBar;

    SkullBoss SB;
    private int bossHPTotal;

    void Start()
    {
        SB = GameObject.Find("Boss").GetComponent<SkullBoss>();
        DetectorBar = GetComponent<Image>();
        DetectorBar.fillAmount = 0;
        bossHPTotal = SB.bossHp;
    }

    void Update()
    {
        DetectorBar.fillAmount = (float) SB.bossHp / bossHPTotal;
    }
}
