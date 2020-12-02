using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsImages : MonoBehaviour
{
    [SerializeField] bool goodAnswer;
    [SerializeField] bool wrongAnswer;

    public static bool chimeraWinned;

    private void Start()
    {
        chimeraWinned = false;
    }

    public void ButtonClicked()
    {
        if (goodAnswer)
        {
            chimeraWinned = true;
        }
        if (wrongAnswer)
        {
            chimeraWinned = false;
            //Mettre le exit de l'interface
        }
    }
}
