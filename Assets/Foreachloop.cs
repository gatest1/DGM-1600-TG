using UnityEngine;
using System.Collections;

public class Foreachloop : MonoBehaviour
{

    void Start()
    {
        string[] strings = new string[4];

        strings[0] = "How are you today?";
        strings[1] = "Doin' good.  You?";
        strings[2] = "Fantastic.";
        strings[3] = "Good.";

        foreach (string item in strings)
        {
            print(item);
        }
    }
}
