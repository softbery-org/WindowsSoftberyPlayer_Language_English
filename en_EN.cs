using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator;

namespace English
{
    public class en_EN : ILanguage
    {
        public string Name => "English";
        public string formSettings_btnSave => "Save";

        public string formSettings_btnCancel => "Cancel";

        public string formSettings_Text => "Options:";

        public string formSettings_labelOptions => "Options:";

        public string videoControlBar_labelSubtilesOnOffText => "Subtiles:";

        public string videoControlBar_labelOn => "On";

        public string videoControlBar_labelOff => "Off";
        public string videoControlBar_fullscreenOff => "Fullscreen Off";
        public string videoControlBar_fullscreenOn => "Fullscreen On";
        public string videoControlBar_startTxt => "Start";
        public string videoControlBar_subtilesOn => "Subtiles On";
        public string videoControlBar_subtilesOff => "Subtiles Off";
    }
}
