```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorHandling : MonoBehaviour
{
    public Text errorText;

    void Start()
    {
        ImageClassifier.instance.errorText = errorText;
    }

    public void DisplayError(string errorMessage)
    {
        errorText.text = errorMessage;
    }

    public void ClearError()
    {
        errorText.text = "";
    }

    void Update()
    {
        if (ImageClassifier.instance.errorText.text != null)
        {
            errorText.text = ImageClassifier.instance.errorText.text;
        }
    }
}
```
