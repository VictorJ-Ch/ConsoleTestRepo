using System;
using System.IO;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public Level level;

    public GameObject chemain;
    public GameObject glass;


    [ContextMenu("Create Map")]
    public void CreateJsonMap()
    {
        string map = JsonUtility.ToJson(level, true);

        string path = Path.Combine(Application.persistentDataPath, "map");
        File.WriteAllText(path, map);

        Debug.Log("Checkpoint file written to: " + path);
    }

    [ContextMenu("Load Map")]
    public void LoadMap()
    {
        string path = Path.Combine(Application.persistentDataPath, "map");

        if (File.Exists(path))
        {
            string jsonMapFile = File.ReadAllText(path);
            level = JsonUtility.FromJson<Level>(jsonMapFile);
        }

        //Ciclo for
        for (int rows = 0; rows < level.rows.Length; rows++)
        {
            for (int cols = 0; cols < level.rows[rows].cols.Length; cols++)
            {
                Debug.Log(level.rows[rows].cols[cols]);
                if (level.rows[rows].cols[cols] == 1)
                {
                    Instantiate(chemain, new Vector3(cols, 0, -rows), Quaternion.identity);
                }
                else if (level.rows[rows].cols[cols] == 0)
                {
                    Instantiate(glass, new Vector3(cols, 0, -rows), Quaternion.identity);
                }
            }
        }
    }
}