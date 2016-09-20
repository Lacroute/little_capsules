using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSurfaceBehavior : MonoBehaviour {

	private float _seed;
	private Vector3 _pos;


	void Start () {
		_seed = Random.Range (0.5f, 0.8f);
		_pos = transform.position;
	}
	

	void Update () {
		transform.position = new Vector3(_pos.x, Mathf.PerlinNoise(_seed * Time.time, _seed * Time.time) ,_pos.z);
	}
}
