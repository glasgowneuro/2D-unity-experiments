using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	public float speed;
	public float maxPosition = 2.4f;

	private UIManager UIM;
	private Vector2 position;
	private Rigidbody2D rb2D;
	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();
		UIM = GameObject.FindObjectOfType<UIManager> ();
		position = new Vector2 (transform.position.x, transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {
		position.x = transform.position.x;
		position.x = Mathf.Clamp (position.x, -maxPosition, maxPosition);
		transform.position = new Vector2 (position.x, position.y);
	}

	public void MoveLeft(){
		rb2D.velocity = new Vector2 (-speed, 0);
	}
	public void MoveRight(){
		rb2D.velocity = new Vector2 (speed, 0);
	}
	public void SetVelocityZero(){
		rb2D.velocity = Vector2.zero;
	}

	void Awake(){
	}

	void OnCollisionEnter2D(Collision2D coll){
		print ("collision happened");
		GameObject collidingCar = coll.gameObject as GameObject;
		if (collidingCar.GetComponent<EnemyCar> ()) {
			print ("Collided with Enemy car " + collidingCar.name);
			UIM.GameIsOver ();
			Destroy (gameObject);
		}
	}

}
