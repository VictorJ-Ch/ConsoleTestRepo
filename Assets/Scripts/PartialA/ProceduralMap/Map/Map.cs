using UnityEngine;

[System.Serializable]
public struct Level
{
    public Rows[] rows;
}

[System.Serializable]
public struct Rows
{
    public int[] cols;
}
