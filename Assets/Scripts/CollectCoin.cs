using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public SOint CoinCount;
    public ParticleSystem ParticleSystem;
    public AudioSource coinCollected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        if (ParticleSystem != null){ ParticleSystem.transform.SetParent(null); }
        if (coinCollected != null) { coinCollected.transform.SetParent(null); }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if (ParticleSystem != null) { ParticleSystem.Play(); }
            if (coinCollected != null) { coinCollected.Play(); }
            Destroy(gameObject);
            CoinCount.Value += 1;
        }
    }
}
