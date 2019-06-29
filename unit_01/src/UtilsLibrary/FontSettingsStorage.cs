using System;
using System.Collections;
using System.Collections.Generic;

namespace UtilsLibrary
{
    public class FontSettingsStorage
    {
        [Flags]
        public enum FontSettings
        {
            None         = 0,
            Bold         = 1,
            Italic       = 2,
            Underline    = 4
        }

        private readonly Dictionary<FontSettings, string> _dictionary = new Dictionary<FontSettings, string>()
        {
            {FontSettings.Bold, "Bold"},
            {FontSettings.Italic, "Italic"},
            {FontSettings.Underline, "Underline"}
        };

        private FontSettings _currentFontSettings;

        public void ToggleFontSetting(int value)
        {
            if (value == 3)
            {
                value += 1;
            }

            ToggleFontSettingImpl((FontSettings)value);
        }

        private void ToggleFontSettingImpl(FontSettings value)
        {
            if ((_currentFontSettings & value) == value)
            {
                _currentFontSettings ^= value;
            }
            else
            {
                _currentFontSettings |= value;
            }
        }

        public void PrintCurrentSettings()
        {
            Console.WriteLine("Параметры надписи: {0}", GetCurrentSettingsAsString());
        }

        private string GetCurrentSettingsAsString()
        {
            if (_currentFontSettings == FontSettings.None)
            {
                return "None";
            }

            var result = new List<string>();
            foreach (FontSettings t in Enum.GetValues(typeof(FontSettings)))
            {
                var index = _currentFontSettings & t;
                if (index != FontSettings.None)
                {
                    result.Add(_dictionary[index]);
                }
            }

            return string.Join(",", result);
        }
    }
}