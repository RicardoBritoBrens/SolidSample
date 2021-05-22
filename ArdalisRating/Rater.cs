using System;

namespace ArdalisRating
{
    public abstract class Rater
    {
        public RatingEngine _engine;
        public ConsoleLogger _logger;

        protected Rater(RatingEngine engine, ConsoleLogger logger)
        {
            _engine = engine;
            _logger = logger;
        }

        public abstract void Rate(Policy policy);
    }
}