using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject pipePrefab;
    public static GameManager instance;
    
    void Awake()
    {
        if(instance == null){
            instance = this;
        }else if(instance != this){
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spawnPipes");
    }

    private IEnumerator spawnPipes(){
        new WaitForSeconds(1.5f);
        while(true){
            float ypos = Random.Range(1,5);
            Instantiate(pipePrefab, new Vector3(4.5f, ypos, -1), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
