using UnityEngine;
using System.Collections;

public class TrackMove : MonoBehaviour {

	private readonly float speed = 0.5f;
	private Vector2 offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		offset = new Vector2 (0, -Time.time * speed);
		GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}
}
