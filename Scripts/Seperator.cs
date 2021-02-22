﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seperator : Kinematic
{
    Separation myMoveType;
    LookWhereGoing myRotateType;

    public Kinematic[] targets;

    // Start is called before the first frame update
    void Start()
    {


        myMoveType = new Separation();
        myRotateType = new LookWhereGoing();

        myMoveType.character = this;
        myRotateType.character = this;

        myMoveType.targets = targets;
        myRotateType.target = myTarget;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;
        base.Update();
    }
}
