using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


//Hold down space bar to move cube along Z axis

public class CubeMoveSmooth : MonoBehaviour
{
    public GameObject cube;
    public float yDistance = 1f;


    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            cube.transform.position += new Vector3(0f, yDistance, 0f);
        }
    }
}
