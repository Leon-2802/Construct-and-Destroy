using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerManagement : MonoBehaviour
{
    public List<Transform> targetsEast = new List<Transform>();
    public List<Transform> targetsWest = new List<Transform>();
    public void removeTransformWest(Transform target)
    {
        targetsWest.Remove(target);
    }
    public void removeTransformEast(Transform target)
    {
        targetsEast.Remove(target);
    }
}
