using System.IO;
using UnityEngine;

public class LanguageManager : MonoBehaviour
{
    public ClassLanguages classLanguages;

    [ContextMenu("Create Languages json")]
    private void CreateJson()
    {
        string languagesFile = JsonUtility.ToJson(classLanguages, true);

        string path = Path.Combine(Application.persistentDataPath, "languagesSettings");
        File.WriteAllText(path, languagesFile);

        Debug.Log("File written to: " + path);
    }

    [ContextMenu("Load Languages json")]
    private void LoadJson()
    {
        string path = Path.Combine(Application.persistentDataPath, "languagesSettings");

        if (File.Exists(path))
        {
            string languagesFile = File.ReadAllText(path);
            classLanguages = JsonUtility.FromJson<ClassLanguages>(languagesFile);
        }
    }
}