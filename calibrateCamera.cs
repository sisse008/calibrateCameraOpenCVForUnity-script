using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * 
 * 
 * Trying to use function calibrateCamera in OpenCVForUnity with docs: https://enoxsoftware.github.io/OpenCVForUnity/3.0.0/doc/html/class_open_c_v_for_unity_1_1_calib3d_module_1_1_calib3d.html#ace50158f878665d9addf4caeceab4b6f
 * 
 * 
 * */
public class calibrateCamera : MonoBehaviour
{

    public Vector3[] screenPositions;
    public Vector3[] handPositions;


    public List<OpenCVForUnity.CoreModule.Mat> Arrayof3DVectorstoListofMat(Vector3[] arrayOf3DVectors)
    {

        List<OpenCVForUnity.CoreModule.Mat> matList = new List<OpenCVForUnity.CoreModule.Mat>();

        foreach (Vector3 _vec in arrayOf3DVectors)
        {
            float[] _screenPosArray = { _vec.x, _vec.y, _vec.z };
            OpenCVForUnity.CoreModule.Mat _screenMat = new OpenCVForUnity.CoreModule.Mat(1, 3, OpenCVForUnity.CoreModule.CvType.CV_64F);
            _screenMat.put(1, 3, _screenPosArray);

            matList.Add(_screenMat);
        }

        return matList;
    }
    // Start is called before the first frame update
    void Start()
    {

        //List< Mat > 	objectPoints
        List<OpenCVForUnity.CoreModule.Mat> screenMatList = Arrayof3DVectorstoListofMat(screenPositions);

        //List<Mat> imagePoints
        List<OpenCVForUnity.CoreModule.Mat> handMatList = Arrayof3DVectorstoListofMat(handPositions);

        //TODO: Size imageSize
        OpenCVForUnity.CoreModule.Size imageSize = new OpenCVForUnity.CoreModule.Size(Screen.width, Screen.height);

        //TODO: Mat cameraMatrix
        OpenCVForUnity.CoreModule.Mat cameraMatrix = new OpenCVForUnity.CoreModule.Mat(3, 3, OpenCVForUnity.CoreModule.CvType.CV_64F);

        //TODO: Mat distCoeffs

        //TODO: List<Mat> rvecs




        OpenCVForUnity.Calib3dModule.Calib3d.calibrateCamera();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
