using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {

        /*
                IoC     inversion of control 
        */




        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AppointmentManager>().As<IAppointmentService>();
            builder.RegisterType<EfAppointmentDal>().As<IAppointmentDal>();

            builder.RegisterType<CityManager>().As<ICityService>();
            builder.RegisterType<EfCitytDal>().As<ICityDal>();

            builder.RegisterType<ClinicManager>().As<IClinicService>();
            builder.RegisterType<EfClinicDal>().As<IClinicDal>();

            builder.RegisterType<CountryManager>().As<ICountryService>();
            builder.RegisterType<EfCountryDal>().As<ICountryDal>();

            builder.RegisterType<DistrictManager>().As<IDistrictService>();
            builder.RegisterType<EfDistrictDal>().As<IDistrictDal>();

            builder.RegisterType<ExaminationManager>().As<IExaminationService>();
            builder.RegisterType<EfExaminationDal>().As<IExaminationDal>();

            builder.RegisterType<ExaminationTestManager>().As<IExaminationTestService>();
            builder.RegisterType<EfExaminationTestDal>().As<IExaminationTestDal>();

            builder.RegisterType<HospitalClinicManager>().As<IHospitalClinicService>();
            builder.RegisterType<EfHospitalClinicDal>().As<IHospitalClinicDal>();

            builder.RegisterType<HospitalManager>().As<IHospitalService>();
            builder.RegisterType<EfHospitalDal>().As<IHospitalDal>();

            builder.RegisterType<MedicineManager>().As<IMedicineService>();
            builder.RegisterType<EfMedicineDal>().As<IMedicineDal>();

            builder.RegisterType<PrescriptionMedicineManager>().As<IPrescriptionMedicineService>();
            builder.RegisterType<EfPrescriptionMedicineDal>().As<IPrescriptionMedicineDal>();

            builder.RegisterType<PrescriptionManager>().As<IPrescriptionService>();
            builder.RegisterType<EfPrescriptionDal>().As<IPrescriptionDal>();

            builder.RegisterType<TestManager>().As<ITestService>();
            builder.RegisterType<EfTestDal>().As<ITestDal>();

        }
    }
}


