using UnityEngine;
using System.Collections;

public class Third : MonoBehaviour {

	int myInt = 5;
	void Start () {
		myInt = MultiplyByFour(myInt);
		Debug.Log (myInt);
	}
	int MultiplyByFour(int number) {
		int ret;
		ret = number * 2;
			return ret;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
