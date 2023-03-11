namespace Sparky
{
    public class Customer
    {
        public string GreetMessage { get; set; }
        public string CombineName(string fname, string lname)
        {
            GreetMessage = "Good Morning";

            return $"{fname} {lname}";
        }
    }
}
