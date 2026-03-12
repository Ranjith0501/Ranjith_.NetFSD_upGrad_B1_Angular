using System;

namespace Class_Assignment_1
{
    class Appointment
    {
        public int AppointmentId;
        public string? PatientName;
        public string? DoctorName;
        public DateTime AppointmentDate;

        public Appointment()
        {
            DoctorName = "General Physician";
            AppointmentDate = DateTime.Today;
        }

        static void Main()
        {
            Appointment a = new Appointment();

            a.AppointmentId = 1;
            a.PatientName = "Ranjith";

            Console.WriteLine(a.AppointmentId);
            Console.WriteLine(a.PatientName);
            Console.WriteLine(a.DoctorName);
            Console.WriteLine(a.AppointmentDate);
        }
    }
}