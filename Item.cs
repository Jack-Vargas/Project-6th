using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Item //LOOK AT THIS it makes this its own thing instead of "deriving from monobehavior"
{
    public abstract string GiveName();// abstract and virtual are similar but i do not know the difference
    public virtual void Update(Player player, int stacks) // the word virtual here makes this a method that can be used elsewhere like a template
    {

    }

    public virtual void PickUp(Player player, int stacks)
    {

    }

}
//we have two classes in one script
public class HealingItem : Item //this is deriving from the above class
{

    public override string GiveName()// im not sure why but theres an error up in the class name if you dont have an overide thing here
    {
        return "HealingItem";
    }

    public override void Update(Player player, int stacks)
    {
        player.health += 3 + (1 * stacks);
    }
}

public class DemonEgg : Item
{
    GameObject baby;
    public override string GiveName()
    {
        return "Egg";
    }

    public override void PickUp(Player player, int stacks)
    {
        if (baby == null) baby = (GameObject)Resources.Load("DemonBabyCute", typeof(GameObject));
        GameObject healingArea = GameObject.Instantiate(baby, player.transform.position, Quaternion.Euler(Vector3.zero));
    }
}
