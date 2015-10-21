using UnityEngine;
using System.Collections;

public class Dowhileloops : MonoBehaviour {

	// Use this for initialization
	void Start () {
        bool shouldcontinue = false;

        do
        {
            print("Good Morning!");
        } while (shouldcontinue == true);
	}
}
