namespace MediaTypes
{
    class album : MediaTypes
    {
        public string Artist;

        public album(string title, string artist)
                : base(title)

        {
            Artist = artist;
        }

         public string GetDisplayText()
        {
            string text = "Album Title: " + Title + "by: " + Artist;
            if (Borrowed)
            {
                if (!string.IsNullOrEmpty(Loanee))
                {
                text += "(Currently Borrowed by: " + Loanee + ")";
                } else {
                    text = text += "(Currently Borrowed)";
                }
            }
            return text;
        }
    }
}