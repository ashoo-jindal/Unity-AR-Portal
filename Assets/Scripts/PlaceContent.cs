using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceContent : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public GraphicRaycaster raycaster;



    private void Update()
    {

        if(Input.GetMouseButtonDown(0) && !IsClickOverUI())
        {
            List<ARRaycastHit> hitpoints = new List<ARRaycastHit>();
            raycastManager.Raycast(Input.mousePosition, hitpoints, TrackableType.Planes);

            if (hitpoints.Count  > 0)
            {
                Pose pose = hitpoints[0].pose;
                transform.rotation = pose.rotation;
                transform.position = pose.position;

                //Vector3 currAngle = transform.eulerAngles;
                //transform.LookAt(Camera.main.transform);
                //transform.eulerAngles = new Vector3(currAngle.x, transform.eulerAngles.y, currAngle.z);
            }
        }

    }

    bool IsClickOverUI()
    {
        PointerEventData data = new PointerEventData(EventSystem.current)
        {
            position = Input.mousePosition 
        };
        List<RaycastResult> results = new List<RaycastResult>();
        raycaster.Raycast(data, results);
        return results.Count > 0;
    }


}
