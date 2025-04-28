using static KCode.JustVideoCall.Util.Constants;

namespace KCode.JustVideoCall.Util
{
    internal interface IComposite
    {
        void joinCall(string name, string acsToken, string callID, CallType callType, LocalizationProps? localization, DataModelInjectionProps? dataModelInjection, OrientationProps? orientationProps, CallControlProps? callControlProps);
        List<string> languages();
        List<string> orientations();
    }
}
