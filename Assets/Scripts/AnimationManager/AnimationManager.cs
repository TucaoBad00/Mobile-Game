using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator animator;
    public List<AnimatorSetup> animatorSetups;
    public enum AnimationTypes
    {
        IDLE,
        RUN,
        DEAD
    }
    public void Play(AnimationTypes types)
    {
        foreach(var animation in animatorSetups)
        {
            if(animation.types == types)
            {
                animator.SetTrigger(animation.triggers);
                break;
            }
        }
    }
}

[System.Serializable]
public class AnimatorSetup
{
    public AnimationManager.AnimationTypes types;
    public string triggers;
}
