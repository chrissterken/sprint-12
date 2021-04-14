namespace AudioDevices.Devices
{
    public class CdDiskMan : DisplayAudioDevice
    {
        private readonly int mbSize = 700;
        private bool isEjected = false;

        public CdDiskMan(int serialId)
        {
            this.serialId = serialId;
        }

        public override string DisplayStorageCapacity()
        {
            return mbSize + " mb.";
        }

        public void Eject()
        {
            isEjected = !isEjected;
        }

        public int MbSize
        {
            get { return mbSize; }
        }

        public bool IsEjected
        {
            get { return isEjected; }
        }
    }
}
