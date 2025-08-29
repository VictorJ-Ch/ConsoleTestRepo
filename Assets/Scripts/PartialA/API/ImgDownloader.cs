using UnityEngine;
using UnityEngine.UI;


public class ImgDownloader : MonoBehaviour
{
    public QueryManager queryManager;

    public Button downloadImgBttn;
    public RawImage rawImage;
    public Texture2D newImgTex;

    void OnEnable()
    {
        queryManager.queryComplete += OnQueryComplete;
    }

    void OnDisable()
    {
        queryManager.queryComplete -= OnQueryComplete;
    }

    void Start()
    {
        downloadImgBttn.onClick.AddListener(() => queryManager.Get()); //POO.Encapsulacion
    }

    private void OnQueryComplete(byte[] result)
    {
        Debug.Log("C'est fini");

        //newImgTex.LoadImage(result);

        Texture2D texture2D = new Texture2D(1, 1);
        texture2D.LoadImage(result);
        rawImage.texture = texture2D;
    }
}
