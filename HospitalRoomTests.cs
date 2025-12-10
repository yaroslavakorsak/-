using HospitalManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementTests
{
    [TestFixture]
    public class HospitalRoomTests
    {
        [Test]
        public void HospitalRoom_Constructor_ShouldInitializeProperties()
        {
            var room = new HospitalRoom(101, 2);

            Assert.AreEqual(101, room.RoomNumber);
            Assert.AreEqual(2, room.Capacity);
            Assert.IsNotNull(room.Patients);
            Assert.AreEqual(0, room.Patients.Count);
        }

        [Test]
        public void AddPatient_WhenRoomHasSpace_ShouldAddPatient()
        {

            var room = new HospitalRoom(101, 2);
            var patient = new Patient(1, "Коваленко Тарас", 35);

            room.AddPatient(patient);

            Assert.AreEqual(1, room.Patients.Count);
            Assert.Contains(patient, room.Patients);
        }

        [Test]
        public void AddPatient_WhenRoomIsFull_ShouldNotAddPatient()
        {
            var room = new HospitalRoom(101, 1);
            var patient1 = new Patient(1, "Пацієнт 1", 30);
            var patient2 = new Patient(2, "Пацієнт 2", 40);


            room.AddPatient(patient1);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                room.AddPatient(patient2);
                string output = sw.ToString();

                Assert.AreEqual(1, room.Patients.Count);
                Assert.Contains(patient1, room.Patients);
                Assert.IsFalse(room.Patients.Contains(patient2));
                Assert.IsTrue(output.Contains("переповнена"));
            }

            var standardOutput = new StreamWriter(Console.OpenStandardOutput());
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);
        }

        [Test]
        public void AddPatient_CanAddMultiplePatients_UpToCapacity()
        {


            var room = new HospitalRoom(102, 3);
            var patient1 = new Patient(1, "Пацієнт 1", 30);
            var patient2 = new Patient(2, "Пацієнт 2", 40);
            var patient3 = new Patient(3, "Пацієнт 3", 50);

            room.AddPatient(patient1);
            room.AddPatient(patient2);
            room.AddPatient(patient3);

            Assert.AreEqual(3, room.Patients.Count);
            Assert.Contains(patient1, room.Patients);
            Assert.Contains(patient2, room.Patients);
            Assert.Contains(patient3, room.Patients);
        }

        [Test]
        public void HospitalRoom_WithZeroCapacity_ShouldNotAcceptPatients()
        {

            var room = new HospitalRoom(103, 0);
            var patient = new Patient(1, "Пацієнт", 30);

            room.AddPatient(patient);

            Assert.AreEqual(0, room.Patients.Count);
        }
    }
}
