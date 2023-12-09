```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button uploadButton;
    public Text resultText;
    public RawImage displayImage;
    private ImageUpload imageUpload;
    private ImageClassifier imageClassifier;

    void Start()
    {
        imageUpload = GetComponent<ImageUpload>();
        imageClassifier = GetComponent<ImageClassifier>();

        uploadButton.onClick.AddListener(OnUploadButtonClicked);
        ImageClassifier.instance.resultText = resultText;
    }

    void OnUploadButtonClicked()
    {
        imageUpload.OnUploadButtonClicked();
    }

    void Update()
    {
        if (imageUpload.displayImage.texture != null)
        {
            displayImage.texture = imageUpload.displayImage.texture;
        }

        if (imageClassifier.resultText.text != null)
        {
            resultText.text = imageClassifier.resultText.text;
        }
    }
}
```
