using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newww : test1
{
    public override string state
    {
        get { return _state; }
        set { _state = value; }
    }
    public override void Initialize()
    {
        _state = "xxx";
    }
}
