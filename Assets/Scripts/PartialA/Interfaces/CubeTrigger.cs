using UnityEngine;

public class CubeTrigger : MonoBehaviour, IInterfaceSample
{
    public void SomeTriggerFunction() { Debug.Log(this.gameObject.name + "Is colliding"); }
}
