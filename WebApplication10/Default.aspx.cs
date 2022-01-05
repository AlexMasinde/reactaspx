using React;
using System;
using System.Web.UI;


namespace WebApplication6
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var env = AssemblyRegistration.Container.Resolve<IReactEnvironment>();
            var objectModel = new { user = "React User" };
            var reactComponent = env.CreateComponent("App", objectModel);

            App.Text = reactComponent.RenderHtml();
        }
    }
}