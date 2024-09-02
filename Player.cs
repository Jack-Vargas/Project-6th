using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<ItemList> items = new List<ItemList>();

    public int health;
    public int mode;
    private SpriteRenderer spriteR;
    public Sprite SpriteGreen;
    public Sprite SpriteRed;
    public Sprite SpriteYellow;
    public Sprite SpriteBlue;
    public Behaviour PlayerAttacj;
    public Behaviour PlayerBlue;

    void Start()
    {
        StartCoroutine(CallItemUpdate());

        spriteR = gameObject.GetComponent<SpriteRenderer>();

        HealingItem item = new HealingItem(); //thesee two lines are giving the player the healing item
        items.Add(new ItemList(item, item.GiveName(), 1)); //the 1 at the end is the number of stacks
    }

    IEnumerator CallItemUpdate()
    {
        foreach (ItemList i in items)
        {
            i.item.Update(this, i.stacks); // this is a way of calling update for the items
        }
        yield return new WaitForSeconds(1); // the use of 1 here means the update is called every second instead of every frame if you want it lower change it.
        StartCoroutine(CallItemUpdate());//this bad boy loops itself BABY... but only after being called by start to start the loop
    }

    public void CallItemOnPickUp()
    {
        foreach (ItemList i in items)
        {
            i.item.PickUp(this, i.stacks);
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U) && mode != 0)
        {
            ShiftGreen();
            ShiftOutBlue();
        }
        if (Input.GetKeyDown(KeyCode.I) && mode != 1)
        {
            ShiftRed();
            ShiftOutBlue();
        }
        if (Input.GetKeyDown(KeyCode.O) && mode != 2)
        {
            ShiftYellow();
            ShiftOutBlue();
        }
        if (Input.GetKeyDown(KeyCode.P) && mode != 3)
        {
            ShiftBlue();
        }
    }

    void ShiftGreen()
    {
        mode = 0;
        spriteR.sprite = SpriteGreen;
    }
    void ShiftRed()
    {
        mode = 1;
        spriteR.sprite = SpriteRed;
    }
    void ShiftYellow()
    {
        mode = 2;
        spriteR.sprite = SpriteYellow;
    }
    void ShiftBlue()
    {
        mode = 3;
        spriteR.sprite = SpriteBlue;
        PlayerAttacj.enabled = false;
        PlayerBlue.enabled = true;
    }

    void ShiftOutBlue()
    {
        PlayerAttacj.enabled = true;
        PlayerBlue.enabled = false;
    }
}
