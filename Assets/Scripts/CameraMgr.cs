using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMgr : MonoBehaviour
{
    // Start is called before the first frame update
    public static CameraMgr inst;
    private void Awake()
    {
        inst = this;
    }
    void Start()
    {
        
    }
    public GameObject RTSCameraRig;
    public GameObject YawNode;
    public GameObject PitchNode;
    public GameObject RollNode;
    public float cameraMoveSpeed = 100;
    public float cameraTurnRate = 10;
    public Vector3 yawEulerAngle = Vector3.zero;
    public Vector3 pitchEulerAngle = Vector3.zero;
    public bool isRTSMode = true;  
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
            YawNode.transform.Translate(Vector3.forward * Time.deltaTime * cameraMoveSpeed);
        if(Input.GetKey(KeyCode.S))
            YawNode.transform.Translate(Vector3.back * Time.deltaTime * cameraMoveSpeed);
        if(Input.GetKey(KeyCode.A))
            YawNode.transform.Translate(Vector3.left * Time.deltaTime * cameraMoveSpeed);
        if(Input.GetKey(KeyCode.D))
            YawNode.transform.Translate(Vector3.right * Time.deltaTime * cameraMoveSpeed);
        if(Input.GetKey(KeyCode.R))
            YawNode.transform.Translate(Vector3.up * Time.deltaTime * cameraMoveSpeed);
        if(Input.GetKey(KeyCode.F))
            YawNode.transform.Translate(Vector3.down * Time.deltaTime * cameraMoveSpeed);
        
        yawEulerAngle = YawNode.transform.localEulerAngles;
        if(Input.GetKey(KeyCode.Q))
            yawEulerAngle.y += cameraTurnRate * Time.deltaTime;
        if(Input.GetKey(KeyCode.E))
            yawEulerAngle.y -= cameraTurnRate * Time.deltaTime;
        YawNode.transform.localEulerAngles = yawEulerAngle;        

        pitchEulerAngle = PitchNode.transform.localEulerAngles;
        if(Input.GetKey(KeyCode.Z))
            pitchEulerAngle.x += cameraTurnRate * Time.deltaTime;
        if(Input.GetKey(KeyCode.X))
            pitchEulerAngle.x -= cameraTurnRate * Time.deltaTime;
        PitchNode.transform.localEulerAngles = pitchEulerAngle;
        
        if(Input.GetKeyUp(KeyCode.C)){
            if (isRTSMode) {
                YawNode.transform.SetParent(SelectionMgr.inst.selectedEntity.cameraRig.transform);
                YawNode.transform.localPosition = Vector3.zero;
                YawNode.transform.localEulerAngles = Vector3.zero;
                
            }else {
                YawNode.transform.SetParent(RTSCameraRig.transform);
                YawNode.transform.localPosition = Vector3.zero;
                YawNode.transform.localEulerAngles = Vector3.zero;
            }
            isRTSMode = !isRTSMode;
        }
        
    }
}
