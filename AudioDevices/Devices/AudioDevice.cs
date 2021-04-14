using System;

namespace AudioDevices.Devices
{
    public abstract class AudioDevice : IAudioDevice
    {
        protected int serialId;
        protected String model;
        protected String make;
        protected decimal priceExBtw;
        protected DateTime creationDate;
        protected const double btwPercentage = 19.0;

        public String DisplayIdentity()
        {
            return "Serial: " + serialId;
        }

        public String DisplayIdentity(bool modelInfo, bool makeInfo)
        {
            String temp = DisplayIdentity();
            if (modelInfo)
            {
                temp += "\nModel: " + model;
            }
            if (makeInfo)
            {
                temp += "\nMake: " + make;
            }
            return temp;
        }

        public String GetDeviceLifetime()
        {
            if (creationDate.Ticks != 0)
            {
                return "Lifetime: " + DateTime.Now.Subtract(creationDate).Days + " Days";
            }
            else
            {
                return "Lifetime: unknown";
            }
        }

        public abstract String DisplayStorageCapacity();

        public int SerialId
        {
            get { return serialId; }
            set { serialId = value; }
        }

        public String Model
        {
            get { return model; }
            set { model = value; }
        }

        public String Make
        {
            get { return make; }
            set { make = value; }
        }

        public decimal PriceExBtw
        {
            get { return priceExBtw; }
            set { priceExBtw = value; }
        }

        public decimal ConsumerPrice
        {
            get { return Decimal.Round(priceExBtw*(((decimal)btwPercentage/100)+1), 2, MidpointRounding.AwayFromZero); }
        }

        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
    }
}
