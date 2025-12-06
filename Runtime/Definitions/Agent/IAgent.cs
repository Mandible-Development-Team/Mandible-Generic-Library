using UnityEngine;
public interface IAgent
{
    GameObject gameObject { get; }
    Transform transform { get; }
    IInputSystem Input { get; }
    Vector3 GetLookDirection();

    void ApplyImpulse(Vector3 impulse);
    void CancelGravity();
}
