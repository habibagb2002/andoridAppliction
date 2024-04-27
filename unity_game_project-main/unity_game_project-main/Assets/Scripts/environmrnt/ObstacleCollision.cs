using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
   public GameObject thePlayer;
    public GameObject charModel;
    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<playerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
    }
}
