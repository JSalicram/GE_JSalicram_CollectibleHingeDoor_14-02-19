using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public static LevelManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void activateDoor()
    {
        Debug.Log("Door Activated");
    }

    public void OnLevelItemTriggerEnter(Collider2D otherColliderInCollision, LevelItemTrigger itemInCollision)
    {

    }

    public void OnLevelItemTriggerExit(Collider2D other, LevelItemTrigger item)
    {

    }
}
