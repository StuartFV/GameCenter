using System;
using System.Windows.Forms;
using GameCenter_GUI;
using OfficeOpenXml;

namespace GameCenter_PA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ExcelPackage.License.SetNonCommercialOrganization("ISIL Desarrollo de Aplicaciones Basico");

            ApplicationConfiguration.Initialize();
            Application.Run(new frmPrincipal());
        }
    }
}