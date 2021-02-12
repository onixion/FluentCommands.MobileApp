using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FluentCommands.MobileApp.Controls.Cards
{
    /// <summary>
    /// Card.
    /// </summary>
    public class Card : Frame
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Card()
        {
            Padding = 0;
            CornerRadius = 25;
            BackgroundColor = Color.White;
            HasShadow = false;
        }
    }
}
