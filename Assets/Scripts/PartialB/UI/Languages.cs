using System;
using UnityEngine;

[Serializable]
public class ClassLanguages
{
    public string[] languages;
    public LanguagesKeys[] languagesKeys;
}

[Serializable]
public class LanguagesKeys
{
    public string keys;
    public string[] languageValue;
}