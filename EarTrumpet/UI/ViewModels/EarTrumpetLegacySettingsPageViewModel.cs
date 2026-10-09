namespace EarTrumpet.UI.ViewModels
{
    public class EarTrumpetLegacySettingsPageViewModel : SettingsPageViewModel
    {
        public bool UseLegacyIcon
        {
            get => _settings.UseLegacyIcon;
            set => _settings.UseLegacyIcon = value;
        }

        public bool OpenMixerOnStartup
        {
            get => _settings.OpenMixerOnStartup;
            set => _settings.OpenMixerOnStartup = value;
        }

        private readonly AppSettings _settings;

        public EarTrumpetLegacySettingsPageViewModel(AppSettings settings) : base(null)
        {
            _settings = settings;
            Title = Properties.Resources.LegacySettingsPageText;
            Glyph = "\xE825";
        }
    }
}