using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace FotoChef.Forms
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();

            Text = string.Format("Acerca de {0}", AssemblyTitle);
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = string.Format("Versión de compilación: {0}.", AssemblyVersion);
            labelCopyright.Text = string.Format(AssemblyCopyright, DateTime.UtcNow.Year);

            string[] links = new[] { "jaracoder.com", "GitHub" };

            linkCompanyName.Links.Clear();
            linkCompanyName.LinkBehavior = LinkBehavior.HoverUnderline;
            linkCompanyName.Text = "Este producto ha sido desarrollado por Juan Antonio Ripoll Armengol."
                                 + " Puedes contactar con el autor desde el sitio web " + links[0] + " y "
                                 + " ver el código fuente del proyecto en " + links[1] + ".";

            Link linkWeb = linkCompanyName.Links.Add(linkCompanyName.Text.IndexOf(links[0]), links[0].Length);
            linkWeb.LinkData = "https://" + links[0] + "?o=" + AssemblyTitle;
            linkWeb.Description = "Sitio web del autor.";

            Link linkRepo = linkCompanyName.Links.Add(linkCompanyName.Text.IndexOf(links[1]), links[1].Length);
            linkRepo.LinkData = "https://github.com/jaracoder";
            linkRepo.Description = "Repositorio del proyecto.";

            textBoxDescription.Text = AssemblyDescription;

        }


        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);

                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];

                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }

                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);

                if (attributes.Length == 0)
                    return "";

                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);

                if (attributes.Length == 0)
                    return "";

                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);

                if (attributes.Length == 0)
                    return "";

                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);

                if (attributes.Length == 0)
                    return "";

                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        private void linkCompanyName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }
    }
}
