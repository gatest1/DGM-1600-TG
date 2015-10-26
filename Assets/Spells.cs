using UnityEngine;
using System.Collections;

public class Spells : MonoBehaviour
{

    // Use this for initialization
    public class Spells9
    {
        public int Spell1;

        public Spells9()
        {
            Spell1 = 5;
        }
        public Spells9(int expeliamus)
        {
            Spell1 = expeliamus;
        }
    }
    public Spells9 mySpells9 = new Spells9(8);

    void Start()
    {
        Debug.Log(mySpells9.Spell1);
    }
}
