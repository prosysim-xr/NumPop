using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace sks.ARNumPop {
    public class MultiplayerManager : MonoBehaviour {
        // Start is called before the first frame update
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }


        bool multiplayerIsConnected = false;
        /// <summary>
        /// Start the Connection Process
        /// If not connected yet connect this application instance to Mulitplayer Framewoerk Cloud Network
        /// </summary>
        public void Connect() {
            if (multiplayerIsConnected) {
                Debug.LogWarning("MultiplayerManager: Connect() called but already connected.");
            } else {
                SetMultiplayerSettings();
                MultiplayerConnectUsingSettings();
            }
        }

        private void MultiplayerConnectUsingSettings() {
            throw new NotImplementedException();
        }

        private void SetMultiplayerSettings() {
            throw new NotImplementedException();
        }

        public void OnConnnectedToMaster() {
            //This will be called when a client leaves a room
            //Leaving a room causes the client to disconnect and reconnect 
            SceneManager.LoadScene("Main",LoadSceneMode.Single);

        }

        public void OnDisCOnnected() {
            SceneManager.LoadScene("DisconnectedScene");
        }
    }
}
