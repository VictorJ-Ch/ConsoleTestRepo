using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    /*
    public delegate void DelegateAttackPressed();
    public  DelegateAttackPressed onAttackPressed;
    */

    public delegate void DelegateTxtGeneratorInputPressed();
    public DelegateTxtGeneratorInputPressed txtGeneratorInputPressed;
    //public Button attackBttn;
    public Button generateTxtBttn;
    public Canvas canvasMobile;


    void Start()
    {
        //attackBttn.onClick.AddListener(()=> onAttackPressed?.Invoke());
        generateTxtBttn.onClick.AddListener(()=> txtGeneratorInputPressed?.Invoke());


#if UNITY_EDITOR_WIN
        canvasMobile.enabled = true;
#endif

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //onAttackPressed?.Invoke();
            txtGeneratorInputPressed?.Invoke();
        }
        ;
    }
}
