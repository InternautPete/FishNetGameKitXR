using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameKit.Utilities.Types.OptionMenuButtons
{

    public class OptionMenuImageButton : OptionMenuButton
    {
        #region Serialized.
        /// <summary>
        /// Image component to show image on.
        /// </summary>
        [Tooltip("Image component to show image on.")]
        [SerializeField]
        private Image _image;
        #endregion

        public virtual void Initialize(ImageButtonData buttonData)
        {
            base.Initialize(buttonData);
            _image.sprite = buttonData.DisplayImage;
        }
    }


}