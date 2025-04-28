namespace KCode.JustVideoCall.Util
{
    public class Constants
    {
        public enum CallType
        {
            TeamsCall,
            GroupCall,
            OneToN,
            RoomsCall
        }
        public struct LocalizationProps
        {
            public string locale;
            public Boolean isLeftToRight;
        }

        public struct DataModelInjectionProps
        {
            public string localAvatar;
            public string remoteAvatar;
        }

        public struct OrientationProps
        {
            public string setupScreenOrientation;
            public string callScreenOrientation;
        }

        public struct CallControlProps
        {
            public Boolean isSkipSetupON;
            public Boolean isMicrophoneON;
            public Boolean isCameraON;
            public Boolean isDisableLeaveCallConfirmation;
            public String title;
            public String subtitle;
            public Boolean updateSubtitleOnParticipantCountChange;
        }
    }
}
