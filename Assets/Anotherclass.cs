using UnityEngine;
using System.Collections;

public class Anotherclass : MonoBehaviour
{
    public int grapes;
    public int strawberries;

    private int glue;
    private int stickers;

    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }
    private void OfficeStuff(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);

    }
}
