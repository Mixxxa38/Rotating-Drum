using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ReverseRotateDrum : MonoBehaviour
{
    private HingeJoint _hingeJoint;
    private bool spinningСlockwise = true;

    private void Start()
    {
        _hingeJoint = GetComponent<HingeJoint>();
    }

    public void ReverseRotate()
    {
        var reverseMotor = _hingeJoint.motor;
        reverseMotor.targetVelocity *= -1;
        _hingeJoint.motor = reverseMotor;
        if (spinningСlockwise)
        {
            spinningСlockwise = !spinningСlockwise;
        }
        else
        {
           spinningСlockwise = true;
        }
    }
}
