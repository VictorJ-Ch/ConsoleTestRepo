using UnityEngine;

public class CylinderTrigger : MonoBehaviour, IInterfaceSample
{
    public void SomeTriggerFunction() { Debug.Log(this.gameObject.name + "Is colliding"); }
}
