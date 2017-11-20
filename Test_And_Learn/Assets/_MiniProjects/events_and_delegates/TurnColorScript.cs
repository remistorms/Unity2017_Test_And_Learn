using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorScript : MonoBehaviour {

	void OnEnable()
	{
		EventManager.OnClicked += RandomColor;
	}

	void OnDisable()
	{
		EventManager.OnClicked -= RandomColor;
	}

	public void RandomColor()
	{
		Debug.Log ("Random Color method inside " + this.gameObject.name + " has been called");
		Color random_color = new Color (Random.value, Random.value, Random.value);
		GetComponent<MeshRenderer> ().material.color = random_color;
	}


}
