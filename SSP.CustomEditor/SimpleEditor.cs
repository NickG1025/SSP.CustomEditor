using System.Linq;
using System.Collections.Generic;
using EPiServer.Core.PropertySettings;
using EPiServer.Editor.TinyMCE;
using PageTypeBuilder;

namespace SSP.CustomEditor
{
    public class SimpleEditor : IUpdateGlobalPropertySettings<TinyMCESettings>
    {
        public string DisplayName
        {
            get { return "Simple editor"; }
        }

        public string Description
        {
            get { return "Only the most essential settings"; }
        }

        public bool? IsDefault
        {
            get { return false; }
        }

        public bool Match(PropertySettingsWrapper propertySettingsWrapper)
        {
            return propertySettingsWrapper.DisplayName.Equals(DisplayName);
        }

        public void UpdateSettings(TinyMCESettings settings)
        {
            settings.ToolbarRows.Clear();
            var buttons = new List<string> { "bold", "italic", "separator", "epilink", "unlink", "separator", "removeformat", "code" };
            var toolbarRow = new ToolbarRow(buttons);
            settings.ToolbarRows.Add(toolbarRow);
            settings.Height = 100;
        }

        public int GetSettingsHashCode(TinyMCESettings settings)
        {
            var flattened = settings.ToolbarRows.SelectMany(row => row.Buttons);
            return string.Concat(flattened).GetHashCode() + settings.Height;
        }

        public bool OverWriteExistingSettings
        {
            get { return true; }
        }
    }
}