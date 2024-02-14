using System;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int _totalCoinsCount = 0;
    private int _currentCoinsCount = 0;

    public static Action OnAllCoinsCollected;

    private void Start()
    {
        _totalCoinsCount = FindObjectsByType(typeof(Collectible), FindObjectsSortMode.None).Length;
        _currentCoinsCount = 0;
    }

    private void OnEnable()
    {
        Collectible.OnCollected += Collectible_OnCollected;
    }

    private void OnDisable()
    {
        Collectible.OnCollected -= Collectible_OnCollected;
    }
    

    private void Collectible_OnCollected(Collectible collectible)
    {
        _currentCoinsCount++;
        if (_currentCoinsCount >= _totalCoinsCount)
        {
            OnAllCoinsCollected?.Invoke();
            Debug.Log("[CoinManager] OnAllCoinsCollected");
        }
    }
}
