using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundCamera : MonoBehaviour
{

    private RawImage Image;
    private WebCamTexture cam;
    private AspectRatioFitter ar;
    private float f;

    // Use this for initialization
    void Start()
    {
        ar = GetComponent<AspectRatioFitter>();
        Image = GetComponent<RawImage>();
        for (int i = 0; i < WebCamTexture.devices.Length;i++)
        {
            if(!WebCamTexture.devices[i].isFrontFacing)
                cam = new WebCamTexture(WebCamTexture.devices[i].name,Screen.width,Screen.height);

            break;
        }
        cam.Play();
        Image.texture = cam;

    }

    // Update is called once per frame
    void Update()
    {/*
        if (cam.width < 100)
        {
            return;
        }
        f = cam.videoRotationAngle;
        if (cam.videoVerticallyMirrored)
        {
            f += 180f;
        }
        Image.rectTransform.localEulerAngles = new Vector3(0f, 0f, f);

        f = (float)cam.width / (float)cam.height;
        ar.aspectRatio = f;

        if (cam.videoVerticallyMirrored)
        {
            Image.uvRect = new Rect(1,0,-1,1);
        }
        else
        {
            Image.uvRect = new Rect(1, 0, 1, 1);

        }*/
        if (cam.width < 100) {
            float ratio = (float)cam.width / (float)cam.height;
            ar.aspectRatio = ratio;

            float sclay = cam.videoVerticallyMirrored ? -1.0f : 1.0f;
            Image.rectTransform.localScale = new Vector3(1f, sclay, 1);

            int orient = -cam.videoRotationAngle;
            Image.rectTransform.localEulerAngles = new Vector3(0,0,orient);
        }

    }
}
