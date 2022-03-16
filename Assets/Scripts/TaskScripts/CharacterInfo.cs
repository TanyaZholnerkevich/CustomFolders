using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterInfo : ScriptableObject
{
    [SerializeField] private List<GameObject> males;
    [SerializeField] private List<GameObject> females;
    [SerializeField] private string gender;
    public string Gender
    {
        set
        {
            gender = value;
        }
    }
    
    public GameObject GetRandomCharacter()
    {
       GameObject character = null;
        if (gender == "Male")
        {
          character = males[Random.Range(0, males.Count)];
        }

        else if (gender == "Female")
        {
            character = females[Random.Range(0, females.Count)];
        }
        return character;
    }
}
