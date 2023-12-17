using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sks.ARNumPop {
    public class AppConfig : MonoBehaviour {

        public static AppConfig Instance;
        void Awake() {
            if (Instance != null) {
                Destroy(gameObject);
            } else {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }
        void Start() {

        }

        void Update() {

        }
    }
}