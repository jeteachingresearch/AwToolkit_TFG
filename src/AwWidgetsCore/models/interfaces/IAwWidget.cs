namespace AwWidgetsCore.models.interfaces
{
    public interface IAwWidget
    {
        public void displayWithUnnoticeableDisturbance();

        public void displayWithSubtleDisturbance();

        public void displayWithIntrusiveDisturbance();

        public void displayWithDisruptiveDisturbance();

        public void resetStyles();

        public Tuple<int, int> getSize();

        public Tuple<int, int> getTopLeftCorner();
    }
}
