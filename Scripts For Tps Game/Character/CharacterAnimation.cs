using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public Animator anim;
    public CharacterBove characterBove;
    public CharacterStatus characterStatus;
    public void AnimationUpdate()
    {

        anim.SetBool("sprint", characterStatus.isSprint);
        anim.SetBool("aiming", characterStatus.isAiming);
        if (!characterStatus.isAiming)
            AnimationNormal();
        
        else
            AnimationAiming();
    }


    void AnimationNormal()
    {
        anim.SetFloat("vertical", characterBove.moveAmount, 0.15f, Time.deltaTime);
    }
    void AnimationAiming()
    {
        float v = characterBove.vertical;
        float h = characterBove.horizontal;

        anim.SetFloat("vertical", v, 0.15f, Time.deltaTime);
        anim.SetFloat("horizontal", h, 0.15f, Time.deltaTime);
    }
}
