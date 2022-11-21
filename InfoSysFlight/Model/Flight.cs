using System;
using InfoSysFlight.Enums;

namespace InfoSysFlight.Model
{
    class Flight
    {
        private string departurePoint;

        private string destinationPoint;

        private DateTime departureTime;

        private int flightDuration;

        private FlightType typeOfFlight;

        public Flight () { } 

        public Flight(string departurePoint, string destinationPoint, 
            DateTime departureTime, int flightDuration, FlightType typeOfFlight) 
        {
            DeparturePoint = departurePoint;

            DestinationPoint = destinationPoint;

            DepartureTime = departureTime;

            FlightDuration = flightDuration;

            TypeOfFlight = typeOfFlight;
        }
        
        public string DepartureTimeToString ()
        {
            return departureTime.ToString("dd.MM.yyyy HH:mm");
        }
        
        public string DeparturePoint
        {
            get { return departurePoint; }
            set
            {
                Validator.AssertOnValidText(value);
                Validator.AssertOnValidLength(value);
                departurePoint = value;
            } 
        }
        
        public string DestinationPoint
        {
            get { return destinationPoint; }
            set
            {
                Validator.AssertOnValidText(value);
                Validator.AssertOnValidLength(value);
                destinationPoint = value;
            }
        }
        
        public DateTime DepartureTime
        {
            get { return departureTime; }
            set
            {
                Validator.AssertOnValidDate(value);
                departureTime = value;
            }
        }
        
        public int FlightDuration
        {
            get { return flightDuration; }
            set
            {
                Validator.AssertOnInRange(0, 1000, value);
                flightDuration = value;
            }
        }
        
        public FlightType TypeOfFlight
        {
            get { return typeOfFlight; }
            set
            {
                typeOfFlight = value;
            }
        }
        
        public string FlightToString()
        {
            return DepartureTimeToString() + " " + DeparturePoint + " " + DestinationPoint;
        }
        
        public string AllInfoToString()
        {
            return DeparturePoint + ";" + DestinationPoint + ";" 
                + DepartureTimeToString() + ";" + FlightDuration + ";" + TypeOfFlight;
        }
    
        public bool IsAllCompleted()
        {
            if (flightDuration == 0 || departureTime == DateTime.MinValue ||
                string.IsNullOrWhiteSpace(departurePoint) || string.IsNullOrEmpty(departurePoint)
                || string.IsNullOrWhiteSpace(destinationPoint) || string.IsNullOrEmpty(destinationPoint))
            {
                return false;
            }
            return true;
        }
    }
}
