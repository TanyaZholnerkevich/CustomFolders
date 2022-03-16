using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectButton : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Text textLabel;

    public void Setup(string id, Action callback)
    {
        textLabel.text = id;
        button.onClick.AddListener(delegate
        {
            callback?.Invoke();
        });
    }
    
    public void Setup(string id, Action<string> callback)
    {
        textLabel.text = id;
        button.onClick.AddListener(delegate
        {
            callback?.Invoke(id);
        });
    }
}
