using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class mouvement : MonoBehaviour
{

    [Range(1,10)]
    public int speed = 4;
    public void OnJump(){
        Debug.Log("Jump");
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }
}
