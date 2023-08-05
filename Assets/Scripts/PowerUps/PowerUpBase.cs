using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpBase : MonoBehaviour
{
    public float duration;
    public GameObject player;
    public Transform PlayerController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        player = collision.gameObject;
        StartPower();
    }
    public virtual void StartPower()
    {
        Invoke(nameof(EndPower), duration);
    }
    public virtual void EndPower()
    {
        Destroy(gameObject);
    }
}
