using Assignment2.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Components.Pages
{
    public partial class Flights : ComponentBase
    {
       /* List<Flight> flightsList = new List<Flight>();
        SortedSet<string> departureAirport = new SortedSet<string>();
        SortedSet<string> arrivalAirport = new SortedSet<string>();
        HashSet<string> weekDays = new HashSet<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        SelectOptions selectOption = new SelectOptions();
        List<Flight> searchResult = new List<Flight>();

        string selectedRow = "";

        protected override void OnInitialized()
        {
            flightsList = new List<Flight>();
            // Get the path to the "res" directory
            string resDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot/Data");
            string filePath = Path.Combine(resDirectory, "flights.csv");

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    Flight flight = new Flight(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], int.Parse(parts[6]), double.Parse(parts[7]));
                    flightsList.Add(flight);
                    departureAirport.Add(parts[2]);
                    arrivalAirport.Add(parts[3]);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }
        }
        private void SearchFlights()
        {
            searchResult.Clear();
            foreach(Flight flight in flightsList)
            {
                bool matchesDeparture = string.IsNullOrEmpty(selectOption.departureAirport) || selectOption.departureAirport == "Any" || flight.From == selectOption.departureAirport;
                bool matchesArrival = string.IsNullOrEmpty(selectOption.arrivalAirport) || selectOption.arrivalAirport == "Any" || flight.To == selectOption.arrivalAirport;
                bool matchesWeekDay = string.IsNullOrEmpty(selectOption.weekDay) || selectOption.weekDay == "Any" || flight.Weekday == selectOption.weekDay;
                if (matchesDeparture && matchesArrival && matchesWeekDay)
                {
                    searchResult.Add(flight);
                }
            }
        }
        private void OnFlightSelected(Flight flight)
        {
            selectedRow = flight.Code;
            //Console.WriteLine(flight.flightCode);
        }*/
    }
}
