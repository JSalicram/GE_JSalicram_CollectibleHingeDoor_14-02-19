using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelItemTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D otherColliderInCollision)
    {
        //Debug.Log("Someone entered the trigger of " + this.name);

        LevelManager.instance.OnLevelItemTriggerEnter(otherColliderInCollision, this);

    }

    /*
    void OnTriggerExit2D(Collider2D otherColliderInCollision)
    {
        //Debug.Log("Someone left the trigger of " + this.name);

        LevelManager.instance.OnLevelItemTriggerExit(otherColliderInCollision, this);
    }
    */
}
