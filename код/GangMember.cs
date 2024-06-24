using System.Collections.Generic;

namespace YourNamespace
{
    public class GangMember : CrimeRecord
    {
        private List<string> accomplices;
        private string gangName;

        public List<string> Accomplices
        {
            get => accomplices; set => accomplices = value;
        }
        public string GangName
        {
            get => gangName; set => gangName = value;
        }

        public GangMember() : base()
        {
            accomplices = new List<string>();
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" Member of gang: {GangName}.";
        }

        public void AddAccomplice(string accomplice)
        {
            if (!accomplices.Contains(accomplice)) {
                accomplices.Add(accomplice);
            }
        }

        public void RemoveAccomplice(string accomplice)
        {
            if (accomplices.Contains(accomplice)) {
                accomplices.Remove(accomplice);
            }
        }
    }
}
