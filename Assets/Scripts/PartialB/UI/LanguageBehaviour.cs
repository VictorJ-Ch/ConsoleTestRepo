using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LanguageBehaviour : MonoBehaviour
{
    public TMP_Dropdown languageSelector;
    public ClassLanguages classLanguages;

#if UNITY_EDITOR
    private void OnValidate()
    {
        languageSelector.ClearOptions();

        List<string> options = new List<string>();
        for (int i = 0; i < classLanguages.languages.Length; i++)
        {
            options.Add(classLanguages.languages[i]);
        }

        languageSelector.AddOptions(options);
    }
#endif

    private void Start()
    {
    }
}