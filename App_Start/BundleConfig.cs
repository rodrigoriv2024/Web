using System.Web;
using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Content/assets/vendor/jquery/jquery.min.js",
                "~/Content/assets/vendor/bootstrap/js/bootstrap.bundle.min.js",
                "~/Content/assets/vendor/jquery.easing/jquery.easing.min.js",
                "~/Content/assets/vendor/php-email-form/validate.js",
                "~/Content/assets/vendor/waypoints/jquery.waypoints.min.js",
                "~/Content/assets/vendor/counterup/counterup.min.js",
                "~/Content/assets/vendor/venobox/venobox.min.js",
                "~/Content/assets/vendor/owl.carousel/owl.carousel.min.js",
                "~/Content/assets/vendor/isotope-layout/isotope.pkgd.min.js",
                "~/Content/assets/vendor/aos/aos.js",
                "~/Content/assets/js/main.js"




                ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
             "~/Content/assets/img/favicon.png",
             "~/Content/assets/img/apple-touch-icon.png", 
             "~/Content/assets/vendor/bootstrap/css/bootstrap.min.css",
             "~/Content/assets/vendor/bootstrap/css/bootstrap-grid.css",
             "~/Content/assets/vendor/bootstrap/css/bootstrap-grid.min.css",
             "~/Content/assets/vendor/bootstrap/css/bootstrap-reboot.css",
             "~/Content/assets/vendor/bootstrap/css/bootstrap-reboot.min.css",
             "~/Content/assets/vendor/bootstrap/css/bootstrap.css",
             "~/Content/assets/vendor/icofont/icofont.min.css",
             "~/Content/assets/vendor/boxicons/css/boxicons.min.css",
             "~/Content/assets/vendor/venobox/venobox.css",
             "~/Content/assets/vendor/remixicon/remixicon.css",
             "~/Content/assets/vendor/owl.carousel/assets/owl.carousel.min.css",
             "~/Content/assets/vendor/aos/aos.css",
             "~/Content/assets/css/style.css"));



        }
    }
}
