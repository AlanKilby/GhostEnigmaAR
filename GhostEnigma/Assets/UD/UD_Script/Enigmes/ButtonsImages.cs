using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsImages : MonoBehaviour
{
    [SerializeField] bool goodAnswer;
    [SerializeField] bool wrongAnswer;

    public static bool chimeraWinned;

    public InstantiateIcon icon;

    GameObject player;
    GameObject parent;
    GameObject spawner;

    public GameObject upsideDown;

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
            icon.InstatiateIcon();
            upsideDown = GameObject.FindGameObjectWithTag("upsidedown");
            Destroy(upsideDown);
            DistanceToObject.canDetect = true;
            parent.SetActive(false);
            
        }
        if (wrongAnswer)
        {
            chimeraWinned = false;
            //Mettre le exit de l'interface
        }
    }
}
