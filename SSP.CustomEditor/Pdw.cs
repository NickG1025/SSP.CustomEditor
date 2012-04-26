using EPiServer.Editor.TinyMCE;

namespace SSP.CustomEditor
{
    [TinyMCEPluginButton(LanguagePath = "/admin/tinymce/plugins/pdw",
        GroupName = "media", 
        ButtonSortIndex = 0, 
        ButtonName = "pdw_toggle", 
        PlugInName = "pdw", 
        IconClass = "mce_pdw_toggle",
        EditorInitConfigurationOptions = @"{
            pdw_toggle_on : 1,
            pdw_toggle_toolbars : ""1,2"" }"
        )]
    public class Pdw
    {
    }
}