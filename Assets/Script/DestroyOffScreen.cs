using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffScreen : MonoBehaviour
{    void OnBecameInvisible()
    {
        Debug.Log("Destroy");
        Destroy(this.transform.parent.gameObject);
        // Destroy(gameObject);
    }
}
