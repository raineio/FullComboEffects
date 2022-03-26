using FullComboEffects.Installers;
using IPA;
using IPA.Config;
using IPA.Config.Stores;
using IPALogger = IPA.Logging.Logger;
using FullComboEffects.Configuration;
using SiraUtil.Zenject;

namespace FullComboEffects
{
    [Plugin(RuntimeOptions.DynamicInit), NoEnableDisable]
    internal class Plugin
    {
        [Init]
        public void Init(IPALogger logger, Config config, Zenjector zenjector)
        {
            zenjector.UseLogger(logger);

            zenjector.Install<AppInstaller>(Location.App, config.Generated<PluginConfig>());
        }
    }
}
