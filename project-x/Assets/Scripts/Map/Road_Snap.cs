using UnityEngine;

public class Road_Snap : MonoBehaviour
{
    public float Range = 5.0f;

    public void Snap()
    {
        Vector3 end_position1 = gameObject.transform.GetChild(0).position;
        Vector3 end_position2 = gameObject.transform.GetChild(1).position;


    }
}
