using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class InputSelect : MonoBehaviour
{
    [SerializeField] PlacementObject[] placedObject; //On doit mettre les Objets de la scene dans cette list
    [SerializeField] Camera arCamera;

    private Vector2 touchPosition = default;

    private ARRaycastManager arRaycastManager;

    void Awake()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
        ChangeSelectedObject(placedObject[0]);
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = touch.position;

            if(touch.phase == TouchPhase.Began)
            {
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObject;
                if(Physics.Raycast(ray, out hitObject))
                {
                    PlacementObject placementObject = hitObject.transform.GetComponent<PlacementObject>();
                    if(placementObject != null)
                    {
                        ChangeSelectedObject(placementObject);
                    }
                }
            }
        }
    }

    void ChangeSelectedObject(PlacementObject selected)
    {
        foreach(PlacementObject current in placedObject)
        {
            if(selected != current)
            {
                current.IsSelected = false;
            }
            else
            {
                current.IsSelected = true;
            }
        }
    }
}
