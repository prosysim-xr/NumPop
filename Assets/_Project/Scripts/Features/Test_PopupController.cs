using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test_PopupController : MonoBehaviour
{
    PopupController popupController;
    // Start is called before the first frame update
    void Start()
    {
        popupController = PopupController.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        bool sPressed = InputSystem.GetDevice<Keyboard>().sKey.wasPressedThisFrame;
        if(sPressed) {
            TestShowPopup();
        }
        bool hPressed = InputSystem.GetDevice<Keyboard>().hKey.wasPressedThisFrame;
        if(hPressed) {
            TestHidePopup();
        }
    }

    public void TestShowPopup() {
        popupController.ShowPopup("No Host Cannot connect.No host Cannot connect");
    }
    public void TestHidePopup() {
        popupController.HidePopup();
    }
}
