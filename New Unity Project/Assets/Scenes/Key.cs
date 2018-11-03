using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {



    void OnTriggerEnter(Collider other)
    {

        Player player = other.GetComponent<Player>();

        if (player != null)
        {
            player.haskey = true;
            this.transform.parent = player.gameObject.transform;
        }        

    }


}
