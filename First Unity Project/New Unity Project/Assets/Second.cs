using UnityEngine;
using System.Collections;

public class Second : MonoBehaviour {

	int myInt = 5;
	void Start () {
		myInt = MultiplyByTwo(myInt);
		myInt = MultiplyByTwo(myInt);
		Debug.Log (myInt);
	}
	int MultiplyByTwo(int number) {
		int ret;
		ret = number * 2;
		return ret;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
