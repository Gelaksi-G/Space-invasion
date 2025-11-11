using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotate : MonoBehaviour
{
    private bool isPressed;
    public float RotateSpeed;
    private float Rot;
    private float Boost;
    private float Rotation;
    private int Turn;

    private void Start()
    {
        Boost = 3;
    }
    void Update()
    {
        if (isPressed)
        {
            if (Rot < 1)
            {
                Rot += Time.deltaTime * Boost;
                if (Rot >= 1)
                {
                    Rot = 1;
                }
            }
        }
        else 
        {
           if (Rot > 0)
           {
                Rot -= Time.deltaTime * Boost;
                if(Rot <= 0)
                {
                    Rot = 0;
                }
           }
        }
        Rotation = Rot * RotateSpeed;
        transform.Rotate(0, 0, Rotation * Turn * Time.deltaTime);
    }
    public void LeftTogglePressed()
    {
        isPressed = true;
        Turn = 1;
    }
    public void RightTogglePressed()
    {
        isPressed = true;
        Turn = -1;
    }
    public void ToggleNotPressed()
    {
        isPressed = false;
    }
    public void PauseOff()
    {
        Turn = 0;
    }
    public void SpeedUp()
    {
        RotateSpeed += RotateSpeed / 20;
    }
}