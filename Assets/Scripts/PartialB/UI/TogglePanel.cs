using UnityEngine;
using UnityEngine.UI;

public class TogglePanel : MonoBehaviour
{
    [SerializeField] private GameObject logInCanvas;
    [SerializeField] private GameObject userPanelCanvas;
    [SerializeField] private Button logInBttn;

    void Start()
    {
        logInBttn.onClick.AddListener(ChangePanel);
        logInCanvas.SetActive(true);
        userPanelCanvas.SetActive(false);
    }

    private void ChangePanel()
    { 
        logInCanvas.SetActive(false);
        userPanelCanvas.SetActive(true);
    }

}
