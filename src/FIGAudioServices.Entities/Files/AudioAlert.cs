namespace FIGAudioServices.Entities.Files
{
    public class AudioAlert
    {
        private Audio? _audio;
        private string _description = string.Empty;

        public int Id { get; set; }

        public Audio Audio
        {
            get
            {
                return _audio!;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(Audio));
                }
                _audio = value;
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(Description));
                }
                _description = value;
            }
        }
    }
}