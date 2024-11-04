using System.ComponentModel;

namespace LearningInterfaces
{
    public class Player : INotifyPropertyChanged
    {
        private int _score;
        public int Score
        {
            get => _score;
            set
            {
                if (_score != value)
                {
                    var oldScore = _score;
                    _score = value;
                    OnScoreChanged(nameof(Score), oldScore, _score);
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnScoreChanged(string propertyName, int oldValue, int newValue)
        {
            PropertyChanged?.Invoke(this, new ScorePropertyChangedEventArgs(propertyName, oldValue, newValue));
        }
    }

    public class ScorePropertyChangedEventArgs
        : PropertyChangedEventArgs
    {
        public int OldValue { get; }
        public int NewValue { get; }

        public ScorePropertyChangedEventArgs(string propertyName, int oldValue, int newValue)
            : base(propertyName)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
