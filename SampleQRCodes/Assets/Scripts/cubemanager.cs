using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemanager : MonoBehaviour
{
    public Microsoft.MixedReality.QR.QRCode qrCode;
    public GameObject source; 
    public GameObject target; 
    private long newTimeStamp;
    //private TextMesh oldTimeStamp;
    private long lastTimeStamp = 0;
    // Start is called before the first frame update
    void Start()
    {
        newTimeStamp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        source = GameObject.Find("QRVitual");
        target = GameObject.Find("QRInfo");
        // if (lastTimeStamp == 0) lastTimeStamp = qrCode.SystemRelativeLastDetectedTime.Ticks;
        // newTimeStamp = lastTimeStamp = qrCode.SystemRelativeLastDetectedTime.Ticks;

        // if (newTimeStamp - lastTimeStamp > 1) {
        //     // do your reset
        //     source.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        // }

        source.transform.position = target.transform.position;
        source.transform.rotation = target.transform.rotation;
    }
}
