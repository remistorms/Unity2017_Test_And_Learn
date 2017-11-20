using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour {

	public static ManagerScript instance { get; private set;}
	public static int counter { get; private set;}

	// Use this for initialization
	void Start () 
	{
		instance = this;	
	}
	
	public void IncrementCounter()
	{
		counter++;
		UIScript.instance.UpdatePointsText ();
	}

	public void RestartGame()
	{
		PlayGamesScript.AddScoreToLeaderboard (GPGSIds.leaderboard_leaderboard, counter);
		counter = 0;
		UIScript.instance.UpdatePointsText ();
	}
}
