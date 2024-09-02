using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandoMove : MonoBehaviour
{
    public float randoNum;
    public float MinVariability;

    public float RangeMax;
    public float RangeMin;


    private void Start()
    {
        StartCoroutine(RandoShifter());
    }


    public IEnumerator RandoShifter()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            randoNum = (Random.Range(RangeMin, RangeMax)); // ok so apearently if you put in the range as 2,2 it will always be an int if you want a float put in 2f,2f

            if (randoNum !> gameObject.transform.position.x + MinVariability || randoNum !< gameObject.transform.position.x - MinVariability)
            {
                if (randoNum! > gameObject.transform.position.x + MinVariability)
                {
                    randoNum += 3;
                }
                else
                {
                    randoNum -= 3;
                }
            }

            if (randoNum > RangeMax || randoNum < RangeMin)
            {
                randoNum = 0;
            }


            gameObject.transform.position = new Vector3(randoNum, transform.position.y, -1f);
        }
    }
}
