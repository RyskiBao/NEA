using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NOT DONE(Changes quality and resolution of the game)

public class ResolutionController : MonoBehaviour
{
    public void SetQuality()
    {
        changeQuality();
        SetScreenRes();
    }
    void changeQuality()
    {
        string level = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        switch (level)
        {
            case "LOW":
                QualitySettings.SetQualityLevel(0);
                break;
            case "NORMAL":
                QualitySettings.SetQualityLevel(1);
                break;
            case "HIGH":
                QualitySettings.SetQualityLevel(2);
                break;
        }
    }
    void SetScreenRes()
    {
        string index = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        switch (index)
        {
            case "1152 x 648":
                Screen.SetResolution(1152, 648, true);
                break;
            case "1280 x 720":
                Screen.SetResolution(1280, 720, true);
                break;
            case "1360 x 764":
                Screen.SetResolution(1360, 764, true);
                break;
            case "1920 x 1080":
                Screen.SetResolution(1920, 1080, true);
                break;
        }
    }
}
