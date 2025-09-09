using UnityEngine;

public class SphereTrigger : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.TryGetComponent<IInterfaceSample>(out var otherGameObject))
        {
            otherGameObject.SomeTriggerFunction();
        }
    }
}
