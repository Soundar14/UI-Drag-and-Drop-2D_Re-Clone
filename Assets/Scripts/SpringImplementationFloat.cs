using UnityEngine;

public class SpringImplementationFloat : MonoBehaviour
{
    SpringUtils.tDampedSpringMotionParams springParams;


    public float frequency = 15f;
    public float dampingRatio = 0.5f;

    public float targetPos;
    public float currentPos;
    float vel;

    private void Awake()
    {
        springParams = new SpringUtils.tDampedSpringMotionParams();
    }
    private void Update()
    {
        SpringUtils.CalcDampedSpringMotionParams(ref springParams, Time.deltaTime, frequency, dampingRatio);
        SpringUtils.UpdateDampedSpringMotion(ref currentPos, ref vel, targetPos, in springParams);
        transform.position = new Vector3(currentPos,transform.position.y, 0);
    }
}