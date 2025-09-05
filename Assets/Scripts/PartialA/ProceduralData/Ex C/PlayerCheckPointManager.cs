using System.IO;
using UnityEngine;

public class PlayerCheckPointManager : MonoBehaviour
{
    public JsonPlayerCheckpoint jsonPlayerCheckpointData;

    [ContextMenu("Create CheckPoint on a JsonFile")]
    public void CreateJsonFtPlayerPos()
    {
        string jsonFtPlayerPos = JsonUtility.ToJson(jsonPlayerCheckpointData, true);

        string path = Path.Combine(Application.persistentDataPath, "Player Checkpoint");
        File.WriteAllText(path, jsonFtPlayerPos);

        Debug.Log("Checkpoint file written to: " + path);
    }

    [ContextMenu("Load last checkpoint")]
    public void LoadLastCheckpoint()
    {
        string path = Path.Combine(Application.persistentDataPath, "file");

        if (File.Exists(path))
        {
            string jsonDataFile = File.ReadAllText(path);
            jsonPlayerCheckpointData = JsonUtility.FromJson<JsonPlayerCheckpoint>(jsonDataFile);
        }
    }

}