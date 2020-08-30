using UnityEngine;

public class ButtonTrigger : MonoBehaviour 
{
	public PlayerControl player;

	void OnTriggerEnter2D(Collider2D obj)
	{
		if(true) //obj.Tag == "Player"
		{
			player.currHealth -= 30f;

			Destroy(gameObject);
		}
	}

}
