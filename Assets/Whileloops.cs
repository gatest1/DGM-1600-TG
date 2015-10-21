using UnityEngine;
using System.Collections;

public class Whileloops : MonoBehaviour {

	void Start () {
        int orangesinthebasket = 23;

        while(orangesinthebasket > 0)
        {
            print("Let's make some Orange Juice!");
            orangesinthebasket--;
        }
	}
}
