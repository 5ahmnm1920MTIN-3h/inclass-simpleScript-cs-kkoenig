using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public InputField ipVarA;
    public InputField ipVarB;
    public Text result;

    float varA;
    float varB;

    // Start is called before the first frame update
    void Start()
    {
        varA = 5;
        varB = 4;
        Debug.Log("in start: " + SubtractNumbers(varA, varB));
        Debug.Log("in start: " + SubtractNumbers(4, 7));
        Debug.Log(10 - SubtractNumbers(varA, varB));
        Debug.Log(100 - SubtractNumbers(4, 7));
        SetResult();
    }

    public void TestMethod()
    {
        Debug.Log("Test");
    }
    public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
        Debug.Log("in SetResult " + (a - b));
    }

    public float SubtractNumbers(float variableA, float variableB)
    {
        float result = variableA - variableB;
       // Debug.Log("Test sub" + result.ToString());
        return result;
    }

    public float MultNumbers(float variableA, float variableB)
    {
        float result = variableA * variableB;
        // Debug.Log("Test sub" + result.ToString());
        return result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
