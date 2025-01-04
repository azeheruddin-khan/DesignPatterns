namespace Interpreter.Structural
{
    public class Context
    {
        private Dictionary<string, dynamic> properties = new Dictionary<string, dynamic>();

        public string this[string key]
        {
            get => properties[key];
            set => properties[key] = value;
        }
    }
}
