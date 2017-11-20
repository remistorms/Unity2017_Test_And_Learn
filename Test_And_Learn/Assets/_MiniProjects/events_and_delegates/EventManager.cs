using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

	public static EventManager instance;

	#region
	public delegate void ClickAction();
	public static event ClickAction OnClicked;
	#endregion

	void Awake()
	{
		instance = this;
	}

	public void FireClickEvent()
	{
		if (OnClicked != null) 
		{
			OnClicked ();
		}
	}
}
