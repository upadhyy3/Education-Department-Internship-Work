using System.Web;
using System.Web.Optimization;

namespace EducationDepartmentV1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/ckeditor/ckeditor.js",
                      "~/Scripts/ckeditor/config.js",
                      "~/Scripts/ckeditor/styles.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/ckeditor").Include(
                      "~/Scripts/ckeditor/ckeditor.js",
                      "~/Scripts/ckeditor/config.js",
                      "~/Scripts/ckeditor/style.js"));

            bundles.Add(new ScriptBundle("~/bundles/rappid").Include(
                  "~/trial/node_modules/jquery/dist/jquery.js",
                  "~/trial/node_modules/lodash/index.js",
                  "~/trial/node_modules/backbone/backbone.js",
                  "~/trial/node_modules/graphlib/dist/graphlib.core.js",
                  "~/trial/node_modules/dagre/dist/dagre.core.js",
                  "~/trial/KitchenSink/lib/KeyboardJS/keyboard.js",
                  "~/trial/build/rappid.min.js",
                  "~/trial/KitchenSink/src/inspector.js",
                  "~/trial/KitchenSink/src/stencil.js",
                  "~/trial/KitchenSink/src/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/simple-sidebar.css",
                      "~/Content/custom.css",
                      "~/trial/build/rappid.min.css",
                      "~/trial/KitchenSink/css/layout.css",
                      "~/trial/KitchenSink/css/paper.css",
                      "~/trial/KitchenSink/css/inspector.css",
                      "~/trial/KitchenSink/css/navigator.css",
                      "~/trial/KitchenSink/css/stencil.css",
                      "~/trial/KitchenSink/css/halo.css",
                      "~/trial/KitchenSink/css/selection.css",
                      "~/trial/KitchenSink/css/toolbar.css" ,
                      "~/trial/KitchenSink/css/statusbar.css" ,
                      "~/trial/KitchenSink/css/freetransform.css",
                      "~/trial/KitchenSink/css/style.css"));
        }
    }
}
