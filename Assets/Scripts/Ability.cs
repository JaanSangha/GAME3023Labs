using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewAbility", menuName ="AbilitySystem/Ability")]
public class Ability : ScriptableObject
{
    [SerializeField]
    private new string name;

    [SerializeField]
    private string description;

    [SerializeField]
    private IEffect[] effects;

    void Cast(ICharacter self, ICharacter other)
    {

    }
}
