using UnityEngine;
using System.Collections;

public class Spells : MonoBehaviour
{

    // Main Class
    public class House
    {
        public string wallColor;
        //Sub Class
        public House()
        {
            //Defalt Constructor
            /*Instance*/
            wallColor = "blue";
        }
        //Parameter----(8)
        public House(string _color)
        {
            /*Instance*/
            wallColor = _color;
        }
    }
    public House house1 = new House();


    void Start()
    {
        House house2 = house1;
        house2.wallColor = "red";

        int num1 = 5;
        int num2 = num1;
        num2 = 30;

        //Debug.Log(mySpells9.Spell1);
        //Debug.Log(mySpells2.SpellFire);
    }
}
