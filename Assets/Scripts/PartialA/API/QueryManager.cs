using System.Collections;
using UnityEngine;
using UnityEngine.Networking;


public class QueryManager : MonoBehaviour
{
    public delegate void OnQueryComplete(byte[] result); // MVC.DelegarEventos
    public OnQueryComplete queryComplete;

    public string endPoint;



    public void Get()
    {
        StartCoroutine(RutineGet(endPoint));
    }

    IEnumerator RutineGet(string url)
    {
        WWWForm form = new WWWForm();
        UnityWebRequest webRequest = UnityWebRequest.Get(url);
        yield return webRequest.SendWebRequest();

        Debug.Log(webRequest.result); // TESTING A

        if (webRequest.result.Equals(UnityWebRequest.Result.Success))
        {
            Debug.Log(webRequest.downloadHandler.data); // TESTING B

            queryComplete?.Invoke(webRequest.downloadHandler.data);
        }
        else
        {

        }
    }
}
