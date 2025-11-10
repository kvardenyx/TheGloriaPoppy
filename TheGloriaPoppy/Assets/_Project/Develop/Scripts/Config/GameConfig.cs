using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Configs/Game Config")]
public class GameConfig : ScriptableObject
{
    [Header("Player Settings")]
    [Tooltip("Начальная скорость движения игрока")]
    public float basePlayerSpeed = 60f;
    [Tooltip("Максимальная скорость движения игрока")]
    public float maxPlayerSpeed = 180f;
    
    [Tooltip("Начальное здоровье игрока")]
    public int playerHealth = 2;

    [Header("Enemy Settings")]
    [Tooltip("Максимальное время спавна для врагов")]
    public float upperEnemySpawnInterval = 4f;
    [Tooltip("Минимальное время спавна для врагов")]
    public float lowerEnemySpawnInterval = 3f;
    [Tooltip("Остановка уменьшения времени спавна")]
    public float minEnemySpawnInterval = 0.5f;
    
    [Tooltip("Начальная скорость движения врагов")]
    public float baseEnemySpeed = 2.5f;
    [Tooltip("Максимальная скорость движения врагов")]
    public float maxEnemySpeed = 4f;

    [Header("Bonus Settings")]
    [Tooltip("Множитель появления бонуса")]
    public float bonusSpawnInterval = 10f;
    [Tooltip("Скорость вращения бонуса")]
    public float bonusRotateSpeed = 100f;

    [Header("Camera Settings")]
    [Tooltip("Параметр размера камеры")]
    public float cameraSize = 5f;
    
    [Tooltip("Базовое соотношение сторон")]
    public float baseAspectRatio = 9f/16f;
    [Tooltip("Соотношение сторон")]
    public float currentAspectRatio = 9f/16f;
    
    [Header("Level Settings")]
    [Tooltip("Кратность очков для усложнения")]
    public int bonusLevelUp = 5;
    
    [Tooltip("Увеличение скорости игрока")]
    public float increasePlayerSpeed = 5f;
    
    [Tooltip("Увеличение скорости врагов")]
    public float increaseEnemySpeed = 0.1f;
    [Tooltip("Уменьшение времени спавна")]
    public float reducingSpawnTime = 0.1f;
    
}