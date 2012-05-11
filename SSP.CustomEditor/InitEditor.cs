using EPiServer.Editor.TinyMCE;

namespace SSP.CustomEditor
{
    [TinyMCEPluginNonVisual(AlwaysEnabled = true,
        PlugInName = "SSPEditorSettings",
        DisplayName = "Init options",
        Description = "Custom editor init options.",
        EditorInitConfigurationOptions = @"{ 
            extended_valid_elements: 'iframe[src|frameborder=0|alt|title|width|height|align|name|allowTransparency|style]' 
        }"
        )]  
    public class InitEditor
    {

    }
}