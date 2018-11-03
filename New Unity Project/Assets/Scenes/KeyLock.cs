using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyLock : MonoBehaviour {

    //NoteToSelf: need to add a object in the inspector 
    public Gate gate;
    public Key key;


    void Start()
        
    {
        ///***gate = GetComponent<Gate>();
        
    }


    /* 
     * private void OnCollisionEnter(Collision other)
     {

         print("hey");
         Player player = other.gameObject.GetComponent<Player>();

         //key = other.GetComponent<Key>() ;



         if (player.haskey && other.gameObject.name == "Key") {


             Destroy(other.gameObject);


             player.haskey = false;




             gate.open();

         }

     }*/



    private void OnTriggerEnter(Collider other)
    {

        Player player = other.gameObject.GetComponent<Player>();

        if (player.haskey) {

            Destroy(key.gameObject);
              
            player.haskey = false;

            gate.isOpen = true;

            
              

        }

     

       




    }





}
