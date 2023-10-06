using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OneSignalSDK;

public class EAOnesignalModul : MonoBehaviour
{
        private string ONESIGNAL_ID = "71b4c030-20d0-4e94-9fb0-9d4969751051";
    // Start is called before the first frame update
    void Start()
    {
        OneSignal.Default.Initialize(ONESIGNAL_ID);
    }

}
