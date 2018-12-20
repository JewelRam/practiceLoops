namespace MediaTypes
{
    class movie : MediaTypes
    {
        public string Genre;

        public movie(string title, string genre)
                        : base(title)

        {
            Genre = genre;
        }

        public string GetDisplayText()
        {
            string text = "Movie Title: " + Title + "which is: " + Genre;
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