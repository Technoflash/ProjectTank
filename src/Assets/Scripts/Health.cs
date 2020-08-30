using UnityEngine;

public class Health : MonoBehaviour 
{

	public PlayerControl player;
	
	void Update () 
	{
		float healthPercent = (player.currHealth / player.maxHealth) * 100;
		float healthLevel = healthPercent / 10;
		transform.localScale = new Vector3(healthLevel, 0.5f, 1f);

		transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 4f, transform.position.z);
	}
}
