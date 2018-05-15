using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LiveCoding{
    [AddComponentMenu("LiveCoding/Camera Editor")]
    public class CameraEditor : MonoBehaviour {

        Camera[] cameras;
        Camera liveCamera;

	    void Start () {
            cameras = Camera.allCameras;
            liveCamera = Camera.main;

            for (int i = 0; i < cameras.Length; i++) {
                Camera cam = cameras [i];
                cam.targetDisplay = 0;
                cam.enabled = false;
            }
            liveCamera.enabled = true;
	    }
	
        public void CameraChange(int newCamId){
            if (newCamId < cameras.Length && newCamId >= 0) {
                Camera newCam = cameras [newCamId];
                if (newCam.enabled == false) {
                    newCam.enabled = true;
                    liveCamera.enabled = false;
                    liveCamera = newCam; 
                }
            }
        }

        void Update () {}
    }
}
