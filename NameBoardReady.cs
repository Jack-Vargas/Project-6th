using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameBoardReady : MonoBehaviour
{
    public GameObject NameBoard;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            NameBoard.SetActive(true);
        }
    }

    public void NameBoardClose()
    {
        NameBoard.SetActive(false);
    }
}
