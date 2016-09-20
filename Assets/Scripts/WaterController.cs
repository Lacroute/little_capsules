using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour {


	public GameObject P_WaterSurface;
	public int WorldPadding;

	private List<GameObject> _WaterSurfaces;


	void Start () {
		Vector3 refer = GameObject.Find("C_Terrain").GetComponent<Renderer>().bounds.center;
		int width = (int) Mathf.Abs (refer.x) * 2 + WorldPadding;
		int height = (int) Mathf.Abs (refer.z) * 2 + WorldPadding;

		_WaterSurfaces = new List<GameObject> ();

		for (int i = - width / 2 ; i < WorldPadding; i++) {
			for(int k = - height / 2; k < WorldPadding; k++){
				_WaterSurfaces.Add (Instantiate (
					P_WaterSurface,
					new Vector3(i, 0, k),
					Quaternion.identity,
					transform
				));
			}

		}
	}
	

	void Update () {

	}
}
