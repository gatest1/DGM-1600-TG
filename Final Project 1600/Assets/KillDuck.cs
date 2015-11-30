using UnityEngine;
using System.Collections;

public class KillDuck : MonoBehaviour {

	
	void OnTriggerEnter (Collider hit)
    {
	if (hit.tag == "Killzone")
        {
            Destroy(this.gameObject);
        }
	}
}
