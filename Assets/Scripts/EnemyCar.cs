using UnityEngine;
using System.Collections;

public class EnemyCar : MonoBehaviour {

    private Vector3 position;
    private readonly float carSpeed = -3;
    private readonly float speed = 1f;

	// Use this for initialization
	void Start () {
    }

    // Update is called once per frame
    void Update () {
        float x = Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        transform.Translate (new Vector2 (x, speed * Time.deltaTime));
	}
}
