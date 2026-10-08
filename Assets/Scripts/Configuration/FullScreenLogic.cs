using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FullScreenLogic : MonoBehaviour
{

    public Toggle toggle;
    public TMP_Dropdown resolucionDropdown;
    Resolution[] resolutionver;
    // Start is called before the first frame update
    void Start()
    {
        if(Screen.fullScreen){
            toggle.isOn=true;
        }else{
            toggle.isOn=false;
        }

        checkResolution();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateFullScreen(bool screenOnOff){
        Screen.fullScreen=screenOnOff;
    }

    public void checkResolution(){
        resolutionver = Screen.resolutions;
        resolucionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int actualResolution =0;
        for(int i =0; i< resolutionver.Length;i++){
            string optionString = resolutionver[i].width +" x " + resolutionver[i].height;
            options.Add(optionString);
            if(Screen.fullScreen && resolutionver[i].width== Screen.currentResolution.width && resolutionver[i].height ==Screen.currentResolution.height){
                actualResolution =1;
            }
        }
        resolucionDropdown.AddOptions(options);
        resolucionDropdown.value = actualResolution;
        resolucionDropdown.RefreshShownValue();

        resolucionDropdown.value =PlayerPrefs.GetInt("numeroResulucion", 0);
    }

    public void ChangeResolution(int indexResolution){
        PlayerPrefs.SetInt("numeroResulucion", resolucionDropdown.value);
        Resolution resolutionfuction =resolutionver[indexResolution];
        Screen.SetResolution(resolutionfuction.width,resolutionfuction.height,Screen.fullScreen);
    }
}
