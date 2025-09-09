using UnityEngine;

public class LvlManager : MonoBehaviour
{
    public ClassLevels classLevels;
    public StrutLevels strutLevels;

    public ClassLevels claseDummy;
    public StrutLevels structDummy;

    
    [ContextMenu("Simulate Class")]
    public void ProccesClass()
    {
        //ClassLevels claseDummy = new ClassLevels();

        //claseDummy = new ClassLevels(); // if not public reference.
        claseDummy = classLevels;
        claseDummy.rows = 10;
        
    }


    [ContextMenu("Simulate Struct")]
    public void ProcessStruct()
    {
        structDummy.rows = 5;

        structDummy = strutLevels;
        structDummy.rows = 10;
    }
}
