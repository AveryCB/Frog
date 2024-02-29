using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public interface IGameManager
{
    ManagerStatus status { get; }

    void Startup();
}

public enum ManagerStatus
{
    Shutdown,
    Initializing,
    Started
}
