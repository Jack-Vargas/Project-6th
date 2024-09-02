using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;
    public Items itemDrop;

    // Start is called before the first frame update
    void Start()
    {
        item = AssignItem(itemDrop);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player player = collision.GetComponent<Player>();
            AddItem(player);
            player.CallItemOnPickUp();
            Destroy(this.gameObject);
        }
    }

    public void AddItem(Player player)
    {
        foreach(ItemList i in player.items)
        {
            if (i.name == item.GiveName())
            {
                i.stacks += 1;
                return;
            }
        }
        player.items.Add(new ItemList(item, item.GiveName(), 1));
    }

    public Item AssignItem(Items itemToAssign)
    {
        switch (itemToAssign)
        {
            case Items.HealingItem:
                return new HealingItem();
            case Items.DemonEgg: 
                return new DemonEgg();
            
            default: return null;
        }
    }
}

public enum Items // an enum is essentialy an array. here it sets Healingitem to 0 and demon egg to 1
{
    HealingItem,//put in a comma to seperate each one
    DemonEgg // dont need a comma for the last one
}
