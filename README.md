# AI-based Image Classification Mobile Application

This project is an AI-based mobile application developed using Unity. The application classifies a given image into one of the five classes: Cats, Dogs, Cars, Trees, and Buildings. The application is production-ready and can be uploaded to the Android store.

## Features

- Allows users to upload an image.
- Classifies the uploaded image into one of the five classes.
- User-friendly UI/UX.
- Handles errors or exceptions gracefully.
- Optimized for performance and minimal footprint on device memory and battery life.

## How to Use

1. Open the application.
2. Click on the upload button to upload an image.
3. The application will classify the image and display the result.

## Scripts

- `ImageUpload.cs`: Handles the image upload functionality. It allows users to upload an image from their device.
- `ImageClassifier.cs`: Contains the image classification model. It classifies the uploaded image into one of the five classes.
- `UIController.cs`: Manages the UI of the application. It updates the UI based on the user's actions and the results of the image classification.
- `ErrorHandling.cs`: Handles any errors or exceptions that occur during the operation of the application.
- `PerformanceOptimization.cs`: Optimizes the performance of the application. It checks the memory usage and battery level of the device and adjusts the operation of the application accordingly.

## Model

The image classification model is trained on a diverse dataset that includes various examples of Cats, Dogs, Cars, Trees, and Buildings. The model has a classification accuracy of at least 95% on the test dataset.

## Requirements

- Unity 2019.4.0f1 or later
- Android SDK

## Building and Running

To build and run the application, follow these steps:

1. Open the project in Unity.
2. Go to File > Build Settings.
3. Select Android and click on the Switch Platform button.
4. Click on the Build button to build the application.
5. Install the APK file on your Android device to run the application.

## License

This project is licensed under the MIT License - see the LICENSE file for details.
