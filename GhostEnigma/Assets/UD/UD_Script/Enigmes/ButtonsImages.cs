using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsImages : MonoBehaviour
{
    [SerializeField] bool goodAnswer;
    [SerializeField] bool wrongAnswer;

    public static bool chimeraWinned;

    GameObject player;
    GameObject parent;
    GameObject spawner;

    private void Start()
    {
        chimeraWinned = false;
        player = GameObject.FindGameObjectWithTag("Player");
        spawner = GameObject.FindGameObjectWithTag("Spawner");
        parent = transform.parent.gameObject;

        player.GetComponent<PlayerInteractions>();
    }

    public void ButtonClicked()
    {
        if (goodAnswer)
        {
            chimeraWinned = true;
            player.GetComponent<PlayerInteractions>().enigmaValidator++;
            spawner.GetComponent<ObjectSpawner>().GenerateChallenge();
            parent.SetActive(false);
            
        }
        if (wrongAnswer)
        {
            chimeraWinned = false;
            //Mettre le exit de l'interface
        }
    }
}
