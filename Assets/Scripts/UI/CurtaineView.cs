using System;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace UI
{
    public class CurtainView : MonoBehaviour
    {
        [SerializeField] private Image _fadeImage;
        [SerializeField] private float _fadeDuration = 0.5f;

        private Tween _currentTween;

        public void FadeIn(Action onComplete = null)
        {
            StartFade(1f, onComplete);
        }

        public void FadeOut(Action onComplete = null)
        {
            StartFade(0f, onComplete);
        }

        private void StartFade(float targetAlpha, Action onComplete)
        {
            _currentTween?.Kill();

            _currentTween = _fadeImage.DOFade(targetAlpha, _fadeDuration)
                .SetEase(Ease.Linear)
                .OnComplete(() => onComplete?.Invoke());
        }
    }
}
