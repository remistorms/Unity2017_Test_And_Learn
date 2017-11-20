using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour {

	public static UIScript instance { get; private set;}

	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	[SerializeField]
	private TextMeshProUGUI pointsTxt;

	public void GetPoint()
	{
		ManagerScript.instance.IncrementCounter ();
	}

	public void Restart()
	{
		ManagerScript.instance.RestartGame ();
	}

	public void Increment()
	{
		PlayGamesScript.IncrementAchievement (GPGSIds.achievement_incremental_achievement, 5);	
	}

	public void Unlock()
	{
		PlayGamesScript.UnlockAchievement (GPGSIds.achievement_test_achievement_01);
	}

	public void ShowAchievements()
	{
		PlayGamesScript.ShowAchievementsUI ();
	}

	public void ShowLeaderboards()
	{
		PlayGamesScript.ShowLeaderboardUI ();
	}

	public void UpdatePointsText()
	{
		pointsTxt.text = "score : " + ManagerScript.counter.ToString ();
	}
}
