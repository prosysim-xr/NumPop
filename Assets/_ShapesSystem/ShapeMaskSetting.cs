using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeMaskSetting : MonoBehaviour
{
    [SerializeField] GameObject materialObject;
    public Material material;
    private void OnValidate() {
       if(materialObject != null) material = materialObject.GetComponent<MeshRenderer>().sharedMaterial;
    }
}
