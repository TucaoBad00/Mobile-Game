using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectable : MonoBehaviour
{
    public ParticleSystem particle;
    public float timeToHide;
    public GameObject graphicItem;
    public ScaleAnimation scaleAnimation;
    [Header("Sounds")]
    public AudioSource audioSource;
    
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Player"))
        {
            Collect();
        }
    }
    protected virtual void Collect()
    {
        if (graphicItem != null) graphicItem.SetActive(false);
        Invoke("HideObject", timeToHide);
        OnCollect();

    }
    private void OnCollect()
    {
        if (particle != null) particle.Play();
        if (audioSource != null) audioSource.Play();
        scaleAnimation.Animations[1].Tween();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
