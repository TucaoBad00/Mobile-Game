using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheckEndLine : MonoBehaviour
{
    public LevelManager level;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            level.SpawNextLevel();
        }
    }
}
