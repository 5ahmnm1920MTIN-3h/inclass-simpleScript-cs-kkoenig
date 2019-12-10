using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    // init variables
    public InputField ipVarA;
    public InputField ipVarB;
    public Text result;

    // show result in text-box
    public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
        result.text = SubtractNumbers(a, b).ToString();
    }

    // substract numbers and return result value
    private float SubtractNumbers(float variableA, float variableB)
    {
        float result = variableA - variableB;
        return result;
    }
}