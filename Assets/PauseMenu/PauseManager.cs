using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private GameObject _imagePlay;
    [SerializeField] private GameObject _imagePause;

    private bool _isPause = false;

    public void PauseGame()
    {
        if (!_isPause)
        {
            Time.timeScale = 0f;
            _imagePlay.SetActive(false);
            _imagePause.SetActive(true);

            _isPause = true;
        }
        else if (_isPause)
        {
            Time.timeScale = 1f;
            _imagePlay.SetActive(true);
            _imagePause.SetActive(false);

            _isPause = false;
        }
    }
}
