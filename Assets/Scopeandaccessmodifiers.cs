using UnityEngine;
using System.Collections;

public class Scopeandaccessmodifiers : MonoBehaviour
{
     public int first = 10;

    private int second = 0;
    private int third = 10;

    private Anotherclass myOtherClass;

    void Start()
    {
        first = 58;

        myOtherClass = new Anotherclass();
        myOtherClass.FruitMachine(first, myOtherClass.grapes);
        Debug.Log("First is set to: " + first);
    }
    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * first;
        Debug.Log(answer);
    }
    void Update()
    {
  //      Debug.Log("First is set to: " + first);
    }
}
