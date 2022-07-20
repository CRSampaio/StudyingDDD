namespace FIGAudioServices.Entities.Files
{
    public class AudioAlert
    {
        public int Id { get; set; }

        public Audio Audio
        {
            get => Audio;
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(Audio));
                }

                Audio = value;
            }
        }
        
        public string? Description { get; set; }
    }
}