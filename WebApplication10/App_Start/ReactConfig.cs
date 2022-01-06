using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WebApplication10.ReactConfig), "Configure")]

namespace WebApplication10
{
    public static class ReactConfig
    {
		public static void Configure()
		{
			JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
			JsEngineSwitcher.Current.EngineFactories.AddV8();
			ReactSiteConfiguration.Configuration.AddScript("~/Scripts/components/App.js");
		}
	}
}