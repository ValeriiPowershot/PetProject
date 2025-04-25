using System;
using UI;

namespace Services
{
    public class CurtainService
    {
        private readonly CurtainView _curtain;
        private readonly bool _enabled;

        public CurtainService(CurtainView curtainView, bool enabled = true)
        {
            _curtain = curtainView;
            _enabled = enabled;
        }

        public void Show(Action onComplete = null)
        {
            if (_enabled)
            {
                _curtain.FadeIn(onComplete);
            }
            else
            {
                onComplete?.Invoke();
            }
        }

        public void Hide(Action onComplete = null)
        {
            if (_enabled)
                _curtain.FadeOut(onComplete);
            else
                onComplete?.Invoke();
        }
    }
}
