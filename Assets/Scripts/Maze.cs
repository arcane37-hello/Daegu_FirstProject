using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : SwordMan
{
    // Start is called before the first frame update
    void Start()
    {
        // MoveForward();
        // MoveForward();
        Move();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Move()
    {
        base.Move();

        print("������ �߻��մϴ�.");
    }
}