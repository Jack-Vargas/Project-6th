using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestinEnum : MonoBehaviour
{

    private enum Direction { north, east, south, west } // an enum  is essentialy an array, here north represents a value
                                                    // east 2, south 3, and west 4, you can for example change south to be
                                                   // 12 by saying south = 12 and i believe this will also bump west up to 13
    void Start()
    {
        Direction facing = Direction.north; // heres an example of allpying a direction
    }
}
