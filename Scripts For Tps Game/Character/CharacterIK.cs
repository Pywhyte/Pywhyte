using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterIK : MonoBehaviour
{

    public Animator anim;
    public CharacterBove characterBove;
    public CharacterInventory characterInventory;
    public CharacterStatus characterStatus;
    public Transform targetLook;

    public Transform l_Hand;
    public Transform l_hand_Target;
    public Transform r_hand;

    public Quaternion lh_rot;

    public float rh_Weight;

    public Transform shoulder;
    public Transform aimPivot;


    
    void Start()
    {
        shoulder = anim.GetBoneTransform(HumanBodyBones.RightShoulder).transform;

        aimPivot = new GameObject().transform;
        aimPivot.name = "aim pivot";
        aimPivot.transform.parent = transform;

        r_hand = new GameObject().transform;
        r_hand.name = "right hand";
        r_hand.transform.parent = aimPivot;

        l_Hand = new GameObject().transform;
        l_Hand.name = "left hand";
        l_Hand.transform.parent = aimPivot;

        r_hand.localPosition = characterInventory.firstWeapon.rHandPos;
        Quaternion rotRight = Quaternion.Euler(characterInventory.firstWeapon.rHandRot.x, characterInventory.firstWeapon.rHandRot.y, characterInventory.firstWeapon.rHandRot.z);
        
        r_hand.localRotation = rotRight;
       

    }
    
    
    void Update()
    {
        lh_rot = l_hand_Target.rotation;
        l_Hand.position = l_hand_Target.position;
        if (characterStatus.isAiming)
            rh_Weight += Time.deltaTime * 3;
        else rh_Weight -= Time.deltaTime * 3;
        rh_Weight = Mathf.Clamp(rh_Weight, 0, 1);
        
    }
    private void OnAnimatorIK(int layerIndex)
    {
        aimPivot.position = shoulder.position;
        if(characterStatus.isAiming)

        {
            aimPivot.LookAt(targetLook); 
            anim.SetLookAtWeight(1, .3f, 1);
            anim.SetLookAtPosition(targetLook.position);

            anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
            anim.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
            anim.SetIKPosition(AvatarIKGoal.LeftHand, l_Hand.position);
            anim.SetIKRotation(AvatarIKGoal.LeftHand, lh_rot);

            anim.SetIKPositionWeight(AvatarIKGoal.RightHand, rh_Weight);
            anim.SetIKRotationWeight(AvatarIKGoal.RightHand, rh_Weight);
            anim.SetIKPosition(AvatarIKGoal.RightHand, r_hand.position);
            anim.SetIKRotation(AvatarIKGoal.RightHand, r_hand.rotation);
        }
        else
        {
            anim.SetLookAtWeight(.3f, .3f, .3f);
            anim.SetLookAtPosition(targetLook.position);

            anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
            anim.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
            anim.SetIKPosition(AvatarIKGoal.LeftHand, l_Hand.position);
            anim.SetIKRotation(AvatarIKGoal.LeftHand, lh_rot);

            anim.SetIKPositionWeight(AvatarIKGoal.RightHand, rh_Weight);
            anim.SetIKRotationWeight(AvatarIKGoal.RightHand, rh_Weight);
            anim.SetIKPosition(AvatarIKGoal.RightHand, r_hand.position);
            anim.SetIKRotation(AvatarIKGoal.RightHand, r_hand.rotation);
        }

    }
}
 