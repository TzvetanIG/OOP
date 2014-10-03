namespace CompanyHierarchy.Utilities
{
    using System;

    public class Project
    {
        public Project(string name, DateTime startData, string ditails = null)
        {
            this.Name = name;
            this.StartData = startData;
            this.Ditails = ditails;
            this.State = State.Open;
        }

        public string Name { get; private set; }
        public DateTime StartData { get; private set; }
        public string Ditails { get; set; }
        public State State { get; private set; }

        public void CloseProject()
        {
            this.State = State.Closed;
        }

        public override string ToString()
        {
            return string.Format("{0} - state: {1}", this.Name, this.State);
        }
    }
}

