using UnityEngine;

[CreateAssetMenu(fileName = "SpeedModifier", menuName = "ScriptableObjects/SpeedModifier", order = 1)]
public class GainScriptableObject : ScriptableObject
{
    public int enemySpeedGain;
    public int obstacleSpeedGain;
    public int enemySpeedLose;
    public int obstacleSpeedLose;
    public int baloonSpeedLose;
    public int baloonSpeedGain;
    


    private void OnEnable()
    {
        baloonSpeedGain = Random.Range(0, 50);
        baloonSpeedLose = Random.Range(0, 50);
    }
}
