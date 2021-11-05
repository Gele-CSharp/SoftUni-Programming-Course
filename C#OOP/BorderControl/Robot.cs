namespace BorderControl
{
    public class Robot : Citizen, IRobot
    {
        public Robot(string iD, string model)
            : base(iD)
        {
            Model = model;
        }

        public string Model { get; protected set; }
    }
}
