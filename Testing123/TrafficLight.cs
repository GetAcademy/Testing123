namespace Testing123
{
    public class TrafficLight
    {
        private int _phase;
        public bool IsRedOn => _phase < 2;
        public bool IsYellowOn => _phase is 1 or 3;
        public bool IsGreenOn => _phase == 2;

        public void NextPhase()
        {
            _phase = (_phase + 1) % 4;

            //_phase++;
            //if (_phase == 4)
            //{
            //    _phase = 0;
            //}

            //_phase = _phase == 3 ? 0 : _phase + 1;
        }
    }
}
