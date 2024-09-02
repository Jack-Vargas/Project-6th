using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentSwapFireMan : MonoBehaviour
{

  
        void OnTriggerEnter2D(Collider2D other)
        {
            gameObject.transform.SetParent(other.transform, true); //ok so the "true" here dose some wierd stuff, true means
                                                        //it functions like katamari, false changes the child size and stuff
        }
}
