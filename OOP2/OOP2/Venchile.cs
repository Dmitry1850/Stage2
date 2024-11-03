namespace OOP2
{
    class Venchile
    {
        private string _model;

        public string ShowModelInfo()
        {
            if (_model == null)
                return "unknown";

            return _model;
        }

        public void SetModelName(string Name)
        {
            if (Name != null)
                _model = Name;
            else
                _model = "unknown";
        }
    }

    class Car : Venchile 
    {
        private int _pistons_Mass;

        public int PistonsMass
        {
            get { return _pistons_Mass; }
            set { _pistons_Mass = value; }
        }
    }

    class Bicycle : Venchile
    {
        private bool Katafotik;

        public bool KatafotikInstalled
        {
            get { return Katafotik; }
            set { Katafotik = value; }
        }
    }
}
