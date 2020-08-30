using UnityEngine;

public class PlayerControl : MonoBehaviour 
{

	public float maxHealth = 100;
	public float currHealth = 100;

	public Rigidbody2D rb;

	public float jumpForce = 7000f;
	public float speed = 5f;

	void Start() 
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update() 
	{
		if(currHealth > 0)
		{
			float moveX = Input.GetAxis("Horizontal");

			rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);

			if(Input.GetKeyDown(KeyCode.UpArrow))
			{
				rb.AddForce(Vector2.up * jumpForce);
			}

			if(currHealth > maxHealth)
			{
				currHealth = maxHealth;
			}
		}
		else
		{
			Destroy(gameObject);
		}
	}
}
