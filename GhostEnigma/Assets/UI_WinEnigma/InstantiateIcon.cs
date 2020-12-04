using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateIcon : MonoBehaviour
{
    WinLists WL;
    [SerializeField] GameObject icon;

    private void Start()
    {
        WL = GameObject.Find("WinIconList").GetComponent<WinLists>();
    }

    public void InstatiateIcon()
    {
        for (int i = 0; i < WL.slots.Length; i++)
        {
            if (WL.isFull[i] == false)
            {
                //WL.icon[i] = gameObject; //Met le module dans la liste

                //Mo.moduleSlot = i; //Attribue un slot au Module // JSP A QUOI CA SERT

                WL.isFull[i] = true; //Fait que le Slot ne puisse plus être utilisé

                Instantiate(icon, WL.slots[i].transform, false);

                transform.SetParent(WL.slots[i].transform);

                break;
            }

        }
    }
}
