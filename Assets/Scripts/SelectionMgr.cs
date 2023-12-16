using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionMgr : MonoBehaviour
{   
    public static SelectionMgr inst;
    private void Awake() {
        inst = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Tab)){
            SelectNextEntity();
            if (!CameraMgr.inst.isRTSMode){
                CameraMgr.inst.YawNode.transform.SetParent(selectedEntity.cameraRig.transform);
                CameraMgr.inst.YawNode.transform.localPosition = Vector3.zero;
                CameraMgr.inst.YawNode.transform.localEulerAngles = Vector3.zero;
            }
    }
    }
    public int selectedEntityIndex = 1;
    public EntityFrigate selectedEntity;
    void SelectNextEntity()
    {   UnselectAll();
        selectedEntityIndex = (selectedEntityIndex >= EntityMgr.inst.entities.Count - 1 ? 0 : selectedEntityIndex + 1 );
        selectedEntity = EntityMgr.inst.entities[selectedEntityIndex];
        selectedEntity.isSelected = true;
    }
    void UnselectAll()
    {
        foreach(EntityFrigate ent in EntityMgr.inst.entities)
            ent.isSelected = false;
    }

}
