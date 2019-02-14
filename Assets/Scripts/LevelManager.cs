using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public static LevelManager instance;
    public DoorController theDoor;

    private int counter;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        counter = 0;
    }

    public void activateDoor()
    {
        if(counter >= 3)
        {
            Debug.Log("Door Activated");
        }
    }

    public void OnLevelItemTriggerEnter(Collider2D otherColliderInCollision, LevelItemTrigger itemInCollision)
    {
        counter++;
        Destroy(itemInCollision.gameObject);
    }

    /*public void OnLevelItemTriggerExit(Collider2D other, LevelItemTrigger item)
    {

    }*/
}
