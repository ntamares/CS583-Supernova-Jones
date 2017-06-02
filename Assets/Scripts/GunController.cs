using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

	public GameObject Bullets;
	float intervalTime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		intervalTime += Time.deltaTime; 
		if(Input.GetKey(KeyCode.V)){
			if(intervalTime >= 0.1f){
				intervalTime = 0.0f;
				Instantiate(Bullets, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			}
		}
	}
}
