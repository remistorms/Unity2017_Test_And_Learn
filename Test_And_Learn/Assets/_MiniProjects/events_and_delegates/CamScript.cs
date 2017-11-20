using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour {

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			Debug.Log ("Space key pressed and fire event FireClickEvent remotely from the Event Manager.... pretty cool eh");
			EventManager.instance.FireClickEvent ();
		}
	}
}
