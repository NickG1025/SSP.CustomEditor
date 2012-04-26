using System.Linq;
using System.Collections.Generic;
using EPiServer.Core.PropertySettings;
using EPiServer.Editor.TinyMCE;
using PageTypeBuilder;

namespace SSP.CustomEditor
{
    public class AdvancedEditor : IUpdateGlobalPropertySettings<TinyMCESettings>
    {
        public string DisplayName
        {
            get { return "Advanced editor"; }
        }

        public string Description
        {
            get { return "Editor with advanced settings"; }
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

            var buttonsRow1 = new List<string>
                                  {
                                      "bold", 
                                      "italic", 
                                      "separator", 
                                      "epilink", 
                                      "unlink", 
                                      "separator",
                                      "image",
                                      "advimage",
                                      "styleselect", 
                                      "separator", 
                                      "justifyleft", 
                                      "justifycenter", 
                                      "justifyright", 
                                      "separator", 
                                      "bullist", 
                                      "numlist", 
                                      "separator", 
                                      "outdent", 
                                      "indent", 
                                      "separator", 
                                      "pdw_toggle"
                                  };
            var buttonsRow2 = new List<string>
                                  {
                                      "epidynamiccontent", 
                                      "media",
                                      "separator", 
                                      "removeformat", 
                                      "code"
                                  };
            var buttonsRow3 = new List<string>
                                  {
                                      "tablecontrols", 
                                      "table", 
                                      "row_props", 
                                      "cell_props", 
                                      "delete_col", 
                                      "col_after", 
                                      "col_before", 
                                      "delete_row", 
                                      "row_after", 
                                      "row_before", 
                                      "split_cells", 
                                      "merge_cells"
                                  };
            

            settings.ToolbarRows.Add(new ToolbarRow(buttonsRow1));
            settings.ToolbarRows.Add(new ToolbarRow(buttonsRow2));
            settings.ToolbarRows.Add(new ToolbarRow(buttonsRow3));
            settings.Height = 300;
            settings.Width = 500;
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