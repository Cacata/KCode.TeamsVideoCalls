using KCode.TeamsVideoCalls.Platforms.Android;
using KCode.TeamsVideoCalls.Util;
using static KCode.TeamsVideoCalls.Util.Constants;

namespace KCode.TeamsVideoCalls
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
             callComposite.joinCall("Maui Teams UI", "eyJhbGciOiJSUzI1NiIsImtpZCI6IkRCQTFENTczNEY1MzM4QkRENjRGNjA4NjE2QTQ5NzFCOTEwNjU5QjAiLCJ4NXQiOiIyNkhWYzA5VE9MM1dUMkNHRnFTWEc1RUdXYkEiLCJ0eXAiOiJKV1QifQ.eyJza3lwZWlkIjoiYWNzOjU4MGI0NTFiLTM2NGItNGMzMS1iYTI2LTYyNmFjZDVjZWViZF8wMDAwMDAyNy0zYzRjLWIwZTgtNzQwZS05MTNhMGQwMDk0OWEiLCJzY3AiOjE3OTIsImNzaSI6IjE3NDYzODA5ODMiLCJleHAiOjE3NDY0NjczODMsInJnbiI6ImFtZXIiLCJhY3NTY29wZSI6InZvaXAiLCJyZXNvdXJjZUlkIjoiNTgwYjQ1MWItMzY0Yi00YzMxLWJhMjYtNjI2YWNkNWNlZWJkIiwicmVzb3VyY2VMb2NhdGlvbiI6InVuaXRlZHN0YXRlcyIsImlhdCI6MTc0NjM4MDk4M30.ERuPXTPIGks6CemLbvVHnM4ZpF6LGoVJihJ-sVlRwLPGzAupujx_fnSrzKbJKz6xaU1gJY_ovlAoCN9EaUcahWh4RZQzQA6I_zXqBn63l7ampyJqbWOaP-5aJp90Ff9wXgOpmY4X4BvxlSdyfhmREVeLCLDr7ZMQOgT3kCu9EMompZ-KqlESC_crz-Nf8yygZtRXPtx7Q6TiRO4nke8Y-D6znE9cg1I3gW8xB_3vAb4te1gnbFfrXaGtFEkTqECUhwsOnrNzk0MVBSqIWJkL-S6rAs24Tvg4oRX7eV42va87QjJAPa57YB6TFPnklVdHg55wyiKasizL0oPrMdrx8A", "https://teams.microsoft.com/l/meetup-join/19%3ameeting_ZjEyYWNlMTEtYmUxYi00YzM3LTk1NzctODVjYTRiNDI2N2Rl%40thread.v2/0?context=%7b%22Tid%22%3a%221c63379b-6ae1-41bb-9d14-432c3131367b%22%2c%22Oid%22%3a%22e7e1e557-021b-4929-9a38-1de15d0deca7%22%7d", CallType.TeamsCall, _localization, _dataModelInjection, _orientationProps, _callControlProps);
        }
    }

}
