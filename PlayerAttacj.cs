using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacj : MonoBehaviour
{

    public Player script;
    [SerializeField] Vector3 mousePos;
    public GameObject Hand;
    public GameObject SwordGraphic;

    void Start()
    {
        script = this.GetComponent<Player>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Attack();
        }
    }

    public void Attack()
    {
        switch (script.mode)
        {
                case 0:
                AtkGr();
                break;

                case 1:
                AtkRd();
                break;

                case 2:
                AtkYlw();
                break;

                case 3:
                AtkBl();
                break;
                
        }
    }

    public void AtkGr()
    {
        //Debug.Log("gr");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - Hand.transform.position;
        Hand.transform.right = -direction;
    }

    public void AtkRd()
    {
        //Debug.Log("Rd");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos + gameObject.transform.position; //if you use hands position you get 0,0,0 as it dosnt move relative to the player
        Hand.transform.right = -direction;
        //StartCoroutine(SwordAnim());

    }

    public void AtkYlw()
    {
        //Debug.Log("Ylw");
    }

    public void AtkBl()
    {
        //Debug.Log("Bl");
    }

    /*IEnumerator SwordAnim()
    {
        SwordGraphic.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        SwordGraphic.SetActive(false);
    }*/
}
