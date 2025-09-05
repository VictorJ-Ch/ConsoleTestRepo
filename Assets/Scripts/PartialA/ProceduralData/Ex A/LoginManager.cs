using System.IO;
using UnityEngine;

public class LoginManager : MonoBehaviour
{
    public Json jsonData;

    [ContextMenu("Create a Json file")]

    public void CreateJson()
    {
        string jsonCreated = JsonUtility.ToJson(jsonData, true);

        //Debug.Log(jsonData);

        string path = Path.Combine(Application.persistentDataPath, "file"); // "file" is the name of the file you'll create
        File.WriteAllText(path, jsonCreated); // I need where i'll save it and the jsonData.

        Debug.Log("File written to: " + path);
    }

    [ContextMenu("Load data from Json")]
    public void LoadJson()
    {
        string path = Path.Combine(Application.persistentDataPath, "file");
        string jsonDataFile = File.ReadAllText(path);
        jsonData = JsonUtility.FromJson<Json>(jsonDataFile);
    }

}