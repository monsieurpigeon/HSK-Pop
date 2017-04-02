using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleEmitterController : MonoBehaviour {

	private float time = 0.0f;
	private float scale = 0.0f;
	private float periode;

	public GameObject bubble;
	public GameObject level;
	public float periodeMax;
	public float window;

	// Use this for initialization
	void Start () {
		periode = periodeMax;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		gameObject.transform.position = new Vector3(window * Mathf.Sin (Time.time), gameObject.transform.position.y, gameObject.transform.position.z);
		if (time > periode) {
			if (
			scale = Random.Range (0.5f, 1.2f);
			bubble.transform.localScale = new Vector3 (scale, scale, scale);
			Instantiate (bubble, gameObject.transform.position, gameObject.transform.rotation);
			periode = Random.Range (0.5f, periodeMax);
			time = 0;
		}
	}
}
