namespace CompisitionLabColtonGarrett
{
    public class author
    {
        private string name;
        private string email;
        private char gender;

        public author(string name, string email, char gender)
        {

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

        public void SetName()
        {
            this.name=name;
        }
        public void SetGender()
        {
            this.gender=gender;
        }
        public void SetEmail()
        {
            this.email=email;
        }

        public string Tostring()
        {

        }
    }
}