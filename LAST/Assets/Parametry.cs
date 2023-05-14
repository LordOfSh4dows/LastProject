using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parametry : MonoBehaviour
{

    public HingeJoint Stand;
    public ConfigurableJoint Linear;
    public HingeJoint Plecho;
    public HingeJoint Predplechie;

    public float Q1;
    public float Q2;
    public float Q3;
    public float Q4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring JS1 = Stand.spring;
        JS1.targetPosition = Q1;
        Stand.spring = JS1;
        Linear.targetPosition = new Vector3(0,0,Q2/27);
        JS1 = Plecho.spring;
        JS1.targetPosition = Q3;
        Plecho.spring = JS1;
        JS1 = Predplechie.spring;
        JS1.targetPosition = Q4;
        Predplechie.spring = JS1;
    }
}
