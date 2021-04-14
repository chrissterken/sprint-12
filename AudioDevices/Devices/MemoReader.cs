using System;

namespace AudioDevices.Devices
{
    public class MemoReader : AudioDevice
    {
        private MemoCartridgeType maxCartridgeType;

        public MemoReader(int serialId)
        {
            this.serialId = serialId;
        }

        public override String DisplayStorageCapacity()
        {
            String temp = "Max capacity: ";

            switch (maxCartridgeType)
            {
                case MemoCartridgeType.C60:
                    temp += "60 min.";
                    break;
                case MemoCartridgeType.C90:
                    temp += "90 min.";
                    break;
                case MemoCartridgeType.C120:
                    temp += "120 min.";
                    break;
                case MemoCartridgeType.Unknown:
                    temp += "Unknown.";
                    break;
                default:
                    temp += "Unknown.";
                    break;
            }
            return temp;
        }

        public MemoCartridgeType MaxCartridgeType
        {
            get { return maxCartridgeType; }
            set { maxCartridgeType = value; }
        }
    }

    public enum MemoCartridgeType
    {
        C60,
        C90,
        C120,
        Unknown
    }
}
