using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPipe : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Collider)
    {

            Debug.Log("pipe : " + Collider.gameObject.name);
    }


}
