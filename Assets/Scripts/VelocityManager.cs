using UnityEngine;

public class VelocityManager : MonoBehaviour
{
    [SerializeField]
    private float maxVelo;

    [SerializeField]
    private float veloIncreases;

    [SerializeField]
    private float veloDecreases;

    [SerializeField]
    private float veloGravity;

    [SerializeField]
    private float rotationStrength;

    private float currentVelo = 0;

    // Update is called once per frame
    void Update()
    {
        if (currentVelo > maxVelo)
        {
            currentVelo = maxVelo;
        }
        else if (currentVelo < -(maxVelo/2))
        {
            currentVelo = -(maxVelo / 2);
        }

        if (Input.GetKey(KeyCode.W))
        {
            currentVelo += veloIncreases;
        }
        else if(currentVelo>0)
        {
            currentVelo -= veloGravity;
        }

        if(Input.GetKey(KeyCode.S))
        {
            currentVelo -= veloDecreases;
        }
        else if (currentVelo<0)
        {
            currentVelo += veloGravity;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down*rotationStrength);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotationStrength);
        }

        transform.Translate(Vector3.forward * currentVelo);
    }
}
