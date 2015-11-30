using UnityEngine;
using System.Collections;

public class Enum : MonoBehaviour
{

    /*   enum Direction { North, East, South, West }; void Start()
       {
           Direction myDirection;

           myDirection = Direction.North;
       }

       Direction ReverseDirection(Direction dir)
       {
           if (dir == Direction.North)
               dir = Direction.South;
           else if (dir == Direction.South)
               dir = Direction.North;
           else if (dir == Direction.East)
               dir = Direction.West;
           else if (dir == Direction.West)
               dir = Direction.East;

           return dir;
       }
   }*/
    enum Nation { Water =1, Earth =2, Fire =3, Air =4 }; //values//
    void Start()
    {
        Nation myNation;

        myNation = Nation.Water;
        ReverseNation(myNation);
    }
    Nation ReverseNation(Nation dir)//returning from a function//
    {
        if (dir == Nation.Water)
            dir = Nation.Fire;
        else if (dir == Nation.Fire)
            dir = Nation.Water;
        else if (dir == Nation.Earth)
            dir = Nation.Air;
        else if (dir == Nation.Air)
            dir = Nation.Earth;
        Debug.Log(dir);
        return dir;
    }
}

enum Element : short {Water, Earth, Fire, Air};
void Start ()

{
    Element myElement;
    myElement = Element.Water;
    myElement = ElementChange (myElement);
}

Element ElementChange (Element Ele)
{
    Ele = Element.Fire;
    return Ele;
}