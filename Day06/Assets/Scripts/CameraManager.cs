using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {
    public static Camera MainC;
    public static Camera SubC;

    // Use this for initialization
    private void Awake()
    {
      
    }
    void  Start () {
       
        
	}
	private static  void MainCameraOn()
    {
        Camera[] came = Camera.allCameras;
        MainC = came[0];
        SubC = came[1];

        MainC.enabled = true;
        SubC.enabled = false;
    }
    private static void SubCameraOn()
    {
        Camera[] came = Camera.allCameras;
        MainC = came[0];
        SubC = came[1];

        MainC.enabled = false;
        SubC.enabled = true;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
