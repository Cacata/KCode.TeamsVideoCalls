# Microsoft Teams Video Calls UI for .NET MAUI: Android

Original Post: ....

Even with the market being blooding by the lack of options The Azure team has designed this new library as a solution. This required a platform-specific implementation, but today we will just focus on Android.

The Azure Communication UI Mobile Library gives you plug-and-play UI components for building B2C and B2B calling experiences fast—no need to start from scratch. Now let's start the coding...

## Prerequisites

Based on Contributors Documentation take this requirements as must:

- Create an Azure account and make a subscription active:
- Don't forget to Download Android Studio and run a test project.
- Create and add the Azure Communication Resource into your previous Azure account created.
- Don't forget to get your service Token for authentication.
- Remember having setup your Visual Studio Or Visual Code.
- Download GitBash at your end or have installed anything that could run .sh files.
- And finally, download this repo at your end.

After having done all preparation points, let's start with the implementation.

## Getting Start

1- Open the repo downloaded call: CommunicationCallingSampleMauiApp with your file explorer/finder.

2- Now, create your own .NET MAUI project. In my case, I created one based on .NET 9 just for Android.

![image](https://github.com/user-attachments/assets/c9bdf4f6-92bf-4409-93b5-a652be476693)

3- From the repo project downloaded, find this folder AndroidMauiBindings and copy the files from the image into your solution folder:

![image](https://github.com/user-attachments/assets/ac9a4ef5-bae1-439d-b149-c2d6c6ffe659)

4- Run the script file with your Gitbash (Windows) console or your preference editor, like this:

![image](https://github.com/user-attachments/assets/b7113c59-1ebe-459f-b4b1-321dc6ea24bf)

```
///First command
chmod +x downloadJarScript.sh
///Second command
./downloadJarScript.sh
```

5- Import the android bindings previously copied under your solution:

![image](https://github.com/user-attachments/assets/140809f4-ac7d-4edd-97c7-2023fab9214c)

![image](https://github.com/user-attachments/assets/e941424a-b117-4096-8f38-1784cfb4ba6c)

![image](https://github.com/user-attachments/assets/c57afaa8-33c5-4f1b-8e3d-4b7ce07ad11e)

This binding are very important and their Jars libreries too. If you can get it correctly from the repo, try it from the original source.

6- After that, add the resources folder require for bindings to get the necessary assets to drawing the Video Call UI:

![image](https://github.com/user-attachments/assets/cd68456c-0456-40d6-a75f-bae0433bee19)

![image](https://github.com/user-attachments/assets/a73dbd06-b108-4f32-bfeb-694171507dea)

7- Now go to your Android Manifest file and make sure it looks like this:

```
<?xml version="1.0" encoding="utf-8"?>
<manifest xmlns:android="http://schemas.android.com/apk/res/android" xmlns:tools="http://schemas.android.com/tools">
  <application
    android:allowBackup="true"
    tools:replace="android:label"
    android:icon="@mipmap/appicon"
    android:roundIcon="@mipmap/appicon_round"
    android:supportsRtl="true"
    android:enableOnBackInvokedCallback="true"/>
  <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
    <uses-permission android:name="android.permission.INTERNET" />
</manifest>
```

8- Now is time to compile your project and everything should be good.

![image](https://github.com/user-attachments/assets/6c4d5125-1916-45fb-b0d9-ab1451ddb6e8)

9- I submitted a repo with this working, and you can find the missed pieces in there.

10- Considered to add in your Azure Portal the necessary resources to make this work. For this one we will need an Azure Communication Service. First create the resource and finally, generate the token.
