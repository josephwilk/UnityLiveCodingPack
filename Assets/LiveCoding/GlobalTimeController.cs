using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LiveCoding{
    [AddComponentMenu("LiveCoding/Global Time Controller")]
    public class GlobalTimeController : MonoBehaviour {
        private float speedRatio = 1.0f;

        public float _speedRatio {
            get { return speedRatio; }
            set { speedRatio = value; }
        }

        void Start () {}

        void Update () {
            Time.timeScale      = speedRatio;
            Time.fixedDeltaTime = speedRatio*0.02f;
        }
    }
}
