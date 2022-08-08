using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Spawner : MonoBehaviour
{
    public GameObject _arObject;
    public GameObject placementIndicator;
    public Pose PlacementPose;
    private bool placementPoseIsValid = false;
    public bool didHit;

    
    void Update()
    {
        if (placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            didHit = true; 
        }
        UpdatePlacementIndicator();
    }
    void UpdatePlacementIndicator() 
    {
        if (placementPoseIsValid)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(PlacementPose.position, PlacementPose.rotation);
        }

    }
}

