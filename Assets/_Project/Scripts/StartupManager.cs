using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
namespace sks.ARNumPop {
    public class StartupManager : MonoBehaviour {
        public bool isOfflineMode = false;
        public bool isDebugMode = false;
        public bool isServerMode = false;
        public bool autoLoadScene = false;
        public MultiplayerManager multiplayerManager;
        void Start() {
            multiplayerManager = GetComponent<MultiplayerManager>();
            if(null == multiplayerManager) {
                this.enabled = false;
            }
            PlayerPrefs.SetInt(KeyStrings.AutoLoadScene, autoLoadScene ? 1 : 0);
            PlayerPrefs.SetInt(KeyStrings.ServerMode, isServerMode ? 1 : 0);
        }

        void Update() {

        }

        bool MultiplayerOfflineMode = false;
        public void StartConnection() {
            if (isOfflineMode) { MultiplayerOfflineMode = true; }
            else { multiplayerManager.Connect(); }
        }
    }
}

