using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cypherScript : MonoBehaviour
{

    InputField input;
    InputField.SubmitEvent se;
    public Text output;

    void Start()
    {
        input = gameObject.GetComponent<InputField>();
        se = new InputField.SubmitEvent();
        se.AddListener(SubmitInput);
        input.onEndEdit = se;
        input.Select();
        input.ActivateInputField();

    }

    private void SubmitInput(string arg0)
    {
        string currentText = output.text; //maybe add ToString()?
        string newText = currentText + "\n" + arg0;
        output.text = newText;
        input.text = "";
        input.ActivateInputField();
    }


}