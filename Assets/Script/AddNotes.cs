using System;
using Script;
using UnityEngine;

public class AddNotes : MonoBehaviour
{
    [SerializeField] private GameObject[] Note;
    public GameObject RewardWarning;
    public GameObject changecolor;

    private int _index = 0;

    private ChangeColor _changeColor;
 
    private void Start()
    {
        _changeColor = FindObjectOfType<ChangeColor>();
    }

    public void Add()
    {
        if (_index < 20)
        {
            Note[_index].SetActive(true);
            _index++;
        }
    }

    public void Delete()
    {
        if (_index > 0)
        {
            Note[_index].SetActive(false);
            _index--;
        }
    }

    public void SetTrueRW()
    {
        RewardWarning.SetActive(true);
    }

    public void SetFalseRW()
    {
        RewardWarning.SetActive(false);
    }

    public void SetFalse()
    {
        changecolor.SetActive(false);
    }

    public void SetTrue()
    {
        YandexAdsManager.Instance.ShowAdvertisement(success =>
        {
            if (success)
            {
                _changeColor.ChangeColorImage();
            }

            RewardWarning.SetActive(false);
        });
    }
}