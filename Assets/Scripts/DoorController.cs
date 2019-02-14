using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

    private HingeJoint2D hingeJoint;

    private void Start()
    {
        hingeJoint = this.gameObject.GetComponent<HingeJoint2D>();
    }

    public void openDoor()
    {
        Debug.Log("open door");
        //hingeJoint.motor.motorSpeed = -40;
    }

    public void closeDoor()
    {
        Debug.Log("close door");
    }
}
