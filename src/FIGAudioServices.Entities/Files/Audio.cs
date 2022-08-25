namespace FIGAudioServices.Entities.Files
{
    public class Audio
    {
        private string filename = string.Empty;

        public int Id { get; set; }

        public string Filename
        {
            get => filename;
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(Filename));
                }
                filename = value;
            }
        }
    }
}
