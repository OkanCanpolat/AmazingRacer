using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour
{
	//A reference to the game manager
	public GameManager gameManager; 

	// Triggers when the player enters the water
	void OnTriggerEnter(Collider other)
	{
		// Moves the player to the spawn point

		if(other.gameObject.tag == "Player") 
		{ 
		gameManager.PositionPlayer();
		}
	}
}
