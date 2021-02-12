using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace FluentCommands.MobileApp
{
    /// <summary>
    /// Test label.
    /// </summary>
    public class TestLabel : Label
    { 
        const string textAnimationHandle = "textAnimation";
        Animation textAnimation;

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == nameof(Text))
            {
                if (textAnimation != null)
                    this.AbortAnimation(textAnimationHandle);

                textAnimation = new Animation(
                    v => Opacity = v, 
                    1.0, 
                    0.0, 
                    Easing.CubicOut);

                textAnimation.Commit(this, textAnimationHandle, 16, 3000);
            }
        }
    }
}
