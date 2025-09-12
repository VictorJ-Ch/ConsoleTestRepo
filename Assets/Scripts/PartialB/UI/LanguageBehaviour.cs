using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LanguageBehaviour : MonoBehaviour
{
    public TMP_Dropdown languageSelector;
    public List<string> languageOptions;


    private void Start()
    {
        languageOptions = new List<string>();
        languageOptions.Add("Spanish");
        languageOptions.Add("English");

        languageSelector.ClearOptions();
        languageSelector.AddOptions(languageOptions);
    }
}