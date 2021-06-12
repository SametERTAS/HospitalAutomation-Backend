using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AppointmentCreated = "Appointment Created";
        public static string AppointmentDeleted = "Appointment Deleted";
        public static string AppointmentUpdated = "Appointment Updated";
        public static string AppointmentListed = "Appointment Listed";

        public static string CityCreated = "City Created";
        public static string CityDeleted = "City Deleted";
        public static string CityUpdated = "City Updated";
        public static string CityListed = "City Listed";

        public static string ClinicCreated = "Clinic Created";
        public static string ClinicDeleted = "Clinic Deleted";
        public static string ClinicUpdated = "Clinic Updated";
        public static string ClinicListed = "Clinic Listed";

        public static string CountryCreated = "Country Created";
        public static string CountryDeleted = "Country Deleted";
        public static string CountryUpdated = "Country Updated";
        public static string CountryListed = "Country Listed";

        public static string DistrictCreated = "District Created";
        public static string DistrictDeleted = "District Deleted";
        public static string DistrictUpdated = "District Updated";
        public static string DistrictListed = "District Listed";

        public static string ExaminationCreated = "Examination Created";
        public static string ExaminationDeleted = "Examination Deleted";
        public static string ExaminationUpdated = "Examination Updated";
        public static string ExaminationListed = "Examination Listed";

        public static string ExaminationTestCreated = "ExaminationTest Created";
        public static string ExaminationTestDeleted = "ExaminationTest Deleted";
        public static string ExaminationTestUpdated = "ExaminationTest Updated";
        public static string ExaminationTestListed = "ExaminationTest Listed";

        public static string HospitalClinicCreated = "HospitalClinic Created";
        public static string HospitalClinicDeleted = "HospitalClinic Deleted";
        public static string HospitalClinicUpdated = "HospitalClinic Updated";
        public static string HospitalClinicListed = "HospitalClinic Listed";

        public static string HospitalCreated = "Hospital Created";
        public static string HospitalDeleted = "Hospital Deleted";
        public static string HospitalUpdated = "Hospital Updated";
        public static string HospitalListed = "Hospital Listed";

        public static string MedicineCreated = "Medicine Created";
        public static string MedicineDeleted = "Medicine Deleted";
        public static string MedicineUpdated = "Medicine Updated";
        public static string MedicineListed = "Medicine Listed";

        public static string PrescriptionMedicineCreated = "PrescriptionMedicine Created";
        public static string PrescriptionMedicineDeleted = "PrescriptionMedicine Deleted";
        public static string PrescriptionMedicineUpdated = "PrescriptionMedicine Updated";
        public static string PrescriptionMedicineListed = "PrescriptionMedicine Listed";

        public static string PrescriptionCreated = "Prescription Created";
        public static string PrescriptionDeleted = "Prescription Deleted";
        public static string PrescriptionUpdated = "Prescription Updated";
        public static string PrescriptionListed = "Prescription Listed";

        public static string TestCreated = "Test Created";
        public static string TestDeleted = "Test Deleted";
        public static string TestUpdated = "Test Updated";
        public static string TestListed = "Test Listed";

        public static string UserCreated = "User Created";
        public static string UserNotFound = "User could not found";
        public static string PasswordError = "Incorrect password";
        public static string SuccessfulLogin = "Login is successful";
        public static string UserExistsError = "User already exists";
        public static string UserRegistered = "User registered";
        public static string AccessTokenCreated = "Access token Created";




        public static string OperationClaimCreated = "Operation claim Created";
        public static string OperationClaimGetByName = "Operation claim was brought by name";
        public static string OperationClaimListed = "Operation claims were listed";


        public static string UserOperationClaimCreated = "User operation claim created";


        public static string CityCountOfCountryError = "City count can not be greater than 20 for a country";
        internal static string CountryCountLimitExceded = "Country count can not be more than 20";
    }
}
