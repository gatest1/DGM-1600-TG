using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour
{
    public GameObject[] players;

    /*   void Start()
       {
           players = GameObject.FindGameObjectsWithTag("Player");

           for (int i = 0; i < players.Length; i++)
           {
               Debug.Log("Player Number " + i + " is named " + players[i].name);
           }
       }
       */
    public int[] Basket = new int[8];//{5,6,7,8};
    
    void Start()
    {
      for (int i = 0; i < Basket.Length; i++)
        {
            Debug.Log("Element " + i + " is " + Basket[i]);
        }

    }
}


