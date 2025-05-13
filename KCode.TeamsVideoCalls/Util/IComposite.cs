using static KCode.TeamsVideoCalls.Util.Constants;

namespace KCode.TeamsVideoCalls.Util
{
    internal interface IComposite
    {
        void joinCall(string name, string acsToken, string callID, CallType callType, LocalizationProps? localization, DataModelInjectionProps? dataModelInjection, OrientationProps? orientationProps, CallControlProps? callControlProps);
        List<string> languages();
        List<string> orientations();
    }
}
