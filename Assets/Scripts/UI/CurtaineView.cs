using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class CurtainView : MonoBehaviour
    {
        [SerializeField] private Image _fadeImage;
        [SerializeField] private float _fadeDuration = 0.5f;

        private Coroutine _currentRoutine;

        public void FadeIn(Action onComplete = null)
        {
            StartFade(1, onComplete);
        }

        public void FadeOut(Action onComplete = null)
        {
            StartFade(0, onComplete);
        }

        private void StartFade(float targetAlpha, Action onComplete)
        {
            if (_currentRoutine != null)
                StopCoroutine(_currentRoutine);

            _currentRoutine = StartCoroutine(FadeRoutine(targetAlpha, onComplete));
        }

        private IEnumerator FadeRoutine(float targetAlpha, Action onComplete)
        {
            float startAlpha = _fadeImage.color.a;
            float time = 0;

            while (time < _fadeDuration)
            {
                time += Time.deltaTime;
                float t = time / _fadeDuration;
                float alpha = Mathf.Lerp(startAlpha, targetAlpha, t);
                _fadeImage.color = new Color(0, 0, 0, alpha);
                yield return null;
            }

            _fadeImage.color = new Color(0, 0, 0, targetAlpha);
            onComplete?.Invoke();
        }
    }
}
