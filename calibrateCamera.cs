using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calibrateCamera : MonoBehaviour
{

    public Vector3[] screenPositions;
    public Vector3[] handPositions;
    // Start is called before the first frame update
    void Start()
    {

        //List< Mat > 	objectPoints
        List<OpenCVForUnity.CoreModule.Mat> screenMatList = new List<OpenCVForUnity.CoreModule.Mat>();

        foreach (Vector3 _screenPos in screenPositions)
        {
            float[] _screenPosArray = {_screenPos.x, _screenPos.y, _screenPos.z };
            OpenCVForUnity.CoreModule.Mat _screenMat = new OpenCVForUnity.CoreModule.Mat(1,3, OpenCVForUnity.CoreModule.CvType.CV_64F);
            _screenMat.put(1,3,_screenPosArray);

            screenMatList.Add(_screenMat);
        }

        OpenCVForUnity.Calib3dModule.Calib3d.calibrateCamera();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
