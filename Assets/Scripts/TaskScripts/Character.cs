using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Character : MonoBehaviour
{
    [SerializeField] private Renderer hairColor;
    public void ChangeHairColor()
    {
        hairColor.material.color = Color.red;
    }
}
