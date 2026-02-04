using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverComponent : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverMenu;
    [SerializeField] private float _delay = 3f;

    public void GameOver()
    {
        _gameOverMenu.SetActive(true);
    }

}
