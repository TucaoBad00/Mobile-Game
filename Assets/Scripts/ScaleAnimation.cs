using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScaleAnimation : MonoBehaviour
{
    public List<animations> Animations;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.D))
            Tween();*/
    }
    
}
[System.Serializable]
public class animations
{
    public Ease ease;
    public float ScaleModifier;
    public float time;
    public float deley;
    public bool backToNormal;
    public ScaleAnimation scaleAnimation;
    
    public void Tween()
    {
        scaleAnimation.transform.DOScale(scaleAnimation.transform.localScale + new Vector3(ScaleModifier, ScaleModifier, ScaleModifier), time).SetEase(ease).SetDelay(deley);
        if (backToNormal)
            scaleAnimation.transform.DOScale(scaleAnimation.transform.localScale - new Vector3(ScaleModifier, ScaleModifier, ScaleModifier), time).SetEase(ease).SetDelay(time);

    }
}
