﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    internal class ReservationManager
    {

        
        private static string Reservation_TXT = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot/Data/reservation.csv");

        private static Random random = new Random();
       
        private static List<Reservation> reservations = new List<Reservation>();

        public List<Reservation> FindReservations(string reservationCode, string airline, string name)
        {
            List<Reservation> found = new List<Reservation>();

            foreach (Reservation reservation in reservations)
            {
                if (reservation.Code.Contains(reservationCode) && reservation.Airline.Contains(airline) && reservation.Name.Contains(name))
                {
                    found.Add(reservation);
                }
                else if (reservation.Code.Contains(reservationCode))
                {
                    found.Add(reservation);
                }
               
                else if (reservation.Name.Contains(name))
                {
                    found.Add(reservation);
                }
                
                else if (reservation.Airline.Contains(airline))
                {
                    found.Add(reservation);
                }
            }

            return found;
        }

        public string GenerateResCode()
        {
            return GenerateReservationCode();
        }

        
        public string GenerateReservationCode()
        {
            string reservationCode;

            do
            {
                char letter = (char)('A' + random.Next(26));
                string numbers = random.Next(1000, 10000).ToString();
                reservationCode = letter + numbers;
            } while (IsCodeGenerated(reservationCode, Reservation_TXT));

            return reservationCode;
        }

        private static bool IsCodeGenerated(string reservationCode, string Reservation_TXT)
        {
            if (!File.Exists(reservationCode))
            {
                return false;
            }

            List<string> existingCode = File.ReadAllLines(Reservation_TXT).ToList();

            return existingCode.Contains(reservationCode);
        }

        public static List<Reservation> GetReservations()
        {
            List<Reservation> res = new List<Reservation>();
            foreach (string line in File.ReadLines(Reservation_TXT))
            {
                string[] parts = line.Split(",");
                string reservationCode = parts[0];
                string flightCode = parts[1];
                string airline = parts[2];
                double cost = double.Parse(parts[3]);
                string name = parts[4];
                string citizenship = parts[5];
                string status = parts[6];

                Reservation newReservation = new Reservation(reservationCode, flightCode, airline, cost, name, citizenship, status);
                res.Add(newReservation);
            }
            reservations = res;
            return res;
        }

        public void AddReservation(Reservation res)
        {
            File.AppendAllText(Reservation_TXT, $"{res.Code},{res.FlightCode},{res.Airline},{res.Cost},{res.Name},{res.Citizenship},{res.Active}\n");
        }

        public void UpdateReservation(Reservation res)
        {
            var lines = File.ReadAllLines(Reservation_TXT).ToList();

            // TODO
            // Add code to change the status from Active to Cancelled for the selected flight
            // and update the record in the reservation.csv file  
            // ...................................
            int index = lines.FindIndex(line => line.Split(',')[0] == res.FlightCode);

            if (index != -1)
            {
                lines[index] = lines[index].Replace("Active", "Inactive");
                File.WriteAllLines(Reservation_TXT, lines);
            }
            
            else
            {
                Console.WriteLine($"Reservation with flight number {res.FlightCode} not found.");
            }

            File.WriteAllLines(Reservation_TXT, lines);
            }
        }
    }


