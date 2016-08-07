using UnityEngine;
using System.Collections;

public class ApplePick : MonoBehaviour {
	public int value;
	private GameObject player;
	private PlayerInventory playerInventory;


	// Use this for initialization
	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerInventory = player.GetComponent<PlayerInventory> ();
		value = 1;
		//onTriggerStay ();
		//print("Cool");

	}
	
	void OnTriggerEnter (Collider other)
	{
		//print ("Cool2");
		if(other.gameObject == player)
		{
			//print ("Cool3");
			playerInventory.appleCount = playerInventory.appleCount +value;

			Destroy(gameObject);

			//print(playerInventory.appleCount);
		}
	}

}