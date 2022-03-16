using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class CharacterPlayer : MonoBehaviour
{
    [SerializeField] private Text textLabelFemale;
    [SerializeField] private Text textLabelMale;
    [SerializeField] private GameObject panel;
    private List<GameObject> characters = new List<GameObject>();

    private CharacterInfo config;

    void Start()
    {
        config = Resources.Load<CharacterInfo>("CharacterInfo");
        panel.SetActive(false);
    }
    public void SetFemale()
    {
        config.Gender = textLabelFemale.text;
        ShowCharacter();
        panel.SetActive(true);
    }
    public void SetMale()
    {
        config.Gender = textLabelMale.text;
        ShowCharacter();
        panel.SetActive(true);
    }
    
    private void ShowCharacter()
    {
        if (characters.Count > 0)
        {
            Destroy(characters[0]);
            characters.RemoveAt(0);
        }
        var character = Instantiate(config.GetRandomCharacter(), Vector3.forward, Quaternion.identity);
        characters.Add(character);
    }
}
