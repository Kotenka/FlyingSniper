using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //это выстрел?
        ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
        if (shot != null)
        {

            //уничтожить выстрел
            Destroy(shot.gameObject);

        }
    }
   
}
