using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManager : MonoBehaviour
{
    public Slider detector;
    public TextMeshProUGUI enigmaCounter;
    PlayerInteractions player;

    [Range(0, 1)]
    public float detectorValue;
    public float enigmaValue;

    private void Start()
    {
      
    }
    private void Update()
    {
        if (player)
        {
            enigmaValue = player.enigmaValidator;
        }
        detector.value = detectorValue;
        enigmaCounter.text = enigmaValue.ToString() + "/3";
    }
}
