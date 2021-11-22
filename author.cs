namespace CompisitionLabColtonGarrett
{
    public class author
    {
        private string name;
        private string email;
        private char gender;

        public author(string name, string email, char gender)
        {
            this.name=name;
            this.email=email;
            this.gender=gender;
        }

        public string GetName()
        {
            return name;
        }

        public char GetGender()
        {
            return gender;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetName(string name)
        {
            this.name=name;
        }
        public void SetGender(char gender)
        {
            this.gender=gender;
        }
        public void SetEmail(string email)
        {
            this.email=email;
        }

        public string ToString(string name, string email, char gender)
        {
            string authorcombined=name+email+gender;
            return authorcombined;
        }
    }
}