using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildModeManager : MonoBehaviour
{
    public GameObject BuildModeScreen;
    public bool modeUp;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && modeUp == false)
        {
            if (modeUp == true)
            {
                BuildModeScreen.SetActive(true);
                modeUp = false;
            }

            if (modeUp == false)
            {
                BuildModeScreen.SetActive(true);
                modeUp = true;
            }
        }
    }
}
