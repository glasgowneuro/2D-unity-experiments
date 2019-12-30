using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	public float carSpeed;
	public float maxPosition = 2.4f;

	private UIManager UIM;
	private Vector3 position;
	// Use this for initialization
	void Start () {
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void Awake(){
	}

	void OnCollisionEnter2D(Collision2D coll){
		print ("collision happened");
		GameObject collidingCar = coll.gameObject as GameObject;
		if (collidingCar.GetComponent<EnemyCar> ()) {
			print ("Collided with Enemy car " + collidingCar.name);
//			UIM.GameIsOver ();
//			Destroy (gameObject);
		}
	}

}
