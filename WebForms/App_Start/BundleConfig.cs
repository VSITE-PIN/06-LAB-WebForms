using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace WebForms
{
    public class BundleConfig
    {
        // Registracija bundle-ova
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterJQueryScriptManager();

            bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
                "~/Scripts/WebForms/WebForms.js",
                "~/Scripts/WebForms/WebUIValidation.js",
                "~/Scripts/WebForms/MenuStandards.js",
                "~/Scripts/WebForms/Focus.js",
                "~/Scripts/WebForms/GridView.js",
                "~/Scripts/WebForms/DetailsView.js",
                "~/Scripts/WebForms/TreeView.js",
                "~/Scripts/WebForms/WebParts.js"));

            // Microsoft AJAX JavaScript
            bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
                "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

            // Modernizr
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));
        }

        // Registracija jQuery mappinga
        public static void RegisterJQueryScriptManager()
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
                new ScriptResourceDefinition
                {
                    Path = "~/Scripts/jquery-3.7.0.min.js",
                    DebugPath = "~/Scripts/jquery-3.7.0.js",
                    CdnPath = "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.7.0.min.js",
                    CdnDebugPath = "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.7.0.js"
                });
        }
    }
}
