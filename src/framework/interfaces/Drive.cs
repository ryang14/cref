namespace BaseClasses
{
    abstract class Drive
    {
        protected int _throttle;
        protected int _steering;

        protected virtual void _SetThrottle(int percent) {}
        protected virtual void _SetSteering(int percent) {}

        public int throttle
        {
            get => _throttle;
            set {
                _throttle = value;
                this._SetThrottle(value);
            }
        }

        public int steering
        {
            get => _steering;
            set {
                _steering = value;
                this._SetSteering(value);
            }
        }
    }
}