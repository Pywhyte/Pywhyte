using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public CharacterBove characterBove;
    public CharacterAnimation characterAnimation;
    public CharacterInput characterInput;
    public void Update()
    {
        characterBove.MoveUpdate();
        characterAnimation.AnimationUpdate();
        characterInput.InputUpdate();
    }
}
