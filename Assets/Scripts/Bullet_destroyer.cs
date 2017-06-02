using UnityEngine;
using System.Collections;

public class Bullet_destroyer : MonoBehaviour {
	float lifespan = 1.0f;
	//public int enemy_hits;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		lifespan -= Time.deltaTime;
		if(lifespan <= 0)
		{
			Explode();
		}
		
		
	}
	
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Enemy")
		{
			
			col.gameObject.GetComponent<Rigidbody>().AddForce(0, 1000, 0);
			
		}
	}
	
	void Explode()
	{
		Destroy(gameObject);
	}
}