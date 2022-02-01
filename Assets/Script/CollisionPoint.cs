using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPoint : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D Collider)
    {
        Debug.Log("Poihnt : "+Collider.gameObject.name);
    }
}
