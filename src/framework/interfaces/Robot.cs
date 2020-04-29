namespace BaseClasses
{
    abstract class Robot
    {
        public tools.API api;

        public Robot()
        {
            api = new tools.API( );
        }
    }
}