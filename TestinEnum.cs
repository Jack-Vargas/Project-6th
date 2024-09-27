using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestinEnum : MonoBehaviour
{

    private enum cardinalDirection { north, east, south, west } // an enum  is essentialy an array, here north represents a value
                                                    // east 2, south 3, and west 4, you can for example change south to be
                                                   // 12 by saying south = 12 and i believe this will also bump west up to 13
    void Start()
    {
        var facing = cardinalDirections.north // now i you want to apply a value from the options in the enum you use facing
                                                                  // var is just a variable that automaticlay changs to the needed type
                                                                  //if you want to see a proper use check wizard mode "spell ready"
        
    }
}
