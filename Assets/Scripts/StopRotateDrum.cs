using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRotateDrum : MonoBehaviour
{
    private HingeJoint _hingeJoint;
    private void Start()
    {
        _hingeJoint = GetComponent<HingeJoint>();
    }

    public void StopRotate()
    {
        var stopMotor = _hingeJoint.motor;
        stopMotor.targetVelocity = 0f;
        _hingeJoint.motor = stopMotor;
    }
}
