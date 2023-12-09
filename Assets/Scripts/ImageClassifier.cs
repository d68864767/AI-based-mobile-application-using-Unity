```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TensorFlowLite;

public class ImageClassifier : MonoBehaviour
{
    public static ImageClassifier instance;
    public Text resultText;

    private Interpreter interpreter;
    private float[] input;
    private float[][] output;

    private const int IMAGE_SIZE = 224;
    private const int NUM_CLASSES = 5;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        var model = Resources.Load("ImageClassificationModel") as TextAsset;
        interpreter = new Interpreter(model.bytes);
        input = new float[IMAGE_SIZE * IMAGE_SIZE * 3];
        output = new float[1][];
        output[0] = new float[NUM_CLASSES];
    }

    public void Classify(Texture2D image)
    {
        var resized = TextureTools.scaled(image, IMAGE_SIZE, IMAGE_SIZE, FilterMode.Bilinear);
        var tensor = new Tensor(resized, 3);
        tensor.ToTensor(input);

        interpreter.SetInputTensorData(0, input);
        interpreter.Invoke();
        interpreter.GetOutputTensorData(0, output[0]);

        var maxIndex = 0;
        var maxConfidence = output[0][0];
        for (int i = 1; i < NUM_CLASSES; i++)
        {
            if (output[0][i] > maxConfidence)
            {
                maxConfidence = output[0][i];
                maxIndex = i;
            }
        }

        string[] labels = { "Cat", "Dog", "Car", "Tree", "Building" };
        resultText.text = labels[maxIndex];
    }

    void OnDestroy()
    {
        interpreter.Dispose();
    }
}
```
