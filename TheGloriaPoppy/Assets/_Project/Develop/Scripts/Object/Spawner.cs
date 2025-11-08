using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Project.Scripts
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private Transform spawnerPositon;
        [SerializeField] private Vector2 spawnerRange;

        [SerializeField, Range(1f, 3f)] 
        private float minTime = 3f;
        [SerializeField, Range(2f, 5f)] 
        private float maxTime = 5f;

        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private GameObject bonusPrefab;
        
        private Vector2 _randomPosition;
        
        [SerializeField] private ScoreController scoreController;
        
        private void OnEnable()
        {
            scoreController.PowerUp += LowerRespawnTime;
        }

        private void OnDisable()
        {
            scoreController.PowerUp -= LowerRespawnTime;
        }

        private void Start()
        {
            StartCoroutine(SpawnEnemyLoop());
            StartCoroutine(SpawnBonusLoop());
            
            
        }

        private void LowerRespawnTime()
        {
            if (minTime > 1)
            {
                minTime -= 0.1f;
            }
            
            if (maxTime > 2)
            {
                maxTime -= 0.1f;
            }
        }

        private void SpawnEnemy()
        {
            GenerateRandomDot();
            
            Instantiate(enemyPrefab, _randomPosition, Quaternion.identity);
        }
        
        private void SpawnBonus()
        {
            GenerateRandomDot();
            
            Instantiate(bonusPrefab, _randomPosition, Quaternion.identity);
        }

        private void GenerateRandomDot()
        {
            _randomPosition = spawnerPositon.position + new Vector3(0, Random.Range(-spawnerRange.y, spawnerRange.y));
        }
        
        private IEnumerator SpawnEnemyLoop()
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.Range(minTime, maxTime));
                SpawnEnemy();
            }
        }
        
        private IEnumerator SpawnBonusLoop()
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.Range((minTime * 3), (maxTime * 3)));
                SpawnBonus();
            }
        }
    }
}
