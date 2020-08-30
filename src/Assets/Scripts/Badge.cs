using UnityEngine;

public class Badge : MonoBehaviour {

	public PlayerControl player;

	void OnTriggerEnter2D(Collider2D obj)
	{
		if(true) //obj.Tag == "Player"
		{
			player.currHealth += 50f;

			if(player.currHealth > player.maxHealth)
			{
				player.currHealth = player.maxHealth;
			}

			Destroy(gameObject);
		}
	}
}
