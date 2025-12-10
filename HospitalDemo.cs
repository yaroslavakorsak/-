using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");
            Hospital hospital = new Hospital();

            hospital.AddDoctor(new Doctor(1, "Корсак Ярослава", "Хірург"));
            hospital.AddDoctor(new Doctor(2, "Мирко Микола", "Офтальмолог"));
            hospital.AddDoctor(new Doctor(3, "Макарук Нікіта", "Уролог"));
            hospital.AddDoctor(new Doctor(4, "Кільбович Мілана", "Терапевт"));

            hospital.RegisterPatient(new Patient(1, "Демін Артем", 17));
            hospital.RegisterPatient(new Patient(2, "Шевченко Анна", 30));
            hospital.RegisterPatient(new Patient(3, "Ярчук Семен", 22));
            hospital.RegisterPatient(new Patient(4, "Маківська Аліса", 18));

            hospital.CreateRoom(new HospitalRoom(101, 3));
            hospital.CreateRoom(new HospitalRoom(202, 2));
            hospital.CreateRoom(new HospitalRoom(303, 1));

            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 202);
            hospital.HospitalizePatient(3, 303);
            hospital.HospitalizePatient(4, 101);

            hospital.AddMedicalRecord(new MedicalRecord(hospital.Patients[0], hospital.Doctors[0], DateTime.Now, "Грип, призначено огляд"));
            hospital.AddMedicalRecord(new MedicalRecord(hospital.Patients[1], hospital.Doctors[1], DateTime.Now, "Операція на нирках"));

            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(2);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            Console.WriteLine(hospital.GetStatistics());
        }
    }
}
