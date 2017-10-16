using UnityEngine;
using System.Collections;

public class demo3 : MonoBehaviour {

	public GameObject origin;
	// Use this for initialization
	void Start () {
		//1
//		GameObject obj = new GameObject ();
//		obj.name="zzz";
//		obj.transform.position = Vector3.zero;

		//2
//		GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Sphere);
//		cube.name="MyCube";
//		cube.transform.position = new Vector3 (1, 1, 1);
//		cube.SetActive (false);

	
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 o= origin.GetComponent<Transform> ().position;
		this.transform.RotateAround (o, Vector3.up, 1);


	}
}
