using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 5;
    void Start()
    {
        Debug.Log("j'ai spawn");
 
 
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }

}
