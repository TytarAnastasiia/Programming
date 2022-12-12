using System;
using InfoSysFlight.Enums;

namespace InfoSysFlight.Model
{
    /// <summary>
    /// Хранит информацию о перелёте.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Пункт вылета.
        /// </summary>
        private string _departurePoint;

        /// <summary>
        /// Пункт прибытия.
        /// </summary>
        private string _destinationPoint;

        /// <summary>
        /// Время вылета.
        /// </summary>
        private DateTime _departureTime;

        /// <summary>
        /// Продолжительность полёта.
        /// </summary>
        private int _flightDuration;

        /// <summary>
        /// Тип перелёта.
        /// </summary>
        private FlightType _flightType;

        /// <summary>
        /// Переводит время вылета в строку.
        /// </summary>
        /// <returns>Возвращает строку.</returns>
        public string DepartureTimeToString()
        {
            return _departureTime.ToString("dd.MM.yyyy HH:mm");
        }
        
        /// <summary>
        /// Проверяет пункт вылета.
        /// </summary>
        public string DeparturePoint
        {
            get 
            { 
                return _departurePoint; 
            }
            set
            {
                Validator.AssertOnValidText(value);
                Validator.AssertOnValidLength(value);
                _departurePoint = value;
            } 
        }
        
        /// <summary>
        /// Проверяет пункт прибытия.
        /// </summary>
        public string DestinationPoint
        {
            get 
            {
                return _destinationPoint;
            }
            set
            {
                Validator.AssertOnValidText(value);
                Validator.AssertOnValidLength(value);
                _destinationPoint = value;
            }
        }
        
        /// <summary>
        /// Проверяет время вылета.
        /// </summary>
        public DateTime DepartureTime
        {
            get 
            {
                return _departureTime; 
            }
            set
            {
                Validator.AssertOnValidDate(value);
                _departureTime = value;
            }
        }
        
        /// <summary>
        /// Проверяет продолжительность полёта.
        /// </summary>
        public int FlightDuration
        {
            get 
            { 
                return _flightDuration; 
            }
            set
            {
                Validator.AssertOnInRange(0, 1000, value);
                _flightDuration = value;
            }
        }
        
        /// <summary>
        /// Устанавливает тип перелёта.
        /// </summary>
        public FlightType TypeOfFlight
        {
            get 
            {
                return _flightType; 
            }
            set
            {
                _flightType = value;
            }
        }
                
        public string FlightToString()
        {
            return DepartureTimeToString() + " " + DeparturePoint + " " + DestinationPoint;
        }

        /// <summary>
        /// Переводит всю информацию о полёте в строку.
        /// </summary>
        /// <returns>Возвращает строку.</returns>
        public string AllInfoToString()
        {
            return DeparturePoint + ";" + DestinationPoint + ";" 
                + DepartureTimeToString() + ";" + FlightDuration + ";" + TypeOfFlight;
        }
    
        public bool IsAllCompleted()
        {
            if (_flightDuration == 0 || _departureTime == DateTime.MinValue ||
                string.IsNullOrWhiteSpace(_departurePoint) || string.IsNullOrEmpty(_departurePoint)
                || string.IsNullOrWhiteSpace(_destinationPoint) || string.IsNullOrEmpty(_destinationPoint))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight() { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departurePoint">Пункт вылета. Должен быть задан,
        /// содержать корректные символы и не превышать заданной длины.</param>
        /// <param name="destinationPoint">Пункт прибытия. Должен быть задан,
        /// содержать корректные символы и не превышать заданной длины.</param>
        /// <param name="departureTime">Время вылета. Должно находиться в 
        /// верном диапазоне дат.</param>
        /// <param name="flightDuration">Продолжительность полёта. Должна быть задана.</param>
        /// <param name="typeOfFlight">Тип перелёта.</param>
        public Flight(string departurePoint, string destinationPoint,
            DateTime departureTime, int flightDuration, FlightType typeOfFlight)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            DepartureTime = departureTime;
            FlightDuration = flightDuration;
            TypeOfFlight = typeOfFlight;
        }
    }
}
