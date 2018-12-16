using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexagon : MonoBehaviour {

    public Rigidbody2D hexagonRigidbody;
    //public static double i = 0;
    float shrinkSpeed = 3f;
	// Use this for initialization
	void Start () {
        hexagonRigidbody.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
	}
	
	// Update is called once per frame
	void Update () {
        //i += 0.01;

        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        if (transform.localScale.x < .05f)
            Destroy(gameObject);
	}
}
