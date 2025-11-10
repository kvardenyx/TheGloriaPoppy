using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Project.Scripts
{
    public class Spawner : MonoBehaviour
    {
        public GameConfig config;
        
        [SerializeField] private Transform spawnerPositon;
        [SerializeField] private Vector2 spawnerRange;
        
        private float _minInterval;
        private float _maxInterval;

        private float _speed;

        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private GameObject bonusPrefab;
        
        private Vector2 _randomPosition;
        
        [SerializeField] private ScoreController scoreController;
        
        private void OnEnable()
        {
            scoreController.LevelUp += LowerRespawnTime;
            scoreController.LevelUp += SpeedUp;
        }

        private void OnDisable()
        {
            scoreController.LevelUp -= LowerRespawnTime;
            scoreController.LevelUp -= SpeedUp;
        }

        private void Start()
        {
            _minInterval = config.lowerEnemySpawnInterval;
            _maxInterval = config.upperEnemySpawnInterval;

            _speed = config.baseEnemySpeed;
            
            StartCoroutine(SpawnEnemyLoop());
            StartCoroutine(SpawnBonusLoop());
        }

        private void LowerRespawnTime()
        {
            if (_minInterval > config.minEnemySpawnInterval)
            {
                _minInterval -= config.reducingSpawnTime;
                _maxInterval -= config.reducingSpawnTime;
            }
        }

        private void SpawnEnemy()
        {
            GenerateRandomDot();
            
            GameObject enemy = Instantiate(enemyPrefab, _randomPosition, Quaternion.identity);
            ObjectMovment movement = enemy.GetComponent<ObjectMovment>();
            if (movement)
            {
                movement.speed = _speed;
            }
        }
        
        private void SpawnBonus()
        {
            GenerateRandomDot();
            
            GameObject bonus = Instantiate(bonusPrefab, _randomPosition, Quaternion.identity);
            ObjectMovment movement = bonus.GetComponent<ObjectMovment>();
            if (movement)
            {
                movement.speed = _speed - 1f;
            }
        }

        private void SpeedUp()
        {
            if (_speed < config.maxEnemySpeed)
            {
                _speed += config.increaseEnemySpeed;
            }
        }

        private void GenerateRandomDot()
        {
            _randomPosition = spawnerPositon.position + new Vector3(0, Random.Range(-spawnerRange.y, spawnerRange.y));
        }
        
        private IEnumerator SpawnEnemyLoop()
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.Range(_minInterval, _maxInterval));
                SpawnEnemy();
            }
        }
        
        private IEnumerator SpawnBonusLoop()
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.Range((_minInterval * config.bonusSpawnInterval), (_maxInterval * config.bonusSpawnInterval)));
                SpawnBonus();
            }
        }
    }
}
