using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAvoidier : Kinematic
{
    CollisionAvoide myMoveType;
    public Kinematic[] targets = new Kinematic[4];


    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new CollisionAvoide();
        myMoveType.character = this;
        myMoveType.targets = targets;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = myMoveType.getSteering();
        base.Update();
    }
}
