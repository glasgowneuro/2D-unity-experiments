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
        float y = Input.GetAxis("Vertical") * carSpeed;
        print(y);
        transform.Translate (new Vector2 (x, (speed+y) * Time.deltaTime));
	}
}
