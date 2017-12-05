using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoCamera : MonoBehaviour {

    private Gyroscope gyro;
    private bool gyrosupported;
    private Quaternion newcamera;
    bool ok = false;

    [SerializeField]
    private Transform world;
    private float starty = 0f;
    private float startx = 0f;

	// Use this for initialization
	void Start () {
        gyrosupported = SystemInfo.supportsGyroscope;

        GameObject camperant = new GameObject("camperant");
        camperant.transform.position = transform.position;
        transform.parent = camperant.transform ;
        if (gyrosupported)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            camperant.transform.rotation = Quaternion.Euler(90f, 180f, 0f);
            newcamera = new Quaternion(0, 0, 1, 0);
        }
	}
	
	// Update is called once per frame
	void Update () {

        transform.localRotation = gyro.attitude * newcamera;

        if (!ok) {
            restgerorotation();
        }

		//Quaternion rotFix = new Quaternion (Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
		
	}

    public void restgerorotation()
    {
        starty = transform.eulerAngles.y;
        startx = transform.eulerAngles.x;

        world.rotation = Quaternion.Euler(startx, starty, 0f);
       // world.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
      //  world.transform.position = transform.position + transform.forward * 4f;
    }

    public void Ok() {
        ok = true;

    }
}
