using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shapes;
using UnityEngine.Rendering;

public class ShapeSettingsUpdate : MonoBehaviour
{
    //take parent object and find its sibling and store its children into a list 
    //then loop through the list and set the shape settings to the parent object
    [SerializeField] ShapeRenderer shapeRenderer;
    public int renderQueueTest;
    public int refTest;
    public Transform[] siblingsTest;
    [ContextMenu(nameof(UpdateShapeSettings))]
    public void UpdateShapeSettings() {
        Transform parentTransform = transform.parent.parent;
        // Get an array of all children of the parent
        Transform[] siblingsAndSelf = parentTransform.GetComponentsInChildren<Transform>(true);
        // Filter out the children, leaving only the siblings
        Transform[] siblings = System.Array.FindAll(siblingsAndSelf, t => t.parent == parentTransform && t != transform);
        siblingsTest = siblings;


        foreach (Transform sibling in siblings) {
            ShapeMaskSetting shapeMaskSetting = sibling.GetComponent<ShapeMaskSetting>();
            if (shapeMaskSetting != null) { renderQueueTest = shapeMaskSetting.material.renderQueue; }
            if (shapeMaskSetting != null) { var someFLoat = shapeMaskSetting.material.GetFloat("_StencilRef"); }
        }
    }



}
