using UnityEngine;
using System.Collections;

public class SpawnDuck : MonoBehaviour {
    public GameObject Duck;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void CreateDuck()
    {
        Debug.Log("spawn duck");
        Instantiate(Duck, transform.position, Quaternion.identity);
	}
}
