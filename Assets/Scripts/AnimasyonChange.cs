using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasyonChange : MonoBehaviour
{
    public Animator animator;
    public AnimationClip sapkaliKosmaAnimasyonu;
    public AnimationClip sapkaliZiplamaAnimasyonu;
    public AnimationClip sapkaliKosmaAnimasyon;
    public AnimationClip sapkaliZiplamaAnimasyon;

    private AnimatorOverrideController overrideController;

    void Start()
    {
        overrideController = new AnimatorOverrideController(animator.runtimeAnimatorController);
        animator.runtimeAnimatorController = overrideController;

        // Þapkalý animasyonlarý atayýn
        overrideController["Player_Fall"] = sapkaliKosmaAnimasyonu;
        overrideController["Player_jump"] = sapkaliZiplamaAnimasyonu;
    }
}
