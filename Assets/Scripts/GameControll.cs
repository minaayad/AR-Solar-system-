using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public  class GameControll : MonoBehaviour {

    public  GameObject Panel;
	// Use this for initialization
    public  GameObject PlantOnPanelPosition;
    public GameObject PlantOnPanel;
    public GameObject talker;
    private float x, y ,z;
    public string [] plantDesctiptions;
    public Text description;

    
    

    public  void OpenPanel(GameObject plant,int i)
    {
        Panel.SetActive(true);
        talker.SetActive (true);
        Destroy(PlantOnPanel);
        PlantOnPanel = Instantiate(plant, PlantOnPanelPosition.transform.position, PlantOnPanelPosition.transform.rotation) as GameObject;
        Destroy(PlantOnPanel.GetComponent("Animator"));
        //PlantOnPanel.GetComponent<Orbit>().orbitSpeed = 0;
        Destroy(PlantOnPanel.GetComponent("Orbit"));

        PlantOnPanel.AddComponent(typeof(Orbit));
        //PlantOnPanel.AddComponent<Rotate>();
        x = PlantOnPanel.transform.localScale.x;
        y= PlantOnPanel.transform.localScale.y;
        z =PlantOnPanel.transform.localScale.z;
  
        if (i == 0)
        {
            PlantOnPanel.transform.localScale = new Vector3((x * 30) / 100, (y * 30) / 100, (z * 30) / 100);
        }
        else {
            if (i == 6)
            {
                PlantOnPanel.transform.localScale = new Vector3((x * 50) / 100, (y * 50) / 100, (z * 50) / 100);
            }
            else
            {
                PlantOnPanel.transform.localScale = new Vector3((x * 80) / 100, (y * 80) / 100, (z * 80) / 100);
            }
        }
        description.text = plantDesctiptions[i];
	}


    public  void ClosePanel()
    {
        talker.SetActive(false);
        Panel.SetActive(false);
        Destroy(PlantOnPanel);

    }
	
}
