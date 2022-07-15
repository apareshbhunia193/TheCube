using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayLight : MonoBehaviour
{
    [SerializeField] float dayAndNightSpeed;
    [SerializeField] Material defaultSkyboxMat;
    [SerializeField] Material starfieldMat;
    //Quaternion startAngle, currentAngle;

    private void Start()
    {
        //startAngle = transform.rotation;
    }
    void Update()
    {
        transform.Rotate(new Vector3(dayAndNightSpeed, 0,0));
        //currentAngle = transform.rotation;
        if (transform.eulerAngles.x > 0f && transform.eulerAngles.x < 90f)
        {
            RenderSettings.skybox = defaultSkyboxMat;

        }
        else                                                            //(Quaternion.Angle(startAngle, currentAngle) < 165f)
        {
            RenderSettings.skybox = starfieldMat;
        }
    }
}
