using System.ComponentModel.Design.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainPlayer : MonoBehaviour
{
    public InputHandler inputHandler;
    public TextMeshProUGUI randomTxt;

    void OnEnable()
    {
        //inputHandler.onAttackPressed += OnKeyAttackPressed;
        inputHandler.txtGeneratorInputPressed += OnKeyTxtGeneratorPressed;
    }

    void OnDisable()
    {
        //inputHandler.onAttackPressed -= OnKeyAttackPressed;
        inputHandler.txtGeneratorInputPressed -= OnKeyTxtGeneratorPressed;
    }

    //private void OnKeyAttackPressed() { Debug.Log("Attacking"); }

    private void OnKeyTxtGeneratorPressed()
    {
        Debug.Log("Funciona?");
        randomTxt.text = "Azucar";
    }
}
