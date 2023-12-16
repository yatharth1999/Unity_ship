using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlMgr : MonoBehaviour
{   
    public Text Speed;
    public Text Heading;
    public Text Selected;
    public static ControlMgr inst;
    private void Awake()
    {
        inst = this;
    }
    // Start is called before the first frame update
    
    void Start()
    {
        
    }
    public float deltaSpeed = 1;
    public float deltaHeading = 2;
    // Update is called once per frame
    void Update()
    {
         
        if(Input.GetKeyUp(KeyCode.UpArrow))
            SelectionMgr.inst.selectedEntity.desiredSpeed += deltaSpeed;
        if(Input.GetKeyUp(KeyCode.DownArrow))
            SelectionMgr.inst.selectedEntity.desiredSpeed -= deltaSpeed;
        SelectionMgr.inst.selectedEntity.desiredSpeed = 
        utils.clamp(SelectionMgr.inst.selectedEntity.desiredSpeed,SelectionMgr.inst.selectedEntity.minSpeed,SelectionMgr.inst.selectedEntity.maxSpeed);  
      
      
        if(Input.GetKeyUp(KeyCode.LeftArrow))
            SelectionMgr.inst.selectedEntity.desiredHeading -= deltaHeading;
        if(Input.GetKeyUp(KeyCode.RightArrow))
            SelectionMgr.inst.selectedEntity.desiredHeading += deltaHeading;
        SelectionMgr.inst.selectedEntity.desiredHeading = utils.Degree360(SelectionMgr.inst.selectedEntity.desiredHeading);
        if(SelectionMgr.inst.selectedEntityIndex == 0)
            Selected.text = "Battleship";
        else
            Selected.text = "Frigate";
        Speed.text = "SPEED = " + SelectionMgr.inst.selectedEntity.speed.ToString()  + "  Desired SPEED = " + SelectionMgr.inst.selectedEntity.desiredSpeed.ToString();
        Heading.text = "Heading = " + SelectionMgr.inst.selectedEntity.heading.ToString() + "  Desired Heading = " + SelectionMgr.inst.selectedEntity.desiredHeading.ToString();
        
    }
}
