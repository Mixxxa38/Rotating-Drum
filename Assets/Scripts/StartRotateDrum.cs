using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class StartRotateDrum : MonoBehaviour
{ 
  [SerializeField] private float _velocity = 50f;
  private HingeJoint _hingeJoint;
  private void Start()
  {
    _hingeJoint = GetComponent<HingeJoint>();
  }

  public void StartRotate()
  {
    var startMotor = _hingeJoint.motor;
    startMotor.targetVelocity = _velocity;
    _hingeJoint.motor = startMotor;
  }
}