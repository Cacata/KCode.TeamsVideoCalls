using KCode.JustVideoCall.Platforms.Android;
using KCode.JustVideoCall.Util;
using static KCode.JustVideoCall.Util.Constants;

namespace KCode.JustVideoCall
{
    public partial class MainPage : ContentPage
    {
        IComposite callComposite = new Composite();

        LocalizationProps _localization;
        DataModelInjectionProps _dataModelInjection;
        OrientationProps _orientationProps;
        CallControlProps _callControlProps;

        public MainPage()
        {
            InitializeComponent();

            _localization = new LocalizationProps();
            _localization.locale = "en";
            _localization.isLeftToRight = true;

            _orientationProps = new OrientationProps();
            _orientationProps.setupScreenOrientation = "PORTRAIT";
            _orientationProps.callScreenOrientation = "USER";

            _dataModelInjection = new DataModelInjectionProps();
            _dataModelInjection.localAvatar = "";
            _dataModelInjection.remoteAvatar = "";

            _callControlProps = new CallControlProps();
            _callControlProps.isSkipSetupON = false;
            _callControlProps.isMicrophoneON = false;
            _callControlProps.isCameraON = false;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
             //callComposite.joinCall("[Call Name]", "[Token generated]", "[Teams Link]", CallType.TeamsCall, _localization, _dataModelInjection, _orientationProps, _callControlProps);
        }
    }

}
