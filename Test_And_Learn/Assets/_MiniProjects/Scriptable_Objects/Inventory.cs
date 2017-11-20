using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public static Inventory instance;

	public List<Item> items = new List<Item>();

	void Awake()
	{
		instance = this;
	}

	public void AddItem(Item itemToAdd)
	{
		items.Add (itemToAdd);
	}

	public void RemoveItem(Item itemToRemove)
	{
		items.Remove (itemToRemove);
	}
}
