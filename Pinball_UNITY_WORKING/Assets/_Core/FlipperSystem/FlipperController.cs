using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlipperSystem
{
    public class FlipperController : MonoBehaviour
    {
        [SerializeField] public float flipperForce = 1000f;
        [SerializeField] public KeyCode inputName;
        [SerializeField] public HingeJoint2D hinge;
        [SerializeField] public RightOrLeft rightOrLeft;

        void Update()
        {
            if (rightOrLeft == RightOrLeft.Right)
            {
                if (Input.GetKeyDown(inputName))
                {
                    JointMotor2D motor = hinge.motor;
                    motor.motorSpeed = flipperForce;
                    hinge.motor = motor;
                }
                else if (Input.GetKeyUp(inputName))
                {
                    JointMotor2D motor = hinge.motor;
                    motor.motorSpeed = -flipperForce;
                    hinge.motor = motor;
                }
            }
            else if (rightOrLeft == RightOrLeft.Left)
            {
                if (Input.GetKeyDown(inputName))
                {
                    JointMotor2D motor = hinge.motor;
                    motor.motorSpeed = -flipperForce;
                    hinge.motor = motor;
                }
                else if (Input.GetKeyUp(inputName))
                {
                    JointMotor2D motor = hinge.motor;
                    motor.motorSpeed = flipperForce;
                    hinge.motor = motor;
                }
            }
        }
    }
}
