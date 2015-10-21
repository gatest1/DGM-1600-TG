using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    void Start() {
        int numFriends = 5;
    
            for (int i = 0; i < numFriends; i++)
            {
                Debug.Log("I need more friends." + i);
            }
        }
    }
