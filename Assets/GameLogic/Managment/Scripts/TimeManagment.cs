using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManagment : MonoBehaviour
{
    [SerializeField] private Text _textTime;

    private void Update()
    {
        _textTime.text = Time.timeSinceLevelLoad.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
    }
}
