using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeEnigma : MonoBehaviour
{
    [SerializeField] bool goodAnswer;
    [SerializeField] bool wrongAnswer;

    public static bool cubeWinned;

    GameObject player;
    GameObject parent;
    GameObject spawner;
    public GameObject upsideDown;

    public InstantiateIcon icon;

    private void Start()
    {
        cubeWinned = false;
        player = GameObject.FindGameObjectWithTag("Player");
        spawner = GameObject.FindGameObjectWithTag("Spawner");
        parent = transform.parent.gameObject;

        player.GetComponent<PlayerInteractions>();
    }

    public void ButtonClicked()
    {
        if (goodAnswer)
        {
            cubeWinned = true;
            player.GetComponent<PlayerInteractions>().enigmaValidator++;
            spawner.GetComponent<ObjectSpawner>().GenerateChallenge();
            icon.InstatiateIcon();
            upsideDown = GameObject.FindGameObjectWithTag("upsidedown");
            Destroy(upsideDown);
            parent.SetActive(false);

        }
        if (wrongAnswer)
        {
            cubeWinned = false;
            //Mettre le exit de l'interface
        }
    }
}
