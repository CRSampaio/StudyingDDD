namespace FIGAudioServices.Entities.Files
{
    public class Audio
    {
        public int Id { get; set; }

        public string Filename
        {
            get => Filename;
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(Filename));
                }
                Filename = value;
            }
        }
    }
}
