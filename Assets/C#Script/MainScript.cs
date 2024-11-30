using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScientificCalculatorVRA704 : MonoBehaviour
{
    public Text displayText;
    public  float currentValue = 0;
    private string currentOperation;

    
   

    public void OnNumberButtonPressed(int number)
    {
        displayText.text += number.ToString();//this should pass all strings to a specified type n return a
                                              //value indicating whether the coversion was succesfful.
    }

    public void OnOperationButtonPressed(string operation)
    {
        if (float.TryParse(displayText.text, out currentValue))
        {
            displayText.text = "";
            currentOperation = operation;
        }
    }

    public void OnEqualsButtonPressed()
    {
        float newValue;
        if (float.TryParse(displayText.text, out newValue))
        {
            switch (currentOperation)
            {
                case "Addition":
                    currentValue += newValue;
                    break;
                case "Subtraction":
                    currentValue -= newValue;
                    break;
                case "Multiplication":
                    currentValue *= newValue;
                    break;
                case "Division":
                    currentValue /= newValue;
                    break;
                case "Modular":
                    currentValue %= newValue;
                    break;
                case "Exponent":
                    currentValue = Mathf.Pow(currentValue, newValue);//Retuen a number raised to a specied power
                    break;
                case "Square root":
                    currentValue = Mathf.Round(Mathf.Sqrt(currentValue));//Round the lowerst decimal number
                    break;
                case "Squared":
                    currentValue = Mathf.Pow(currentValue, 2);//Retun a number raised to a specied power
                                                              //and in this case rasing a number to the power 2
                    break;

            }
            displayText.text = currentValue.ToString();
            currentOperation = null;
        }
    }

    public void ClearEntry()
    {
        displayText.text = "";
        currentValue = 0;
        currentOperation = null;
    }



}


