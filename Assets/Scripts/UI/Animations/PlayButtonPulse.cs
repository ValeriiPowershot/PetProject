using UnityEngine;
using DG.Tweening;

namespace UI.Animations
{
    public class PlayButtonPulse : MonoBehaviour
    {
        [SerializeField] private float pulseScale = 1.05f;
        [SerializeField] private float pulseDuration = 0.8f;
        [SerializeField] private Ease pulseEase = Ease.InOutSine;

        private Vector3 _originalScale;

        private void Start()
        {
            _originalScale = transform.localScale;

            transform
                .DOScale(_originalScale * pulseScale, pulseDuration)
                .SetEase(pulseEase)
                .SetLoops(-1, LoopType.Yoyo);
        }
    }
}
