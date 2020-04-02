using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthChanger : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private float _hp;
    [SerializeField] private float _duration;

    private IEnumerator _healthCoroutine;

    public void ChangeHealth()
    {
        _healthCoroutine = ChangeHealth(_healthBar.value, _healthBar.value + _hp, _duration);
        StartCoroutine(_healthCoroutine);
    }

    private IEnumerator ChangeHealth(float startValue, float endValue, float duration)
    {
        float elapsedTime = 0;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;

            _healthBar.value = Mathf.Lerp(startValue, endValue, elapsedTime / duration);
            yield return null;
        }
    }

    
}
