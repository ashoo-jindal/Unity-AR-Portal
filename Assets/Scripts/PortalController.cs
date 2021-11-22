using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class PortalController : MonoBehaviour
	{

		//public Material[] materials;
		//public MeshRenderer meshRenderer;
		//public UnityARVideo UnityARVideo;

		//private bool isInside = false;
		//private bool isOutside = true;

	// Use this for initialization
	void Start()
	{
		//isInside = false;
		//isOutside = true;
		OutsidePortal();
	}

	void OnTriggerStay(Collider col)
		{

		//if (col.name != "Main Camera")
		//	return;

		if (col.gameObject.tag == "MyTrigger")
        {
			//isOutside = false;
			//isInside = true;
			InsidePortal();
		}
		else
        {
			//isInside = false;
			//isOutside = true;
			OutsidePortal();
		}


		//Vector3 playerPos = Camera.main.transform.position +
  //                          Camera.main.transform.forward * (Camera.main.nearClipPlane);
  //      if (transform.InverseTransformPoint(playerPos).z <= 0)
  //      {
  //          if (isOutside)
		//		{
		//			isOutside = false;
		//			isInside = true;
		//			InsidePortal();
		//		}
  //      }
  //      else
  //      {
  //          if (isInside)
		//		{
		//			isInside = false;
		//			isOutside = true;
		//			OutsidePortal();
		//		}
  //      }
    }


	void InsidePortal()
		{
			GameObject[] walls = GameObject.FindGameObjectsWithTag("walls");
			foreach (GameObject wall in walls)
			{
				wall.layer = LayerMask.NameToLayer("Default");
			}
		}

		void OutsidePortal()
		{
			GameObject[] walls = GameObject.FindGameObjectsWithTag("walls");
			foreach (GameObject wall in walls)
			{
				wall.layer = LayerMask.NameToLayer("InsidePortal");
			}
		}

	}



