using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieArea : MonoBehaviour 
{
	public GameObject respawn;

	void OnTriggerEnter2D(Collider2D obj)
	{
		if(true) //obj.Tag == "Player"
		{
			obj.transform.position = respawn.transform.position;
		}
	}

}
