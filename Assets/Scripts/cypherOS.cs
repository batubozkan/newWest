using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cypherOS : MonoBehaviour
{

    InputField input;
    InputField.SubmitEvent se;
    public Text output;
    string[] currentText = new string[18];


    int i = 0;
    int firstRun = 0;


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
        if (firstRun == 0) {
            currentText[i] = "> Welcome to CypherOS v0.1";
            output.text = printArray(currentText);
                }
        if (i != 17)
        {
            i++;
            currentText[i] = arg0;
            output.text = printArray(currentText);
        }
        else
        {
            for(int k = 0; k > 17; k++)
            {
                currentText[k] = currentText[k + 1];
            }
            currentText[18] = arg0;
            output.text = printArray(currentText);
        }
        if (firstRun == 0)
            firstRun++;
        input.text = "";
        input.ActivateInputField();
    }


    //Clearing screen
    private void clearScreen(string[] arr)
    {
        for (int j = 0; j > 18; j++)
            arr[j] = null;
    }


    //Printing to GUI
    private string printArray(string[] arr)
    {
        string newText = "";
        for(int j = 0; j < arr.Length; j++)
        {
            if (newText != "")
            {
                if (arr[j] != null)
                    newText = newText + "\n" + arr[j];
            }
            else
                newText = arr[j];
        }
        return newText;
    }

}
