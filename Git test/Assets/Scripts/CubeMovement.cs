using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour {

	public float speed = 3.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += Vector3.up * Time.deltaTime * this.speed;
	}
}
